namespace FINAL_PROJECT
{
    partial class TaskAccomplishments
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIndicator = new System.Windows.Forms.Label();
            this.lblDescript = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picBoxIcon = new System.Windows.Forms.PictureBox();
            this.deleteHistory = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIndicator
            // 
            this.lblIndicator.AutoSize = true;
            this.lblIndicator.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicator.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIndicator.Location = new System.Drawing.Point(461, 65);
            this.lblIndicator.Name = "lblIndicator";
            this.lblIndicator.Size = new System.Drawing.Size(44, 16);
            this.lblIndicator.TabIndex = 8;
            this.lblIndicator.Text = "label3";
            // 
            // lblDescript
            // 
            this.lblDescript.BackColor = System.Drawing.Color.Transparent;
            this.lblDescript.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescript.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescript.Location = new System.Drawing.Point(103, 61);
            this.lblDescript.Name = "lblDescript";
            this.lblDescript.Size = new System.Drawing.Size(236, 36);
            this.lblDescript.TabIndex = 7;
            this.lblDescript.Text = "label2";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(98, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 28);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // picBoxIcon
            // 
            this.picBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.picBoxIcon.Location = new System.Drawing.Point(29, 12);
            this.picBoxIcon.Name = "picBoxIcon";
            this.picBoxIcon.Size = new System.Drawing.Size(79, 78);
            this.picBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIcon.TabIndex = 9;
            this.picBoxIcon.TabStop = false;
            // 
            // deleteHistory
            // 
            this.deleteHistory.BackColor = System.Drawing.Color.Transparent;
            this.deleteHistory.BackgroundImage = global::FINAL_PROJECT.Properties.Resources.ICON_Trash__1_;
            this.deleteHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteHistory.Location = new System.Drawing.Point(522, 14);
            this.deleteHistory.Margin = new System.Windows.Forms.Padding(2);
            this.deleteHistory.Name = "deleteHistory";
            this.deleteHistory.Size = new System.Drawing.Size(24, 22);
            this.deleteHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteHistory.TabIndex = 76;
            this.deleteHistory.TabStop = false;
            this.deleteHistory.Click += new System.EventHandler(this.deleteHistory_Click);
            // 
            // TaskAccomplishments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::FINAL_PROJECT.Properties.Resources.BG_Taskbar2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.deleteHistory);
            this.Controls.Add(this.lblIndicator);
            this.Controls.Add(this.lblDescript);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picBoxIcon);
            this.DoubleBuffered = true;
            this.Name = "TaskAccomplishments";
            this.Size = new System.Drawing.Size(560, 100);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIndicator;
        public System.Windows.Forms.Label lblDescript;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picBoxIcon;
        private System.Windows.Forms.PictureBox deleteHistory;
    }
}
