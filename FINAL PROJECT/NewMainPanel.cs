﻿using ComponentFactory.Krypton.Toolkit;
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
    public partial class NewMainPanel : KryptonForm
    {
        public static NewMainPanel _newMainPanelInstance;
        private Timer expandCollapseTimer;
        private bool isExpanded = false;
        private const int expandedWidth = 220;
        private const int collapsedWidth = 87;
        private const int panelHeight = 743;
        private const int animationStep = 10; // The step size for each tick of the timer

        private Dashboard dashboardForm;
        private Calendar calendarForm;
        private Deadline deadlineForm;
        private User userForm;
        private aboutUs aboutUsForm;
        private Form previousClickedForm = new Dashboard();



        private List<KryptonButton> buttons;
        public NewMainPanel()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            InitializeComponent();
            InitializeForms();
            InitializeExpandCollapseTimer();
            panelbtnContainer.Size = new Size(collapsedWidth, panelHeight);
            LoadFormIntoPanel(new Dashboard());
            SetButtonColors(btnDashboard, Color.Indigo, Color.BlueViolet);

        }

        private void InitializeForms()
        {
            dashboardForm = null;
            calendarForm = null;
            deadlineForm = null;
            userForm = null;
            aboutUsForm = null;
        }

        public Dashboard GetDashboardForm()
        {
            if (dashboardForm == null || dashboardForm.IsDisposed)
            {
                dashboardForm = new Dashboard();
                Dashboard._dashboard = dashboardForm;
            }
            return dashboardForm;

        }

        public Calendar GetCalendarForm()
        {
            if (calendarForm == null || calendarForm.IsDisposed)
            {

                calendarForm = new Calendar();
            }
            return calendarForm;
        }

        public Deadline GetDeadlineForm()
        {
            if (deadlineForm == null || deadlineForm.IsDisposed)
            {

                deadlineForm = new Deadline();
                Deadline.Deadline_instance = deadlineForm;
            }
            return deadlineForm;
        }

        public User GetUserForm()
        {
            if (userForm == null || userForm.IsDisposed)
            {

                userForm = new User();
                User.user_intance = userForm;
            }
            return userForm;
        }

        public aboutUs GetAboutUsForm()
        {
            if (aboutUsForm == null || aboutUsForm.IsDisposed)
            {

                aboutUsForm = new aboutUs();
            }
            return aboutUsForm;
        }

        private void InitializeExpandCollapseTimer()
        {
            expandCollapseTimer = new Timer();
            expandCollapseTimer.Interval = 15; // Adjust the interval for smoother or faster animation
            expandCollapseTimer.Tick += new EventHandler(ExpandCollapseTimer_Tick);
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            expandCollapseTimer.Start();
        }

        private void ExpandCollapseTimer_Tick(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                // Collapse the panel
                if (panelbtnContainer.Width > collapsedWidth)
                {
                    panelbtnContainer.Width -= animationStep;
                    if (panelbtnContainer.Width < collapsedWidth)
                    {
                        panelbtnContainer.Width = collapsedWidth;
                        expandCollapseTimer.Stop();
                        isExpanded = false;
                    }
                }
            }
            else
            {
                // Expand the panel
                if (panelbtnContainer.Width < expandedWidth)
                {
                    panelbtnContainer.Width += animationStep;
                    if (panelbtnContainer.Width > expandedWidth)
                    {
                        panelbtnContainer.Width = expandedWidth;
                        expandCollapseTimer.Stop();
                        isExpanded = true;
                    }
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void SwitchToDashboard()
        {
            ResetButtonColors();
            LoadFormIntoPanel(GetDashboardForm());
            SetButtonColors(btnDashboard, Color.Indigo, Color.BlueViolet);
        }
        public void SwitchToDashboardPanel()
        {
            ResetButtonColors();
            LoadFormIntoPanel(GetDashboardForm());
            SetButtonColors(btnDashboard, Color.Indigo, Color.BlueViolet);
        }
        private void LoadFormIntoPanel(Form form)
        {
            // Clear previous controls
            panelContainer.Controls.Clear();

            // Set form properties
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Add the form to the panel
            panelContainer.Controls.Add(form);
            panelContainer.Tag = form;


            // Show the form
            form.Show();

            if (previousClickedForm != form)
            {
                previousClickedForm.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                previousClickedForm = form;
            }
        }

       
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            LoadFormIntoPanel(GetCalendarForm());
            SetButtonColors(btnCalendar, Color.Indigo, Color.BlueViolet);
        }

        private void btn_Deadline_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            LoadFormIntoPanel(GetDeadlineForm()); 
            SetButtonColors(btn_Deadline, Color.Indigo, Color.BlueViolet);
        }

        public void btn_Profile_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            LoadFormIntoPanel(GetUserForm());
            SetButtonColors(btn_Profile, Color.Indigo, Color.BlueViolet);
        }

        private void btn_aboutUs_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            LoadFormIntoPanel(GetAboutUsForm());
            SetButtonColors(btn_aboutUs, Color.Indigo, Color.BlueViolet);
        }
    

        //Retain the color
        private void SetButtonColors(KryptonButton button, Color color1, Color color2)
        {
            button.StateCommon.Back.Color1 = color1;
            button.StateCommon.Back.Color2 = color2;
        }


        //Change the button color after changing form
        private void ResetButtonColors()
        {
            buttons = new List<KryptonButton>
        {
             btnDashboard,
             btnCalendar,
             btn_Deadline,
            btn_Profile,
            btn_aboutUs
        };
            foreach (var btn in buttons)
            {
                btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(48, 20, 75);
                btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(32, 32, 41);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            ResetButtonColors();
            LoadFormIntoPanel(GetDashboardForm());
            SetButtonColors(btnDashboard, Color.Indigo, Color.BlueViolet); 
        }
    }
}
