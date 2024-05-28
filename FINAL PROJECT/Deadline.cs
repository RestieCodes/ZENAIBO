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
        public static Deadline Deadline_instance;
        public Deadline()
        {
            InitializeComponent();
        }
        private void Deadline_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
            {
                TaskBar taskBar = new TaskBar();
                taskBar.DisplayContent(TempStorage.TaskStorage[i]);
                taskbarCtn.Controls.Add(taskBar);

            }
            dtpSetDate.MinDate = DateTime.Now;
            dtpSetDate.Value = DateTime.Now;
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
            if (txtBoxTitle1.Text == string.Empty || txtBoxDescription1.Text == string.Empty || listBoxTaskType.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill Up All the Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TempStorage.AddTask(txtBoxTitle1.Text, txtBoxDescription1.Text, listBoxTaskType.Text, dtpSetDate.Value.ToString("MM"), dtpSetDate.Value.ToString("dd"), dtpSetDate.Value.ToString("yyyy"), listBoxTaskType.SelectedIndex);
                taskbarCtn.Controls.Clear();
                for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
                {
                    TaskBar taskBar = new TaskBar();
                    taskBar.DisplayContent(TempStorage.TaskStorage[i]);
                    taskbarCtn.Controls.Add(taskBar);

                }
                ResetTextCtn();
            }

        }

        private void ResetTextCtn()
        {
            txtBoxTitle1.Text = string.Empty;
            txtBoxDescription1.Text = string.Empty;
            picBoxTaskTypeIcon.Image = null;
            listBoxTaskType.SelectedIndex = -1;
        }

        private void checkBoxAcads_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAcads.Checked == true)
            {
                checkBoxCareer.Checked = false;
                checkBoxGym.Checked = false;
                checkBoxAppointment.Checked = false;
                checkBoxOther.Checked = false;

                taskbarCtn.Controls.Clear();
                garbageCollect();

                for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
                {
                    TaskBar taskBar = new TaskBar();
                    taskBar.AcadsOnly(TempStorage.TaskStorage[i]);
                    taskBar.DisplayContent(TempStorage.TaskStorage[i]);
                    taskbarCtn.Controls.Add(taskBar);
                }

            }
            else
            {
                taskbarCtn.Controls.Clear();
                garbageCollect();
                for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
                {
                    TaskBar taskBar = new TaskBar();
                    taskBar.DisplayContent(TempStorage.TaskStorage[i]);
                    taskbarCtn.Controls.Add(taskBar);

                }
            }
        }

        private void checkBoxCareer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCareer.Checked == true)
            {
                checkBoxAcads.Checked = false;
                checkBoxGym.Checked = false;
                checkBoxAppointment.Checked = false;
                checkBoxOther.Checked = false;

                taskbarCtn.Controls.Clear();
                garbageCollect();
                for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
                {
                    TaskBar taskBar = new TaskBar();
                    taskBar.CareerOnly(TempStorage.TaskStorage[i]);
                    taskBar.DisplayContent(TempStorage.TaskStorage[i]);
                    taskbarCtn.Controls.Add(taskBar);
                }
            }
            else
            {
                taskbarCtn.Controls.Clear();
                garbageCollect();
                for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
                {
                    TaskBar taskBar = new TaskBar();
                    taskBar.DisplayContent(TempStorage.TaskStorage[i]);
                    taskbarCtn.Controls.Add(taskBar);
                }
            }
        }

        private void checkBoxGym_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGym.Checked == true)
            {
                checkBoxAcads.Checked = false;
                checkBoxCareer.Checked = false;
                checkBoxAppointment.Checked = false;
                checkBoxOther.Checked = false;

                taskbarCtn.Controls.Clear();
                garbageCollect();
                for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
                {
                    TaskBar taskBar = new TaskBar();
                    taskBar.GymOnly(TempStorage.TaskStorage[i]);
                    taskBar.DisplayContent(TempStorage.TaskStorage[i]);
                    taskbarCtn.Controls.Add(taskBar);
                }
            }
            else
            {
                taskbarCtn.Controls.Clear();
                garbageCollect();
                for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
                {
                    TaskBar taskBar = new TaskBar();
                    taskBar.DisplayContent(TempStorage.TaskStorage[i]);
                    taskbarCtn.Controls.Add(taskBar);
                }
            }
        }

   
        private void checkBoxAppointment_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAppointment.Checked == true)
            {
                checkBoxAcads.Checked = false;
                checkBoxCareer.Checked = false;
                checkBoxGym.Checked = false;
                checkBoxOther.Checked = false;

                taskbarCtn.Controls.Clear();
                garbageCollect();
                for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
                {
                    TaskBar taskBar = new TaskBar();
                    taskBar.AppointOnly(TempStorage.TaskStorage[i]);
                    taskBar.DisplayContent(TempStorage.TaskStorage[i]);
                    taskbarCtn.Controls.Add(taskBar);
                }
            }
            else
            {
                taskbarCtn.Controls.Clear();
                garbageCollect();
                for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
                {
                    TaskBar taskBar = new TaskBar();
                    taskBar.DisplayContent(TempStorage.TaskStorage[i]);
                    taskbarCtn.Controls.Add(taskBar);
                }
            }
        }

       
        private void checkBoxOther_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOther.Checked == true)
            {
                checkBoxAcads.Checked = false;
                checkBoxCareer.Checked = false;
                checkBoxGym.Checked = false;
                checkBoxAppointment.Checked = false;

                taskbarCtn.Controls.Clear();
                garbageCollect();
                for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
                {
                    TaskBar taskBar = new TaskBar();
                    taskBar.OtherOnly(TempStorage.TaskStorage[i]);
                    taskBar.DisplayContent(TempStorage.TaskStorage[i]);
                    taskbarCtn.Controls.Add(taskBar);
                }
            }
            else
            {
                taskbarCtn.Controls.Clear();
                garbageCollect();
                for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
                {
                    TaskBar taskBar = new TaskBar();
                    taskBar.DisplayContent(TempStorage.TaskStorage[i]);
                    taskbarCtn.Controls.Add(taskBar);
                }
            }
        }

        private void garbageCollect()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Deadline.Deadline_instance.lblHeader.Text = "ADD GOAL";
            TempStorage.SaveChanges(txtBoxTitle1.Text, txtBoxDescription1.Text, listBoxTaskType.Text, dtpSetDate.Value.ToString("MM"), dtpSetDate.Value.ToString("dd"), dtpSetDate.Value.ToString("yyyy"), listBoxTaskType.SelectedIndex, lblUserSearch.Text);
            btnSaveChanges.Visible = false;
            deleteIcon.Visible = false;
            btnAddTask.Visible = true;
            ResetTextCtn();

            taskbarCtn.Controls.Clear();
            garbageCollect();
            for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
            {
                TaskBar taskBar = new TaskBar();
                taskBar.BorderStyle = BorderStyle.None;
                taskBar.DisplayContent(TempStorage.TaskStorage[i]);
                taskbarCtn.Controls.Add(taskBar);
            }

        }

        private void deleteIcon_Click(object sender, EventArgs e)
        {
            TempStorage.RemoveTask(lblUserSearch.Text);
            btnSaveChanges.Visible = false;
            btnAddTask.Visible = true;
            deleteIcon.Visible = false;
            ResetTextCtn();

            taskbarCtn.Controls.Clear();
            garbageCollect();
            for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
            {
                TaskBar taskBar = new TaskBar();
                taskBar.BorderStyle = BorderStyle.None;
                taskBar.DisplayContent(TempStorage.TaskStorage[i]);
                taskbarCtn.Controls.Add(taskBar);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void taskbarCtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }
    }
}
