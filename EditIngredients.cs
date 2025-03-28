using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace MochaPointInventory
{
    public partial class DrinkCreationForm : Form
    {
        // Database location
        private string dbPath = @"C:\Users\Owner\AppData\Local\inventory.db";

        public DrinkCreationForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(DrinkCreationForm_Load);
        }

        private void DrinkCreationForm_Load(object sender, EventArgs e)
        {
            PopulateIngredientComboBox();
            PopulateDrinkSelectionComboBox();
            PopulateComboBoxAdd();
        }

        // Populate comboBoxIngredient (left panel) with ingredients from Inventory table
        private void PopulateIngredientComboBox()
        {
            comboBoxIngredient.Items.Clear();
            if (File.Exists(dbPath))
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};"))
                {
                    conn.Open();
                    string query = "SELECT IngredientName FROM Inventory ORDER BY IngredientName ASC";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxIngredient.Items.Add(reader["IngredientName"].ToString());
                        }
                    }
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Database file not found.");
            }
        }

        // Populate comboBoxDrinkSelection (right panel) with distinct drinks from DrinkIngredients table
        private void PopulateDrinkSelectionComboBox()
        {
            comboBoxDrinkSelection.Items.Clear();
            if (File.Exists(dbPath))
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};"))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT DrinkName FROM DrinkIngredients ORDER BY DrinkName ASC";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxDrinkSelection.Items.Add(reader["DrinkName"].ToString());
                        }
                    }
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Database file not found.");
            }
        }

        // Button click to add an ingredient to a drink (left panel)
        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            string drinkName;

            // Check if the user has selected a drink from comboBoxAdd or entered a new one
            if (comboBoxAdd.SelectedItem != null)
            {
                // Use the selected drink name from comboBoxAdd
                drinkName = comboBoxAdd.SelectedItem.ToString();
            }
            else if (!string.IsNullOrEmpty(textBoxDrinkName.Text.Trim()))
            {
                // If the user has entered a new drink name in textBoxDrinkName
                drinkName = textBoxDrinkName.Text.Trim();
            }
            else
            {
                MessageBox.Show("Please select an existing drink or enter a new drink name.");
                return;
            }

            // Check if an ingredient is selected
            if (comboBoxIngredient.SelectedItem == null)
            {
                MessageBox.Show("Please select an ingredient.");
                return;
            }

            string ingredient = comboBoxIngredient.SelectedItem.ToString();
            int quantity = (int)numericUpDownQuantity.Value;

            // Insert or update the ingredient in the database
            if (File.Exists(dbPath))
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};"))
                {
                    conn.Open();

                    // Check if the ingredient already exists for the selected drink
                    string checkQuery = "SELECT COUNT(*) FROM DrinkIngredients WHERE DrinkName = @DrinkName AND IngredientName = @Ingredient";
                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@DrinkName", drinkName);
                        checkCmd.Parameters.AddWithValue("@Ingredient", ingredient);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            // If ingredient exists, update the quantity
                            string updateQuery = "UPDATE DrinkIngredients SET Quantity = @Quantity WHERE DrinkName = @DrinkName AND IngredientName = @Ingredient";
                            using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@DrinkName", drinkName);
                                updateCmd.Parameters.AddWithValue("@Ingredient", ingredient);
                                updateCmd.Parameters.AddWithValue("@Quantity", quantity);
                                updateCmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Ingredient updated successfully.");
                        }
                        else
                        {
                            // If ingredient doesn't exist, insert it
                            string insertQuery = "INSERT INTO DrinkIngredients (DrinkName, IngredientName, Quantity) VALUES (@DrinkName, @Ingredient, @Quantity)";
                            using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@DrinkName", drinkName);
                                insertCmd.Parameters.AddWithValue("@Ingredient", ingredient);
                                insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                                insertCmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Ingredient added to drink successfully.");
                        }
                    }

                    conn.Close();
                }

                // Refresh the comboBoxAdd to show the updated drink names
                PopulateComboBoxAdd();
                // If an existing drink was modified, refresh its ingredients list
                if (comboBoxAdd.SelectedItem != null)
                {
                    RefreshIngredientList();
                }
            }
            else
            {
                MessageBox.Show("Database file not found.");
            }
        }


        // When a drink is selected from the right panel, display its ingredients in listBoxDrinkIngredients
        private void comboBoxDrinkSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshIngredientList();
        }

        private void PopulateComboBoxAdd()
        {
            comboBoxAdd.Items.Clear();
            if (File.Exists(dbPath))
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};"))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT DrinkName FROM DrinkIngredients ORDER BY DrinkName ASC";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxAdd.Items.Add(reader["DrinkName"].ToString());
                        }
                    }
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Database file not found.");
            }
        }

        // Helper method to refresh the ingredients list for the selected drink
        private void RefreshIngredientList()
        {
            listBoxDrinkIngredients.Items.Clear();
            if (comboBoxDrinkSelection.SelectedItem == null)
                return;

            string selectedDrink = comboBoxDrinkSelection.SelectedItem.ToString();
            if (File.Exists(dbPath))
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};"))
                {
                    conn.Open();
                    string query = "SELECT IngredientName, Quantity FROM DrinkIngredients WHERE DrinkName = @DrinkName";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DrinkName", selectedDrink);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string ing = reader["IngredientName"].ToString();
                                int qty = Convert.ToInt32(reader["Quantity"]);
                                listBoxDrinkIngredients.Items.Add($"{ing} - {qty}");
                            }
                        }
                    }
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Database file not found.");
            }
        }

        // Button click to remove the selected drink from the database
        private void buttonRemoveDrink_Click(object sender, EventArgs e)
        {
            // Ensure a drink is selected in comboBoxDrinkSelection.
            if (comboBoxDrinkSelection.SelectedItem == null)
            {
                MessageBox.Show("Please select a drink to remove.");
                return;
            }

            string selectedDrink = comboBoxDrinkSelection.SelectedItem.ToString();

            // Confirm deletion.
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the drink '{selectedDrink}' and all its ingredients?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            if (File.Exists(dbPath))
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};"))
                {
                    conn.Open();
                    // Delete all rows from DrinkIngredients with this drink name.
                    string query = "DELETE FROM DrinkIngredients WHERE DrinkName = @DrinkName";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DrinkName", selectedDrink);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                MessageBox.Show("Drink removed successfully.");
                // Refresh drink selection and clear the ingredient list.
                PopulateDrinkSelectionComboBox();
                listBoxDrinkIngredients.Items.Clear();
            }
            else
            {
                MessageBox.Show("Database file not found.");
            }
        }

        // Button click to remove the selected ingredient from the selected drink
        private void buttonRemoveIngredient_Click(object sender, EventArgs e)
        {
            // Ensure a drink is selected in comboBoxDrinkSelection.
            if (comboBoxDrinkSelection.SelectedItem == null)
            {
                MessageBox.Show("Please select a drink first.");
                return;
            }

            // Ensure an ingredient is selected in listBoxDrinkIngredients.
            if (listBoxDrinkIngredients.SelectedItem == null)
            {
                MessageBox.Show("Please select an ingredient to remove.");
                return;
            }

            string selectedDrink = comboBoxDrinkSelection.SelectedItem.ToString();
            // The list box item is in the format "IngredientName - Quantity".
            string selectedItem = listBoxDrinkIngredients.SelectedItem.ToString();
            string ingredient = selectedItem.Split('-')[0].Trim();

            DialogResult result = MessageBox.Show($"Are you sure you want to remove the ingredient '{ingredient}' from drink '{selectedDrink}'?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            if (File.Exists(dbPath))
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};"))
                {
                    conn.Open();
                    string query = "DELETE FROM DrinkIngredients WHERE DrinkName = @DrinkName AND IngredientName = @Ingredient";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DrinkName", selectedDrink);
                        cmd.Parameters.AddWithValue("@Ingredient", ingredient);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                MessageBox.Show("Ingredient removed successfully.");
                // Refresh the ingredient list for the selected drink.
                RefreshIngredientList();
            }
            else
            {
                MessageBox.Show("Database file not found.");
            }
        }

        // Back button to close the form
        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            this.Close();
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {
        }

        private void listBoxDrinkIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBoxDrinkIngredients_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
    }
}

