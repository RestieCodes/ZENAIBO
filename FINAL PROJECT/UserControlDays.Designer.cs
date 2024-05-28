namespace FINAL_PROJECT
{
    partial class UserControlDays
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
            this.lbDays = new System.Windows.Forms.Label();
            this.flowLayoutPanelCTN = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDays.Location = new System.Drawing.Point(12, 9);
            this.lbDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(34, 25);
            this.lbDays.TabIndex = 0;
            this.lbDays.Text = "00";
            // 
            // flowLayoutPanelCTN
            // 
            this.flowLayoutPanelCTN.AutoScroll = true;
            this.flowLayoutPanelCTN.Location = new System.Drawing.Point(56, 0);
            this.flowLayoutPanelCTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelCTN.Name = "flowLayoutPanelCTN";
            this.flowLayoutPanelCTN.Size = new System.Drawing.Size(116, 87);
            this.flowLayoutPanelCTN.TabIndex = 1;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(180)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.flowLayoutPanelCTN);
            this.Controls.Add(this.lbDays);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UserControlDays";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(172, 87);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCTN;
    }
}
