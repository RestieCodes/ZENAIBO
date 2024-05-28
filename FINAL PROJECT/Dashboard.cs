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
    public partial class Dashboard : Form
    {
        //Motivational messages
        private int currentImageIndex = 4;
        private readonly string[] imageNames = {
            "Dashboard_Motivation1",
            "Dashboard_Motivation2",
            "Dashboard_Motivation3",
            "Dashboard_Motivation4",
            "Dashboard_Motivation5"
        };

        public Dashboard()
        {
            InitializeComponent();


            //display the goal list in the flowpanel
            for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
            {
                GoalPanelDashboardDisplay goalPanelDashboardDisplay = new GoalPanelDashboardDisplay();
                goalPanelDashboardDisplay.BorderStyle = BorderStyle.None;
                goalPanelDashboardDisplay.DisplayContent(TempStorage.TaskStorage[i]);
                goalsContainer.Controls.Add(goalPanelDashboardDisplay);

            }
            InitializeMotivationImageChanger();
        }
        private void InitializeMotivationImageChanger()
        {
            // Set the initial image
            ChangeImage();

            // Configure the timer
            Timer timer = new Timer();
            timer.Interval = 5000; // 1 minute
            timer.Tick += (sender, e) => ChangeImage();
            timer.Start();
        }
        private void ChangeImage()
        {
            currentImageIndex = (currentImageIndex + 1) % imageNames.Length;
            pictureMotivations.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageNames[currentImageIndex]);
        }

        private void ShowTaskTomorrow_Click(object sender, EventArgs e)
        {
            if (ShowTaskTomorrow.Text == "TASK TOMORROW")
            {
                ShowTaskTomorrow.Text = "TASK TODAY";
                ShowTaskTomorrow.StateCommon.Content.ShortText.Color1 = Color.BlueViolet;
                //change task display 
            }
            else
            {
                ShowTaskTomorrow.Text = "TASK TOMORROW";
                ShowTaskTomorrow.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
                //change task display 
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            NewMainPanel._newMainPanelInstance.btn_Profile.PerformClick();

        }

        private void goalsContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
