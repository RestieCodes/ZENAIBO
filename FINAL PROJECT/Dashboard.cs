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
    public partial class Dashboard : Form
    {
        public static Dashboard _dashboard;
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
            if (ShowTaskTomorrow.Text == "CHECK TASK TOMORROW")
            {
                ShowTaskTomorrow.Text = "CHECK TASK TODAY";
                ShowTaskTomorrow.StateCommon.Content.ShortText.Color1 = Color.BlueViolet;
                

                ShowTaskTommorow();
                Calendar.Image = Properties.Resources.Dashboard_CALENDARJun2;

                //change task display 
            }
            else
            {
                ShowTaskTomorrow.Text = "CHECK TASK TOMORROW";
                ShowTaskTomorrow.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
                Calendar.Image = Properties.Resources.Dashboard_CALENDARJun1;

                ShowTaskToday();
                //change task display 
            }
        }

        public void ShowTaskTommorow() 
        {
            panelTask.Controls.Clear();
            DateTime now = DateTime.Now;
            DateTime nameOfDay = new DateTime(now.Year, now.Month, now.Day + 1);
            string dayName = nameOfDay.DayOfWeek.ToString("G");
            string fullDayName = dayName + " | " + DateTimeFormatInfo.CurrentInfo.GetMonthName(now.Month) + " " + (now.Day + 1) + ", " + now.Year;

            for (int i = 0; i < TempStorage.TaskDaily.Count; i++)
            {
                if (fullDayName == TempStorage.TaskDaily[i].Item6)
                {
                    TaskDailyInDashboard td = new TaskDailyInDashboard();
                    td.DisplayTask(TempStorage.TaskDaily[i]);
                    panelTask.Controls.Add(td);
                }
            }
        }

        public void ShowTaskToday()
        {
            panelTask.Controls.Clear();
            DateTime now = DateTime.Now;        
            DateTime nameOfDay = new DateTime(now.Year, now.Month, now.Day);
            string dayName = nameOfDay.DayOfWeek.ToString("G");
            string fullDayName = dayName + " | " + DateTimeFormatInfo.CurrentInfo.GetMonthName(now.Month) + " " + now.Day + ", " + now.Year;

            for (int i = 0; i < TempStorage.TaskDaily.Count; i++)
            {
                if (fullDayName == TempStorage.TaskDaily[i].Item6)
                {
                    TaskDailyInDashboard td = new TaskDailyInDashboard();
                    td.DisplayTask(TempStorage.TaskDaily[i]);
                    panelTask.Controls.Add(td);
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            NewMainPanel._newMainPanelInstance.btn_Profile.PerformClick();

        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

            //display the goal list in the flowpanel
            TempStorage.TaskStorage = TempStorage.SortTaskStorage();    
            for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
            {
                GoalPanelDashboardDisplay goalPanelDashboardDisplay = new GoalPanelDashboardDisplay();
                goalPanelDashboardDisplay.BorderStyle = BorderStyle.None;
                goalPanelDashboardDisplay.DisplayContent(TempStorage.TaskStorage[i]);
                goalsContainer.Controls.Add(goalPanelDashboardDisplay);

            }
            LoadUCIntoPanel();
            ShowTaskToday();          
        }

        public void LoadUCIntoPanel()
        {
            panelUserProgress.Controls.Clear();
            UserProgress uc = new UserProgress();
            panelUserProgress.Controls.Add(uc);
        }

    }
}
