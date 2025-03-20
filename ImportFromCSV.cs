using System;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MochaPointInventory
{
    public partial class ImportFromCSV : Form
    {
        private const string DbFilePath = @"C:\Users\Owner\AppData\Local\Inventory.db";

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

                    // Clear existing data in the DataGridView
                    dataGridViewInventory.Rows.Clear();

                    // Start processing from row 15 (index 14)
                    foreach (string line in lines.Skip(15))
                    {
                        string[] values = line.Split(',');

                        if (values.Length >= 5)
                        {
                            string ingredient = values[3].Trim();  // Modifier Name
                            string unit = "oz";  // Default unit for all ingredients
                            if (int.TryParse(values[4].Trim(), out int quantitySold))
                            {
                                // Get current inventory data from database
                                double currentQuantity = GetCurrentInventory(ingredient);

                                if (currentQuantity >= 0) // Ingredient found
                                {
                                    double newInventoryLevel = Math.Max(currentQuantity - quantitySold, 0);

                                    // Update database with new inventory level
                                    UpdateInventory(ingredient, newInventoryLevel);

                                    // Update DataGridView
                                    dataGridViewInventory.Rows.Add(ingredient, unit, newInventoryLevel);
                                }
                                else
                                {
                                    MessageBox.Show($"Ingredient '{ingredient}' not found in inventory.",
                                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
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

        private double GetCurrentInventory(string ingredientName)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT CurrentQuantity FROM Inventory WHERE IngredientName = @IngredientName";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IngredientName", ingredientName);

                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToDouble(result) : -1; // Return -1 if ingredient not found
                }
            }
        }

        private void UpdateInventory(string ingredientName, double newQuantity)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string updateQuery = "UPDATE Inventory SET CurrentQuantity = @NewQuantity WHERE IngredientName = @IngredientName";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@NewQuantity", newQuantity);
                    command.Parameters.AddWithValue("@IngredientName", ingredientName);
                    command.ExecuteNonQuery();
                }
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

        private void dataGridViewInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Currently not being used
        }
    }
}

