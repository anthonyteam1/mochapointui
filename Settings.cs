using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  // Make sure this is included for UI controls
using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace MochaPointInventory
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        // Load ingredients from the database on form load
        private void Settings_Load(object sender, EventArgs e)
        {
            LoadIngredientsFromDatabase();
            numericUpDownThreshold.Value = 0; // Default threshold value
        }

        // Load ingredients into comboBoxIngredients
        private void LoadIngredientsFromDatabase()
        {
            string dbPath = @"C:\Users\Owner\AppData\Local\inventory.db"; // Ensure this path is correct
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT IngredientName FROM Inventory"; // Correct table name

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxIngredients.Items.Add(reader["IngredientName"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading ingredients: " + ex.Message);
                }
            }
        }

        // Save the new password in the database
        private void buttonSavePassword_Click(object sender, EventArgs e)
        {
            string newPassword = textBoxNewPassword.Text;

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please enter a valid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UpdatePasswordInDatabase(newPassword))
            {
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error updating password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to update the password in the database
        private bool UpdatePasswordInDatabase(string newPassword)
        {
            bool success = false;
            string dbPath = @"C:\Users\Owner\AppData\Local\inventory.db"; // Correct database path
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE UserSettings SET Password = @Password";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Password", newPassword);

                        int rowsAffected = command.ExecuteNonQuery();
                        success = rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating password: " + ex.Message);
                }
            }

            return success;
        }

        // Accept Changes - Updates threshold for selected ingredient
        private void buttonAcceptChanges_Click(object sender, EventArgs e)
        {
            if (comboBoxIngredients.SelectedItem == null)
            {
                MessageBox.Show("Please select an ingredient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedIngredient = comboBoxIngredients.SelectedItem.ToString();
            int newThreshold = (int)numericUpDownThreshold.Value;

            if (UpdateThresholdInDatabase(selectedIngredient, newThreshold))
            {
                MessageBox.Show($"Threshold for {selectedIngredient} updated to {newThreshold}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error updating threshold.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update threshold in the database
        private bool UpdateThresholdInDatabase(string ingredientName, int newThreshold)
        {
            bool success = false;
            string dbPath = @"C:\Users\Owner\AppData\Local\inventory.db";
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Inventory SET Threshold = @Threshold WHERE IngredientName = @IngredientName";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IngredientName", ingredientName);
                        command.Parameters.AddWithValue("@Threshold", newThreshold);

                        int rowsAffected = command.ExecuteNonQuery();
                        success = rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating threshold: " + ex.Message);
                }
            }

            return success;
        }

        // Back button functionality
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();

            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
        }

        // Empty event handlers for unused UI elements (optional)
        private void label4_Click(object sender, EventArgs e) { }
        private void labelThreshold_Click(object sender, EventArgs e) { }
        private void numericUpDownThreshold_ValueChanged(object sender, EventArgs e) { }
    }
}

