using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace MochaPointInventory
{
    public class Database
    {
        private const string DbFilePath = @"C:\Users\Owner\AppData\Local\Inventory.db";

        public static SQLiteConnection GetConnection()
        {
            MessageBox.Show($"Database Path: {DbFilePath}");
            var connection = new SQLiteConnection($"Data Source={DbFilePath};Version=3;");
            return connection;
        }

        public static void CreateDatabase()
        {
            string folderPath = @"C:\Users\Owner\AppData\Local";

            // Ensure folder exists
            if (!System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }

            // Create database if it doesn't exist
            if (!System.IO.File.Exists(DbFilePath))
            {
                SQLiteConnection.CreateFile(DbFilePath);

                using (var connection = GetConnection())
                {
                    connection.Open();
                    string createTablesScript = @"
                    CREATE TABLE IF NOT EXISTS UserSettings (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Password TEXT NOT NULL
                    );
                    INSERT OR IGNORE INTO UserSettings (Password) VALUES ('ILOVECOFFEE');

                    CREATE TABLE IF NOT EXISTS Products (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        ProductName TEXT NOT NULL,
                        BaseQuantity REAL NOT NULL,
                        BaseUnit TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Ingredients (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        IngredientName TEXT NOT NULL,
                        Unit TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS ProductIngredients (
                        ProductId INTEGER,
                        IngredientId INTEGER,
                        QuantityPerDrink REAL NOT NULL,
                        FOREIGN KEY(ProductId) REFERENCES Products(Id),
                        FOREIGN KEY(IngredientId) REFERENCES Ingredients(Id),
                        PRIMARY KEY(ProductId, IngredientId)
                    );

                    CREATE TABLE IF NOT EXISTS SalesData (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        ProductName TEXT NOT NULL,
                        DrinksSold INTEGER NOT NULL,
                        ModifierName TEXT NOT NULL,
                        ModifierUnitsSold INTEGER NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Inventory (
                        IngredientId INTEGER PRIMARY KEY,
                        CurrentQuantity REAL NOT NULL,
                        Unit TEXT NOT NULL,
                        Threshold REAL NOT NULL,
                        FOREIGN KEY(IngredientId) REFERENCES Ingredients(Id)
                    );

                    CREATE TABLE IF NOT EXISTS ThresholdNotifications (
                        IngredientId INTEGER PRIMARY KEY,
                        NotificationEmail TEXT NOT NULL,
                        FOREIGN KEY(IngredientId) REFERENCES Inventory(IngredientId)
                    );";

                    using (var command = new SQLiteCommand(createTablesScript, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static string GetPassword()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT Password FROM UserSettings LIMIT 1";
                using (var command = new SQLiteCommand(query, connection))
                {
                    var result = command.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        public static void UpdatePassword(string newPassword)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE UserSettings SET Password = @Password WHERE Id = 1";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Password", newPassword);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void SubtractFromInventory(string ingredientName, double quantityToSubtract)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                // Check if the ingredient exists in the Inventory table by IngredientName
                string checkQuery = "SELECT CurrentQuantity FROM Inventory WHERE IngredientName = @IngredientName";

                using (var checkCommand = new SQLiteCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@IngredientName", ingredientName);

                    using (var reader = checkCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            double currentQuantity = Convert.ToDouble(reader["CurrentQuantity"]);

                            // Subtract quantity but prevent negative values
                            double newQuantity = Math.Max(currentQuantity - quantityToSubtract, 0);

                            string updateQuery = "UPDATE Inventory SET CurrentQuantity = @NewQuantity WHERE IngredientName = @IngredientName";
                            using (var updateCommand = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@NewQuantity", newQuantity);
                                updateCommand.Parameters.AddWithValue("@IngredientName", ingredientName);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Ingredient '{ingredientName}' not found in inventory.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }


        // Updated method to use CurrentQuantity instead of BaseQuantity!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public static void AddOrUpdateIngredient(string ingredientName, string unit, double quantityToSubtract)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                // Check if the ingredient already exists in the Inventory table
                string checkQuery = "SELECT CurrentQuantity FROM Inventory WHERE IngredientName = @IngredientName";
                using (var checkCommand = new SQLiteCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@IngredientName", ingredientName);

                    using (var reader = checkCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Ingredient exists — Update the quantity
                            double currentQuantity = Convert.ToDouble(reader["CurrentQuantity"]);

                            // Ensure quantity doesn't go negative
                            double newQuantity = currentQuantity - quantityToSubtract;
                            if (newQuantity < 0)
                            {
                                newQuantity = 0; // Set to 0 if quantity is negative after subtraction
                            }

                            string updateQuery = "UPDATE Inventory SET CurrentQuantity = @NewQuantity WHERE IngredientName = @IngredientName";
                            using (var updateCommand = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@NewQuantity", newQuantity);
                                updateCommand.Parameters.AddWithValue("@IngredientName", ingredientName);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Ingredient does NOT exist — Insert it with a starting quantity (this should not normally happen if inventory is correct)
                            string insertQuery = @"
                    INSERT INTO Inventory (IngredientName, CurrentQuantity, Unit, Threshold) 
                    VALUES (@IngredientName, @CurrentQuantity, @Unit, @Threshold)";
                            using (var insertCommand = new SQLiteCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@IngredientName", ingredientName);
                                insertCommand.Parameters.AddWithValue("@CurrentQuantity", 1000); // Starting quantity
                                insertCommand.Parameters.AddWithValue("@Unit", unit);
                                insertCommand.Parameters.AddWithValue("@Threshold", 500); // Example threshold value
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
        public static void CheckInventoryLevels()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\Owner\\AppData\\Local\\inventory.db;Version=3;"))
            {
                connection.Open();

                string query = "SELECT IngredientName, CurrentQuantity, Threshold FROM Inventory WHERE CurrentQuantity <= Threshold";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string ingredientName = reader["IngredientName"].ToString();
                        double currentQuantity = Convert.ToDouble(reader["CurrentQuantity"]);
                        double threshold = Convert.ToDouble(reader["Threshold"]);

                        ShowNotification($"{ingredientName} is low!", $"Only {currentQuantity} remaining (Threshold: {threshold})");
                    }
                }
            }
        }

        private static void ShowNotification(string title, string message)
        {
            NotifyIcon notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Warning,
                Visible = true,
                BalloonTipTitle = title,
                BalloonTipText = message
            };

            notifyIcon.ShowBalloonTip(5000);  // 5 seconds
        }
    }
}



