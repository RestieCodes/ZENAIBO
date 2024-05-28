using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class CalendarDay : Form
    {
        public static CalendarDay _calendarDay;
        int day, month, year, monthTotalDays;
        public CalendarDay()
        {
            InitializeComponent();
        }

        private void CalendarDay_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            day = now.Day;
            year = now.Year;
            month = now.Month;
            DateTime nameOfDay = new DateTime(year, month, day);
            string dayName = nameOfDay.DayOfWeek.ToString("G");
            monthTotalDays = DateTime.DaysInMonth(year, month);
            btnSaveEdit.Visible = false;
            lblDay.Text = dayName + " | " + DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + day + ", " + year;

            PrevDayCalendar.Visible = false;

            for (int i = 0; i < TempStorage.TaskDaily.Count; i++)
            {
                if (lblDay.Text == TempStorage.TaskDaily[i].Item6)
                {
                    TaskDaily taskDaily = new TaskDaily();
                    taskDaily.DisplayTask(TempStorage.TaskDaily[i]);
                    panelTaskContainer.Controls.Add(taskDaily);
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtBoxTitle1.Text == string.Empty || txtBoxDescription1.Text == string.Empty || listBoxTaskType.SelectedIndex == -1 || txtBoxTimeStart.Text == string.Empty || txtBoxTimeEnd.Text == string.Empty)
            {
                MessageBox.Show("Please Fill Up All the Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                int timeStart = Convert.ToInt32(txtBoxTimeStart.Text);
                int timeEnd = Convert.ToInt32(txtBoxTimeEnd.Text);

                bool validStage1 = SleepSchedNotif(timeStart, timeEnd);
                bool validStage2 = TimeSpanArrangement(timeStart, timeEnd);
                if (!validStage1)
                {
                    MessageBox.Show("Can't Set Task in Your Sleeping Sched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(!validStage2)
                {
                    MessageBox.Show("Invalid Time Span", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    panelTaskContainer.Controls.Clear();
                    TempStorage.SaveTask(txtBoxTitle1.Text, txtBoxDescription1.Text, listBoxTaskType.SelectedIndex, timeStart, timeEnd, lblDay.Text);

                    for (int i = 0; i < TempStorage.TaskDaily.Count; i++)
                    {
                        if (lblDay.Text == TempStorage.TaskDaily[i].Item6)
                        {
                            TaskDaily taskDaily = new TaskDaily();
                            taskDaily.DisplayTask(TempStorage.TaskDaily[i]);
                            panelTaskContainer.Controls.Add(taskDaily);
                        }
                    }
                }              
            }                    
        }

        private bool SleepSchedNotif(int timeStart, int timeEnd)
        {
            bool validation = true;

            int[] arr = {1,2,3,4,5,6,7,24};

            for (int i = timeStart; i < timeEnd; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == arr[j]) 
                    {
                        validation = false;
                        break;
                    }
                }
            }

            return validation;
        }

        private bool TimeSpanArrangement(int timeStart, int timeEnd) 
        {
            bool validation;
            if (timeStart > timeEnd || timeStart == timeEnd)
            {
                validation = false;
            }
            else 
            {
                validation = true;            
            }

            return validation;
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtBoxTitle1.Text = string.Empty;
            txtBoxDescription1.Text = string.Empty; 
            listBoxTaskType.SelectedIndex = -1;
            txtBoxTimeStart.Text = string.Empty;
            txtBoxTimeEnd.Text = string.Empty;
            picBoxTaskTypeIcon.Image = null;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnSaveEdit.Visible = false;
            lblHeader.Text = "ADD TASK";
            if (txtBoxTitle1.Text == string.Empty || txtBoxDescription1.Text == string.Empty || listBoxTaskType.SelectedIndex == -1 || txtBoxTimeStart.Text == string.Empty || txtBoxTimeEnd.Text == string.Empty)
            {
                MessageBox.Show("Please Fill Up All the Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int timeStart = Convert.ToInt32(txtBoxTimeStart.Text);
                int timeEnd = Convert.ToInt32(txtBoxTimeEnd.Text);

                bool validStage1 = SleepSchedNotif(timeStart, timeEnd);
                bool validStage2 = TimeSpanArrangement(timeStart, timeEnd);
                if (!validStage1)
                {
                    MessageBox.Show("Can't Set Task in Your Sleeping Sched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!validStage2)
                {
                    MessageBox.Show("Invalid Time Span", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    panelTaskContainer.Controls.Clear();
                    TempStorage.SaveChangesTaskDaily(txtBoxTitle1.Text, txtBoxDescription1.Text, listBoxTaskType.SelectedIndex, timeStart, timeEnd, lblDay.Text, lblKey1.Text, lblKey2.Text); ;

                    for (int i = 0; i < TempStorage.TaskDaily.Count; i++)
                    {
                        if (lblDay.Text == TempStorage.TaskDaily[i].Item6)
                        {
                            TaskDaily taskDaily = new TaskDaily();
                            taskDaily.DisplayTask(TempStorage.TaskDaily[i]);
                            panelTaskContainer.Controls.Add(taskDaily);
                        }
                    }
                }
            }



            txtBoxTitle1.Text = string.Empty;
            txtBoxDescription1.Text = string.Empty;
            listBoxTaskType.SelectedIndex = -1;
            txtBoxTimeStart.Text = string.Empty;
            txtBoxTimeEnd.Text = string.Empty;
            picBoxTaskTypeIcon.Image = null;




        }

        private void listBoxTaskType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxTaskType.SelectedIndex)
            {
                case 0:
                    picBoxTaskTypeIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023405_591;
                    break;

                case 1:
                    picBoxTaskTypeIcon.Image = Properties.Resources.Untitled_design___2024_04_29T022644_520;
                    break;

                case 2:
                    picBoxTaskTypeIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023254_961;
                    break;

                case 3:
                    picBoxTaskTypeIcon.Image = Properties.Resources.Untitled_design___2024_04_29T021726_290;
                    break;

                case 4:
                    picBoxTaskTypeIcon.Image = Properties.Resources.Untitled_design___2024_04_29T022707_602;
                    break;

                case 5:
                    picBoxTaskTypeIcon.Image = Properties.Resources.Untitled_design___2024_04_29T022658_810;
                    break;

                case 6:
                    picBoxTaskTypeIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023527_334;
                    break;

                case 7:
                    picBoxTaskTypeIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023639_486;
                    break;
            }
        }

        private void NextDayCalendar_Click(object sender, EventArgs e)
        {
            panelTaskContainer.Controls.Clear();
            PrevDayCalendar.Visible = true;
            if (day == monthTotalDays)
            {
                month++;
                monthTotalDays = DateTime.DaysInMonth(year, month);
                day = 1;               
            }
            else 
            {
                day++;
            }
            
            DateTime nameOfDay = new DateTime(year, month, day);
            string dayName = nameOfDay.DayOfWeek.ToString("F");
            lblDay.Text = dayName + " | " + DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + day + ", " + year;


            for (int i = 0; i < TempStorage.TaskDaily.Count; i++)
            {
                if (lblDay.Text == TempStorage.TaskDaily[i].Item6)
                {
                    TaskDaily taskDaily = new TaskDaily();
                    taskDaily.DisplayTask(TempStorage.TaskDaily[i]);
                    panelTaskContainer.Controls.Add(taskDaily);
                }
            }

        }

        private void PrevDayCalendar_Click(object sender, EventArgs e)
        {
            panelTaskContainer.Controls.Clear();
            DateTime now = DateTime.Now;
            if (day == 1)
            {
                month--;
                monthTotalDays = DateTime.DaysInMonth(year, month);
                day = monthTotalDays;
            }
            else
            {
                day--;
            }

            DateTime nameOfDay = new DateTime(year, month, day);
            DateTime today = new DateTime(now.Year,now.Month,now.Day);

            string dayName = nameOfDay.DayOfWeek.ToString("F");
            string dayNameToday = nameOfDay.DayOfWeek.ToString("F");

            string dayNameTodayText = dayNameToday + " | " + DateTimeFormatInfo.CurrentInfo.GetMonthName(now.Month) + " " + now.Day + ", " + now.Year;
            lblDay.Text = dayName + " | " + DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + day + ", " + year;

            if (lblDay.Text == dayNameTodayText) 
            {
                PrevDayCalendar.Visible = false;
            }

            for (int i = 0; i < TempStorage.TaskDaily.Count; i++)
            {
                if (lblDay.Text == TempStorage.TaskDaily[i].Item6)
                {
                    TaskDaily taskDaily = new TaskDaily();
                    taskDaily.DisplayTask(TempStorage.TaskDaily[i]);
                    panelTaskContainer.Controls.Add(taskDaily);
                }
            }
        }
    }
}
