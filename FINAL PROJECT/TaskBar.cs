using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class TaskBar : UserControl
    {
        public static bool doneTask;
        public TaskBar()
        {
            InitializeComponent();
        }

        public void DisplayContent(Tuple<string, string, string, string, string, string, int> data)
        {
            
            DateTime now = DateTime.Now;
            int numMonth = Convert.ToInt32(data.Item4);
            int numDay = Convert.ToInt32(data.Item5);
            int indicator = numDay - now.Day;

            DateTime nameOfDay = new DateTime(Convert.ToInt32(data.Item6), Convert.ToInt32(data.Item4), Convert.ToInt32(data.Item5));
            string dayName = nameOfDay.DayOfWeek.ToString("G");

            lblTitle.Text = data.Item1;
            lblDescript.Text = data.Item2;
            lblIndex.Text = data.Item7.ToString();

            if (indicator <= 2 && numMonth - now.Month == 0)
            {
                lblDate.ForeColor = Color.Crimson;
                lblDate.Text = dayName + ", " + DateTimeFormatInfo.CurrentInfo.GetMonthName(numMonth) + " " + data.Item5 + " " + data.Item6;
            }
            else if ((indicator >= 3 && indicator <= 6)&& numMonth - now.Month == 0)
            {
                lblDate.ForeColor = Color.Yellow;
                lblDate.Text = dayName + ", " + DateTimeFormatInfo.CurrentInfo.GetMonthName(numMonth) + " " + data.Item5 + " " + data.Item6;

            }
            else{ 
                lblDate.ForeColor = Color.Green;
                lblDate.Text = dayName + ", " + DateTimeFormatInfo.CurrentInfo.GetMonthName(numMonth) + " " + data.Item5 + " " + data.Item6;
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

        public void AcadsOnly(Tuple<string, string, string, string, string, string, int> data)
        {
            if (data.Item3 != "ACADS")
            {
                this.Hide();
            }
        }

        public void CareerOnly(Tuple<string, string, string, string, string, string, int> data)
        {
            if (data.Item3 != "CAREER")
            {
                this.Hide();
            }
        }

        public void GymOnly(Tuple<string, string, string, string, string, string, int> data)
        {
            if (data.Item3 != "WORKOUT")
            {
                this.Hide();
            }
        }

        public void EtnOnly(Tuple<string, string, string, string, string, string, int> data)
        {
            if (data.Item3 != "ENTERTAINMENT")
            {
                this.Hide();
            }
        }

        public void HomeResOnly(Tuple<string, string, string, string, string, string, int> data)
        {
            if (data.Item3 != "HOME RESPONSIBILITY")
            {
                this.Hide();
            }
        }

        public void AppointOnly(Tuple<string, string, string, string, string, string, int> data)
        {
            if (data.Item3 != "APPOINTMENT")
            {
                this.Hide();
            }
        }

        public void SmallTaskOnly(Tuple<string, string, string, string, string, string, int> data)
        {
            if (data.Item3 != "SMALL TASK")
            {
                this.Hide();
            }
        }

        public void OtherOnly(Tuple<string, string, string, string, string, string, int> data)
        {
            if (data.Item3 != "OTHERS")
            {
                this.Hide();
            }
        }

       

        private void editIcon_Click_1(object sender, EventArgs e)
        {
            Deadline.Deadline_instance.lblHeader.Text = "EDIT TASK";
           

            Deadline.Deadline_instance.btnSaveChanges.Visible = true;
            Deadline.Deadline_instance.btnAddTask.Visible = false;

            Deadline.Deadline_instance.txtBoxTitle1.Text = lblTitle.Text;
            Deadline.Deadline_instance.txtBoxDescription1.Text = lblDescript.Text;

            if (lblIndex.Text == "0")
            {
                Deadline.Deadline_instance.listBoxTaskType.SelectedIndex = 0;
            }
            else if (lblIndex.Text == "1")
            {
                Deadline.Deadline_instance.listBoxTaskType.SelectedIndex = 1;
            }
            else if (lblIndex.Text == "2")
            {
                Deadline.Deadline_instance.listBoxTaskType.SelectedIndex = 2;
            }
            else if (lblIndex.Text == "3")
            {
                Deadline.Deadline_instance.listBoxTaskType.SelectedIndex = 3;
            }
            else if (lblIndex.Text == "4")
            {
                Deadline.Deadline_instance.listBoxTaskType.SelectedIndex = 4;
            }
            else if (lblIndex.Text == "5")
            {
                Deadline.Deadline_instance.listBoxTaskType.SelectedIndex = 5;
            }
            else if (lblIndex.Text == "6")
            {
                Deadline.Deadline_instance.listBoxTaskType.SelectedIndex = 6;
            }
            else if (lblIndex.Text == "7")
            {
                Deadline.Deadline_instance.listBoxTaskType.SelectedIndex = 7;
            }

            char[] delimitersChar = { ' ', ',' };
            string[] date = lblDate.Text.Split(delimitersChar, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                Deadline.Deadline_instance.dtpSetDate.Value = new DateTime(Convert.ToInt32(date[3]), GetMonthNumber(date[1]), Convert.ToInt32(date[2]), 0, 0, 0, 0);
            }
            catch (ArgumentOutOfRangeException) 
            {
                Deadline.Deadline_instance.dtpSetDate.Value = DateTime.Now;
            }
            Deadline.Deadline_instance.lblUserSearch.Text = lblDescript.Text;
            Deadline.Deadline_instance.deleteIcon.Visible = true;

            circleIcon.Visible = true;

        }

        private int GetMonthNumber(string month)
        {
            DateTimeFormatInfo dtfi = CultureInfo.CurrentCulture.DateTimeFormat;

            string[] monthNames = dtfi.MonthNames;

            for (int i = 0; i < monthNames.Length; i++)
            {
                if (monthNames[i].Equals(month, StringComparison.CurrentCultureIgnoreCase))
                {

                    return i + 1;
                }
            }

            return -1;
        }

        private void circleIcon_Click(object sender, EventArgs e)
        {
            doneIcon.Visible = true;
            circleIcon.Visible = false;
            doneTask = true;
        }

        private void doneIcon_Click(object sender, EventArgs e)
        {
            circleIcon.Visible = true;
            doneIcon.Visible = false;
            doneTask = false;

        }

        private void TaskBar_Load(object sender, EventArgs e)
        {

        }
    }
}
