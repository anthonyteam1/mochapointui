using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MochaPointInventory
{
    public partial class ViewInventory : Form
    {
        // Constructor
        public ViewInventory()
        {
            InitializeComponent();
        }

        // UI Setup
        private void InitializeComponent()  // <-- This should be the ONLY InitializeComponent() method
        {
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "View Inventory";

            // Table (DataGridView) setup
            DataGridView dataGridView = new DataGridView
            {
                ColumnCount = 4,
                Columns =
                {
                    [0] = { Name = "Ingredient" },
                    [1] = { Name = "Quantity" },
                    [2] = { Name = "Unit of Measurement" },
                    [3] = { Name = "Notification Threshold" }
                },
                Dock = DockStyle.Top,
                Height = 300
            };

            // Back Button
            Button buttonBack = new Button
            {
                Text = "Back",
                Location = new System.Drawing.Point(350, 360),
                Size = new System.Drawing.Size(100, 40)
            };
            buttonBack.Click += (sender, e) => this.Close();

            // Add controls to the form
            this.Controls.Add(dataGridView);
            this.Controls.Add(buttonBack);
        }
    }
}

