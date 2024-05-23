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
        public User()
        {
            InitializeComponent();

            uploadPicture.BackColor = Color.Transparent;

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            aboutUs about = new aboutUs();
            about.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Deadline deadline = new Deadline();
            deadline.Show();
            this.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
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
            pctProfile.Image = FINAL_PROJECT.Properties.Resources.fpBlank;
        }
    }
}
