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
            this.editIcon = new System.Windows.Forms.PictureBox();
            this.picBoxIcon = new System.Windows.Forms.PictureBox();
            this.doneIcon = new System.Windows.Forms.PictureBox();
            this.circleIcon = new System.Windows.Forms.PictureBox();
            this.lblIndex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doneIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(78, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDescript
            // 
            this.lblDescript.BackColor = System.Drawing.Color.Transparent;
            this.lblDescript.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescript.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescript.Location = new System.Drawing.Point(80, 52);
            this.lblDescript.Name = "lblDescript";
            this.lblDescript.Size = new System.Drawing.Size(236, 36);
            this.lblDescript.TabIndex = 2;
            this.lblDescript.Text = "label2";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(327, 44);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 16);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label3";
            // 
            // editIcon
            // 
            this.editIcon.BackColor = System.Drawing.Color.Transparent;
            this.editIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editIcon.Image = global::FINAL_PROJECT.Properties.Resources.ICON_edit__1_;
            this.editIcon.Location = new System.Drawing.Point(550, 31);
            this.editIcon.Name = "editIcon";
            this.editIcon.Size = new System.Drawing.Size(30, 39);
            this.editIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editIcon.TabIndex = 4;
            this.editIcon.TabStop = false;
            this.editIcon.Click += new System.EventHandler(this.editIcon_Click_1);
            // 
            // picBoxIcon
            // 
            this.picBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.picBoxIcon.Location = new System.Drawing.Point(9, 9);
            this.picBoxIcon.Name = "picBoxIcon";
            this.picBoxIcon.Size = new System.Drawing.Size(79, 78);
            this.picBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIcon.TabIndex = 5;
            this.picBoxIcon.TabStop = false;
            // 
            // doneIcon
            // 
            this.doneIcon.BackColor = System.Drawing.Color.Transparent;
            this.doneIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doneIcon.Image = global::FINAL_PROJECT.Properties.Resources.Check__Done_;
            this.doneIcon.Location = new System.Drawing.Point(501, 15);
            this.doneIcon.Name = "doneIcon";
            this.doneIcon.Size = new System.Drawing.Size(51, 71);
            this.doneIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doneIcon.TabIndex = 7;
            this.doneIcon.TabStop = false;
            this.doneIcon.Visible = false;
            this.doneIcon.Click += new System.EventHandler(this.doneIcon_Click);
            // 
            // circleIcon
            // 
            this.circleIcon.BackColor = System.Drawing.Color.Transparent;
            this.circleIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circleIcon.Image = global::FINAL_PROJECT.Properties.Resources.circleIcon;
            this.circleIcon.Location = new System.Drawing.Point(490, 17);
            this.circleIcon.Name = "circleIcon";
            this.circleIcon.Size = new System.Drawing.Size(75, 69);
            this.circleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circleIcon.TabIndex = 8;
            this.circleIcon.TabStop = false;
            this.circleIcon.Visible = false;
            this.circleIcon.Click += new System.EventHandler(this.circleIcon_Click);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.lblIndex.Location = new System.Drawing.Point(31, 36);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(42, 13);
            this.lblIndex.TabIndex = 6;
            this.lblIndex.Text = "asdada";
            // 
            // TaskBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::FINAL_PROJECT.Properties.Resources.BG_Taskbar2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.editIcon);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDescript);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picBoxIcon);
            this.Controls.Add(this.doneIcon);
            this.Controls.Add(this.circleIcon);
            this.Controls.Add(this.lblIndex);
            this.DoubleBuffered = true;
            this.Name = "TaskBar";
            this.Size = new System.Drawing.Size(590, 100);
            this.Load += new System.EventHandler(this.TaskBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doneIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblDescript;
        private System.Windows.Forms.PictureBox editIcon;
        private System.Windows.Forms.PictureBox picBoxIcon;
        public System.Windows.Forms.PictureBox doneIcon;
        public System.Windows.Forms.PictureBox circleIcon;
        private System.Windows.Forms.Label lblIndex;
    }
}
