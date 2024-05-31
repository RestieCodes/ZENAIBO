using ComponentFactory.Krypton.Toolkit;
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
    public partial class User : Form
    {
        public static User user_intance;
        public User()
        {
            InitializeComponent();

            uploadPicture.BackColor = Color.Transparent;
         

        }

        private void uploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a Profile Picture";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Show the dialog and get result
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the image from the selected file
                string imagePath = openFileDialog.FileName;
                Image profileImage = Image.FromFile(imagePath);

                // Display the image in the PictureBox
                pctProfile.Image = profileImage;
                pctProfile.SizeMode = PictureBoxSizeMode.Zoom; // Adjust as necessary

            }


        }

        private void deletePicture_Click(object sender, EventArgs e)
        {
            pctProfile.Image = Properties.Resources.fpBlank;
        }

        private void User_Load(object sender, EventArgs e)
        {
            PrevAccomplishments.Visible = false;
            for (int i = TempStorage.TaskDoneHistory.Count - 1; i >= 0; i--)
            {
                TaskAccomplishments taskFinished = new TaskAccomplishments();
                taskFinished.DisplayHistory(TempStorage.TaskDoneHistory[i]);
                taskDoneCTN.Controls.Add(taskFinished);

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Dispose();
            NewMainPanel._newMainPanelInstance.Dispose();
            Login._login.Show();

            
        }

        private void NextAccomplishments_Click(object sender, EventArgs e)
        {
            NextAccomplishments.Visible=false;
            PrevAccomplishments.Visible = true;
            lblTitle.Text = "DAILY TASKS";

            taskDoneCTN.Controls.Clear();
            for (int i = TempStorage.TaskDailyHistory.Count - 1; i >= 0; i--)
            {
                TaskDailiesAccomplishments tda = new TaskDailiesAccomplishments();
                tda.DisplayHistory(TempStorage.TaskDailyHistory[i]);
                User.user_intance.taskDoneCTN.Controls.Add(tda);

            }
        }

        private void PrevAccomplishments_Click(object sender, EventArgs e)
        {
            NextAccomplishments.Visible = true;
            PrevAccomplishments.Visible = false;
            lblTitle.Text = "GOALS";
            taskDoneCTN.Controls.Clear();
            for (int i = TempStorage.TaskDoneHistory.Count - 1; i >= 0; i--)
            {
                TaskAccomplishments taskFinished = new TaskAccomplishments();
                taskFinished.DisplayHistory(TempStorage.TaskDoneHistory[i]);
                taskDoneCTN.Controls.Add(taskFinished);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
