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
    public partial class MainPanel : KryptonForm
    {
        private const int TargetHeight = 200;
        private const int AnimationDuration = 420;              

        private KryptonButton previousClickedButton;
        private Timer timer;
        private bool isAnimationInProgress = false;

        // Forms
        private Dashboard dashboardForm;
        private Calendar calendarForm;
        private Deadline deadlineForm;
        private User userForm;
        private aboutUs aboutUsForm;

        public MainPanel()
        {
            InitializeComponent();
            InitializeTimer(); // Initialize the timer object
            InitializeForms(); // Initialize the forms
            InitializeButtonPositions();
            
            // Set the Dashboard button as the default button
            btnDashboard_Click(this, EventArgs.Empty);
            
        }

        // Initialize forms
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
            if (dashboardForm == null)
            {
                dashboardForm = new Dashboard();
            }

            return dashboardForm;
            
        }

        public Calendar GetCalendarForm()
        {
            if (calendarForm == null )
            {
               
                calendarForm = new Calendar();
            }
            return calendarForm;
        }

        public Deadline GetDeadlineForm()
        {
            if (deadlineForm == null)
            {
                
                deadlineForm = new Deadline();
            }
            return deadlineForm;
        }

        public User GetUserForm()
        {
            if (userForm == null)
            {
                
                userForm = new User();
            }
            return userForm;
        }

        public aboutUs GetAboutUsForm()
        {
            if (aboutUsForm == null)
            {
               
                aboutUsForm = new aboutUs();
            }
            return aboutUsForm;
        }

        


        // Show the specified form in the panelContainer
        private void ShowForm(Form form)
        {
            panelContainer.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(form);

            
                form.Show();
                
            
         
        }

        // Handle button click event
        private void HandleButtonClick(KryptonButton clickedButton, Form form)
        {
            if (isAnimationInProgress || previousClickedButton == clickedButton)
                return;

            ResetButtons();
            AnimateButtonResize(clickedButton);
            AdjustButtonPositions(clickedButton);
            
            ShowForm(form);
            previousClickedButton = clickedButton;
        }

        private void InitializeButtonPositions()
        {
            btnDashboard.Location = new Point(0, 84);
            btnCalendar.Location = new Point(0, 147);
            btnDeadline.Location = new Point(0, 210);
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 45; // Animation interval (adjust as needed)
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
            HandleButtonClick(btnDashboard, GetDashboardForm());
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            
            HandleButtonClick(btnCalendar, GetCalendarForm());
        }

        private void btnDeadline_Click(object sender, EventArgs e)
        {
            
            HandleButtonClick(btnDeadline, GetDeadlineForm());
        }

        private void HandleButtonClick(KryptonButton clickedButton)
        {
            if (isAnimationInProgress || previousClickedButton == clickedButton)
                return;

            ResetButtons();
            AnimateButtonResize(clickedButton);
            AdjustButtonPositions(clickedButton);
            previousClickedButton = clickedButton;
        }

        private void AdjustButtonPositions(KryptonButton clickedButton)
        {
            foreach (Control control in panelButtons.Controls)
            {
                if (control is KryptonButton button && button != clickedButton && button.Top > clickedButton.Top)
                {
                    button.Top += clickedButton.Height - 63;
                }
            }
        }

        private void ResetButtons()
        {
            if (previousClickedButton != null)
            {
                ResetButton(previousClickedButton);
                previousClickedButton = null;
            }
        }

        private void ResetButton(KryptonButton button)
        {
            int initialHeight = button.Height;
            int targetHeight = 63;
            int changeInHeight = initialHeight - targetHeight;
            double animationSteps = (double)changeInHeight / (AnimationDuration / timer.Interval); // Adjusted calculation

            isAnimationInProgress = true;

            Timer resetTimer = new Timer();
            resetTimer.Interval = timer.Interval; // Use the existing timer interval
            int stepCount = 0;

            resetTimer.Tick += (sender, e) =>
            {
                if (stepCount < (AnimationDuration / timer.Interval))
                {
                    button.Height -= (int)Math.Ceiling(animationSteps);
                    stepCount++;
                }
                else
                {
                    button.Height = targetHeight; // Ensure the button's height is exactly the target height
                    resetTimer.Stop(); // Stop the timer when animation completes
                    resetTimer.Dispose(); // Dispose the timer to release resources
                    isAnimationInProgress = false; // Reset the flag when the animation completes
                }
            };

            resetTimer.Start();

            foreach (Control control in panelButtons.Controls)
            {
                if (control is KryptonButton btn && btn != button && btn.Top > button.Top)
                {
                    btn.Top -= changeInHeight;
                }
            }
        }

        private void AnimateButtonResize(KryptonButton button)
        {
            int initialHeight = button.Height;
            int changeInHeight = TargetHeight - initialHeight;
            double animationSteps = (double)changeInHeight / (AnimationDuration / timer.Interval); // Adjusted calculation
            int targetTop = button.Top + changeInHeight;

            isAnimationInProgress = true;

            Timer resizeTimer = new Timer();
            resizeTimer.Interval = timer.Interval; // Use the existing timer interval
            int stepCount = 0;

            resizeTimer.Tick += (sender, e) =>
            {
                if (stepCount < (AnimationDuration / timer.Interval))
                {
                    button.Height += (int)Math.Ceiling(animationSteps);
                    button.Top = Math.Min(button.Top + (int)Math.Ceiling(animationSteps), targetTop);
                    stepCount++;
                }
                else
                {
                    resizeTimer.Stop(); // Stop the timer when animation completes
                    resizeTimer.Dispose(); // Dispose the timer to release resources
                    isAnimationInProgress = false; // Reset the flag when the animation completes
                }
            };

            resizeTimer.Start();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            HandleBottomButtonClick(btnUser);
            ShowForm(GetUserForm());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            HandleBottomButtonClick(btnAbout);
            ShowForm(GetAboutUsForm());
        }

        private void HandleBottomButtonClick(KryptonButton clickedButton)
        {
            if (isAnimationInProgress || previousClickedButton == clickedButton)
                return;

            ResetButtons();
            AnimateButtonResize(clickedButton);
            AdjustButtonPositions(clickedButton);
            AdjustTopButtons(clickedButton); // Adjust top buttons when btnUser or btnAbout is clicked
            previousClickedButton = clickedButton;
        }

        private void AdjustTopButtons(KryptonButton clickedButton)
        {
            foreach (Control control in panelButtons.Controls)
            {
                if (control is KryptonButton button && button != clickedButton && button.Top < clickedButton.Top)
                {
                    button.Top += 63 - clickedButton.Height;
                }
            }
        }
        //close program
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //minimize
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      
    }

}
