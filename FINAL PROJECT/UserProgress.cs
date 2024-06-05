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
    public partial class UserProgress : UserControl
    {
        public UserProgress()
        {
            InitializeComponent();
            
        }

        private void UserProgress_Load(object sender, EventArgs e)
        {
            if (TempStorage.TaskStorage.Count < 10)
            {
                totalGOals.Text = "0" + (TempStorage.TaskStorage.Count);
            }
            else
            {
                totalGOals.Text = "" + (TempStorage.TaskStorage.Count);
            }

            if (TempStorage.TaskDoneHistory.Count < 10)
            {
                accomplishedGoals.Text = "0" + (TempStorage.TaskDoneHistory.Count);
            }
            else
            {
                accomplishedGoals.Text = "" + (TempStorage.TaskDoneHistory.Count);
            }

            double progress;
            if (TempStorage.AllTaskCount > 0 && TempStorage.AllTaskDoneCount> 0)
            {
                try
                {
                    progress = (TempStorage.AllTaskDoneCount/TempStorage.AllTaskCount) * 100;
                    if (progress < 10)
                    {
                        lblPercent.Text = "0" + Math.Round(progress, 0) + "%";
                    }
                    else
                    {
                        lblPercent.Text = Math.Round(progress, 0) + "%";
                    }

                }
                catch (System.DivideByZeroException)
                {
                    lblPercent.Text = "0%";
                }
            }
            
        }
    }
}
