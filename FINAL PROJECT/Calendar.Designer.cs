namespace FINAL_PROJECT
{
    partial class Calendar
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnMonth = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnWeek = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDays = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "CALENDAR";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.Location = new System.Drawing.Point(16, 70);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1213, 644);
            this.panelContainer.TabIndex = 0;
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(481, 21);
            this.btnMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(132, 31);
            this.btnMonth.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnMonth.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnMonth.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.btnMonth.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.btnMonth.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMonth.StateCommon.Border.Rounding = 5;
            this.btnMonth.StateCommon.Border.Width = 3;
            this.btnMonth.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.btnMonth.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonth.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnMonth.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnMonth.TabIndex = 19;
            this.btnMonth.Values.Text = "Month";
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnWeek
            // 
            this.btnWeek.Location = new System.Drawing.Point(621, 21);
            this.btnWeek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(132, 31);
            this.btnWeek.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnWeek.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnWeek.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.btnWeek.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.btnWeek.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnWeek.StateCommon.Border.Rounding = 5;
            this.btnWeek.StateCommon.Border.Width = 3;
            this.btnWeek.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.btnWeek.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeek.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnWeek.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnWeek.TabIndex = 20;
            this.btnWeek.Values.Text = "Week";
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // btnDays
            // 
            this.btnDays.Location = new System.Drawing.Point(761, 21);
            this.btnDays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDays.Name = "btnDays";
            this.btnDays.Size = new System.Drawing.Size(132, 31);
            this.btnDays.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnDays.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnDays.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.btnDays.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.btnDays.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDays.StateCommon.Border.Rounding = 5;
            this.btnDays.StateCommon.Border.Width = 3;
            this.btnDays.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.btnDays.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDays.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnDays.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnDays.TabIndex = 21;
            this.btnDays.Values.Text = "Days";
            this.btnDays.Click += new System.EventHandler(this.btnDays_Click);
            // 
            // Calendar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1243, 729);
            this.Controls.Add(this.btnDays);
            this.Controls.Add(this.btnWeek);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMonth;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnWeek;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDays;
    }
}