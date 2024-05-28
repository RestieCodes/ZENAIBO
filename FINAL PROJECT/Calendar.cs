using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace FINAL_PROJECT
{
    public partial class Calendar : Form
    {
        private CalendarMonth calendarMonthForm;
        private CalendarDay calendarDayForm;
        private CalendarWeek calendarWeekForm;
        private Form previousClickedForm = new CalendarMonth();
        public int Month;
        public Calendar()
        {
            InitializeComponent();
            InitializeForms();
            this.Load += new EventHandler(Calendar_Load);
        }

        private void InitializeForms()
        {
            calendarMonthForm = null;     
            calendarDayForm = null;
            calendarWeekForm = null;
        }


        public CalendarMonth GetCalendarMonthForm()
        {
            if (calendarMonthForm == null || calendarMonthForm.IsDisposed)
            {

                calendarMonthForm = new CalendarMonth();
            }

            return calendarMonthForm;
        }

        public CalendarWeek GetCalendarWeekForm()
        {
            if (calendarWeekForm == null || calendarWeekForm.IsDisposed)
            {

                calendarWeekForm = new CalendarWeek();
            }

            return calendarWeekForm;
        }

        public CalendarDay GetCalendarDayForm()
        {
            if (calendarDayForm == null || calendarDayForm.IsDisposed)
            {

                calendarDayForm = new CalendarDay();
                CalendarDay._calendarDay = calendarDayForm;
            }   

            return calendarDayForm;
        }

        private void Calendar_Load(object sender, EventArgs e)
        {

            ShowForm(GetCalendarMonthForm());
            btnMonth.StateCommon.Back.Color1 = Color.FromArgb(108, 23, 180);
            btnMonth.StateCommon.Back.Color2 = Color.FromArgb(108, 23, 180);
            btnMonth.StateCommon.Content.ShortText.Color1 = Color.White;

        }

        private void ShowForm(Form form)
        {
            panelContainer.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(form);

            // Show the form
            form.Show();

            if (previousClickedForm != form)
            {
                previousClickedForm.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                previousClickedForm = form;
            }
        }





        private void btnMonth_Click(object sender, EventArgs e)
        {
            ShowForm(GetCalendarMonthForm());
            btnWeek.StateCommon.Back.Color1 = Color.White;
            btnWeek.StateCommon.Back.Color2 = Color.White;
            btnWeek.StateCommon.Content.ShortText.Color1 = Color.FromArgb(108, 23, 180);

            btnDay.StateCommon.Back.Color1 = Color.White;
            btnDay.StateCommon.Back.Color2 = Color.White;
            btnDay.StateCommon.Content.ShortText.Color1 = Color.FromArgb(108, 23, 180);

            btnMonth.StateCommon.Back.Color1 = Color.FromArgb(108, 23, 180);
            btnMonth.StateCommon.Back.Color2 = Color.FromArgb(108, 23, 180);
            btnMonth.StateCommon.Content.ShortText.Color1 = Color.White;
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            ShowForm(GetCalendarDayForm());
            btnWeek.StateCommon.Back.Color1 = Color.White;
            btnWeek.StateCommon.Back.Color2 = Color.White;
            btnWeek.StateCommon.Content.ShortText.Color1 = Color.FromArgb(108, 23, 180);

            btnDay.StateCommon.Back.Color1 = Color.FromArgb(108, 23, 180);
            btnDay.StateCommon.Back.Color2 = Color.FromArgb(108, 23, 180);
            btnDay.StateCommon.Content.ShortText.Color1 = Color.White;

            btnMonth.StateCommon.Back.Color1 = Color.White;
            btnMonth.StateCommon.Back.Color2 = Color.White;
            btnMonth.StateCommon.Content.ShortText.Color1 = Color.FromArgb(108, 23, 180);
        }

        private void btnWeek_Click_1(object sender, EventArgs e)
        {
            ShowForm(GetCalendarWeekForm());
            btnWeek.StateCommon.Back.Color1 = Color.FromArgb(108, 23, 180);
            btnWeek.StateCommon.Back.Color2 = Color.FromArgb(108, 23, 180);
            btnWeek.StateCommon.Content.ShortText.Color1 = Color.White;

            btnDay.StateCommon.Back.Color1 = Color.White;
            btnDay.StateCommon.Back.Color2 = Color.White;
            btnDay.StateCommon.Content.ShortText.Color1 = Color.FromArgb(108, 23, 180);

            btnMonth.StateCommon.Back.Color1 = Color.White;
            btnMonth.StateCommon.Back.Color2 = Color.White;
            btnMonth.StateCommon.Content.ShortText.Color1 = Color.FromArgb(108, 23, 180);
        }
    }
}
