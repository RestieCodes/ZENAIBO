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
    public partial class DashboardDailyTask : UserControl
    {
        public DashboardDailyTask()
        {
            InitializeComponent();
        }

        public void DisplayContent(Tuple<string, string, int, int, int, string> data) 
        {
            lblTitle.Text = data.Item1;
            lblDescript.Text = data.Item2;

            string timeStart;
            string timeEnd;
            switch (data.Item3)
            {
                case 0:
                    pictureBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023405_591;
                    break;

                case 1:
                    pictureBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T022644_520;
                    break;

                case 2:
                    pictureBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023254_961;
                    break;

                case 3:
                    pictureBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T021726_290;
                    break;

                case 4:
                    pictureBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T022707_602;
                    break;

                case 5:
                    pictureBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T022658_810;
                    break;

                case 6:
                    pictureBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023527_334;
                    break;

                case 7:
                    pictureBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023639_486;
                    break;

            }

            if (data.Item4 < 12)
            {
                timeStart = data.Item4 + " AM";
            }
            else if (data.Item4 == 12)
            {
                timeStart = data.Item4 + " PM";
            }
            else
            {
                timeStart = (data.Item4 - 12) + " PM";
            }

            if (data.Item5 > 12)
            {
                timeEnd = (data.Item5 - 12) + " PM";
            }
            else if (data.Item5 == 12)
            {
                timeEnd = data.Item5 + " PM";
            }
            else
            {
                timeEnd = data.Item5 + " AM";
            }

            lblTime.Text = timeStart + " - " + timeEnd;
        }
    }
}
