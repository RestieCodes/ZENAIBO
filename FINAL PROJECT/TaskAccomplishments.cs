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
    public partial class TaskAccomplishments : UserControl
    {
        public TaskAccomplishments()
        {
            InitializeComponent();
        }
        public void DisplayHistory(Tuple<string, string, string, string, string, string> data)
        {

            DateTime now = DateTime.Now;
            int numMonth = Convert.ToInt32(data.Item4);
            int numDay = Convert.ToInt32(data.Item5);
            int indicator = numDay - now.Day;


            lblTitle.Text = data.Item1;
            lblDescript.Text = data.Item2;


            if (indicator < 0 && numMonth - now.Month == 0)
            {
                lblIndicator.ForeColor = Color.Crimson;
                lblIndicator.Text = "Done Late";
            }
            else if (indicator == 0 && numMonth - now.Month == 0)
            {
                lblIndicator.ForeColor = Color.Green;
                lblIndicator.Text = "Done on Time";
            }
            else
            {
                lblIndicator.ForeColor = Color.Green;
                lblIndicator.Text = "Done Early";
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

        private void deleteHistory_Click(object sender, EventArgs e)
        {
            TempStorage.RemoveHistory(lblTitle.Text,lblDescript.Text);
            User.user_intance.taskDoneCTN.Controls.Clear();
            for (int i = TempStorage.TaskDoneHistory.Count - 1; i >= 0; i--)
            {
                TaskAccomplishments taskFinished = new TaskAccomplishments();
                taskFinished.DisplayHistory(TempStorage.TaskDoneHistory[i]);
                User.user_intance.taskDoneCTN.Controls.Add(taskFinished);

            }
        }
    }
}
