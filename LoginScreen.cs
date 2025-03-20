using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace MochaPointInventory
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();


            // Set the default button to the Login button (this makes Enter key trigger the login button)
            this.AcceptButton = buttonLogin;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            HandleLogin();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HandleLogin(); // Trigger login if Enter is pressed
            }
        }

        private void HandleLogin()
        {
            string storedPassword = Database.GetPassword();  // Get the stored password from the database
            MessageBox.Show("Stored Password: " + storedPassword); // Debugging line

            if (textBoxPassword.Text == storedPassword)  // Check the entered password
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide(); // Hide login screen after successful login
            }
            else
            {
                MessageBox.Show("Incorrect password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }


