namespace MochaPointInventory
{
    partial class DrinkCreationForm
    {
        private System.ComponentModel.IContainer components = null;
        // Left Panel Controls (Drink Creation)
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelCreateDrink;
        private System.Windows.Forms.TextBox textBoxDrinkName;
        private System.Windows.Forms.Label labelDrinkName;
        private System.Windows.Forms.ComboBox comboBoxIngredient;
        private System.Windows.Forms.Label labelIngredient;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonAddIngredient;
        private System.Windows.Forms.ComboBox comboBoxDrinkSelection;

        // Other Controls
        private System.Windows.Forms.Button buttonBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelCreateDrink = new System.Windows.Forms.Label();
            this.labelDrinkName = new System.Windows.Forms.Label();
            this.textBoxDrinkName = new System.Windows.Forms.TextBox();
            this.labelIngredient = new System.Windows.Forms.Label();
            this.comboBoxIngredient = new System.Windows.Forms.ComboBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.comboBoxDrinkSelection = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.listBoxDrinkIngredients = new System.Windows.Forms.ListBox();
            this.labelSelectDrink = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonRemoveDrink = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemoveIngredient = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.labelCreateDrink);
            this.panelLeft.Controls.Add(this.labelDrinkName);
            this.panelLeft.Controls.Add(this.textBoxDrinkName);
            this.panelLeft.Controls.Add(this.labelIngredient);
            this.panelLeft.Controls.Add(this.comboBoxIngredient);
            this.panelLeft.Controls.Add(this.labelQuantity);
            this.panelLeft.Controls.Add(this.numericUpDownQuantity);
            this.panelLeft.Controls.Add(this.buttonAddIngredient);
            this.panelLeft.Location = new System.Drawing.Point(30, 64);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(300, 379);
            this.panelLeft.TabIndex = 0;
            // 
            // labelCreateDrink
            // 
            this.labelCreateDrink.AutoSize = true;
            this.labelCreateDrink.Location = new System.Drawing.Point(20, 20);
            this.labelCreateDrink.Name = "labelCreateDrink";
            this.labelCreateDrink.Size = new System.Drawing.Size(144, 16);
            this.labelCreateDrink.TabIndex = 0;
            this.labelCreateDrink.Text = "Create New Drink Entry";
            // 
            // labelDrinkName
            // 
            this.labelDrinkName.AutoSize = true;
            this.labelDrinkName.Location = new System.Drawing.Point(20, 50);
            this.labelDrinkName.Name = "labelDrinkName";
            this.labelDrinkName.Size = new System.Drawing.Size(81, 16);
            this.labelDrinkName.TabIndex = 1;
            this.labelDrinkName.Text = "Drink Name:";
            // 
            // textBoxDrinkName
            // 
            this.textBoxDrinkName.Location = new System.Drawing.Point(100, 47);
            this.textBoxDrinkName.Name = "textBoxDrinkName";
            this.textBoxDrinkName.Size = new System.Drawing.Size(170, 22);
            this.textBoxDrinkName.TabIndex = 2;
            // 
            // labelIngredient
            // 
            this.labelIngredient.AutoSize = true;
            this.labelIngredient.Location = new System.Drawing.Point(20, 90);
            this.labelIngredient.Name = "labelIngredient";
            this.labelIngredient.Size = new System.Drawing.Size(69, 16);
            this.labelIngredient.TabIndex = 3;
            this.labelIngredient.Text = "Ingredient:";
            // 
            // comboBoxIngredient
            // 
            this.comboBoxIngredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIngredient.FormattingEnabled = true;
            this.comboBoxIngredient.Location = new System.Drawing.Point(100, 87);
            this.comboBoxIngredient.Name = "comboBoxIngredient";
            this.comboBoxIngredient.Size = new System.Drawing.Size(170, 24);
            this.comboBoxIngredient.TabIndex = 4;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(20, 130);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(58, 16);
            this.labelQuantity.TabIndex = 5;
            this.labelQuantity.Text = "Quantity:";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(100, 128);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(170, 22);
            this.numericUpDownQuantity.TabIndex = 6;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.Location = new System.Drawing.Point(100, 170);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(170, 30);
            this.buttonAddIngredient.TabIndex = 7;
            this.buttonAddIngredient.Text = "Add Ingredient";
            this.buttonAddIngredient.UseVisualStyleBackColor = true;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // comboBoxDrinkSelection
            // 
            this.comboBoxDrinkSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrinkSelection.FormattingEnabled = true;
            this.comboBoxDrinkSelection.Location = new System.Drawing.Point(593, 125);
            this.comboBoxDrinkSelection.Name = "comboBoxDrinkSelection";
            this.comboBoxDrinkSelection.Size = new System.Drawing.Size(170, 24);
            this.comboBoxDrinkSelection.TabIndex = 2;
            this.comboBoxDrinkSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrinkSelection_SelectedIndexChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(351, 478);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 30);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // listBoxDrinkIngredients
            // 
            this.listBoxDrinkIngredients.FormattingEnabled = true;
            this.listBoxDrinkIngredients.ItemHeight = 16;
            this.listBoxDrinkIngredients.Location = new System.Drawing.Point(513, 155);
            this.listBoxDrinkIngredients.Name = "listBoxDrinkIngredients";
            this.listBoxDrinkIngredients.Size = new System.Drawing.Size(250, 276);
            this.listBoxDrinkIngredients.TabIndex = 3;
            this.listBoxDrinkIngredients.SelectedIndexChanged += new System.EventHandler(this.listBoxDrinkIngredients_SelectedIndexChanged_1);
            // 
            // labelSelectDrink
            // 
            this.labelSelectDrink.AutoSize = true;
            this.labelSelectDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSelectDrink.Location = new System.Drawing.Point(481, 129);
            this.labelSelectDrink.Name = "labelSelectDrink";
            this.labelSelectDrink.Size = new System.Drawing.Size(106, 20);
            this.labelSelectDrink.TabIndex = 1;
            this.labelSelectDrink.Text = "Select Drink:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(292, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(201, 29);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Ingredient Menu";
            // 
            // buttonRemoveDrink
            // 
            this.buttonRemoveDrink.Location = new System.Drawing.Point(513, 456);
            this.buttonRemoveDrink.Name = "buttonRemoveDrink";
            this.buttonRemoveDrink.Size = new System.Drawing.Size(111, 52);
            this.buttonRemoveDrink.TabIndex = 4;
            this.buttonRemoveDrink.Text = "Remove Drink";
            this.buttonRemoveDrink.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(456, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Drink and Ingredient Details";
            // 
            // buttonRemoveIngredient
            // 
            this.buttonRemoveIngredient.Location = new System.Drawing.Point(652, 456);
            this.buttonRemoveIngredient.Name = "buttonRemoveIngredient";
            this.buttonRemoveIngredient.Size = new System.Drawing.Size(111, 52);
            this.buttonRemoveIngredient.TabIndex = 6;
            this.buttonRemoveIngredient.Text = "Remove Ingredient";
            this.buttonRemoveIngredient.UseVisualStyleBackColor = true;
            // 
            // DrinkCreationForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(790, 520);
            this.Controls.Add(this.buttonRemoveIngredient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDrinkSelection);
            this.Controls.Add(this.buttonRemoveDrink);
            this.Controls.Add(this.labelSelectDrink);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listBoxDrinkIngredients);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.buttonBack);
            this.Name = "DrinkCreationForm";
            this.Text = "Drink Creation and Viewer";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox listBoxDrinkIngredients;
        private System.Windows.Forms.Label labelSelectDrink;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonRemoveDrink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRemoveIngredient;
    }
}


