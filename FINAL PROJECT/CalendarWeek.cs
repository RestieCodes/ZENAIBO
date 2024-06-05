using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class CalendarWeek : Form
    {
        public static int month, year, firstDayOfWeek, day, MonthTotaldays;
        public int nextWeek = 0;
        public bool blank;



        public CalendarWeek()
        {
            InitializeComponent();
        }

        private void CalendarWeek_Load(object sender, EventArgs e)
        {
            DisplayLabels();
            PrevWeekCalendar.Visible = false;
        }

        

        private void DisplayLabels()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            day = now.Day - 1;
            blank = true;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            txtboxMonthNow.Text = monthName + " " + year;

            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            MonthTotaldays = DateTime.DaysInMonth(year, month);

            // Determine which day of the week the first day of the month falls on (0 = Sunday, 1 = Monday, ..., 6 = Saturday)
            firstDayOfWeek = (int)firstDayOfMonth.DayOfWeek;

            DateTime nameOfDay = new DateTime(year, month, day + 1);
            int dayNameInNum = (int)nameOfDay.DayOfWeek;
            int temp = day - dayNameInNum + 1;

            for (int i = 0; i < dayNameInNum; i++)
            {
                blank = false;
                UCWeekDays weekday = new UCWeekDays();
                weekday.DayName(temp,i, blank);
                flowLayoutPanelWeeks.Controls.Add(weekday);
                temp++;
            }

            for (int i = dayNameInNum; i < 6; i++)
            {
                blank = false;
                day++;
                UCWeekDays weekday = new UCWeekDays();
                weekday.DayName(day, i, blank);
                weekday.DisplayTask(txtboxMonthNow.Text, day);
                flowLayoutPanelWeeks.Controls.Add(weekday);
                
            }

        }

        private void NextWeekCalendar_Click(object sender, EventArgs e)
        {
            PrevWeekCalendar.Visible = true;
            flowLayoutPanelWeeks.Controls.Clear();
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            txtboxMonthNow.Text = monthName + " " + year;

            if (day == 0)
            {


                DateTime firstDayOfMonth = new DateTime(year, month, 1);
                firstDayOfWeek = (int)firstDayOfMonth.DayOfWeek;
                MonthTotaldays = DateTime.DaysInMonth(year, month);

                for (int i = 0; i < firstDayOfWeek; i++)
                {
                    blank = true;
                    UCWeekDays weekday = new UCWeekDays();
                    weekday.DayName(day, i, blank);
                    flowLayoutPanelWeeks.Controls.Add(weekday);
                }

                for (int i = firstDayOfWeek; i < 7; i++)
                {
                    blank = false;
                    day++;
                    UCWeekDays weekday = new UCWeekDays();
                    weekday.DayName(day, i, blank);
                    weekday.DisplayTask(txtboxMonthNow.Text, day);
                    flowLayoutPanelWeeks.Controls.Add(weekday);
                   
                }
            }
            else if (day == MonthTotaldays)
            {
                month++;
                day = 0;
                DateTime firstDayOfMonth = new DateTime(year, month, 1);
                firstDayOfWeek = (int)firstDayOfMonth.DayOfWeek;
                MonthTotaldays = DateTime.DaysInMonth(year, month);
                monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                txtboxMonthNow.Text = monthName + " " + year;

                for (int i = 0; i < firstDayOfWeek; i++)
                {
                    blank = true;
                    UCWeekDays weekday = new UCWeekDays();
                    weekday.DayName(day, i, blank);
                    flowLayoutPanelWeeks.Controls.Add(weekday);
                }

                for (int i = firstDayOfWeek; i < 7; i++)
                {
                    blank = false;
                    day++;
                    UCWeekDays weekday = new UCWeekDays();
                    weekday.DayName(day, i, blank);
                    weekday.DisplayTask(txtboxMonthNow.Text, day);
                    flowLayoutPanelWeeks.Controls.Add(weekday);
                }
            }
            else
            {
                for (int i = 0; i < 7; i++)
                {
                    
                    if (day == MonthTotaldays)
                    {
                        month++;
                        day = 0;
                        break;
                    }
                    else
                    {
                        blank = false;
                        day++;
                        UCWeekDays weekday = new UCWeekDays();
                        weekday.DayName(day, i, blank);
                        weekday.DisplayTask(txtboxMonthNow.Text, day);
                        flowLayoutPanelWeeks.Controls.Add(weekday);
                    }
                    
                }
            }

            

        }

        private void PrevWeekCalendar_Click(object sender, EventArgs e)
        {
            flowLayoutPanelWeeks.Controls.Clear();

            if (day != MonthTotaldays)
            {
                day -= 14;
            }
            

            if (day < 1&& day >= -6)
            {
                DateTime firstDayOfMonth = new DateTime(year, month, 1);
                firstDayOfWeek = (int)firstDayOfMonth.DayOfWeek;
                day = 0;
                for (int i = 0; i < firstDayOfWeek; i++)
                {
                    blank = true;
                    UCWeekDays weekday = new UCWeekDays();
                    weekday.DayName(day, i, blank);
                    flowLayoutPanelWeeks.Controls.Add(weekday);
                }

                for (int i = firstDayOfWeek; i < 7; i++)
                {
                    blank = false;
                    day++;
                    UCWeekDays weekday = new UCWeekDays();
                    weekday.DayName(day, i, blank);
                    weekday.DisplayTask(txtboxMonthNow.Text, day);
                    flowLayoutPanelWeeks.Controls.Add(weekday);
                    
                }
            }
            else if (day < -6)
            {
                month--;
                string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                txtboxMonthNow.Text = monthName + " " + year;
                
                MonthTotaldays = DateTime.DaysInMonth(year, month );
                DateTime now = DateTime.Now;
                if (month == now.Month && year == now.Year)
                {
                    day = now.Day - 2;
                    PrevWeekCalendar.Visible = false;
                }
                else 
                {
                    day = MonthTotaldays - firstDayOfWeek;
                }
                
                for (int i = 0; i < 7; i++)
                {
                    blank = false;
                    day++;
                    UCWeekDays weekday = new UCWeekDays();
                    weekday.DayName(day, i, blank);
                    weekday.DisplayTask(txtboxMonthNow.Text, day);
                    flowLayoutPanelWeeks.Controls.Add(weekday);
                    if (day == MonthTotaldays)
                    {
                        break;
                    }
              
                }
            }
            else if (day == MonthTotaldays)
            {

                DateTime firstDayOfMonth = new DateTime(year, month + 1, 1);
                firstDayOfWeek = (int)firstDayOfMonth.DayOfWeek;
                day = MonthTotaldays - firstDayOfWeek - 7;



                for (int i = 0; i < 7; i++)
                {
                    blank = false;
                    day++;
                    UCWeekDays weekday = new UCWeekDays();
                    weekday.DayName(day, i, blank);
                    weekday.DisplayTask(txtboxMonthNow.Text, day);
                    flowLayoutPanelWeeks.Controls.Add(weekday);
                    
                }
            }
            else
            {

                for (int i = 0; i < 7; i++)
                {
                    blank = false;
                    day++;
                    UCWeekDays weekday = new UCWeekDays();
                    weekday.DayName(day, i, blank);
                    weekday.DisplayTask(txtboxMonthNow.Text, day);
                    flowLayoutPanelWeeks.Controls.Add(weekday);
                    
                }
            }

        }
    }
}
