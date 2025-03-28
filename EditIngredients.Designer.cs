namespace MochaPointInventory
{
    partial class DrinkCreationForm
    {
        private System.ComponentModel.IContainer components = null;
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAdd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDrinkName
            // 
            this.labelDrinkName.AutoSize = true;
            this.labelDrinkName.Location = new System.Drawing.Point(14, 129);
            this.labelDrinkName.Name = "labelDrinkName";
            this.labelDrinkName.Size = new System.Drawing.Size(81, 16);
            this.labelDrinkName.TabIndex = 1;
            this.labelDrinkName.Text = "Drink Name:";
            // 
            // textBoxDrinkName
            // 
            this.textBoxDrinkName.Location = new System.Drawing.Point(115, 127);
            this.textBoxDrinkName.Name = "textBoxDrinkName";
            this.textBoxDrinkName.Size = new System.Drawing.Size(170, 22);
            this.textBoxDrinkName.TabIndex = 2;
            // 
            // labelIngredient
            // 
            this.labelIngredient.AutoSize = true;
            this.labelIngredient.Location = new System.Drawing.Point(14, 258);
            this.labelIngredient.Name = "labelIngredient";
            this.labelIngredient.Size = new System.Drawing.Size(69, 16);
            this.labelIngredient.TabIndex = 3;
            this.labelIngredient.Text = "Ingredient:";
            // 
            // comboBoxIngredient
            // 
            this.comboBoxIngredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIngredient.FormattingEnabled = true;
            this.comboBoxIngredient.Location = new System.Drawing.Point(115, 255);
            this.comboBoxIngredient.Name = "comboBoxIngredient";
            this.comboBoxIngredient.Size = new System.Drawing.Size(170, 24);
            this.comboBoxIngredient.TabIndex = 4;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(12, 305);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(82, 16);
            this.labelQuantity.TabIndex = 5;
            this.labelQuantity.Text = "Serving Size";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(115, 303);
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
            this.buttonAddIngredient.Location = new System.Drawing.Point(90, 467);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(170, 30);
            this.buttonAddIngredient.TabIndex = 7;
            this.buttonAddIngredient.Text = "Add Ingredient/Drink";
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
            this.labelSelectDrink.Location = new System.Drawing.Point(472, 129);
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
            this.labelTitle.Size = new System.Drawing.Size(176, 29);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Drink Settings";
            // 
            // buttonRemoveDrink
            // 
            this.buttonRemoveDrink.Location = new System.Drawing.Point(513, 456);
            this.buttonRemoveDrink.Name = "buttonRemoveDrink";
            this.buttonRemoveDrink.Size = new System.Drawing.Size(111, 52);
            this.buttonRemoveDrink.TabIndex = 4;
            this.buttonRemoveDrink.Text = "Remove Drink";
            this.buttonRemoveDrink.UseVisualStyleBackColor = true;
            this.buttonRemoveDrink.Click += new System.EventHandler(this.buttonRemoveDrink_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(456, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Remove Drink/Ingredient";
            // 
            // buttonRemoveIngredient
            // 
            this.buttonRemoveIngredient.Location = new System.Drawing.Point(652, 456);
            this.buttonRemoveIngredient.Name = "buttonRemoveIngredient";
            this.buttonRemoveIngredient.Size = new System.Drawing.Size(111, 52);
            this.buttonRemoveIngredient.TabIndex = 6;
            this.buttonRemoveIngredient.Text = "Remove Ingredient";
            this.buttonRemoveIngredient.UseVisualStyleBackColor = true;
            this.buttonRemoveIngredient.Click += new System.EventHandler(this.buttonRemoveIngredient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(48, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Create Drink";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(120, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Edit Drink";
            // 
            // comboBoxAdd
            // 
            this.comboBoxAdd.Location = new System.Drawing.Point(115, 201);
            this.comboBoxAdd.Name = "comboBoxAdd";
            this.comboBoxAdd.Size = new System.Drawing.Size(170, 24);
            this.comboBoxAdd.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select Drink";
            // 
            // DrinkCreationForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(790, 520);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRemoveIngredient);
            this.Controls.Add(this.labelDrinkName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDrinkName);
            this.Controls.Add(this.comboBoxDrinkSelection);
            this.Controls.Add(this.labelIngredient);
            this.Controls.Add(this.buttonRemoveDrink);
            this.Controls.Add(this.comboBoxIngredient);
            this.Controls.Add(this.labelSelectDrink);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.listBoxDrinkIngredients);
            this.Controls.Add(this.buttonAddIngredient);
            this.Controls.Add(this.buttonBack);
            this.Name = "DrinkCreationForm";
            this.Text = "Drink Creation and Viewer";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAdd;
        private System.Windows.Forms.Label label4;
    }
}


