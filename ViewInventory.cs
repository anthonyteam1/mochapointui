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
using System.Windows.Forms;

namespace MochaPointInventory
{
    public partial class ViewInventory : Form
    {
        public ViewInventory()
        {
            InitializeComponent(); // This will initialize the UI from the Designer file
            LoadInventory();       // Loading the inventory from the database
        }

        private void LoadInventory()
        {
            // Set up connection to the database
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\Owner\\AppData\\Local\\Inventory.db;Version=3;"))
            {
                connection.Open();

                // SQL query to retrieve the data we need from Inventory table
                string query = "SELECT IngredientName, CurrentQuantity, Unit, Threshold FROM Inventory";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        // Clear any existing rows in DataGridView before adding new ones
                        dataGridView.Rows.Clear();

                        // Populate DataGridView with the data from the database
                        while (reader.Read())
                        {
                            string ingredientName = reader["IngredientName"].ToString();
                            double currentQuantity = Convert.ToDouble(reader["CurrentQuantity"]);
                            string unit = reader["Unit"].ToString();
                            double threshold = reader["Threshold"] != DBNull.Value ? Convert.ToDouble(reader["Threshold"]) : 0;

                            // Add a row to the DataGridView
                            dataGridView.Rows.Add(ingredientName, currentQuantity, unit, threshold);
                        }
                    }
                }
            }
        }

        // Back button click event
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

