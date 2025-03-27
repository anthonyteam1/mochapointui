using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace MochaPointInventory
{
    public partial class ManualEntry : Form
    {
        public ManualEntry()
        {
            InitializeComponent();

            // Populate comboBoxItems with data from the database (ingredient names)
            List<string> ingredientNames = GetIngredientNamesFromDatabase();
            comboBoxItems.Items.AddRange(ingredientNames.ToArray());
            comboBox2.Items.AddRange(ingredientNames.ToArray());

            // Set comboBox1 items to "Add" and "Subtract"
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Add");
            comboBox1.Items.Add("Subtract");
            comboBox1.SelectedIndex = 0; // Default to "Add"
        }

        // Method to get ingredient names from the database
        private List<string> GetIngredientNamesFromDatabase()
        {
            List<string> ingredientNames = new List<string>();
            string dbPath = @"C:\Users\Owner\AppData\Local\inventory.db";
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT IngredientName FROM inventory";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ingredientNames.Add(reader["IngredientName"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }

            return ingredientNames;
        }

        // Back button click event
        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            this.Close();
        }

        // Update inventory based on comboBoxItems and numericUpDownQuantity
        private void buttonUpdateInventory_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBoxItems.SelectedItem?.ToString();
            string addOrSubtract = comboBox1.SelectedItem?.ToString();
            int quantityChange = (int)numericUpDownQuantity.Value;

            // Validate that an ingredient and action (Add/Subtract) are selected
            if (string.IsNullOrEmpty(selectedItem) || string.IsNullOrEmpty(addOrSubtract))
            {
                MessageBox.Show("Please select an ingredient and specify whether to add or subtract.");
                return;
            }

            // Get the current inventory quantity for the selected ingredient
            int currentQuantity = GetCurrentQuantity(selectedItem);
            if (currentQuantity == -1)
            {
                MessageBox.Show("Error fetching current inventory or ingredient does not exist.");
                return;
            }

            // Adjust quantity based on whether the user wants to add or subtract
            int newQuantity = currentQuantity;
            if (addOrSubtract == "Add")
            {
                newQuantity += quantityChange;
            }
            else if (addOrSubtract == "Subtract")
            {
                newQuantity -= quantityChange;

                // Call the method to log ingredient usage when subtracting
                DecrementInventoryAndLogUsage(selectedItem, quantityChange);
            }

            // Update the database with the new quantity
            bool updateSuccess = UpdateInventoryInDatabase(selectedItem, newQuantity);

            // Provide feedback to the user
            if (updateSuccess)
            {
                MessageBox.Show("Inventory successfully updated!");
            }
            else
            {
                MessageBox.Show("Error updating inventory.");
            }
        }

        // Update inventory based on comboBox2 and numericUpDown1
        private void buttonUpdateInventory2_Click(object sender, EventArgs e)
        {
            string selectedItem2 = comboBox2.SelectedItem?.ToString();
            int newQuantity = (int)numericUpDown1.Value;

            // Validate that an ingredient is selected
            if (string.IsNullOrEmpty(selectedItem2))
            {
                MessageBox.Show("Please select an ingredient.");
                return;
            }

            // Update the database with the new quantity
            bool updateSuccess = UpdateInventoryInDatabase(selectedItem2, newQuantity);

            // Provide feedback to the user
            if (updateSuccess)
            {
                MessageBox.Show("Inventory successfully updated!");
            }
            else
            {
                MessageBox.Show("Error updating inventory.");
            }
        }

        // Method to get the current inventory quantity for the selected ingredient
        private int GetCurrentQuantity(string ingredientName)
        {
            int currentQuantity = -1;
            string dbPath = @"C:\Users\Owner\AppData\Local\inventory.db";
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT CurrentQuantity FROM inventory WHERE IngredientName = @IngredientName";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IngredientName", ingredientName);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            currentQuantity = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching current inventory: " + ex.Message);
                }
            }

            return currentQuantity;
        }

        // Method to update the inventory in the database
        private bool UpdateInventoryInDatabase(string ingredientName, int newQuantity)
        {
            bool success = false;
            string dbPath = @"C:\Users\Owner\AppData\Local\inventory.db";
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE inventory SET CurrentQuantity = @Quantity WHERE IngredientName = @IngredientName";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IngredientName", ingredientName);
                        command.Parameters.AddWithValue("@Quantity", newQuantity);

                        int rowsAffected = command.ExecuteNonQuery();
                        success = rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating inventory: " + ex.Message);
                }
            }

            return success;
        }

        // Method to log ingredient usage and decrement inventory
        private void DecrementInventoryAndLogUsage(string ingredientName, int quantityUsed)
        {
            // Step 1: Update Inventory - Decrease the quantity
            string updateInventoryQuery = "UPDATE inventory SET CurrentQuantity = CurrentQuantity - @QuantityUsed WHERE IngredientName = @IngredientName";

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\Owner\\AppData\\Local\\inventory.db"))
            {
                connection.Open();

                // Step 2: Execute the Inventory update
                using (SQLiteCommand command = new SQLiteCommand(updateInventoryQuery, connection))
                {
                    command.Parameters.AddWithValue("@QuantityUsed", quantityUsed);
                    command.Parameters.AddWithValue("@IngredientName", ingredientName);
                    command.ExecuteNonQuery();
                }

                // Step 3: Insert a record into IngredientUsage table to log the usage
                string insertUsageQuery = "INSERT INTO IngredientUsage (IngredientName, QuantityUsed, UsageDate) " +
                                          "VALUES (@IngredientName, @QuantityUsed, @UsageDate)";

                using (SQLiteCommand command = new SQLiteCommand(insertUsageQuery, connection))
                {
                    command.Parameters.AddWithValue("@IngredientName", ingredientName);
                    command.Parameters.AddWithValue("@QuantityUsed", quantityUsed);
                    command.Parameters.AddWithValue("@UsageDate", DateTime.Now.ToString("yyyy-MM-dd")); // Log the current date
                    command.ExecuteNonQuery();
                }
            }
        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle any comboBox item selection changes if needed
        }
    }
}

