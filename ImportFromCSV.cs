using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MochaPointInventory
{
    public partial class ImportFromCSV : Form
    {
        private const string DbFilePath = @"C:\\Users\\Owner\\AppData\\Local\\Inventory.db";

        public ImportFromCSV()
        {
            InitializeComponent();
        }

        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection($"Data Source={DbFilePath};Version=3;");
        }

        private void buttonUpdateInventory_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Select a CSV File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    dataGridViewInventory.Rows.Clear();

                    // Dictionary to store total quantity sold per ingredient
                    Dictionary<string, int> ingredientSales = new Dictionary<string, int>();

                    // Start processing from row 15 (index 14)
                    foreach (string line in lines.Skip(15))
                    {
                        string[] values = line.Split(',');

                        if (values.Length >= 5)
                        {
                            string ingredient = values[3].Trim();  // Modifier Name
                            if (int.TryParse(values[4].Trim(), out int quantitySold))
                            {
                                if (ingredientSales.ContainsKey(ingredient))
                                    ingredientSales[ingredient] += quantitySold;
                                else
                                    ingredientSales[ingredient] = quantitySold;
                            }
                        }
                    }

                    using (var connection = GetConnection())
                    {
                        connection.Open();
                        var transaction = connection.BeginTransaction(); // Start transaction

                        try
                        {
                            // Process each ingredient once
                            foreach (var entry in ingredientSales)
                            {
                                string ingredient = entry.Key;
                                int totalQuantitySold = entry.Value;
                                string unit = "oz"; // Default unit

                                double currentQuantity = GetCurrentInventory(ingredient, connection);

                                if (currentQuantity >= 0) // Ingredient found
                                {
                                    double newInventoryLevel = Math.Max(currentQuantity - totalQuantitySold, 0);
                                    UpdateInventory(ingredient, newInventoryLevel, connection);
                                }
                                else // Ingredient not found, add it
                                {
                                    double newInventoryLevel = Math.Max(0 - totalQuantitySold, 0);
                                    AddIngredientToInventory(ingredient, newInventoryLevel, unit, connection);
                                }

                                // Update DataGridView
                                dataGridViewInventory.Rows.Add(ingredient, unit, GetCurrentInventory(ingredient, connection));
                            }

                            // Additional feature to subtract quantities for ingredients in drinks (column B in the CSV)
                            foreach (string line in lines.Skip(15))
                            {
                                string[] values = line.Split(',');

                                if (values.Length >= 2) // Check for Drink Name in Column B
                                {
                                    string drinkName = values[1].Trim();  // Column B: Drink Name

                                    if (!string.IsNullOrEmpty(drinkName))
                                    {
                                        // Get ingredients for this drink from DrinkIngredients table
                                        string getIngredientsQuery = "SELECT IngredientName, Quantity FROM DrinkIngredients WHERE DrinkName = @DrinkName";
                                        using (var command = new SQLiteCommand(getIngredientsQuery, connection))
                                        {
                                            command.Parameters.AddWithValue("@DrinkName", drinkName);
                                            using (var reader = command.ExecuteReader())
                                            {
                                                while (reader.Read())
                                                {
                                                    string ingredient = reader["IngredientName"].ToString();
                                                    int ingredientQuantity = Convert.ToInt32(reader["Quantity"]);

                                                    // Subtract the ingredient quantity from the Inventory table
                                                    double currentInventory = GetCurrentInventory(ingredient, connection);
                                                    if (currentInventory >= 0)
                                                    {
                                                        double newInventory = Math.Max(currentInventory - ingredientQuantity, 0);
                                                        UpdateInventory(ingredient, newInventory, connection);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            transaction.Commit(); // Commit transaction if everything goes well
                        }
                        catch (Exception)
                        {
                            transaction.Rollback(); // Rollback transaction if something goes wrong
                            throw;
                        }
                    }

                    MessageBox.Show("CSV file successfully imported and inventory updated!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private double GetCurrentInventory(string ingredientName, SQLiteConnection connection)
        {
            string query = "SELECT CurrentQuantity FROM Inventory WHERE IngredientName = @IngredientName";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@IngredientName", ingredientName);
                object result = command.ExecuteScalar();
                return result != null ? Convert.ToDouble(result) : -1; // Return -1 if ingredient not found
            }
        }

        private void UpdateInventory(string ingredientName, double newQuantity, SQLiteConnection connection)
        {
            string updateQuery = "UPDATE Inventory SET CurrentQuantity = @NewQuantity WHERE IngredientName = @IngredientName";
            using (var command = new SQLiteCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@NewQuantity", newQuantity);
                command.Parameters.AddWithValue("@IngredientName", ingredientName);
                command.ExecuteNonQuery();
            }
        }

        private void AddIngredientToInventory(string ingredientName, double initialQuantity, string unit, SQLiteConnection connection)
        {
            string insertQuery = @"
                INSERT INTO Inventory (IngredientName, CurrentQuantity, Unit, Threshold) 
                VALUES (@IngredientName, @CurrentQuantity, @Unit, 1000)"; // Default threshold 1000

            using (var command = new SQLiteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@IngredientName", ingredientName);
                command.Parameters.AddWithValue("@CurrentQuantity", initialQuantity);
                command.Parameters.AddWithValue("@Unit", unit);
                command.ExecuteNonQuery();
            }
        }

        private void buttonAcceptChanges_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes Accepted!");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
        }
    }
}

