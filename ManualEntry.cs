using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace MochaPointInventory
{
    public partial class ManualEntry : Form
    {
        public ManualEntry()
        {
            InitializeComponent();
        }

        // Back button click event
        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Create an instance of the MainMenu form
            MainMenu mainMenuForm = new MainMenu();

            // Show the MainMenu form
            mainMenuForm.Show();

            // Close the current ManualEntry form
            this.Close();
        }
    }
}
