namespace MochaPointInventory
{
    partial class NotificationTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewNotifications = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNotifications
            // 
            this.dataGridViewNotifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotifications.Location = new System.Drawing.Point(23, 61);
            this.dataGridViewNotifications.Name = "dataGridViewNotifications";
            this.dataGridViewNotifications.ReadOnly = true;
            this.dataGridViewNotifications.RowHeadersWidth = 51;
            this.dataGridViewNotifications.RowTemplate.Height = 24;
            this.dataGridViewNotifications.Size = new System.Drawing.Size(704, 400);
            this.dataGridViewNotifications.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(23, 11);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 30);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(260, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(198, 29);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Notification Log";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // NotificationTracker
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(753, 489);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewNotifications);
            this.Name = "NotificationTracker";
            this.Text = "Notification Tracker";
            this.Load += new System.EventHandler(this.NotificationTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNotifications;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTitle;
    }
}
