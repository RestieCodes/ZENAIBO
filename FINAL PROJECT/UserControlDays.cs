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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        public void DisplayGoal(string date, int day)
        {
            DateTime now = DateTime.Now;
            string dayInString;
            if (day < 10)
            {
                dayInString = "0" + day;
            }
            else 
            {
                dayInString = day.ToString();
            }

            lbDays.Text = day + "";
            string Date = dayInString + " " + date;
            string monthNow = now.Day + " " + DateTimeFormatInfo.CurrentInfo.GetMonthName(now.Month) + " " + now.Year;

            if (Date == monthNow)
            {
                this.BackColor = Color.SteelBlue;
                lbDays.ForeColor = Color.White;
            }

            

            for (int i = 0; i < TempStorage.TaskStorage.Count; i++) 
            {
                
                if (Date == TempStorage.TaskStorage[i].Item5 + " " + DateTimeFormatInfo.CurrentInfo.GetMonthName(Convert.ToInt32(TempStorage.TaskStorage[i].Item4)) + " " + TempStorage.TaskStorage[i].Item6)
                {
                    GoaLIcon goalICon = new GoaLIcon();
                    goalICon.Display(TempStorage.TaskStorage[i].Item7);
                    flowLayoutPanelCTN.Controls.Add(goalICon);
                }
            }
            
        }
    }
}
