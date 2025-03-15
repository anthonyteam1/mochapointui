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
using System.IO;
using System.Windows.Forms;

namespace MochaPointInventory
{
    public partial class ImportFromCSV : Form
    {
        public ImportFromCSV()
        {
            InitializeComponent();
        }

        private void buttonAcceptChanges_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes Accepted!");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Go back to the previous screen (e.g., MainMenu)
            this.Close();  // Closes the current form
        }
    }
}

