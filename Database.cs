using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MochaPointInventory
{
    public class Database
    {
        private const string DbFilePath = @"C:\Users\Owner\AppData\Local\Inventory.db";

        public static SQLiteConnection GetConnection()
        {
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

                // Check if the ingredient exists in the Inventory table
                string checkQuery = "SELECT IngredientId, CurrentQuantity FROM Inventory WHERE IngredientId = (SELECT Id FROM Ingredients WHERE IngredientName = @IngredientName)";
                using (var checkCommand = new SQLiteCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@IngredientName", ingredientName);

                    using (var reader = checkCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int ingredientId = Convert.ToInt32(reader["IngredientId"]);
                            double currentQuantity = Convert.ToDouble(reader["CurrentQuantity"]);

                            // Subtract quantity but prevent negative values
                            double newQuantity = Math.Max(currentQuantity - quantityToSubtract, 0);

                            string updateQuery = "UPDATE Inventory SET CurrentQuantity = @NewQuantity WHERE IngredientId = @Id";
                            using (var updateCommand = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@NewQuantity", newQuantity);
                                updateCommand.Parameters.AddWithValue("@Id", ingredientId);
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

        // Updated method to use CurrentQuantity instead of BaseQuantity
        public static void AddOrUpdateIngredient(string ingredientName, string unit, double quantityToSubtract)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                // Check if the ingredient already exists in the Inventory table
                string checkQuery = "SELECT IngredientId, CurrentQuantity FROM Inventory WHERE IngredientId = (SELECT Id FROM Ingredients WHERE IngredientName = @IngredientName)";
                using (var checkCommand = new SQLiteCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@IngredientName", ingredientName);

                    using (var reader = checkCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Ingredient exists — Update the quantity
                            int ingredientId = Convert.ToInt32(reader["IngredientId"]);
                            double currentQuantity = Convert.ToDouble(reader["CurrentQuantity"]);

                            // Ensure quantity doesn't go negative
                            double newQuantity = currentQuantity - quantityToSubtract;
                            if (newQuantity < 0)
                            {
                                newQuantity = 0; // Set to 0 if quantity is negative after subtraction
                            }

                            string updateQuery = "UPDATE Inventory SET CurrentQuantity = @NewQuantity WHERE IngredientId = @Id";
                            using (var updateCommand = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@NewQuantity", newQuantity);
                                updateCommand.Parameters.AddWithValue("@Id", ingredientId);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Ingredient does NOT exist — Insert it with a starting quantity (this should not normally happen if inventory is correct)
                            string insertQuery = @"
                            INSERT INTO Ingredients (IngredientName, Unit) 
                            VALUES (@IngredientName, @Unit)";
                            using (var insertCommand = new SQLiteCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@IngredientName", ingredientName);
                                insertCommand.Parameters.AddWithValue("@Unit", unit);
                                insertCommand.ExecuteNonQuery();
                            }

                            // After inserting, we need to add a record into the Inventory table
                            string insertInventoryQuery = @"
                            INSERT INTO Inventory (IngredientId, CurrentQuantity, Unit, Threshold) 
                            VALUES ((SELECT Id FROM Ingredients WHERE IngredientName = @IngredientName), @CurrentQuantity, @Unit, @Threshold)";
                            using (var inventoryInsertCommand = new SQLiteCommand(insertInventoryQuery, connection))
                            {
                                inventoryInsertCommand.Parameters.AddWithValue("@IngredientName", ingredientName);
                                inventoryInsertCommand.Parameters.AddWithValue("@CurrentQuantity", 1000); // Starting quantity
                                inventoryInsertCommand.Parameters.AddWithValue("@Unit", unit);
                                inventoryInsertCommand.Parameters.AddWithValue("@Threshold", 500); // Example threshold value
                                inventoryInsertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
    }
}

