namespace FINAL_PROJECT
{
    partial class GoalPanelDashboardDisplay
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
            this.picBoxIcon = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.goalTitle = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxIcon
            // 
            this.picBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.picBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.picBoxIcon.Name = "picBoxIcon";
            this.picBoxIcon.Size = new System.Drawing.Size(70, 62);
            this.picBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIcon.TabIndex = 0;
            this.picBoxIcon.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Squada One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDate.Location = new System.Drawing.Point(173, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(68, 18);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Month 00";
            // 
            // goalTitle
            // 
            this.goalTitle.AutoSize = true;
            this.goalTitle.BackColor = System.Drawing.Color.Transparent;
            this.goalTitle.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.goalTitle.Location = new System.Drawing.Point(61, 12);
            this.goalTitle.MaximumSize = new System.Drawing.Size(153, 21);
            this.goalTitle.Name = "goalTitle";
            this.goalTitle.Size = new System.Drawing.Size(153, 21);
            this.goalTitle.TabIndex = 2;
            this.goalTitle.Text = "TITLETITLETITLETITETI";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(52, 33);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(44, 16);
            this.lblIndex.TabIndex = 3;
            this.lblIndex.Text = "label1";
            this.lblIndex.Visible = false;
            // 
            // GoalPanelDashboardDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::FINAL_PROJECT.Properties.Resources.BG_Taskbar2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.goalTitle);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.picBoxIcon);
            this.DoubleBuffered = true;
            this.Name = "GoalPanelDashboardDisplay";
            this.Size = new System.Drawing.Size(262, 62);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxIcon;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label goalTitle;
        private System.Windows.Forms.Label lblIndex;
    }
}
