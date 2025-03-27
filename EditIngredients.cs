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
            // Get drink name, ingredient, and quantity
            string drinkName = textBoxDrinkName.Text.Trim();
            if (string.IsNullOrEmpty(drinkName))
            {
                MessageBox.Show("Please enter a drink name.");
                return;
            }
            if (comboBoxIngredient.SelectedItem == null)
            {
                MessageBox.Show("Please select an ingredient.");
                return;
            }
            string ingredient = comboBoxIngredient.SelectedItem.ToString();
            int quantity = (int)numericUpDownQuantity.Value;

            // Insert into DrinkIngredients table
            if (File.Exists(dbPath))
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};"))
                {
                    conn.Open();
                    string query = "INSERT INTO DrinkIngredients (DrinkName, IngredientName, Quantity) VALUES (@DrinkName, @Ingredient, @Quantity)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DrinkName", drinkName);
                        cmd.Parameters.AddWithValue("@Ingredient", ingredient);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                MessageBox.Show("Ingredient added to drink successfully.");
                // Refresh the right panel drink selection
                PopulateDrinkSelectionComboBox();
            }
            else
            {
                MessageBox.Show("Database file not found.");
            }
        }

        // When a drink is selected from the right panel, display its ingredients in listBoxDrinkIngredients
        private void comboBoxDrinkSelection_SelectedIndexChanged(object sender, EventArgs e)
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

