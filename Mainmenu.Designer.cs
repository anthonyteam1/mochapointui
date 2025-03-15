using System;
using System.Windows.Forms;

namespace MochaPointInventory
{
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonManualEntry;
        private System.Windows.Forms.Button buttonViewInventory;
        private System.Windows.Forms.Button buttonImportFromExcel;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelTitle;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.buttonManualEntry = new System.Windows.Forms.Button();
            this.buttonViewInventory = new System.Windows.Forms.Button();
            this.buttonImportFromExcel = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonManualEntry
            // 
            this.buttonManualEntry.Location = new System.Drawing.Point(288, 290);
            this.buttonManualEntry.Name = "buttonManualEntry";
            this.buttonManualEntry.Size = new System.Drawing.Size(200, 50);
            this.buttonManualEntry.TabIndex = 1;
            this.buttonManualEntry.Text = "Manual Entry";
            this.buttonManualEntry.UseVisualStyleBackColor = true;
            this.buttonManualEntry.Click += new System.EventHandler(this.buttonManualEntry_Click);
            // 
            // buttonViewInventory
            // 
            this.buttonViewInventory.Location = new System.Drawing.Point(288, 346);
            this.buttonViewInventory.Name = "buttonViewInventory";
            this.buttonViewInventory.Size = new System.Drawing.Size(200, 50);
            this.buttonViewInventory.TabIndex = 2;
            this.buttonViewInventory.Text = "View Inventory";
            this.buttonViewInventory.UseVisualStyleBackColor = true;
            this.buttonViewInventory.Click += new System.EventHandler(this.buttonViewInventory_Click);
            // 
            // buttonImportFromExcel
            // 
            this.buttonImportFromExcel.Location = new System.Drawing.Point(288, 402);
            this.buttonImportFromExcel.Name = "buttonImportFromExcel";
            this.buttonImportFromExcel.Size = new System.Drawing.Size(200, 50);
            this.buttonImportFromExcel.TabIndex = 3;
            this.buttonImportFromExcel.Text = "Import from Excel";
            this.buttonImportFromExcel.UseVisualStyleBackColor = true;
            this.buttonImportFromExcel.Click += new System.EventHandler(this.buttonImportFromExcel_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(288, 458);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(200, 50);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(288, 514);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 50);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.Location = new System.Drawing.Point(270, 18);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(251, 225);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(281, 252);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(219, 22);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Mocha Point Inventory";
            // 
            // MainMenu
            // 
            this.ClientSize = new System.Drawing.Size(782, 588);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonImportFromExcel);
            this.Controls.Add(this.buttonViewInventory);
            this.Controls.Add(this.buttonManualEntry);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

