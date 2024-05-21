using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class TaskBar : UserControl
    {
        public TaskBar()
        {
            InitializeComponent();
        }

        public void DisplayContent(Tuple<string, string, string, string, string, string> data)
        {
            
            DateTime now = DateTime.Now;
            int numMonth = Convert.ToInt32(data.Item4);
            int numDay = Convert.ToInt32(data.Item5);
            int indicator = numDay - now.Day;

            DateTime nameOfDay = new DateTime(Convert.ToInt32(data.Item6), Convert.ToInt32(data.Item4), Convert.ToInt32(data.Item5));
            string dayName = nameOfDay.DayOfWeek.ToString("G");

            lblTitle.Text = data.Item1;
            lblDescript.Text = data.Item2;

            if (indicator <= 2 && numMonth - now.Month == 0)
            {
                lblDate.ForeColor = Color.Red;
                lblDate.Text = dayName + ", " + DateTimeFormatInfo.CurrentInfo.GetMonthName(numMonth) + " " + data.Item5 + " " + data.Item6;
            }
            else if ((indicator >= 3 && indicator <= 6)&& numMonth - now.Month == 0)
            {
                lblDate.ForeColor = Color.Yellow;
                lblDate.Text = dayName + ", " + DateTimeFormatInfo.CurrentInfo.GetMonthName(numMonth) + " " + data.Item5 + " " + data.Item6;

            }
            else{ 
                lblDate.ForeColor = Color.Green;
                lblDate.Text = dayName + ", " + DateTimeFormatInfo.CurrentInfo.GetMonthName(numMonth) + " " + data.Item5 + " " + data.Item6;
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

        public void AcadsOnly()
        { 
            if (picBoxIcon.Image != Properties.Resources.Untitled_design___2024_04_29T023405_591) 
            {
                picBoxIcon.Image = null;
            }
        }
    }
}
