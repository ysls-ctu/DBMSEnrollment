using System;
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
    public partial class Form2 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
       
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFName.Text = string.Empty;
            tbMName.Text = string.Empty;
            tbLName.Text = string.Empty;
            dtpBDay.Text = DateTime.Now.ToString();
            cbGender.Text = string.Empty;
            tbMobile.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbAddress.Text = string.Empty;
            cbYearLvl.Text = string.Empty;
            cbSched.Text = string.Empty;
        }

        private void dgvDisplayEnrolled_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewdata() 
        {
            dgvDisplayEnrolled.DataSource = db.sp_user_view();
        }
    }
}
