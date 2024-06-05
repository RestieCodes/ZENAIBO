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
    public partial class UCWeekDays : UserControl
    {
        public UCWeekDays()
        {
            InitializeComponent();
        }

        public void DayName(int day, int num, bool blank)
        {
            if (blank)
            {
                textBoxDay.Visible = false;               
            }
            else
            {
                textBoxDay.Visible = true;
                textBoxDay.Text = day.ToString();
            }

            switch (num)
            {
                case 0:
                    lblDayName.Text = "   Sunday";
                    break;
                case 1:
                    lblDayName.Text = "   Monday";
                    break;
                case 2:
                    lblDayName.Text = "   Tuesday";
                    break;
                case 3:
                    lblDayName.Text = "Wednesday";
                    break;
                case 4:
                    lblDayName.Text = "  Thursday";
                    break;
                case 5:
                    lblDayName.Text = "     Friday";
                    break;
                case 6:
                    lblDayName.Text = "  Saturday";
                    break;
            }
        }

        public void DisplayTask(string date, int day) 
        {
            flowLayoutPanelTaskCtn.Controls.Clear();
            char[] delimitersChar = { ' ', ',' };

          
            string[] Date = date.Split(delimitersChar, StringSplitOptions.RemoveEmptyEntries);
            DateTime nameOfDay = new DateTime(Convert.ToInt32(Date[1]), MonthNum(Date[0]), day);
            string dayName = nameOfDay.DayOfWeek.ToString("G");
            string fullDayName = dayName + " | " + Date[0] + " " + day + ", " + Date[1];

            TempStorage.TaskDaily = TempStorage.SortDailyTask();

            for (int i = 0; i < TempStorage.TaskDaily.Count; i++)
            {
                if (fullDayName == TempStorage.TaskDaily[i].Item6)
                {
                    UCDailyTask dt = new UCDailyTask();
                    dt.DisplayContent(TempStorage.TaskDaily[i]);
                    flowLayoutPanelTaskCtn.Controls.Add(dt);
                }
            }
        }

        private int MonthNum(string month) 
        {
            int num = 0;
            switch (month) 
            {
                case "January":
                    num = 1;
                    break;
                case "February":
                    num = 2;
                    break;
                case "March":
                    num = 3;
                    break;
                case "April":
                    num = 4;
                    break;
                case "May":
                    num = 5;
                    break;
                case "June":
                    num = 6;
                    break;
                case "July":
                    num = 7;
                    break;
                case "August":
                    num = 8;
                    break;
                case "September":
                    num = 9;
                    break;
                case "October":
                    num = 10;
                    break;
                case "November":
                    num = 11;
                    break;
                case "December":
                    num = 12;
                    break;
            
            }
            return num;
        }
    }
}
