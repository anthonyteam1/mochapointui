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
            this.buttonUpdateInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonUpdateInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonUpdateInventory.Location = new System.Drawing.Point(411, 15);
            this.buttonUpdateInventory.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateInventory.Name = "buttonUpdateInventory";
            this.buttonUpdateInventory.Size = new System.Drawing.Size(200, 37);
            this.buttonUpdateInventory.TabIndex = 3;
            this.buttonUpdateInventory.Text = "Upload Clover Spreadsheet";
            this.buttonUpdateInventory.UseVisualStyleBackColor = false;
            this.buttonUpdateInventory.Click += new System.EventHandler(this.buttonUpdateInventory_Click);
            // 
            // buttonAcceptChanges
            // 
            this.buttonAcceptChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAcceptChanges.Location = new System.Drawing.Point(421, 458);
            this.buttonAcceptChanges.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAcceptChanges.Name = "buttonAcceptChanges";
            this.buttonAcceptChanges.Size = new System.Drawing.Size(177, 41);
            this.buttonAcceptChanges.TabIndex = 4;
            this.buttonAcceptChanges.Text = "Accept Changes";
            this.buttonAcceptChanges.UseVisualStyleBackColor = false;
            this.buttonAcceptChanges.Click += new System.EventHandler(this.buttonAcceptChanges_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonBack.Location = new System.Drawing.Point(463, 507);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(79, 34);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IngredientColumn,
            this.UnitOfMeasurementColumn,
            this.NewInventoryLevelColumn});
            this.dataGridViewInventory.Location = new System.Drawing.Point(24, 60);
            this.dataGridViewInventory.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowHeadersWidth = 51;
            this.dataGridViewInventory.Size = new System.Drawing.Size(1013, 390);
            this.dataGridViewInventory.TabIndex = 14;
            // 
            // IngredientColumn
            // 
            this.IngredientColumn.HeaderText = "Ingredient";
            this.IngredientColumn.MinimumWidth = 6;
            this.IngredientColumn.Name = "IngredientColumn";
            // 
            // UnitOfMeasurementColumn
            // 
            this.UnitOfMeasurementColumn.HeaderText = "Unit of Measurement";
            this.UnitOfMeasurementColumn.MinimumWidth = 6;
            this.UnitOfMeasurementColumn.Name = "UnitOfMeasurementColumn";
            // 
            // NewInventoryLevelColumn
            // 
            this.NewInventoryLevelColumn.HeaderText = "New Inventory Level";
            this.NewInventoryLevelColumn.MinimumWidth = 6;
            this.NewInventoryLevelColumn.Name = "NewInventoryLevelColumn";
            // 
            // ImportFromCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAcceptChanges);
            this.Controls.Add(this.buttonUpdateInventory);
            this.Controls.Add(this.dataGridViewInventory);
            this.Margin = new System.Windows.Forms.Padding(4);
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
