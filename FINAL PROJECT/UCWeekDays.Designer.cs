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
            this.lblDayName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTaskCtn = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(118)))));
            this.panel4.Controls.Add(this.lblDayName);
            this.panel4.Location = new System.Drawing.Point(0, 21);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 22);
            this.panel4.TabIndex = 88;
            // 
            // flowLayoutPanelTaskCtn
            // 
            this.flowLayoutPanelTaskCtn.AutoScroll = true;
            this.flowLayoutPanelTaskCtn.Location = new System.Drawing.Point(3, 48);
            this.flowLayoutPanelTaskCtn.Name = "flowLayoutPanelTaskCtn";
            this.flowLayoutPanelTaskCtn.Size = new System.Drawing.Size(128, 405);
            this.flowLayoutPanelTaskCtn.TabIndex = 89;
            // 
            // textBoxDay
            // 
            this.textBoxDay.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBoxDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(118)))));
            this.textBoxDay.Location = new System.Drawing.Point(-5, 3);
            this.textBoxDay.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.ReadOnly = true;
            this.textBoxDay.Size = new System.Drawing.Size(134, 16);
            this.textBoxDay.TabIndex = 90;
            this.textBoxDay.Text = "00";
            this.textBoxDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UCWeekDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.flowLayoutPanelTaskCtn);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCWeekDays";
            this.Size = new System.Drawing.Size(134, 456);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDayName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTaskCtn;
        private System.Windows.Forms.TextBox textBoxDay;
    }
}
