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

        public int Month;
        public Calendar()
        {
            InitializeComponent();
            InitializeForms();  
        }

        private void InitializeForms()
        {
            calendarMonthForm = null;     
            calendarDayForm = null;
            calendarWeekForm = null;
        }
      

        public CalendarMonth GetCalendarMonthForm()
        {
            if (calendarMonthForm == null)
            {

                calendarMonthForm = new CalendarMonth();
            }

            return calendarMonthForm;
        }

        public CalendarWeek GetCalendarWeekForm()
        {
            if (calendarWeekForm == null)
            {

                calendarWeekForm = new CalendarWeek();
            }

            return calendarWeekForm;
        }

        public CalendarDay GetCalendarDayForm()
        {
            if (calendarDayForm == null)
            {

                calendarDayForm = new CalendarDay();
            }

            return calendarDayForm;
        }

        private void Calendar_Load(object sender, EventArgs e)
        {

            ShowForm(GetCalendarMonthForm());

        }

        private void ShowForm(Form form) 
        {
            panelContainer.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(form);
            
            

            try
            {
                form.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while showing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        




        private void btnMonth_Click(object sender, EventArgs e)
        {
            ShowForm(GetCalendarMonthForm());
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            ShowForm(GetCalendarDayForm());
        }

        private void btnWeek_Click_1(object sender, EventArgs e)
        {
            ShowForm(GetCalendarWeekForm());
        }
    }
}
