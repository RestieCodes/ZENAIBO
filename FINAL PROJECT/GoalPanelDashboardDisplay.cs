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
    public partial class GoalPanelDashboardDisplay : UserControl
    {
        public GoalPanelDashboardDisplay()
        {
            InitializeComponent();
        }

        public void DisplayContent(Tuple<string, string, string, string, string, string, int> data)
        {
         
            DateTime now = DateTime.Now;
            int numMonth = Convert.ToInt32(data.Item4);
            int numDay = Convert.ToInt32(data.Item5);
            int indicator = numDay - now.Day;

            DateTime nameOfDay = new DateTime(Convert.ToInt32(data.Item6), Convert.ToInt32(data.Item4), Convert.ToInt32(data.Item5));
            string dayName = nameOfDay.DayOfWeek.ToString("G");

            goalTitle.Text = data.Item1;
            lblIndex.Text = data.Item7.ToString();

            if (indicator <= 2 && numMonth - now.Month == 0)
            {
                lblDate.ForeColor = Color.Crimson;
                lblDate.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(numMonth) + " " + data.Item5 ;
            }
            else if ((indicator >= 3 && indicator <= 6) && numMonth - now.Month == 0)
            {
                lblDate.ForeColor = Color.Yellow;
                lblDate.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(numMonth) + " " + data.Item5;

            }
            else
            {
                lblDate.ForeColor = Color.Green;
                lblDate.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(numMonth) + " " + data.Item5;
            }

            switch (data.Item3)
            {

                case "ACADS":
                    picBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023405_591;
                    break;

                case "CAREER":
                    picBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T022644_520;
                    break;

                case "WORKOUT":
                    picBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023254_961;
                    break;

                case "ENTERTAINMENT":
                    picBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T021726_290;
                    break;

                case "HOME RESPONSIBILITY":
                    picBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T022707_602;
                    break;

                case "APPOINTMENT":
                    picBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T022658_810;
                    break;

                case "SMALL TASK":
                    picBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023527_334;
                    break;

                case "OTHERS":
                    picBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023639_486;
                    break;
            }
        }
    }
}
