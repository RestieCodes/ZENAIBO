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
    public partial class UCDailyTask : UserControl
    {
        public UCDailyTask()
        {
            InitializeComponent();
        }

        public void DisplayContent(Tuple<string, string, int, int, int, string> data) 
        {
            textBoxTitle.Text = data.Item1;
            string timeStart;
            string timeEnd;
            switch (data.Item3) 
            {
                case 0:
                    pictureBoxIcon.Image = Properties.Resources.DailyTaskAcadsIcon;
                    break;

                case 1:
                    pictureBoxIcon.Image = Properties.Resources.DailyTaskCareerIcon;
                    break;

                case 2:
                    pictureBoxIcon.Image = Properties.Resources.DailyTaskGymIcon;
                    break;

                case 3:
                    pictureBoxIcon.Image = Properties.Resources.DailyTaskETNIcon;
                    break;

                case 4:
                    pictureBoxIcon.Image = Properties.Resources.DailyTaskHomeResIcon;
                    break;

                case 5:
                    pictureBoxIcon.Image = Properties.Resources.DailyTaskAPNIcon;
                    break;

                case 6:
                    pictureBoxIcon.Image = Properties.Resources.DailyTaskSmallAPNIcon;
                    break;

                case 7:
                    pictureBoxIcon.Image = Properties.Resources.DailyTaskOthersIcon;
                    break;

            }

            if (data.Item4 < 12) 
            {
                timeStart = data.Item4 + " AM";
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

            textBoxTimeSpan.Text = timeStart + " - " + timeEnd;
        }
    }
}
