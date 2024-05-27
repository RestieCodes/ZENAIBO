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
        public Dashboard()
        {
            InitializeComponent();

           


            for (int i = 0; i < TempStorage.TaskStorage.Count; i++)
            {
                GoalPanelDashboardDisplay goalPanelDashboardDisplay = new GoalPanelDashboardDisplay();
                goalPanelDashboardDisplay.BorderStyle = BorderStyle.None;
                goalPanelDashboardDisplay.DisplayContent(TempStorage.TaskStorage[i]);
                goalsContainer.Controls.Add(goalPanelDashboardDisplay);

            }
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
            NewMainPanel MainPanleAccess = new NewMainPanel();  
            User user = new User();

        }

        private void goalsContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
