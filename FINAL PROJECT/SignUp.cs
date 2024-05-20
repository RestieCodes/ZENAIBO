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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent(); 
        }

        //Go to login
        public void label4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login login = new Login();
            login.Show();
            
        }

        // X button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // - button
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Check whether the circle is glowing(indicating that it met the condition) 
        public void checkGlow()
        {

            //check if the Fullname textbox met the condition (No skipping)
            if (glowFullname.Visible == false)
            {
                textBoxFullname.Focus();
                label5.Visible = false;
                labelRegistration.Text = "             Full Name : Enter 9 to 30 characters";
                labelRegistration.ForeColor = Color.Crimson;
            }
            //check if you choose chronotype (No skipping)
            else if (glowChronotype.Visible == false)
            {
                labelRegistration.Text = "                    Choose your Chronotype";
                labelRegistration.ForeColor = Color.Crimson;
                chronotypeBox.Focus();
            }
            //check if the Username textbox met the condition (No skipping)
            else if (glowUsername.Visible == false)
            {
                label6.Visible = false;
                textBoxUsername.Focus();
                labelRegistration.Text = "            Username : Enter 8 - 15 characters";
                labelRegistration.ForeColor = Color.Crimson;
            }
            //check if the Password textbox met the condition (No skipping)
            else if (glowPassword.Visible == false)
            {
                label7.Visible = false;
                labelRegistration.Text = "Password : Enter 8 - 15 characters with number/s";
                labelRegistration.ForeColor = Color.Crimson;
                textBoxPassword.Focus();
            }
            //check if the Confirm Password textbox met the condition (No skipping)
            else if (glowCPassword.Visible == false)
            {
                label8.Visible = false;
                labelRegistration.Text = "                               Confirm Password";
                labelRegistration.ForeColor = Color.Crimson;
                textBoxCPassword.Focus();
            }
        }

        //Full name 
        public void label5_Click(object sender, EventArgs e)
        {
            //change the label to show the condition
            labelRegistration.Text = "             Full Name : Enter 9 to 30 characters";
            labelRegistration.ForeColor = Color.MediumPurple;

            label5.Visible = false;
            textBoxFullname.Focus();

        }
            //Text Box
        public void textBoxFullname_KeyDown(object sender, KeyEventArgs e)
        {
            label5.Visible = false;
            chronotypeBox.Text = "        Chronotype";
            //change the label to show the condition
            labelRegistration.Text = "             Full Name : Enter 9 to 30 characters";
            labelRegistration.ForeColor = Color.MediumPurple;


            //Count the number of characters
            int numberOfCharacters = textBoxFullname.Text.Length;

            //Real-time checker
            if (numberOfCharacters >= 10 && numberOfCharacters <= 30)
            {
                glowFullname.Visible = true;
            }
            else
            {
                glowFullname.Visible = false;
            }

            //User hit enter
            if (e.KeyCode == Keys.Enter)
            {
                //No input
                if (string.IsNullOrEmpty(textBoxFullname.Text) || textBoxFullname.Text == "Full Name")
                {
                    textBoxFullname.Text = string.Empty;
                }

                //Error input
                if (glowFullname.Visible == false)
                {
                    labelRegistration.ForeColor = Color.Crimson;
                }

                //Correct input
                else
                {
                    chronotypeBox.Focus();
                }
            }
        }

        // Chronotype
        public void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkGlow();

            //Check previous if correct
            if (glowFullname.Visible == true)
            {
                // goto Username txtbox
                label6.Visible = false;
                textBoxUsername.Focus();
                //change the label to show the condition
                labelRegistration.Text = "        Username : Enter 8 - 15 characters";
                labelRegistration.ForeColor = Color.MediumPurple;

                
                glowChronotype.Visible = true;
                label2.Visible = false;
                //Choose from combo box then display
                string selectedItem = chronotypeBox.SelectedItem.ToString();
                switch (selectedItem)
                {
                    case "     LION":
                        pictureBoxChronotype.Image = Properties.Resources.ICON_Lion;
                        break;
                    case "     BEAR":
                        pictureBoxChronotype.Image = Properties.Resources.ICON_Bear;
                        break;
                    case "     WOLF":
                        pictureBoxChronotype.Image = Properties.Resources.ICON_Wolf;
                        break;
                    case "     DOLPHIN":
                        pictureBoxChronotype.Image = Properties.Resources.ICON_Dolphin;
                        break;
                    default:
                        // Do nothing or display a default image if the selected animal is not recognized
                        break;
                }
            }
        }

        //Username
        public void label6_Click(object sender, EventArgs e)
        {
            checkGlow();

            //Check previous if correct
            if (glowChronotype.Visible == true)
            {
                //change the label to show the condition
                labelRegistration.Text = "        Username : Enter 8 - 15 characters";
                labelRegistration.ForeColor = Color.MediumPurple;

                label6.Visible = false;
                textBoxUsername.Focus();

            }
              
        }
             // Text Box
        public void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            //change the label to show the condition
            labelRegistration.Text = "            Username : Enter 8 - 15 characters";
            labelRegistration.ForeColor = Color.MediumPurple;
        
            //Count the number of characters
            int numberOfCharacters = textBoxUsername.Text.Length;

            // Condition with Real-time checker
            if (numberOfCharacters >= 8 && numberOfCharacters < 15)
            {
                glowUsername.Visible = true;
            }
            else
            {
                glowUsername.Visible = false;
            }
            
            //User hit enter
            if (e.KeyCode == Keys.Enter)
            {
                //No input
                if (string.IsNullOrEmpty(textBoxUsername.Text) || textBoxUsername.Text == "Full Name")
                {
                    textBoxUsername.Text = string.Empty;
                }

                //Error input
                if (glowUsername.Visible == false)
                {
                    labelRegistration.ForeColor = Color.Crimson;
                }
                //Correct input
                else
                {
                    label7.Visible = false;
                    textBoxPassword.Focus();
                }
            }
        }

        //Password
        public void label7_Click(object sender, EventArgs e)
        {
            checkGlow();
            //Check previous if correct
            if (glowUsername.Visible == true)
            {
                //change the label to show the condition
                labelRegistration.Text = "Password : Enter 8 - 15 characters with number/s";
                labelRegistration.ForeColor = Color.MediumPurple;

                label7.Visible = false;
                textBoxPassword.Focus();
            }
            

        }
            // Text Box
        public void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            //change the label to show the condition
            labelRegistration.Text = "Password : Enter 8 - 15 characters with number/s";
            labelRegistration.ForeColor = Color.MediumPurple;

            //Count the number of characters
            int numberOfCharacters = textBoxPassword.Text.Length;

            // Condition with Real-time checker
            if (numberOfCharacters >= 8 && numberOfCharacters < 15)
            {
                foreach (char c in textBoxPassword.Text)
                {
                    // Check if the character is a digit
                    if (char.IsDigit(c))
                    {
                        glowPassword.Visible = true;
                    }
                    else
                    {
                        glowPassword.Visible = false;
                    }
                }
            }
            else
            {
                glowPassword.Visible = false;
            }

            //User hit enter
            if (e.KeyCode == Keys.Enter)
            {
                //No input
                if (string.IsNullOrEmpty(textBoxPassword.Text) || textBoxPassword.Text == "Password")
                {
                    textBoxPassword.Text = string.Empty;
                }

                //Error input
                if (glowPassword.Visible == false)
                {
                    labelRegistration.ForeColor = Color.Crimson;
                }
                //Correct input
                else
                {
                    label8.Visible = false;
                    textBoxCPassword.Focus();
                }
            }

        }

        //Confirm Password
        public void label8_Click(object sender, EventArgs e)
        {
            checkGlow();

            //Check previous if correct
            if (glowPassword.Visible == true)
            {
                //change the label to show the condition
                labelRegistration.Text = "                              Confirm Password";
                labelRegistration.ForeColor = Color.MediumPurple;

                label8.Visible = false;
                textBoxCPassword.Focus();
            }
             
        }
            //Text Box
        public void textBoxCPassword_KeyDown(object sender, KeyEventArgs e)
        {
            //change the label to show the condition
            labelRegistration.Text = "                              Confirm Password";
            labelRegistration.ForeColor = Color.MediumPurple;

            // Condition with Real-time checker
            if (textBoxCPassword.Text == textBoxPassword.Text)
            {
                glowCPassword.Visible = true;
            }
            else
            {
                glowCPassword.Visible = false;
            }

            //User hit enter
            if (e.KeyCode == Keys.Enter)
            {
                //No input
                if (string.IsNullOrEmpty(textBoxCPassword.Text) || textBoxCPassword.Text == "Confirm Password")
                {
                    textBoxCPassword.Text = string.Empty;
                }

                //Error input
                if (glowCPassword.Visible == false)
                {
                    labelRegistration.ForeColor = Color.Crimson;
                }
                //Correct input
                else
                {
                    btnSignup.Focus();
                }
            }
        }

        // Sign up button
        private void btnSignup_Click(object sender, EventArgs e)
        {
            NewMainPanel NewmainPanel = new NewMainPanel();
            NewmainPanel.Show();
            this.Hide();

            checkGlow();
            //If all circles are glowing, the account will be registered
            if (glowCPassword.Visible == true)
            {
                //Account registration
            }
        }

       
    }
}
