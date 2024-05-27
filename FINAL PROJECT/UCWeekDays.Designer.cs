namespace FINAL_PROJECT
{
    partial class UCWeekDays
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
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDayName = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTaskCtn = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(118)))));
            this.lblDay.Location = new System.Drawing.Point(55, 2);
            this.lblDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(26, 17);
            this.lblDay.TabIndex = 87;
            this.lblDay.Text = "00";
            // 
            // lblDayName
            // 
            this.lblDayName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDayName.AutoSize = true;
            this.lblDayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDayName.Location = new System.Drawing.Point(24, 4);
            this.lblDayName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDayName.Name = "lblDayName";
            this.lblDayName.Size = new System.Drawing.Size(86, 13);
            this.lblDayName.TabIndex = 0;
            this.lblDayName.Text = "WEDNESDAY";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(738, 24);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(124, 424);
            this.flowLayoutPanel2.TabIndex = 75;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(124, 424);
            this.flowLayoutPanel3.TabIndex = 76;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(118)))));
            this.panel4.Controls.Add(this.flowLayoutPanel2);
            this.panel4.Controls.Add(this.lblDayName);
            this.panel4.Location = new System.Drawing.Point(0, 21);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 22);
            this.panel4.TabIndex = 88;
            // 
            // flowLayoutPanelTaskCtn
            // 
            this.flowLayoutPanelTaskCtn.Location = new System.Drawing.Point(3, 48);
            this.flowLayoutPanelTaskCtn.Name = "flowLayoutPanelTaskCtn";
            this.flowLayoutPanelTaskCtn.Size = new System.Drawing.Size(128, 405);
            this.flowLayoutPanelTaskCtn.TabIndex = 89;
            // 
            // UCWeekDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelTaskCtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblDay);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCWeekDays";
            this.Size = new System.Drawing.Size(134, 456);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblDayName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTaskCtn;
    }
}
