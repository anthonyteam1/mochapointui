using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MochaPointInventory
{
    public partial class ImportFromCSV : Form
    {
        public ImportFromCSV()
        {
            InitializeComponent();
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
                            string unit = "units";  // Placeholder unit for now
                            if (int.TryParse(values[4].Trim(), out int quantitySold))
                            {
                                // Subtract from Inventory
                                Database.SubtractFromInventory(ingredient, quantitySold);

                                // Update DataGridView
                                var existingRow = dataGridViewInventory
                                    .Rows.Cast<DataGridViewRow>()
                                    .FirstOrDefault(row => row.Cells["IngredientColumn"].Value?.ToString() == ingredient);

                                if (existingRow != null)
                                {
                                    int existingQuantity = Convert.ToInt32(existingRow.Cells["NewInventoryLevelColumn"].Value);
                                    existingRow.Cells["NewInventoryLevelColumn"].Value = existingQuantity - quantitySold;
                                }
                                else
                                {
                                    dataGridViewInventory.Rows.Add(ingredient, unit, quantitySold);
                                }
                            }
                        }
                    }

                    MessageBox.Show("CSV file successfully imported and inventory updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void buttonAcceptChanges_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes Accepted!");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Close the current ImportFromCSV form
            this.Close();

            // Create and show the MainMenu form
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
        }

        private void dataGridViewInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Currently not being used
        }
    }
}

