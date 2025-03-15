using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using System;
using System.IO;
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
            this.buttonUpdateInventory.Location = new System.Drawing.Point(308, 12);
            this.buttonUpdateInventory.Name = "buttonUpdateInventory";
            this.buttonUpdateInventory.Size = new System.Drawing.Size(150, 30);
            this.buttonUpdateInventory.TabIndex = 3;
            this.buttonUpdateInventory.Text = "Upload Clover Spreadsheet";

            // 
            // buttonAcceptChanges
            // 
            this.buttonAcceptChanges.Location = new System.Drawing.Point(308, 382);
            this.buttonAcceptChanges.Name = "buttonAcceptChanges";
            this.buttonAcceptChanges.Size = new System.Drawing.Size(133, 33);
            this.buttonAcceptChanges.TabIndex = 4;
            this.buttonAcceptChanges.Text = "Accept Changes";
            this.buttonAcceptChanges.Click += new System.EventHandler(this.buttonAcceptChanges_Click);

            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(347, 420);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(56, 19);
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
            this.dataGridViewInventory.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.Size = new System.Drawing.Size(760, 300);
            this.dataGridViewInventory.TabIndex = 14;

            // 
            // IngredientColumn
            // 
            this.IngredientColumn.HeaderText = "Ingredient";
            this.IngredientColumn.Name = "IngredientColumn";

            // 
            // UnitOfMeasurementColumn
            // 
            this.UnitOfMeasurementColumn.HeaderText = "Unit of Measurement";
            this.UnitOfMeasurementColumn.Name = "UnitOfMeasurementColumn";

            // 
            // NewInventoryLevelColumn
            // 
            this.NewInventoryLevelColumn.HeaderText = "New Inventory Level";
            this.NewInventoryLevelColumn.Name = "NewInventoryLevelColumn";

            // 
            // ImportFromCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAcceptChanges);
            this.Controls.Add(this.buttonUpdateInventory);
            this.Controls.Add(this.dataGridViewInventory);
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
