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
    public partial class TaskDailiesAccomplishments : UserControl
    {
        public TaskDailiesAccomplishments()
        {
            InitializeComponent();
        }

        public void DisplayHistory(Tuple<string, string, int, string> data)
        {
            lblTitle.Text = data.Item1;
            lblDescript.Text = data.Item2;
            lblTaskType.Text = data.Item3 + "";
            lblIndicator.Text = data.Item4;

            switch (data.Item3)
            {

                case 0:
                    picBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023405_591;
                    break;

                case 1:
                    picBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T022644_520;
                    break;

                case 2:
                    picBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023254_961;
                    break;

                case 3:
                    picBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T021726_290;
                    break;

                case 4:
                    picBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T022707_602;
                    break;

                case 5:
                    picBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T022658_810;
                    break;

                case 6:
                    picBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023527_334;
                    break;

                case 7:
                    picBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023639_486;
                    break;
            }
        }

        private void deleteHistory_Click(object sender, EventArgs e)
        {
            TempStorage.TaskDailyRemoveHistory(lblTitle.Text, lblDescript.Text, Convert.ToInt32(lblTaskType.Text), lblIndicator.Text);
            User.user_intance.taskDoneCTN.Controls.Clear();
            for (int i = TempStorage.TaskDailyHistory.Count - 1; i >= 0; i--)
            {
                TaskDailiesAccomplishments tda = new TaskDailiesAccomplishments();
                tda.DisplayHistory(TempStorage.TaskDailyHistory[i]);
                User.user_intance.taskDoneCTN.Controls.Add(tda);

            }
        }
    }
}
