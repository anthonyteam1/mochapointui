namespace MochaPointInventory
{
    partial class IngredientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewIngredients;
        private System.Windows.Forms.Button buttonAddIngredient;
        private System.Windows.Forms.Button buttonRemoveIngredient;
        private System.Windows.Forms.TextBox textBoxIngredientName;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.NumericUpDown numericUpDownUnitConversion;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelIngredientName;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label labelUnitConversion;

        // DataGridView columns
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredientNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitConversionColumn;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.dataGridViewIngredients = new System.Windows.Forms.DataGridView();
            this.IngredientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitConversionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.buttonRemoveIngredient = new System.Windows.Forms.Button();
            this.textBoxIngredientName = new System.Windows.Forms.TextBox();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.numericUpDownUnitConversion = new System.Windows.Forms.NumericUpDown();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelIngredientName = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.labelUnitConversion = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownEdit = new System.Windows.Forms.NumericUpDown();
            this.textBoxEdit = new System.Windows.Forms.TextBox();
            this.comboBoxEdit = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnitConversion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIngredients
            // 
            this.dataGridViewIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IngredientNameColumn,
            this.UnitColumn,
            this.UnitConversionColumn});
            this.dataGridViewIngredients.Location = new System.Drawing.Point(330, 56);
            this.dataGridViewIngredients.Name = "dataGridViewIngredients";
            this.dataGridViewIngredients.RowHeadersWidth = 51;
            this.dataGridViewIngredients.Size = new System.Drawing.Size(443, 342);
            this.dataGridViewIngredients.TabIndex = 0;
            this.dataGridViewIngredients.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIngredients_CellEndEdit);
            // 
            // IngredientNameColumn
            // 
            this.IngredientNameColumn.HeaderText = "Ingredient Name";
            this.IngredientNameColumn.MinimumWidth = 6;
            this.IngredientNameColumn.Name = "IngredientNameColumn";
            this.IngredientNameColumn.Width = 125;
            // 
            // UnitColumn
            // 
            this.UnitColumn.HeaderText = "Unit";
            this.UnitColumn.MinimumWidth = 6;
            this.UnitColumn.Name = "UnitColumn";
            this.UnitColumn.Width = 125;
            // 
            // UnitConversionColumn
            // 
            this.UnitConversionColumn.HeaderText = "Unit Conversion";
            this.UnitConversionColumn.MinimumWidth = 6;
            this.UnitConversionColumn.Name = "UnitConversionColumn";
            this.UnitConversionColumn.Width = 125;
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.Location = new System.Drawing.Point(110, 234);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(75, 22);
            this.buttonAddIngredient.TabIndex = 1;
            this.buttonAddIngredient.Text = "Add Ingredient";
            this.buttonAddIngredient.UseVisualStyleBackColor = true;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // buttonRemoveIngredient
            // 
            this.buttonRemoveIngredient.Location = new System.Drawing.Point(651, 450);
            this.buttonRemoveIngredient.Name = "buttonRemoveIngredient";
            this.buttonRemoveIngredient.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveIngredient.TabIndex = 2;
            this.buttonRemoveIngredient.Text = "Remove Ingredient";
            this.buttonRemoveIngredient.UseVisualStyleBackColor = true;
            this.buttonRemoveIngredient.Click += new System.EventHandler(this.buttonRemoveIngredient_Click);
            // 
            // textBoxIngredientName
            // 
            this.textBoxIngredientName.Location = new System.Drawing.Point(155, 103);
            this.textBoxIngredientName.Name = "textBoxIngredientName";
            this.textBoxIngredientName.Size = new System.Drawing.Size(151, 22);
            this.textBoxIngredientName.TabIndex = 3;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(155, 144);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(151, 22);
            this.textBoxUnit.TabIndex = 4;
            // 
            // numericUpDownUnitConversion
            // 
            this.numericUpDownUnitConversion.Location = new System.Drawing.Point(155, 187);
            this.numericUpDownUnitConversion.Name = "numericUpDownUnitConversion";
            this.numericUpDownUnitConversion.Size = new System.Drawing.Size(151, 22);
            this.numericUpDownUnitConversion.TabIndex = 5;
            this.numericUpDownUnitConversion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(378, 450);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelIngredientName
            // 
            this.labelIngredientName.AutoSize = true;
            this.labelIngredientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelIngredientName.Location = new System.Drawing.Point(14, 107);
            this.labelIngredientName.Name = "labelIngredientName";
            this.labelIngredientName.Size = new System.Drawing.Size(115, 18);
            this.labelIngredientName.TabIndex = 7;
            this.labelIngredientName.Text = "Ingredient Name";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelUnit.Location = new System.Drawing.Point(3, 148);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(146, 18);
            this.labelUnit.TabIndex = 8;
            this.labelUnit.Text = "Unit of Measurement";
            // 
            // labelUnitConversion
            // 
            this.labelUnitConversion.AutoSize = true;
            this.labelUnitConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelUnitConversion.Location = new System.Drawing.Point(15, 191);
            this.labelUnitConversion.Name = "labelUnitConversion";
            this.labelUnitConversion.Size = new System.Drawing.Size(124, 18);
            this.labelUnitConversion.TabIndex = 9;
            this.labelUnitConversion.Text = "Ingredient Serving";
            this.labelUnitConversion.Click += new System.EventHandler(this.labelUnitConversion_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(219, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(284, 29);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "Ingredient Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Create Ingredient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(38, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Edit Ingredient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(15, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingredient Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(3, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Unit of Measurement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(15, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ingredient Serving";
            // 
            // numericUpDownEdit
            // 
            this.numericUpDownEdit.Location = new System.Drawing.Point(155, 403);
            this.numericUpDownEdit.Name = "numericUpDownEdit";
            this.numericUpDownEdit.Size = new System.Drawing.Size(151, 22);
            this.numericUpDownEdit.TabIndex = 16;
            this.numericUpDownEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxEdit
            // 
            this.textBoxEdit.Location = new System.Drawing.Point(155, 361);
            this.textBoxEdit.Name = "textBoxEdit";
            this.textBoxEdit.Size = new System.Drawing.Size(151, 22);
            this.textBoxEdit.TabIndex = 17;
            // 
            // comboBoxEdit
            // 
            this.comboBoxEdit.Location = new System.Drawing.Point(155, 313);
            this.comboBoxEdit.Name = "comboBoxEdit";
            this.comboBoxEdit.Size = new System.Drawing.Size(151, 24);
            this.comboBoxEdit.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 19;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IngredientForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(805, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxEdit);
            this.Controls.Add(this.textBoxEdit);
            this.Controls.Add(this.numericUpDownEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelUnitConversion);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.labelIngredientName);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.numericUpDownUnitConversion);
            this.Controls.Add(this.textBoxUnit);
            this.Controls.Add(this.textBoxIngredientName);
            this.Controls.Add(this.buttonRemoveIngredient);
            this.Controls.Add(this.buttonAddIngredient);
            this.Controls.Add(this.dataGridViewIngredients);
            this.Name = "IngredientForm";
            this.Text = "Manage Ingredients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnitConversion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownEdit;
        private System.Windows.Forms.TextBox textBoxEdit;
        private System.Windows.Forms.ComboBox comboBoxEdit;
        private System.Windows.Forms.Button button1;
    }
}

