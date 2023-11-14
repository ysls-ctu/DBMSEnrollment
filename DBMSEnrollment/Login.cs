﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSEnrollment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Check acc in db
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //code to open sign up form
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            //code to open forgotpass form
        }
    }
}
