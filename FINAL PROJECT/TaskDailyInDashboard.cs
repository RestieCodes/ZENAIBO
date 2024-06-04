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
    public partial class TaskDailyInDashboard : UserControl
    {
        int width = 369;
        int BaseHeightOdd = 47;
        int BaseHeightEven = 98;
        public TaskDailyInDashboard()
        {
            InitializeComponent();
        }

        public void DisplayTask(Tuple<string, string, int, int, int, string> data)
        {
            DateTime now = DateTime.Now;
            DateTime nameOfDay = new DateTime(now.Year, now.Month, now.Day);
            string dayName = nameOfDay.DayOfWeek.ToString("G");
            string fullDayName = dayName + " | " + DateTimeFormatInfo.CurrentInfo.GetMonthName(now.Month) + " " + now.Day + ", " + now.Year;

            if (fullDayName == data.Item6)
            {
                checkBoxTaskDone.Visible = true;
            }
            else 
            {
                checkBoxTaskDone.Visible = false;
            }

            lblTitle.Text = data.Item1;
            lblDescript.Text = data.Item2;
            lblTaskType.Text = data.Item3 + "";
            lblDate.Text = data.Item6;
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
            PanelSize(data.Item5 - data.Item4);
            PanelPos(data.Item4);
        }

        public void PanelSize(int num)
        {
            if (num % 2 == 0)
            {
                this.Size = new System.Drawing.Size(width, BaseHeightEven + 50 * (num - 2));
            }
            else
            {
                this.Size = new System.Drawing.Size(width, BaseHeightOdd + 50 * (num - 1));
            }

        }

        public void PanelPos(int start)
        {
            int baseLoc = 3;

            this.Location = new System.Drawing.Point(3, baseLoc + 51 * (start - 8) - 1);

        }

        private void checkBoxTaskDone_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTaskDone.Checked == true)
            {
                TempStorage.TaskDailyDone(lblTitle.Text,lblDescript.Text, Convert.ToInt32(lblTaskType.Text),lblDate.Text);
                
                    Dashboard._dashboard.panelTask.Controls.Clear();
                    DateTime now = DateTime.Now;
                    DateTime nameOfDay = new DateTime(now.Year, now.Month, now.Day);
                    string dayName = nameOfDay.DayOfWeek.ToString("G");
                    string fullDayName = dayName + " | " + DateTimeFormatInfo.CurrentInfo.GetMonthName(now.Month) + " " + now.Day + ", " + now.Year;

                    for (int i = 0; i < TempStorage.TaskDaily.Count; i++)
                    {
                        if (fullDayName == TempStorage.TaskDaily[i].Item6)
                        {
                            TaskDailyInDashboard td = new TaskDailyInDashboard();
                            td.DisplayTask(TempStorage.TaskDaily[i]);
                            Dashboard._dashboard.panelTask.Controls.Add(td);
                        }
                    }

                    Dashboard._dashboard.panelUserProgress.Controls.Clear();
                    UserProgress uc = new UserProgress();
                    Dashboard._dashboard.panelUserProgress.Controls.Add(uc);
            }
        }
    }
}
