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
    public partial class TaskDaily : UserControl
    {
        int width = 406;
        int BaseHeightOdd = 47;
        int BaseHeightEven = 98;
        
        public TaskDaily()
        {
            InitializeComponent();
        }

        public void DisplayTask(Tuple<string, string, int, int, int, string> data) 
        { 
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
            lblTimeStart.Text = data.Item4.ToString();
            lblTimeEnd.Text = data.Item5.ToString();
            PanelSize(data.Item5 - data.Item4);
            PanelPos(data.Item4);
        }

        public void PanelSize(int num) 
        {
            if (num % 2 == 0)
            {
                this.Size = new System.Drawing.Size(width, BaseHeightEven + 50 * (num - 2));
            }
            else {
                this.Size = new System.Drawing.Size(width, BaseHeightOdd + 50 * (num - 1));
            }
            
        }

        public void PanelPos(int start)
        {
           int baseLoc = 3;

            this.Location = new System.Drawing.Point(3, baseLoc + 51 * (start - 8) - 1);

        }

        private void TaskDaily_DoubleClick(object sender, EventArgs e)
        {
            CalendarDay._calendarDay.btnSave.Visible = false;
            CalendarDay._calendarDay.btnSaveEdit.Visible = true;

            CalendarDay._calendarDay.txtBoxTitle1.Text = lblTitle.Text;
            CalendarDay._calendarDay.txtBoxDescription1.Text = lblDescript.Text;
            CalendarDay._calendarDay.txtBoxTimeStart.Text = lblTimeStart.Text;
            CalendarDay._calendarDay.txtBoxTimeEnd.Text = lblTimeEnd.Text;

            CalendarDay._calendarDay.lblKey1.Text = lblTitle.Text;
            CalendarDay._calendarDay.lblKey2.Text = lblDescript.Text;

            CalendarDay._calendarDay.lblHeader.Text = "EDIT TASK";

            if (lblTaskType.Text == "0")
            {
                CalendarDay._calendarDay.listBoxTaskType.SelectedIndex = 0;
            }
            else if (lblTaskType.Text == "1")
            {
                CalendarDay._calendarDay.listBoxTaskType.SelectedIndex = 1;
            }
            else if (lblTaskType.Text == "2")
            {
                CalendarDay._calendarDay.listBoxTaskType.SelectedIndex = 2;
            }
            else if (lblTaskType.Text == "3")
            {
                CalendarDay._calendarDay.listBoxTaskType.SelectedIndex = 3;
            }
            else if (lblTaskType.Text == "4")
            {
                CalendarDay._calendarDay.listBoxTaskType.SelectedIndex = 4;
            }
            else if (lblTaskType.Text == "5")
            {
                CalendarDay._calendarDay.listBoxTaskType.SelectedIndex = 5;
            }
            else if (lblTaskType.Text == "6")
            {
                CalendarDay._calendarDay.listBoxTaskType.SelectedIndex = 6;
            }
            else if (lblTaskType.Text == "7")
            {
                CalendarDay._calendarDay.listBoxTaskType.SelectedIndex = 7;
            }
        }

        private void deleteDailyTask_Click(object sender, EventArgs e)
        {
            TempStorage.RemoveDailyTask(lblTitle.Text,lblDescript.Text,Convert.ToInt32(lblTaskType.Text),lblDate.Text);
            CalendarDay._calendarDay.panelTaskContainer.Controls.Clear();
            for (int i = 0; i < TempStorage.TaskDaily.Count; i++)
            {
                if (CalendarDay._calendarDay.lblDay.Text == TempStorage.TaskDaily[i].Item6)
                {
                    TaskDaily taskDaily = new TaskDaily();
                    taskDaily.DisplayTask(TempStorage.TaskDaily[i]);
                    CalendarDay._calendarDay.panelTaskContainer.Controls.Add(taskDaily);
                }
            }

        }
    }
}
