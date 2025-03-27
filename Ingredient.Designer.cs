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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnitConversion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIngredients
            // 
            this.dataGridViewIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IngredientNameColumn,
            this.UnitColumn,
            this.UnitConversionColumn});
            this.dataGridViewIngredients.Location = new System.Drawing.Point(262, 56);
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
            this.buttonAddIngredient.Location = new System.Drawing.Point(43, 412);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(75, 23);
            this.buttonAddIngredient.TabIndex = 1;
            this.buttonAddIngredient.Text = "Add Ingredient";
            this.buttonAddIngredient.UseVisualStyleBackColor = true;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // buttonRemoveIngredient
            // 
            this.buttonRemoveIngredient.Location = new System.Drawing.Point(586, 423);
            this.buttonRemoveIngredient.Name = "buttonRemoveIngredient";
            this.buttonRemoveIngredient.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveIngredient.TabIndex = 2;
            this.buttonRemoveIngredient.Text = "Remove Ingredient";
            this.buttonRemoveIngredient.UseVisualStyleBackColor = true;
            this.buttonRemoveIngredient.Click += new System.EventHandler(this.buttonRemoveIngredient_Click);
            // 
            // textBoxIngredientName
            // 
            this.textBoxIngredientName.Location = new System.Drawing.Point(156, 268);
            this.textBoxIngredientName.Name = "textBoxIngredientName";
            this.textBoxIngredientName.Size = new System.Drawing.Size(100, 22);
            this.textBoxIngredientName.TabIndex = 3;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(156, 312);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(100, 22);
            this.textBoxUnit.TabIndex = 4;
            // 
            // numericUpDownUnitConversion
            // 
            this.numericUpDownUnitConversion.Location = new System.Drawing.Point(156, 348);
            this.numericUpDownUnitConversion.Name = "numericUpDownUnitConversion";
            this.numericUpDownUnitConversion.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownUnitConversion.TabIndex = 5;
            this.numericUpDownUnitConversion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(303, 423);
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
            this.labelIngredientName.Location = new System.Drawing.Point(35, 272);
            this.labelIngredientName.Name = "labelIngredientName";
            this.labelIngredientName.Size = new System.Drawing.Size(115, 18);
            this.labelIngredientName.TabIndex = 7;
            this.labelIngredientName.Text = "Ingredient Name";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelUnit.Location = new System.Drawing.Point(4, 316);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(146, 18);
            this.labelUnit.TabIndex = 8;
            this.labelUnit.Text = "Unit of Measurement";
            // 
            // labelUnitConversion
            // 
            this.labelUnitConversion.AutoSize = true;
            this.labelUnitConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelUnitConversion.Location = new System.Drawing.Point(35, 352);
            this.labelUnitConversion.Name = "labelUnitConversion";
            this.labelUnitConversion.Size = new System.Drawing.Size(114, 18);
            this.labelUnitConversion.TabIndex = 9;
            this.labelUnitConversion.Text = "Unit Conversion";
            this.labelUnitConversion.Click += new System.EventHandler(this.labelUnitConversion_Click);
            // 
            // IngredientForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(717, 458);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

