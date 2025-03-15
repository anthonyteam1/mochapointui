using System.Drawing;
using System.Windows.Forms;

namespace MochaPointInventory
{
    partial class ManualEntry
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxItems;
        private NumericUpDown numericUpDownQuantity;
        private Button buttonUpdateInventory;
        private Button buttonBack;
        private Label labelTitle;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label label6;

        private void InitializeComponent()
        {
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonUpdateInventory = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();

            // comboBoxItems
            this.comboBoxItems.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Item3"});
            this.comboBoxItems.Location = new System.Drawing.Point(70, 157);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(150, 24);
            this.comboBoxItems.TabIndex = 0;

            // numericUpDownQuantity
            this.numericUpDownQuantity.Location = new System.Drawing.Point(84, 321);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownQuantity.TabIndex = 1;

            // buttonUpdateInventory
            this.buttonUpdateInventory.Location = new System.Drawing.Point(285, 375);
            this.buttonUpdateInventory.Name = "buttonUpdateInventory";
            this.buttonUpdateInventory.Size = new System.Drawing.Size(150, 30);
            this.buttonUpdateInventory.TabIndex = 2;
            this.buttonUpdateInventory.Text = "Update Inventory";

            // buttonBack
            this.buttonBack.Location = new System.Drawing.Point(313, 422);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(279, 56);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(185, 31);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Manual Entry";

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Product";

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(65, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add/Subtract";

            // comboBox1
            this.comboBox1.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Item3"});
            this.comboBox1.Location = new System.Drawing.Point(70, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 24);
            this.comboBox1.TabIndex = 7;

            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(96, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";

            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(449, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select Product";

            // comboBox2
            this.comboBox2.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Item3"});
            this.comboBox2.Location = new System.Drawing.Point(465, 157);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 24);
            this.comboBox2.TabIndex = 10;

            // label5
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(435, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Set New Quantity";

            // numericUpDown1
            this.numericUpDown1.Location = new System.Drawing.Point(474, 248);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 12;

            // label6
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "OR";

            // ManualEntryForm
            this.ClientSize = new System.Drawing.Size(782, 528);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.buttonUpdateInventory);
            this.Name = "ManualEntryForm";
            this.Text = "Manual Entry";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
