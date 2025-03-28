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
        private System.Windows.Forms.Button buttonNotificationTracker;

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
            this.buttonNotificationTracker = new System.Windows.Forms.Button();
            this.buttonEditIngredients = new System.Windows.Forms.Button();
            this.buttonIngredient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonManualEntry
            // 
            this.buttonManualEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManualEntry.Location = new System.Drawing.Point(192, 321);
            this.buttonManualEntry.Name = "buttonManualEntry";
            this.buttonManualEntry.Size = new System.Drawing.Size(200, 50);
            this.buttonManualEntry.TabIndex = 1;
            this.buttonManualEntry.Text = "Manual Adjustment";
            this.buttonManualEntry.UseVisualStyleBackColor = true;
            this.buttonManualEntry.Click += new System.EventHandler(this.buttonManualEntry_Click);
            // 
            // buttonViewInventory
            // 
            this.buttonViewInventory.Location = new System.Drawing.Point(398, 321);
            this.buttonViewInventory.Name = "buttonViewInventory";
            this.buttonViewInventory.Size = new System.Drawing.Size(200, 50);
            this.buttonViewInventory.TabIndex = 2;
            this.buttonViewInventory.Text = "View Inventory";
            this.buttonViewInventory.UseVisualStyleBackColor = true;
            this.buttonViewInventory.Click += new System.EventHandler(this.buttonViewInventory_Click);
            // 
            // buttonImportFromExcel
            // 
            this.buttonImportFromExcel.Location = new System.Drawing.Point(192, 377);
            this.buttonImportFromExcel.Name = "buttonImportFromExcel";
            this.buttonImportFromExcel.Size = new System.Drawing.Size(200, 50);
            this.buttonImportFromExcel.TabIndex = 3;
            this.buttonImportFromExcel.Text = "Clover Upload";
            this.buttonImportFromExcel.UseVisualStyleBackColor = true;
            this.buttonImportFromExcel.Click += new System.EventHandler(this.buttonImportFromExcel_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(398, 377);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(200, 50);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "App Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(398, 489);
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
            this.labelTitle.Location = new System.Drawing.Point(185, 270);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(427, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Mocha Point Inventory Management";
            // 
            // buttonNotificationTracker
            // 
            this.buttonNotificationTracker.Location = new System.Drawing.Point(398, 433);
            this.buttonNotificationTracker.Name = "buttonNotificationTracker";
            this.buttonNotificationTracker.Size = new System.Drawing.Size(200, 50);
            this.buttonNotificationTracker.TabIndex = 7;
            this.buttonNotificationTracker.Text = "Notification History";
            this.buttonNotificationTracker.UseVisualStyleBackColor = true;
            this.buttonNotificationTracker.Click += new System.EventHandler(this.buttonNotificationTracker_Click);
            // 
            // buttonEditIngredients
            // 
            this.buttonEditIngredients.Location = new System.Drawing.Point(192, 433);
            this.buttonEditIngredients.Name = "buttonEditIngredients";
            this.buttonEditIngredients.Size = new System.Drawing.Size(200, 50);
            this.buttonEditIngredients.TabIndex = 9;
            this.buttonEditIngredients.Text = "Drink Settings";
            this.buttonEditIngredients.UseVisualStyleBackColor = true;
            this.buttonEditIngredients.Click += new System.EventHandler(this.buttonEditIngredients_Click);
            // 
            // buttonIngredient
            // 
            this.buttonIngredient.Location = new System.Drawing.Point(192, 489);
            this.buttonIngredient.Name = "buttonIngredient";
            this.buttonIngredient.Size = new System.Drawing.Size(200, 50);
            this.buttonIngredient.TabIndex = 10;
            this.buttonIngredient.Text = "Edit Ingredients";
            this.buttonIngredient.UseVisualStyleBackColor = true;
            this.buttonIngredient.Click += new System.EventHandler(this.buttonIngredient_Click);
            // 
            // MainMenu
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(789, 563);
            this.Controls.Add(this.buttonIngredient);
            this.Controls.Add(this.buttonEditIngredients);
            this.Controls.Add(this.buttonNotificationTracker);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonImportFromExcel);
            this.Controls.Add(this.buttonViewInventory);
            this.Controls.Add(this.buttonManualEntry);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button buttonEditIngredients;
        private Button buttonIngredient;
    }
}

