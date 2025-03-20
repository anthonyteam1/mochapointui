using System;
using System;
using System.Windows.Forms;

namespace MochaPointInventory
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        // Event handler for Manual Entry button click
        private void buttonManualEntry_Click(object sender, EventArgs e)
        {
            ManualEntry manualEntryForm = new ManualEntry();
            manualEntryForm.Show();  // Show the ManualEntry form
            this.Hide();  // Hide the MainMenu form
        }

        // Event handler for View Inventory button click
        private void buttonViewInventory_Click(object sender, EventArgs e)
        {
            ViewInventory viewInventoryForm = new ViewInventory();
            viewInventoryForm.Show();  // Show the ViewInventory form
            this.Hide();  // Hide the MainMenu form
        }

        // Event handler for Import from Excel button click (Adjusted)
        private void buttonImportFromExcel_Click(object sender, EventArgs e)
        {
            ImportFromCSV importFromCSVForm = new ImportFromCSV(); // Create the ImportFromCSV form instance
            importFromCSVForm.Show(); // Show the ImportFromCSV form
            this.Hide();  // Hide the MainMenu form
        }

        // Event handler for Settings button click
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Show();  // Show the Settings form
            this.Hide();  // Hide the MainMenu form
        }

        // Event handler for Exit button click
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();  // Close the application
        }

        // Event handler for Form Load
        private void MainMenu_Load(object sender, EventArgs e)
        {
            Database.CheckInventoryLevels();
        }

    }
}

