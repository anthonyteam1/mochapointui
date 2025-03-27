using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.SQLite;
using System.IO;
namespace MochaPointInventory
{
    public partial class IngredientForm : Form
    {
        // Database path
        private string dbPath = @"C:\Users\Owner\AppData\Local\inventory.db";

        public IngredientForm()
        {
            InitializeComponent();
            LoadIngredients();
        }

        // Load all ingredients from the Inventory table into DataGridView
        private void LoadIngredients()
        {
            dataGridViewIngredients.Rows.Clear();
            if (File.Exists(dbPath))
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};"))
                {
                    conn.Open();
                    // Query to fetch data
                    string query = "SELECT IngredientName, Unit, UnitConversion FROM Inventory ORDER BY IngredientName ASC";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ingredientName = reader["IngredientName"].ToString();
                            string unit = reader["Unit"].ToString();
                            string unitConversion = reader["UnitConversion"].ToString();

                            // Add the ingredient to the DataGridView
                            dataGridViewIngredients.Rows.Add(ingredientName, unit, unitConversion);
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

        // Add a new ingredient to the Inventory table
        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            string ingredientName = textBoxIngredientName.Text.Trim();
            string unit = textBoxUnit.Text.Trim();
            decimal unitConversion = numericUpDownUnitConversion.Value;

            if (string.IsNullOrEmpty(ingredientName) || string.IsNullOrEmpty(unit))
            {
                MessageBox.Show("Please enter both the ingredient name and unit.");
                return;
            }

            if (File.Exists(dbPath))
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};"))
                {
                    conn.Open();
                    // INSERT now includes CurrentQuantity with a default value of 0.
                    string query = "INSERT INTO Inventory (IngredientName, Unit, CurrentQuantity, UnitConversion) VALUES (@IngredientName, @Unit, @CurrentQuantity, @UnitConversion)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IngredientName", ingredientName);
                        cmd.Parameters.AddWithValue("@Unit", unit);
                        cmd.Parameters.AddWithValue("@CurrentQuantity", 0); // Default value of 0
                        cmd.Parameters.AddWithValue("@UnitConversion", unitConversion);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                MessageBox.Show("Ingredient added successfully.");
                ClearInputFields();
                LoadIngredients();
            }
            else
            {
                MessageBox.Show("Database file not found.");
            }
        }

        // Remove the selected ingredient from the Inventory table
        private void buttonRemoveIngredient_Click(object sender, EventArgs e)
        {
            if (dataGridViewIngredients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an ingredient to remove.");
                return;
            }

            // Get the selected ingredient name from the DataGridView
            string ingredientName = dataGridViewIngredients.SelectedRows[0].Cells[0].Value.ToString();

            if (File.Exists(dbPath))
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};"))
                {
                    conn.Open();
                    string query = "DELETE FROM Inventory WHERE IngredientName = @IngredientName";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IngredientName", ingredientName);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                MessageBox.Show("Ingredient removed successfully.");
                LoadIngredients();
            }
            else
            {
                MessageBox.Show("Database file not found.");
            }
        }

        // Update UnitConversion for selected ingredient
        private void dataGridViewIngredients_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) // UnitConversion column
            {
                string ingredientName = dataGridViewIngredients.Rows[e.RowIndex].Cells[0].Value.ToString();
                decimal unitConversion = Convert.ToDecimal(dataGridViewIngredients.Rows[e.RowIndex].Cells[2].Value);

                if (File.Exists(dbPath))
                {
                    using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};"))
                    {
                        conn.Open();
                        string query = "UPDATE Inventory SET UnitConversion = @UnitConversion WHERE IngredientName = @IngredientName";
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@UnitConversion", unitConversion);
                            cmd.Parameters.AddWithValue("@IngredientName", ingredientName);
                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                    MessageBox.Show("Unit conversion updated successfully.");
                }
                else
                {
                    MessageBox.Show("Database file not found.");
                }
            }
        }

        // Clear input fields after adding an ingredient
        private void ClearInputFields()
        {
            textBoxIngredientName.Text = "";
            textBoxUnit.Text = "";
            numericUpDownUnitConversion.Value = 0;
        }

        // Back button logic
        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            this.Close();
        }

        private void labelUnitConversion_Click(object sender, EventArgs e)
        {

        }
    }
}

