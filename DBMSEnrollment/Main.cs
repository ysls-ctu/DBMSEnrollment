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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnMain_EnrollTracker_Click(object sender, EventArgs e)
        {
            //Code for tracker form
            EnrollTracker enrollTracker = new EnrollTracker();
            this.Hide();
            enrollTracker.ShowDialog();
        }

        private void btnMain_EnrollForm_Click(object sender, EventArgs e)
        {
           
            //code for enroll form
            EnrollmentForm enrollform = new EnrollmentForm();
            this.Hide();
            enrollform.ShowDialog();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pbMain_AccSettings_Click(object sender, EventArgs e)
        {
            //for account settings
        }

        private void btnMain_Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}
