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
        private const string DefaultPassword = "ILOVECOFFEE"; // Temporary hardcoded password

        public LoginScreen()
        {
            InitializeComponent(); // Ensures the controls are initialized
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == DefaultPassword)
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

