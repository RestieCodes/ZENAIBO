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
            this.picBoxEmpty = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmpty)).BeginInit();
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
            // picBoxEmpty
            // 
            this.picBoxEmpty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxEmpty.Location = new System.Drawing.Point(115, 58);
            this.picBoxEmpty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBoxEmpty.Name = "picBoxEmpty";
            this.picBoxEmpty.Size = new System.Drawing.Size(44, 39);
            this.picBoxEmpty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxEmpty.TabIndex = 1;
            this.picBoxEmpty.TabStop = false;
            this.picBoxEmpty.Click += new System.EventHandler(this.picBoxEmpty_Click);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.picBoxEmpty);
            this.Controls.Add(this.lbDays);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(163, 101);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmpty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.PictureBox picBoxEmpty;
    }
}
