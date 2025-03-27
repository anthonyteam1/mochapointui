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
            this.comboBoxIngredients = new System.Windows.Forms.ComboBox();
            this.numericUpDownThreshold = new System.Windows.Forms.NumericUpDown();
            this.buttonAcceptChanges = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
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
            this.buttonSavePassword.Size = new System.Drawing.Size(179, 43);
            this.buttonSavePassword.TabIndex = 1;
            this.buttonSavePassword.Text = "Save New Password";
            this.buttonSavePassword.UseVisualStyleBackColor = true;
            this.buttonSavePassword.Click += new System.EventHandler(this.buttonSavePassword_Click);
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
            // numericUpDownThreshold
            // 
            this.numericUpDownThreshold.Location = new System.Drawing.Point(488, 289);
            this.numericUpDownThreshold.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownThreshold.Name = "numericUpDownThreshold";
            this.numericUpDownThreshold.Size = new System.Drawing.Size(200, 22);
            this.numericUpDownThreshold.TabIndex = 6;
            this.numericUpDownThreshold.ValueChanged += new System.EventHandler(this.numericUpDownThreshold_ValueChanged);
            // 
            // buttonAcceptChanges
            // 
            this.buttonAcceptChanges.Location = new System.Drawing.Point(514, 327);
            this.buttonAcceptChanges.Name = "buttonAcceptChanges";
            this.buttonAcceptChanges.Size = new System.Drawing.Size(174, 43);
            this.buttonAcceptChanges.TabIndex = 7;
            this.buttonAcceptChanges.Text = "Accept Changes";
            this.buttonAcceptChanges.UseVisualStyleBackColor = true;
            this.buttonAcceptChanges.Click += new System.EventHandler(this.buttonAcceptChanges_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(352, 469);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(79, 34);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(483, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select Ingredient";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(414, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Set Notification Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Set New Password";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(319, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(162, 29);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "App Settings";
            // 
            // Settings
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(782, 528);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAcceptChanges);
            this.Controls.Add(this.numericUpDownThreshold);
            this.Controls.Add(this.comboBoxIngredients);
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
        private System.Windows.Forms.ComboBox comboBoxIngredients;
        private System.Windows.Forms.NumericUpDown numericUpDownThreshold;
        private System.Windows.Forms.Button buttonAcceptChanges;
        private System.Windows.Forms.Button buttonBack;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label labelTitle;
    }
}

