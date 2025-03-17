using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  // Make sure this is included for UI controls

namespace MochaPointInventory
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // Load ingredients into the dropdown (just an example, you can load dynamically)
            comboBoxIngredients.Items.Add("Coffee");
            comboBoxIngredients.Items.Add("Tea");
            comboBoxIngredients.Items.Add("Milk");
            comboBoxIngredients.Items.Add("Sugar");
        }

        // Save the new password in the database
        private void buttonSavePassword_Click(object sender, EventArgs e)
        {
            string newPassword = textBoxNewPassword.Text;  // Get the new password entered by the user

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please enter a valid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the database function to update the password
            Database.UpdatePassword(newPassword);

            MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Handle the back button functionality
        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Close the current settings form and go back to the previous form
            this.Close();

            // Create and show the MainMenu form
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
        }
    }
}
