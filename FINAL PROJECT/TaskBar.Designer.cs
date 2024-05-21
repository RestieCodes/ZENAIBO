namespace FINAL_PROJECT
{
    partial class TaskBar
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescript = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.circleIcon = new System.Windows.Forms.PictureBox();
            this.doneIcon = new System.Windows.Forms.PictureBox();
            this.editIcon = new System.Windows.Forms.PictureBox();
            this.picBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.circleIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doneIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(77, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDescript
            // 
            this.lblDescript.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescript.Location = new System.Drawing.Point(79, 50);
            this.lblDescript.Name = "lblDescript";
            this.lblDescript.Size = new System.Drawing.Size(148, 29);
            this.lblDescript.TabIndex = 2;
            this.lblDescript.Text = "label2";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(326, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label3";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.lblIndex.Location = new System.Drawing.Point(320, 73);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(42, 13);
            this.lblIndex.TabIndex = 6;
            this.lblIndex.Text = "asdada";
            // 
            // circleIcon
            // 
            this.circleIcon.Image = global::FINAL_PROJECT.Properties.Resources.circleIcon;
            this.circleIcon.Location = new System.Drawing.Point(465, 19);
            this.circleIcon.Name = "circleIcon";
            this.circleIcon.Size = new System.Drawing.Size(84, 79);
            this.circleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circleIcon.TabIndex = 8;
            this.circleIcon.TabStop = false;
            this.circleIcon.Visible = false;
            this.circleIcon.Click += new System.EventHandler(this.circleIcon_Click);
            // 
            // doneIcon
            // 
            this.doneIcon.Image = global::FINAL_PROJECT.Properties.Resources.checkIcon;
            this.doneIcon.Location = new System.Drawing.Point(464, 15);
            this.doneIcon.Name = "doneIcon";
            this.doneIcon.Size = new System.Drawing.Size(88, 89);
            this.doneIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doneIcon.TabIndex = 7;
            this.doneIcon.TabStop = false;
            this.doneIcon.Visible = false;
            this.doneIcon.Click += new System.EventHandler(this.doneIcon_Click);
            // 
            // editIcon
            // 
            this.editIcon.Image = global::FINAL_PROJECT.Properties.Resources.editICON;
            this.editIcon.Location = new System.Drawing.Point(530, 3);
            this.editIcon.Name = "editIcon";
            this.editIcon.Size = new System.Drawing.Size(60, 51);
            this.editIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editIcon.TabIndex = 4;
            this.editIcon.TabStop = false;
            this.editIcon.Click += new System.EventHandler(this.editIcon_Click_1);
            // 
            // picBoxIcon
            // 
            this.picBoxIcon.Location = new System.Drawing.Point(9, 9);
            this.picBoxIcon.Name = "picBoxIcon";
            this.picBoxIcon.Size = new System.Drawing.Size(79, 78);
            this.picBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIcon.TabIndex = 5;
            this.picBoxIcon.TabStop = false;
            // 
            // TaskBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.editIcon);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDescript);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picBoxIcon);
            this.Controls.Add(this.doneIcon);
            this.Controls.Add(this.circleIcon);
            this.Name = "TaskBar";
            this.Size = new System.Drawing.Size(587, 100);
            ((System.ComponentModel.ISupportInitialize)(this.circleIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doneIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblDescript;
        private System.Windows.Forms.PictureBox editIcon;
        private System.Windows.Forms.PictureBox picBoxIcon;
        private System.Windows.Forms.Label lblIndex;
        public System.Windows.Forms.PictureBox doneIcon;
        public System.Windows.Forms.PictureBox circleIcon;
    }
}
