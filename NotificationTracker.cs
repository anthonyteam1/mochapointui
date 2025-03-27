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
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MochaPointInventory
{
    public partial class NotificationTracker : Form
    {
        public NotificationTracker()
        {
            InitializeComponent();
        }

        private void NotificationTracker_Load(object sender, EventArgs e)
        {
            LoadNotifications();

            // Ensure that the DataGridView has at least 4 columns
            while (dataGridViewNotifications.Columns.Count < 4)
            {
                dataGridViewNotifications.Columns.Add("Threshold", "Threshold");
            }

            // Set the column headers
            dataGridViewNotifications.Columns[0].HeaderText = "Product";
            dataGridViewNotifications.Columns[1].HeaderText = "Date";
            dataGridViewNotifications.Columns[2].HeaderText = "Stock at Alert";
            dataGridViewNotifications.Columns[3].HeaderText = "Threshold";
        }

        private void LoadNotifications()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\Owner\\AppData\\Local\\inventory.db;Version=3;"))
            {
                connection.Open();

                // Modify the query to join NotificationLog with Inventory to get the Threshold value
                string query = @"
                    SELECT 
                        n.IngredientName, 
                        n.AlertDateTime, 
                        n.QuantityAtAlert, 
                        i.Threshold 
                    FROM 
                        NotificationLog n
                    INNER JOIN 
                        Inventory i ON n.IngredientName = i.IngredientName
                    ORDER BY 
                        n.AlertDateTime DESC";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the result to the DataGridView
                    dataGridViewNotifications.DataSource = dataTable;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            this.Close();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}

