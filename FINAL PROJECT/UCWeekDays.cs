using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                lblDay.Visible = false;               
            }
            else
            {
                lblDay.Visible = true;
                lblDay.Text = day.ToString();
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

        public void DisplayTask(Tuple<string, string, int, int, int, string> data) 
        {
        
        }
    }
}
