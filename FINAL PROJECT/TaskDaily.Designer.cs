namespace FINAL_PROJECT
{
    partial class TaskDaily
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
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescript = new System.Windows.Forms.Label();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.deleteDailyTask = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteDailyTask)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxIcon.Location = new System.Drawing.Point(28, 4);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(43, 40);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(73, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 26);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDescript
            // 
            this.lblDescript.BackColor = System.Drawing.Color.Transparent;
            this.lblDescript.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescript.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescript.Location = new System.Drawing.Point(75, 25);
            this.lblDescript.Name = "lblDescript";
            this.lblDescript.Size = new System.Drawing.Size(213, 19);
            this.lblDescript.TabIndex = 3;
            this.lblDescript.Text = "label2";
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Location = new System.Drawing.Point(235, 32);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(35, 13);
            this.lblTimeStart.TabIndex = 4;
            this.lblTimeStart.Text = "label1";
            this.lblTimeStart.Visible = false;
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Location = new System.Drawing.Point(271, 31);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(35, 13);
            this.lblTimeEnd.TabIndex = 5;
            this.lblTimeEnd.Text = "label2";
            this.lblTimeEnd.Visible = false;
            // 
            // lblTaskType
            // 
            this.lblTaskType.AutoSize = true;
            this.lblTaskType.Location = new System.Drawing.Point(308, 31);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(35, 13);
            this.lblTaskType.TabIndex = 6;
            this.lblTaskType.Text = "label3";
            this.lblTaskType.Visible = false;
            // 
            // deleteDailyTask
            // 
            this.deleteDailyTask.BackColor = System.Drawing.Color.Transparent;
            this.deleteDailyTask.BackgroundImage = global::FINAL_PROJECT.Properties.Resources.ICON_Trash__1_;
            this.deleteDailyTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteDailyTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteDailyTask.Location = new System.Drawing.Point(378, 4);
            this.deleteDailyTask.Margin = new System.Windows.Forms.Padding(2);
            this.deleteDailyTask.Name = "deleteDailyTask";
            this.deleteDailyTask.Size = new System.Drawing.Size(19, 21);
            this.deleteDailyTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteDailyTask.TabIndex = 76;
            this.deleteDailyTask.TabStop = false;
            this.deleteDailyTask.Click += new System.EventHandler(this.deleteDailyTask_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(342, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 77;
            this.lblDate.Text = "label4";
            this.lblDate.Visible = false;
            // 
            // TaskDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::FINAL_PROJECT.Properties.Resources.BG_Taskbar2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.deleteDailyTask);
            this.Controls.Add(this.lblTaskType);
            this.Controls.Add(this.lblTimeEnd);
            this.Controls.Add(this.lblTimeStart);
            this.Controls.Add(this.lblDescript);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBoxIcon);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskDaily";
            this.Size = new System.Drawing.Size(406, 47);
            this.DoubleClick += new System.EventHandler(this.TaskDaily_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteDailyTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblDescript;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.PictureBox deleteDailyTask;
        private System.Windows.Forms.Label lblDate;
    }
}
