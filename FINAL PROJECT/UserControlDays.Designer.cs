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
            this.lbDays.Location = new System.Drawing.Point(9, 7);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(27, 20);
            this.lbDays.TabIndex = 0;
            this.lbDays.Text = "00";
            // 
            // picBoxEmpty
            // 
            this.picBoxEmpty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxEmpty.Location = new System.Drawing.Point(86, 33);
            this.picBoxEmpty.Name = "picBoxEmpty";
            this.picBoxEmpty.Size = new System.Drawing.Size(33, 32);
            this.picBoxEmpty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxEmpty.TabIndex = 1;
            this.picBoxEmpty.TabStop = false;
            this.picBoxEmpty.Click += new System.EventHandler(this.picBoxEmpty_Click);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.picBoxEmpty);
            this.Controls.Add(this.lbDays);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(129, 71);
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
