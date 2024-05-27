using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class CalendarMonth : Form
    {
        public static int month, year;
        int[] task = {3,6,21};
        public CalendarMonth()
        {
            InitializeComponent(); 
            
        }

        private void CalendarMonth_Load(object sender, EventArgs e)
        {
            
            DisplayDays(); 
        }

        private void DisplayDays() 
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
           
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            txtboxMonthNow.Text = monthName + " " + year;


            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++) 
            {
                UserControlBlank ucBlank = new UserControlBlank();
                emptyPanel.Controls.Add(ucBlank);
            }



            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                DisplayIcon(ucDays, "May", 2024, task);
                emptyPanel.Controls.Add(ucDays);
            }


        }
       

        private void PrevButtonCalendar_Click_1(object sender, EventArgs e)
        {
            emptyPanel.Controls.Clear();
            if (month <= 1)
            {
                month = 12;
                year--;
            }
            else
            {
                month--;
            }
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            txtboxMonthNow.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                emptyPanel.Controls.Add(ucBlank);
            }



            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                DisplayIcon(ucDays, "May", 2024, task);
                emptyPanel.Controls.Add(ucDays);
            }
        }

        private void NextMonthCalendar_Click(object sender, EventArgs e)
        {
            emptyPanel.Controls.Clear();

            if (month >= 12)
            {
                year++;
                month = 1;
            }
            else
            {
                month++;

            }
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            txtboxMonthNow.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                emptyPanel.Controls.Add(ucBlank);
            }



            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                DisplayIcon(ucDays, "May", 2024, task);
                emptyPanel.Controls.Add(ucDays);
            }
        }

        private void DisplayIcon(UserControlDays uc, string month, int year, int[] arr )
        {
            string date = month + " " + year;
            if (txtboxMonthNow.Text.ToLower() == date.ToLower())
            {
                uc.IconTrigger(arr);
            }
        }

    }
}
