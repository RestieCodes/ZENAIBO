using System;
using System.Collections;
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
    public partial class Deadline : Form
    {
        public Deadline()
        {
            InitializeComponent();
        }

        private void listBoxTaskType_SelectedIndexChanged_1(object sender, EventArgs e)
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


        private void btnAddTask_Click(object sender, EventArgs e)
        {
            TempStorage.AddTask(txtBoxTitle.Text, txtBoxDescription.Text, listBoxTaskType.Text, dtpSetDate.Value.ToString("MM"), dtpSetDate.Value.ToString("dd"), dtpSetDate.Value.ToString("yyyy"));
            taskbarCtn.Controls.Clear();
            for (int i = 0; i < TempStorage.TaskStorage.Count; i++) 
            {
                TaskBar taskBar = new TaskBar();
                taskBar.DisplayContent(TempStorage.TaskStorage[i]);
                taskbarCtn.Controls.Add(taskBar);
            } 
            
        }

        private void checkBoxAcads_Click(object sender, EventArgs e)
        {
            
            if (checkBoxAcads.Checked == true) 
            {
                TaskBar taskBar = new TaskBar();
                taskBar.AcadsOnly();
            }
        }
    }
}
