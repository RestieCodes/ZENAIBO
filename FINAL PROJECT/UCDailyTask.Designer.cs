namespace FINAL_PROJECT
{
    partial class UCDailyTask
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxTimeSpan = new System.Windows.Forms.TextBox();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Location = new System.Drawing.Point(0, 74);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(109, 13);
            this.textBoxTitle.TabIndex = 2;
            this.textBoxTitle.Text = "Laundry";
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTimeSpan
            // 
            this.textBoxTimeSpan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxTimeSpan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTimeSpan.Location = new System.Drawing.Point(0, 107);
            this.textBoxTimeSpan.Name = "textBoxTimeSpan";
            this.textBoxTimeSpan.Size = new System.Drawing.Size(109, 13);
            this.textBoxTimeSpan.TabIndex = 3;
            this.textBoxTimeSpan.Text = "8 am - 9 pm";
            this.textBoxTimeSpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxIcon.Image = global::FINAL_PROJECT.Properties.Resources.DailyTaskOthersIcon;
            this.pictureBoxIcon.Location = new System.Drawing.Point(1, 15);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(107, 44);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // UCDailyTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.textBoxTimeSpan);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.pictureBoxIcon);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UCDailyTask";
            this.Size = new System.Drawing.Size(109, 131);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxTimeSpan;
    }
}
