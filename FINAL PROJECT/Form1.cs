﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace FINAL_PROJECT
{
    public partial class Login : KryptonForm
    {
        public static Login _login;
        public Login()
        {
            InitializeComponent();
        }

        // Go to Signup
        private void label4_Click(object sender, EventArgs e)
        {
            if (SignUp._signUp == null)
            {
                SignUp signUpForm = new SignUp();
                SignUp._signUp = signUpForm;
                signUpForm.Show();
                this.Hide();
            }
            else 
            {
                SignUp._signUp.Show();
                this.Hide();
            }
            
            
            
            
        }

        //Minimize
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Close
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //show password
        private bool showPassword = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (showPassword)
            {
                loginPassword.PasswordChar = '•'; // Hide password
                showPass.Image = Properties.Resources.Login__HidePass___1_;
            }
            else
            {
                loginPassword.PasswordChar = '\0'; // Show password as plain text
                showPass.Image = Properties.Resources.Login__ShowPass_;
            }
            showPassword = !showPassword;
        }

        //loginBtton
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //code for data base

            NewMainPanel mainPanel = new NewMainPanel();
            NewMainPanel._newMainPanelInstance = mainPanel;
            mainPanel.Show();
            if (SignUp._signUp != null)
            {
                SignUp._signUp.Dispose();
            }
            
            this.Hide();
      
        }
    }
}
