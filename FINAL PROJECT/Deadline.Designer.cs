﻿namespace FINAL_PROJECT
{
    partial class Deadline
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxTaskType = new FINAL_PROJECT.CustomListBox();
            this.picBoxTaskTypeIcon = new System.Windows.Forms.PictureBox();
            this.btnAddTask = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpSetDate = new System.Windows.Forms.DateTimePicker();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBoxAcads = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.taskbarCtn = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTaskTypeIcon)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.kryptonTextBox1);
            this.panel2.Controls.Add(this.listBoxTaskType);
            this.panel2.Controls.Add(this.picBoxTaskTypeIcon);
            this.panel2.Controls.Add(this.btnAddTask);
            this.panel2.Controls.Add(this.kryptonLabel5);
            this.panel2.Controls.Add(this.kryptonLabel3);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Controls.Add(this.kryptonLabel2);
            this.panel2.Controls.Add(this.dtpSetDate);
            this.panel2.Controls.Add(this.txtBoxDescription);
            this.panel2.Controls.Add(this.txtBoxTitle);
            this.panel2.Location = new System.Drawing.Point(808, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 606);
            this.panel2.TabIndex = 9;
            // 
            // listBoxTaskType
            // 
            this.listBoxTaskType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxTaskType.FormattingEnabled = true;
            this.listBoxTaskType.ItemHeight = 40;
            this.listBoxTaskType.Items.AddRange(new object[] {
            "ACADS",
            "CAREER",
            "WORKOUT",
            "ENTERTAINMENT",
            "HOME RESPONSIBILITY",
            "APPOINTMENT",
            "SMALL TASK",
            "OTHERS"});
            this.listBoxTaskType.LineHeight = 40;
            this.listBoxTaskType.Location = new System.Drawing.Point(100, 206);
            this.listBoxTaskType.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxTaskType.Name = "listBoxTaskType";
            this.listBoxTaskType.Size = new System.Drawing.Size(199, 244);
            this.listBoxTaskType.TabIndex = 0;
            this.listBoxTaskType.SelectedIndexChanged += new System.EventHandler(this.listBoxTaskType_SelectedIndexChanged_1);
            // 
            // picBoxTaskTypeIcon
            // 
            this.picBoxTaskTypeIcon.Location = new System.Drawing.Point(307, 206);
            this.picBoxTaskTypeIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxTaskTypeIcon.Name = "picBoxTaskTypeIcon";
            this.picBoxTaskTypeIcon.Size = new System.Drawing.Size(84, 76);
            this.picBoxTaskTypeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxTaskTypeIcon.TabIndex = 15;
            this.picBoxTaskTypeIcon.TabStop = false;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(125, 544);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(147, 46);
            this.btnAddTask.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnAddTask.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnAddTask.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnAddTask.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnAddTask.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddTask.StateCommon.Border.Rounding = 13;
            this.btnAddTask.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddTask.TabIndex = 14;
            this.btnAddTask.Values.Text = "  ADD";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(9, 494);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(81, 23);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 13;
            this.kryptonLabel5.Values.Text = "DUE DATE";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(7, 203);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(84, 23);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 12;
            this.kryptonLabel3.Values.Text = "TASK TYPE";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(9, 106);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(108, 23);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 11;
            this.kryptonLabel1.Values.Text = "DESCRIPTION";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(15, 52);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(51, 27);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "TITLE";
            // 
            // dtpSetDate
            // 
            this.dtpSetDate.CalendarForeColor = System.Drawing.Color.Red;
            this.dtpSetDate.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpSetDate.Location = new System.Drawing.Point(97, 494);
            this.dtpSetDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpSetDate.Name = "dtpSetDate";
            this.dtpSetDate.Size = new System.Drawing.Size(240, 22);
            this.dtpSetDate.TabIndex = 8;
            this.dtpSetDate.Value = new System.DateTime(2024, 5, 14, 17, 26, 49, 0);
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(125, 103);
            this.txtBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(239, 22);
            this.txtBoxDescription.TabIndex = 3;
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(125, 52);
            this.txtBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(240, 22);
            this.txtBoxTitle.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox19);
            this.panel3.Controls.Add(this.pictureBox17);
            this.panel3.Controls.Add(this.pictureBox16);
            this.panel3.Controls.Add(this.pictureBox15);
            this.panel3.Controls.Add(this.pictureBox14);
            this.panel3.Controls.Add(this.pictureBox13);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.kryptonLabel4);
            this.panel3.Controls.Add(this.checkBox10);
            this.panel3.Controls.Add(this.checkBox9);
            this.panel3.Controls.Add(this.checkBox8);
            this.panel3.Controls.Add(this.checkBox6);
            this.panel3.Controls.Add(this.checkBox7);
            this.panel3.Controls.Add(this.checkBox4);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.checkBoxAcads);
            this.panel3.Location = new System.Drawing.Point(695, 92);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 606);
            this.panel3.TabIndex = 11;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::FINAL_PROJECT.Properties.Resources.Untitled_design___2024_04_29T023639_486;
            this.pictureBox19.Location = new System.Drawing.Point(39, 523);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(60, 50);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 39;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::FINAL_PROJECT.Properties.Resources.Untitled_design___2024_04_29T022644_520;
            this.pictureBox17.Location = new System.Drawing.Point(39, 144);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(60, 50);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 37;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::FINAL_PROJECT.Properties.Resources.Untitled_design___2024_04_29T023405_591;
            this.pictureBox16.Location = new System.Drawing.Point(39, 81);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(60, 50);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 37;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::FINAL_PROJECT.Properties.Resources.Untitled_design___2024_04_29T023527_334;
            this.pictureBox15.Location = new System.Drawing.Point(39, 464);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(60, 50);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 36;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::FINAL_PROJECT.Properties.Resources.Untitled_design___2024_04_29T022658_810;
            this.pictureBox14.Location = new System.Drawing.Point(39, 400);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(60, 50);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 35;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::FINAL_PROJECT.Properties.Resources.Untitled_design___2024_04_29T022707_602;
            this.pictureBox13.Location = new System.Drawing.Point(40, 335);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(60, 50);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 34;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FINAL_PROJECT.Properties.Resources.Untitled_design___2024_04_29T023254_961;
            this.pictureBox3.Location = new System.Drawing.Point(39, 204);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FINAL_PROJECT.Properties.Resources.Untitled_design___2024_04_29T021726_290;
            this.pictureBox2.Location = new System.Drawing.Point(40, 268);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(19, 36);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(67, 27);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 16;
            this.kryptonLabel4.Values.Text = "SHOW";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox10.Location = new System.Drawing.Point(15, 415);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox10.Size = new System.Drawing.Size(18, 17);
            this.checkBox10.TabIndex = 16;
            this.checkBox10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox9.Location = new System.Drawing.Point(15, 353);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox9.Size = new System.Drawing.Size(18, 17);
            this.checkBox9.TabIndex = 15;
            this.checkBox9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox8.Location = new System.Drawing.Point(13, 286);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox8.Size = new System.Drawing.Size(18, 17);
            this.checkBox8.TabIndex = 14;
            this.checkBox8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox6.Location = new System.Drawing.Point(15, 539);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox6.Size = new System.Drawing.Size(18, 17);
            this.checkBox6.TabIndex = 15;
            this.checkBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox7.Location = new System.Drawing.Point(15, 479);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox7.Size = new System.Drawing.Size(18, 17);
            this.checkBox7.TabIndex = 14;
            this.checkBox7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox4.Location = new System.Drawing.Point(13, 222);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox4.Size = new System.Drawing.Size(18, 17);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox3.Location = new System.Drawing.Point(13, 160);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBoxAcads
            // 
            this.checkBoxAcads.AutoSize = true;
            this.checkBoxAcads.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxAcads.Location = new System.Drawing.Point(13, 100);
            this.checkBoxAcads.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAcads.Name = "checkBoxAcads";
            this.checkBoxAcads.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxAcads.Size = new System.Drawing.Size(18, 17);
            this.checkBoxAcads.TabIndex = 11;
            this.checkBoxAcads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAcads.UseVisualStyleBackColor = true;
            this.checkBoxAcads.Click += new System.EventHandler(this.checkBoxAcads_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Squada One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 42);
            this.label1.TabIndex = 40;
            this.label1.Text = "DEADLINE";
            // 
            // taskbarCtn
            // 
            this.taskbarCtn.AutoScroll = true;
            this.taskbarCtn.BackColor = System.Drawing.Color.Transparent;
            this.taskbarCtn.Location = new System.Drawing.Point(16, 92);
            this.taskbarCtn.Margin = new System.Windows.Forms.Padding(4);
            this.taskbarCtn.Name = "taskbarCtn";
            this.taskbarCtn.Size = new System.Drawing.Size(672, 606);
            this.taskbarCtn.TabIndex = 41;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(125, 146);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(239, 27);
            this.kryptonTextBox1.TabIndex = 0;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // Deadline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1243, 729);
            this.Controls.Add(this.taskbarCtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Deadline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deadline";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTaskTypeIcon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.DateTimePicker dtpSetDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBoxAcads;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddTask;
        private System.Windows.Forms.PictureBox picBoxTaskTypeIcon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel taskbarCtn;
        private CustomListBox listBoxTaskType;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
    }
}