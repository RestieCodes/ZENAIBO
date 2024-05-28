namespace FINAL_PROJECT
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.listBoxTaskType = new FINAL_PROJECT.CustomListBox();
            this.txtBoxTitle1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtBoxDescription1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.deleteIcon = new System.Windows.Forms.PictureBox();
            this.lblUserSearch = new System.Windows.Forms.Label();
            this.btnSaveChanges = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.picBoxTaskTypeIcon = new System.Windows.Forms.PictureBox();
            this.btnAddTask = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpSetDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxOther = new System.Windows.Forms.CheckBox();
            this.checkBoxAppointment = new System.Windows.Forms.CheckBox();
            this.checkBoxGym = new System.Windows.Forms.CheckBox();
            this.checkBoxCareer = new System.Windows.Forms.CheckBox();
            this.checkBoxAcads = new System.Windows.Forms.CheckBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.taskbarCtn = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTaskTypeIcon)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::FINAL_PROJECT.Properties.Resources.BG_Deadline_inputTask;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblHeader);
            this.panel2.Controls.Add(this.listBoxTaskType);
            this.panel2.Controls.Add(this.txtBoxTitle1);
            this.panel2.Controls.Add(this.txtBoxDescription1);
            this.panel2.Controls.Add(this.deleteIcon);
            this.panel2.Controls.Add(this.lblUserSearch);
            this.panel2.Controls.Add(this.btnSaveChanges);
            this.panel2.Controls.Add(this.picBoxTaskTypeIcon);
            this.panel2.Controls.Add(this.btnAddTask);
            this.panel2.Controls.Add(this.kryptonLabel5);
            this.panel2.Controls.Add(this.kryptonLabel3);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Controls.Add(this.kryptonLabel2);
            this.panel2.Controls.Add(this.dtpSetDate);
            this.panel2.Location = new System.Drawing.Point(718, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 494);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Squada One", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblHeader.Location = new System.Drawing.Point(85, 12);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(129, 36);
            this.lblHeader.TabIndex = 42;
            this.lblHeader.Text = "ADD GOAL";
            // 
            // listBoxTaskType
            // 
            this.listBoxTaskType.BackColor = System.Drawing.Color.White;
            this.listBoxTaskType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTaskType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxTaskType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBoxTaskType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTaskType.ForeColor = System.Drawing.Color.Indigo;
            this.listBoxTaskType.FormattingEnabled = true;
            this.listBoxTaskType.ItemHeight = 40;
            this.listBoxTaskType.Items.AddRange(new object[] {
            "ACADS",
            "CAREER",
            "WORKOUT",
            "APPOINTMENT",
            "OTHERS"});
            this.listBoxTaskType.LineHeight = 40;
            this.listBoxTaskType.Location = new System.Drawing.Point(102, 208);
            this.listBoxTaskType.Name = "listBoxTaskType";
            this.listBoxTaskType.Size = new System.Drawing.Size(192, 154);
            this.listBoxTaskType.TabIndex = 0;
            this.listBoxTaskType.SelectedIndexChanged += new System.EventHandler(this.listBoxTaskType_SelectedIndexChanged_1);
            // 
            // txtBoxTitle1
            // 
            this.txtBoxTitle1.Location = new System.Drawing.Point(103, 62);
            this.txtBoxTitle1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxTitle1.Name = "txtBoxTitle1";
            this.txtBoxTitle1.Size = new System.Drawing.Size(191, 29);
            this.txtBoxTitle1.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBoxTitle1.StateActive.Border.Rounding = 10;
            this.txtBoxTitle1.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.txtBoxTitle1.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTitle1.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 2, 4, 2);
            this.txtBoxTitle1.TabIndex = 20;
            // 
            // txtBoxDescription1
            // 
            this.txtBoxDescription1.Location = new System.Drawing.Point(103, 100);
            this.txtBoxDescription1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxDescription1.Multiline = true;
            this.txtBoxDescription1.Name = "txtBoxDescription1";
            this.txtBoxDescription1.Size = new System.Drawing.Size(191, 82);
            this.txtBoxDescription1.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBoxDescription1.StateActive.Border.Rounding = 10;
            this.txtBoxDescription1.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.txtBoxDescription1.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescription1.StateActive.Content.Padding = new System.Windows.Forms.Padding(9, 4, 4, 4);
            this.txtBoxDescription1.TabIndex = 19;
            // 
            // deleteIcon
            // 
            this.deleteIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteIcon.Image = global::FINAL_PROJECT.Properties.Resources.deleteIcon;
            this.deleteIcon.Location = new System.Drawing.Point(232, 440);
            this.deleteIcon.Name = "deleteIcon";
            this.deleteIcon.Size = new System.Drawing.Size(59, 50);
            this.deleteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteIcon.TabIndex = 18;
            this.deleteIcon.TabStop = false;
            this.deleteIcon.Visible = false;
            this.deleteIcon.Click += new System.EventHandler(this.deleteIcon_Click);
            // 
            // lblUserSearch
            // 
            this.lblUserSearch.AutoSize = true;
            this.lblUserSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.lblUserSearch.Location = new System.Drawing.Point(162, 130);
            this.lblUserSearch.Name = "lblUserSearch";
            this.lblUserSearch.Size = new System.Drawing.Size(35, 13);
            this.lblUserSearch.TabIndex = 17;
            this.lblUserSearch.Text = "label2";
            this.lblUserSearch.Visible = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.Location = new System.Drawing.Point(87, 440);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnSaveChanges.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnSaveChanges.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnSaveChanges.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnSaveChanges.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveChanges.Size = new System.Drawing.Size(133, 45);
            this.btnSaveChanges.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnSaveChanges.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnSaveChanges.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnSaveChanges.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnSaveChanges.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveChanges.StateCommon.Border.Rounding = 20;
            this.btnSaveChanges.StateCommon.Border.Width = 3;
            this.btnSaveChanges.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-20);
            this.btnSaveChanges.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnSaveChanges.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnSaveChanges.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnSaveChanges.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSaveChanges.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSaveChanges.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnSaveChanges.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnSaveChanges.TabIndex = 16;
            this.btnSaveChanges.Values.Text = "SAVE";
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // picBoxTaskTypeIcon
            // 
            this.picBoxTaskTypeIcon.Location = new System.Drawing.Point(17, 243);
            this.picBoxTaskTypeIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxTaskTypeIcon.Name = "picBoxTaskTypeIcon";
            this.picBoxTaskTypeIcon.Size = new System.Drawing.Size(67, 61);
            this.picBoxTaskTypeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxTaskTypeIcon.TabIndex = 15;
            this.picBoxTaskTypeIcon.TabStop = false;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.Location = new System.Drawing.Point(93, 440);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnAddTask.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnAddTask.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnAddTask.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnAddTask.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddTask.Size = new System.Drawing.Size(127, 45);
            this.btnAddTask.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnAddTask.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnAddTask.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnAddTask.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnAddTask.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddTask.StateCommon.Border.Rounding = 20;
            this.btnAddTask.StateCommon.Border.Width = 3;
            this.btnAddTask.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-20);
            this.btnAddTask.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnAddTask.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnAddTask.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnAddTask.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnAddTask.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnAddTask.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddTask.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddTask.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddTask.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnAddTask.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnAddTask.TabIndex = 14;
            this.btnAddTask.Values.Text = "ADD";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(18, 391);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(74, 21);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 13;
            this.kryptonLabel5.Values.Text = "DUE DATE";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(14, 212);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(77, 21);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 12;
            this.kryptonLabel3.Values.Text = "TASK TYPE";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(5, 100);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(96, 20);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 11;
            this.kryptonLabel1.Values.Text = "DESCRIPTION";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(30, 66);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(42, 22);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "TITLE";
            // 
            // dtpSetDate
            // 
            this.dtpSetDate.CalendarForeColor = System.Drawing.Color.Firebrick;
            this.dtpSetDate.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpSetDate.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpSetDate.CustomFormat = "";
            this.dtpSetDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSetDate.Location = new System.Drawing.Point(103, 391);
            this.dtpSetDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSetDate.MinDate = new System.DateTime(2024, 5, 21, 0, 0, 0, 0);
            this.dtpSetDate.Name = "dtpSetDate";
            this.dtpSetDate.Size = new System.Drawing.Size(194, 20);
            this.dtpSetDate.TabIndex = 8;
            this.dtpSetDate.Value = new System.DateTime(2024, 5, 21, 0, 0, 0, 0);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.checkBoxOther);
            this.panel3.Controls.Add(this.checkBoxAppointment);
            this.panel3.Controls.Add(this.checkBoxGym);
            this.panel3.Controls.Add(this.checkBoxCareer);
            this.panel3.Controls.Add(this.checkBoxAcads);
            this.panel3.Controls.Add(this.pictureBox19);
            this.panel3.Controls.Add(this.pictureBox17);
            this.panel3.Controls.Add(this.pictureBox16);
            this.panel3.Controls.Add(this.pictureBox14);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.kryptonLabel4);
            this.panel3.Location = new System.Drawing.Point(650, 88);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(63, 494);
            this.panel3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 446);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "OTHERS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(0, 360);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 9);
            this.label5.TabIndex = 43;
            this.label5.Text = "APPOINTMENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Location = new System.Drawing.Point(2, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "WORKOUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(5, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "CAREER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "ACADS";
            // 
            // checkBoxOther
            // 
            this.checkBoxOther.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxOther.AutoSize = true;
            this.checkBoxOther.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxOther.Location = new System.Drawing.Point(26, 461);
            this.checkBoxOther.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOther.Name = "checkBoxOther";
            this.checkBoxOther.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxOther.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOther.TabIndex = 15;
            this.checkBoxOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxOther.UseVisualStyleBackColor = true;
            this.checkBoxOther.CheckedChanged += new System.EventHandler(this.checkBoxOther_CheckedChanged);
            // 
            // checkBoxAppointment
            // 
            this.checkBoxAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxAppointment.AutoSize = true;
            this.checkBoxAppointment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxAppointment.Location = new System.Drawing.Point(26, 376);
            this.checkBoxAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAppointment.Name = "checkBoxAppointment";
            this.checkBoxAppointment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxAppointment.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAppointment.TabIndex = 16;
            this.checkBoxAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAppointment.UseVisualStyleBackColor = true;
            this.checkBoxAppointment.CheckedChanged += new System.EventHandler(this.checkBoxAppointment_CheckedChanged);
            // 
            // checkBoxGym
            // 
            this.checkBoxGym.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxGym.AutoSize = true;
            this.checkBoxGym.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxGym.Location = new System.Drawing.Point(26, 287);
            this.checkBoxGym.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxGym.Name = "checkBoxGym";
            this.checkBoxGym.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxGym.Size = new System.Drawing.Size(15, 14);
            this.checkBoxGym.TabIndex = 13;
            this.checkBoxGym.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxGym.UseVisualStyleBackColor = true;
            this.checkBoxGym.CheckedChanged += new System.EventHandler(this.checkBoxGym_CheckedChanged);
            // 
            // checkBoxCareer
            // 
            this.checkBoxCareer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxCareer.AutoSize = true;
            this.checkBoxCareer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxCareer.Location = new System.Drawing.Point(26, 200);
            this.checkBoxCareer.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCareer.Name = "checkBoxCareer";
            this.checkBoxCareer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxCareer.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCareer.TabIndex = 12;
            this.checkBoxCareer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxCareer.UseVisualStyleBackColor = true;
            this.checkBoxCareer.CheckedChanged += new System.EventHandler(this.checkBoxCareer_CheckedChanged);
            // 
            // checkBoxAcads
            // 
            this.checkBoxAcads.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxAcads.AutoSize = true;
            this.checkBoxAcads.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxAcads.Location = new System.Drawing.Point(26, 113);
            this.checkBoxAcads.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAcads.Name = "checkBoxAcads";
            this.checkBoxAcads.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxAcads.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAcads.TabIndex = 11;
            this.checkBoxAcads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAcads.UseVisualStyleBackColor = true;
            this.checkBoxAcads.CheckedChanged += new System.EventHandler(this.checkBoxAcads_CheckedChanged);
            // 
            // pictureBox19
            // 
            this.pictureBox19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox19.Image = global::FINAL_PROJECT.Properties.Resources.Untitled_design___2024_04_29T023639_486;
            this.pictureBox19.Location = new System.Drawing.Point(1, 401);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(63, 49);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 39;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox17.Image = global::FINAL_PROJECT.Properties.Resources.Untitled_design___2024_04_29T022644_520;
            this.pictureBox17.Location = new System.Drawing.Point(2, 135);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(62, 60);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 37;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox16.Image = global::FINAL_PROJECT.Properties.Resources.Untitled_design___2024_04_29T023405_591;
            this.pictureBox16.Location = new System.Drawing.Point(0, 50);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(65, 52);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 37;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Click += new System.EventHandler(this.pictureBox16_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox14.Image = global::FINAL_PROJECT.Properties.Resources.Untitled_design___2024_04_29T022658_810;
            this.pictureBox14.Location = new System.Drawing.Point(-2, 311);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(66, 51);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 35;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::FINAL_PROJECT.Properties.Resources.Untitled_design___2024_04_29T023254_961;
            this.pictureBox3.Location = new System.Drawing.Point(0, 219);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(8, 18);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(55, 22);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 16;
            this.kryptonLabel4.Values.Text = "SHOW";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Squada One", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 42);
            this.label1.TabIndex = 40;
            this.label1.Text = "GOALS";
            // 
            // taskbarCtn
            // 
            this.taskbarCtn.AutoScroll = true;
            this.taskbarCtn.BackColor = System.Drawing.Color.Transparent;
            this.taskbarCtn.Location = new System.Drawing.Point(9, 8);
            this.taskbarCtn.Name = "taskbarCtn";
            this.taskbarCtn.Size = new System.Drawing.Size(647, 474);
            this.taskbarCtn.TabIndex = 41;
            this.taskbarCtn.Paint += new System.Windows.Forms.PaintEventHandler(this.taskbarCtn_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FINAL_PROJECT.Properties.Resources.BG_Deadline_taskList4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.taskbarCtn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(15, 88);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 490);
            this.panel1.TabIndex = 42;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(9, 8);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(624, 463);
            this.panel4.TabIndex = 76;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.Location = new System.Drawing.Point(25, 71);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.kryptonButton1.Size = new System.Drawing.Size(1005, 4);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 3;
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.kryptonButton1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.TabIndex = 75;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // Deadline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::FINAL_PROJECT.Properties.Resources.BG_Dashboard;
            this.ClientSize = new System.Drawing.Size(1054, 600);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Deadline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deadline";
            this.Load += new System.EventHandler(this.Deadline_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTaskTypeIcon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBoxAppointment;
        private System.Windows.Forms.CheckBox checkBoxOther;
        private System.Windows.Forms.CheckBox checkBoxGym;
        private System.Windows.Forms.CheckBox checkBoxCareer;
        private System.Windows.Forms.CheckBox checkBoxAcads;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel taskbarCtn;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnSaveChanges;
        public System.Windows.Forms.DateTimePicker dtpSetDate;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnAddTask;
        public System.Windows.Forms.PictureBox picBoxTaskTypeIcon;
        public CustomListBox listBoxTaskType;
        public System.Windows.Forms.Label lblUserSearch;
        public System.Windows.Forms.PictureBox deleteIcon;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBoxDescription1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBoxTitle1;
        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}