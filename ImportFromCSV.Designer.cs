using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MochaPointInventory
{
    partial class ImportFromCSV
    {
        private System.ComponentModel.IContainer components = null;

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
            this.buttonUpdateInventory = new System.Windows.Forms.Button();
            this.buttonAcceptChanges = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.IngredientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitOfMeasurementColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewInventoryLevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdateInventory
            // 
            this.buttonUpdateInventory.Location = new System.Drawing.Point(411, 15);
            this.buttonUpdateInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdateInventory.Name = "buttonUpdateInventory";
            this.buttonUpdateInventory.Size = new System.Drawing.Size(200, 37);
            this.buttonUpdateInventory.TabIndex = 3;
            this.buttonUpdateInventory.Text = "Upload Clover Spreadsheet";
            this.buttonUpdateInventory.Click += new System.EventHandler(this.buttonUpdateInventory_Click);
            // 
            // buttonAcceptChanges
            // 
            this.buttonAcceptChanges.Location = new System.Drawing.Point(411, 470);
            this.buttonAcceptChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAcceptChanges.Name = "buttonAcceptChanges";
            this.buttonAcceptChanges.Size = new System.Drawing.Size(177, 41);
            this.buttonAcceptChanges.TabIndex = 4;
            this.buttonAcceptChanges.Text = "Accept Changes";
            this.buttonAcceptChanges.Click += new System.EventHandler(this.buttonAcceptChanges_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(463, 517);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Back";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IngredientColumn,
            this.UnitOfMeasurementColumn,
            this.NewInventoryLevelColumn});
            this.dataGridViewInventory.Location = new System.Drawing.Point(16, 74);
            this.dataGridViewInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowHeadersWidth = 51;
            this.dataGridViewInventory.Size = new System.Drawing.Size(1013, 369);
            this.dataGridViewInventory.TabIndex = 14;
            this.dataGridViewInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInventory_CellContentClick);
            // 
            // IngredientColumn
            // 
            this.IngredientColumn.HeaderText = "Ingredient";
            this.IngredientColumn.MinimumWidth = 6;
            this.IngredientColumn.Name = "IngredientColumn";
            this.IngredientColumn.Width = 125;
            // 
            // UnitOfMeasurementColumn
            // 
            this.UnitOfMeasurementColumn.HeaderText = "Unit of Measurement";
            this.UnitOfMeasurementColumn.MinimumWidth = 6;
            this.UnitOfMeasurementColumn.Name = "UnitOfMeasurementColumn";
            this.UnitOfMeasurementColumn.Width = 125;
            // 
            // NewInventoryLevelColumn
            // 
            this.NewInventoryLevelColumn.HeaderText = "New Inventory Level";
            this.NewInventoryLevelColumn.MinimumWidth = 6;
            this.NewInventoryLevelColumn.Name = "NewInventoryLevelColumn";
            this.NewInventoryLevelColumn.Width = 125;
            // 
            // ImportFromCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAcceptChanges);
            this.Controls.Add(this.buttonUpdateInventory);
            this.Controls.Add(this.dataGridViewInventory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ImportFromCSV";
            this.Text = "ImportFromCSV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonUpdateInventory;
        private System.Windows.Forms.Button buttonAcceptChanges;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitOfMeasurementColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewInventoryLevelColumn;
    }
}
