namespace FINAL_PROJECT
{
    partial class CalendarDay
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
            this.panelTotalTask = new System.Windows.Forms.Panel();
            this.lblDay = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxTimeEnd = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtBoxTimeStart = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblClear = new System.Windows.Forms.Label();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.listBoxTaskType = new FINAL_PROJECT.CustomListBox();
            this.txtBoxTitle1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtBoxDescription1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblUserSearch = new System.Windows.Forms.Label();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.picBoxTaskTypeIcon = new System.Windows.Forms.PictureBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.NextDayCalendar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PrevDayCalendar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.emptyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTaskContainer = new System.Windows.Forms.Panel();
            this.panelTotalTask.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTaskTypeIcon)).BeginInit();
            this.emptyPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotalTask
            // 
            this.panelTotalTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(118)))));
            this.panelTotalTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTotalTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalTask.Controls.Add(this.lblDay);
            this.panelTotalTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(118)))));
            this.panelTotalTask.Location = new System.Drawing.Point(44, 11);
            this.panelTotalTask.Name = "panelTotalTask";
            this.panelTotalTask.Size = new System.Drawing.Size(574, 35);
            this.panelTotalTask.TabIndex = 51;
            // 
            // lblDay
            // 
            this.lblDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblDay.Location = new System.Drawing.Point(144, 0);
            this.lblDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(281, 29);
            this.lblDay.TabIndex = 52;
            this.lblDay.Text = "WEEK | MONTH 00 0000";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.txtBoxTimeEnd);
            this.panel2.Controls.Add(this.txtBoxTimeStart);
            this.panel2.Controls.Add(this.lblClear);
            this.panel2.Controls.Add(this.kryptonLabel4);
            this.panel2.Controls.Add(this.lblHeader);
            this.panel2.Controls.Add(this.listBoxTaskType);
            this.panel2.Controls.Add(this.txtBoxTitle1);
            this.panel2.Controls.Add(this.txtBoxDescription1);
            this.panel2.Controls.Add(this.lblUserSearch);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.picBoxTaskTypeIcon);
            this.panel2.Controls.Add(this.kryptonLabel5);
            this.panel2.Controls.Add(this.kryptonLabel3);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Controls.Add(this.kryptonLabel2);
            this.panel2.Location = new System.Drawing.Point(649, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 514);
            this.panel2.TabIndex = 52;
            // 
            // txtBoxTimeEnd
            // 
            this.txtBoxTimeEnd.Location = new System.Drawing.Point(246, 393);
            this.txtBoxTimeEnd.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTimeEnd.MaxLength = 2;
            this.txtBoxTimeEnd.Name = "txtBoxTimeEnd";
            this.txtBoxTimeEnd.Size = new System.Drawing.Size(62, 29);
            this.txtBoxTimeEnd.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBoxTimeEnd.StateActive.Border.Rounding = 10;
            this.txtBoxTimeEnd.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.txtBoxTimeEnd.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTimeEnd.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 2, 4, 2);
            this.txtBoxTimeEnd.TabIndex = 55;
            this.txtBoxTimeEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTimeStart
            // 
            this.txtBoxTimeStart.Location = new System.Drawing.Point(126, 393);
            this.txtBoxTimeStart.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTimeStart.MaxLength = 2;
            this.txtBoxTimeStart.Name = "txtBoxTimeStart";
            this.txtBoxTimeStart.Size = new System.Drawing.Size(62, 29);
            this.txtBoxTimeStart.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBoxTimeStart.StateActive.Border.Rounding = 10;
            this.txtBoxTimeStart.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.txtBoxTimeStart.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTimeStart.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 2, 4, 2);
            this.txtBoxTimeStart.TabIndex = 54;
            this.txtBoxTimeStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClear
            // 
            this.lblClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClear.AutoSize = true;
            this.lblClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.lblClear.Location = new System.Drawing.Point(281, 461);
            this.lblClear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(50, 17);
            this.lblClear.TabIndex = 53;
            this.lblClear.Text = "CLEAR";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(204, 398);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(29, 21);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 43;
            this.kryptonLabel4.Values.Text = "TO";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Squada One", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblHeader.Location = new System.Drawing.Point(132, 11);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(131, 36);
            this.lblHeader.TabIndex = 42;
            this.lblHeader.Text = "ADD TASK";
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
            "ENTERTAINMENT",
            "HOME RESPONSIBILITY",
            "APPOINTMENT",
            "SMALL TASK",
            "OTHERS"});
            this.listBoxTaskType.LineHeight = 40;
            this.listBoxTaskType.Location = new System.Drawing.Point(106, 187);
            this.listBoxTaskType.Name = "listBoxTaskType";
            this.listBoxTaskType.Size = new System.Drawing.Size(243, 197);
            this.listBoxTaskType.TabIndex = 0;
            this.listBoxTaskType.SelectedIndexChanged += new System.EventHandler(this.listBoxTaskType_SelectedIndexChanged);
            // 
            // txtBoxTitle1
            // 
            this.txtBoxTitle1.Location = new System.Drawing.Point(106, 62);
            this.txtBoxTitle1.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTitle1.Name = "txtBoxTitle1";
            this.txtBoxTitle1.Size = new System.Drawing.Size(242, 29);
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
            this.txtBoxDescription1.Location = new System.Drawing.Point(106, 100);
            this.txtBoxDescription1.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxDescription1.Multiline = true;
            this.txtBoxDescription1.Name = "txtBoxDescription1";
            this.txtBoxDescription1.Size = new System.Drawing.Size(242, 82);
            this.txtBoxDescription1.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBoxDescription1.StateActive.Border.Rounding = 10;
            this.txtBoxDescription1.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.txtBoxDescription1.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescription1.StateActive.Content.Padding = new System.Windows.Forms.Padding(9, 4, 4, 4);
            this.txtBoxDescription1.TabIndex = 19;
            // 
            // lblUserSearch
            // 
            this.lblUserSearch.AutoSize = true;
            this.lblUserSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.lblUserSearch.Location = new System.Drawing.Point(152, 132);
            this.lblUserSearch.Name = "lblUserSearch";
            this.lblUserSearch.Size = new System.Drawing.Size(35, 13);
            this.lblUserSearch.TabIndex = 17;
            this.lblUserSearch.Text = "label2";
            this.lblUserSearch.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(163, 449);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnSave.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnSave.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnSave.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnSave.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.Size = new System.Drawing.Size(110, 37);
            this.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnSave.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnSave.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnSave.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnSave.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 20;
            this.btnSave.StateCommon.Border.Width = 3;
            this.btnSave.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-20);
            this.btnSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnSave.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnSave.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSave.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.btnSave.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(23)))), ((int)(((byte)(180)))));
            this.btnSave.TabIndex = 16;
            this.btnSave.Values.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picBoxTaskTypeIcon
            // 
            this.picBoxTaskTypeIcon.Location = new System.Drawing.Point(30, 220);
            this.picBoxTaskTypeIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxTaskTypeIcon.Name = "picBoxTaskTypeIcon";
            this.picBoxTaskTypeIcon.Size = new System.Drawing.Size(63, 62);
            this.picBoxTaskTypeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxTaskTypeIcon.TabIndex = 15;
            this.picBoxTaskTypeIcon.TabStop = false;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(26, 397);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(80, 21);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 13;
            this.kryptonLabel5.Values.Text = "DURATION";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(38, 195);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(47, 24);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 12;
            this.kryptonLabel3.Values.Text = "TYPE";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(14, 101);
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
            this.kryptonLabel2.Location = new System.Drawing.Point(38, 66);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(42, 22);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "TITLE";
            // 
            // NextDayCalendar
            // 
            this.NextDayCalendar.Location = new System.Drawing.Point(621, 228);
            this.NextDayCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.NextDayCalendar.Name = "NextDayCalendar";
            this.NextDayCalendar.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.NextDayCalendar.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.NextDayCalendar.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.NextDayCalendar.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.NextDayCalendar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NextDayCalendar.Size = new System.Drawing.Size(22, 78);
            this.NextDayCalendar.StateCommon.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.NextDayCalendar.StateCommon.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.NextDayCalendar.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.NextDayCalendar.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.NextDayCalendar.StateCommon.Border.ColorAngle = 50F;
            this.NextDayCalendar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NextDayCalendar.StateCommon.Border.Rounding = 10;
            this.NextDayCalendar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.NextDayCalendar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.NextDayCalendar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextDayCalendar.StateTracking.Back.Color1 = System.Drawing.Color.SlateBlue;
            this.NextDayCalendar.StateTracking.Back.Color2 = System.Drawing.Color.SlateBlue;
            this.NextDayCalendar.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.NextDayCalendar.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.NextDayCalendar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NextDayCalendar.TabIndex = 74;
            this.NextDayCalendar.Values.Text = ">";
            this.NextDayCalendar.Click += new System.EventHandler(this.NextDayCalendar_Click);
            // 
            // PrevDayCalendar
            // 
            this.PrevDayCalendar.Location = new System.Drawing.Point(16, 228);
            this.PrevDayCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.PrevDayCalendar.Name = "PrevDayCalendar";
            this.PrevDayCalendar.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.PrevDayCalendar.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.PrevDayCalendar.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.PrevDayCalendar.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.PrevDayCalendar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PrevDayCalendar.Size = new System.Drawing.Size(22, 78);
            this.PrevDayCalendar.StateCommon.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.PrevDayCalendar.StateCommon.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.PrevDayCalendar.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.PrevDayCalendar.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.PrevDayCalendar.StateCommon.Border.ColorAngle = 50F;
            this.PrevDayCalendar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PrevDayCalendar.StateCommon.Border.Rounding = 10;
            this.PrevDayCalendar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-2, -1, -1, -1);
            this.PrevDayCalendar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.PrevDayCalendar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.PrevDayCalendar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevDayCalendar.StateTracking.Back.Color1 = System.Drawing.Color.SlateBlue;
            this.PrevDayCalendar.StateTracking.Back.Color2 = System.Drawing.Color.SlateBlue;
            this.PrevDayCalendar.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.PrevDayCalendar.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.PrevDayCalendar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PrevDayCalendar.TabIndex = 73;
            this.PrevDayCalendar.Values.Text = "<";
            this.PrevDayCalendar.Click += new System.EventHandler(this.PrevDayCalendar_Click);
            // 
            // emptyPanel
            // 
            this.emptyPanel.AutoScroll = true;
            this.emptyPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.emptyPanel.Controls.Add(this.panel1);
            this.emptyPanel.Location = new System.Drawing.Point(44, 43);
            this.emptyPanel.Name = "emptyPanel";
            this.emptyPanel.Size = new System.Drawing.Size(574, 480);
            this.emptyPanel.TabIndex = 75;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FINAL_PROJECT.Properties.Resources.EnlargedNewTimeLineForWolf;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panelTaskContainer);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 1249);
            this.panel1.TabIndex = 0;
            // 
            // panelTaskContainer
            // 
            this.panelTaskContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelTaskContainer.Location = new System.Drawing.Point(127, 87);
            this.panelTaskContainer.Name = "panelTaskContainer";
            this.panelTaskContainer.Size = new System.Drawing.Size(412, 811);
            this.panelTaskContainer.TabIndex = 0;
            // 
            // CalendarDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1030, 527);
            this.Controls.Add(this.emptyPanel);
            this.Controls.Add(this.NextDayCalendar);
            this.Controls.Add(this.PrevDayCalendar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTotalTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CalendarDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalendarDay";
            this.Load += new System.EventHandler(this.CalendarDay_Load);
            this.panelTotalTask.ResumeLayout(false);
            this.panelTotalTask.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTaskTypeIcon)).EndInit();
            this.emptyPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelTotalTask;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblHeader;
        public CustomListBox listBoxTaskType;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBoxTitle1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBoxDescription1;
        public System.Windows.Forms.Label lblUserSearch;
        public System.Windows.Forms.PictureBox picBoxTaskTypeIcon;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private System.Windows.Forms.Label lblClear;
        private ComponentFactory.Krypton.Toolkit.KryptonButton NextDayCalendar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton PrevDayCalendar;
        private System.Windows.Forms.FlowLayoutPanel emptyPanel;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBoxTimeEnd;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBoxTimeStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTaskContainer;
    }
}