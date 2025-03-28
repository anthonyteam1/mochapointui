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
            this.Load += new EventHandler(this.IngredientForm_Load);
            button1.Click += new EventHandler(buttonEditIngredient_Click);


        }

        private void IngredientForm_Load(object sender, EventArgs e)
        {
            PopulateComboBoxEdit();
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
                    string query = "SELECT IngredientName, Unit, UnitConversion FROM Inventory ORDER BY IngredientName ASC";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ingredientName = reader["IngredientName"].ToString();
                            string unit = reader["Unit"].ToString();
                            string unitConversion = reader["UnitConversion"].ToString();
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

        private void PopulateComboBoxEdit()
        {
            comboBoxEdit.Items.Clear();
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
                            comboBoxEdit.Items.Add(reader["IngredientName"].ToString());
                        }
                    }
                    conn.Close();
                }
            }
        }

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
                    string query = "INSERT INTO Inventory (IngredientName, Unit, CurrentQuantity, UnitConversion) VALUES (@IngredientName, @Unit, @CurrentQuantity, @UnitConversion)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IngredientName", ingredientName);
                        cmd.Parameters.AddWithValue("@Unit", unit);
                        cmd.Parameters.AddWithValue("@CurrentQuantity", 0);
                        cmd.Parameters.AddWithValue("@UnitConversion", unitConversion);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                MessageBox.Show("Ingredient added successfully.");
                ClearInputFields();
                LoadIngredients();
                PopulateComboBoxEdit();
            }
            else
            {
                MessageBox.Show("Database file not found.");
            }
        }

        private void buttonRemoveIngredient_Click(object sender, EventArgs e)
        {
            if (dataGridViewIngredients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an ingredient to remove.");
                return;
            }

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
                PopulateComboBoxEdit();
            }
            else
            {
                MessageBox.Show("Database file not found.");
            }
        }

        private void buttonEditIngredient_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit.SelectedItem == null)
            {
                MessageBox.Show("Please select an ingredient to edit.");
                return;
            }
            string ingredientName = comboBoxEdit.SelectedItem.ToString();
            string unit = textBoxEdit.Text.Trim();
            decimal unitConversion = numericUpDownEdit.Value;

            if (File.Exists(dbPath))
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};"))
                {
                    conn.Open();
                    string query = "UPDATE Inventory SET Unit = @Unit, UnitConversion = @UnitConversion WHERE IngredientName = @IngredientName";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Unit", unit);
                        cmd.Parameters.AddWithValue("@UnitConversion", unitConversion);
                        cmd.Parameters.AddWithValue("@IngredientName", ingredientName);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                MessageBox.Show("Ingredient updated successfully.");
                LoadIngredients();
            }
            else
            {
                MessageBox.Show("Database file not found.");
            }
        }

        private void ClearInputFields()
        {
            textBoxIngredientName.Text = "";
            textBoxUnit.Text = "";
            numericUpDownUnitConversion.Value = 0;
            textBoxEdit.Text = "";
            numericUpDownEdit.Value = 0;
            comboBoxEdit.SelectedIndex = -1;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            this.Close();
        }

        // The missing event handler for DataGridView CellEndEdit
        private void dataGridViewIngredients_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: Add code here to handle when a cell's editing ends, if needed.
        }

        // The missing event handler for label UnitConversion Click
        private void labelUnitConversion_Click(object sender, EventArgs e)
        {
            // TODO: Add code here to handle when the label is clicked, if needed.
        }
    }
}
