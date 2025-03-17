using System;
using System.Windows.Forms;

namespace MochaPointInventory
{
    partial class Settings
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
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.buttonSavePassword = new System.Windows.Forms.Button();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelSelectIngredient = new System.Windows.Forms.Label();
            this.comboBoxIngredients = new System.Windows.Forms.ComboBox();
            this.labelThreshold = new System.Windows.Forms.Label();
            this.numericUpDownThreshold = new System.Windows.Forms.NumericUpDown();
            this.buttonAcceptChanges = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(32, 263);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(200, 22);
            this.textBoxNewPassword.TabIndex = 0;
            // 
            // buttonSavePassword
            // 
            this.buttonSavePassword.Location = new System.Drawing.Point(32, 327);
            this.buttonSavePassword.Name = "buttonSavePassword";
            this.buttonSavePassword.Size = new System.Drawing.Size(200, 23);
            this.buttonSavePassword.TabIndex = 1;
            this.buttonSavePassword.Text = "Save New Password";
            this.buttonSavePassword.UseVisualStyleBackColor = true;
            this.buttonSavePassword.Click += new System.EventHandler(this.buttonSavePassword_Click);
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(74, 174);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(100, 16);
            this.labelNewPassword.TabIndex = 2;
            this.labelNewPassword.Text = "New Password:";
            // 
            // labelSelectIngredient
            // 
            this.labelSelectIngredient.AutoSize = true;
            this.labelSelectIngredient.Location = new System.Drawing.Point(494, 81);
            this.labelSelectIngredient.Name = "labelSelectIngredient";
            this.labelSelectIngredient.Size = new System.Drawing.Size(110, 16);
            this.labelSelectIngredient.TabIndex = 3;
            this.labelSelectIngredient.Text = "Select Ingredient:";
            // 
            // comboBoxIngredients
            // 
            this.comboBoxIngredients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIngredients.FormattingEnabled = true;
            this.comboBoxIngredients.Location = new System.Drawing.Point(488, 166);
            this.comboBoxIngredients.Name = "comboBoxIngredients";
            this.comboBoxIngredients.Size = new System.Drawing.Size(200, 24);
            this.comboBoxIngredients.TabIndex = 4;
            // 
            // labelThreshold
            // 
            this.labelThreshold.AutoSize = true;
            this.labelThreshold.Location = new System.Drawing.Point(494, 235);
            this.labelThreshold.Name = "labelThreshold";
            this.labelThreshold.Size = new System.Drawing.Size(140, 16);
            this.labelThreshold.TabIndex = 5;
            this.labelThreshold.Text = "Notification Threshold:";
            // 
            // numericUpDownThreshold
            // 
            this.numericUpDownThreshold.Location = new System.Drawing.Point(488, 289);
            this.numericUpDownThreshold.Name = "numericUpDownThreshold";
            this.numericUpDownThreshold.Size = new System.Drawing.Size(200, 22);
            this.numericUpDownThreshold.TabIndex = 6;
            // 
            // buttonAcceptChanges
            // 
            this.buttonAcceptChanges.Location = new System.Drawing.Point(488, 327);
            this.buttonAcceptChanges.Name = "buttonAcceptChanges";
            this.buttonAcceptChanges.Size = new System.Drawing.Size(200, 23);
            this.buttonAcceptChanges.TabIndex = 7;
            this.buttonAcceptChanges.Text = "Accept Changes";
            this.buttonAcceptChanges.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(361, 467);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 23);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Settings
            // 
            this.ClientSize = new System.Drawing.Size(782, 528);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAcceptChanges);
            this.Controls.Add(this.numericUpDownThreshold);
            this.Controls.Add(this.labelThreshold);
            this.Controls.Add(this.comboBoxIngredients);
            this.Controls.Add(this.labelSelectIngredient);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.buttonSavePassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button buttonSavePassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelSelectIngredient;
        private System.Windows.Forms.ComboBox comboBoxIngredients;
        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.NumericUpDown numericUpDownThreshold;
        private System.Windows.Forms.Button buttonAcceptChanges;
        private System.Windows.Forms.Button buttonBack;
    }
}

