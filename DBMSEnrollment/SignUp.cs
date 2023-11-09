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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Validation for emailaddress and password from user table
            //................
            //Hash Password
            
            if(tbSignUp_Pass.Text == tbSignUp_Pass2.Text)
            {
                /*try
                {

                }
                catch
                {
                    MessageBox.Show("Unsuccessfull Signing Up", "Error", MessageBoxButtons.OK);
                }*/

                DialogResult signupmsgboxsuccess = MessageBox.Show("Successfully Signed Up\nReturnin to Login Page", "Sign Up Success", MessageBoxButtons.OK);
                if (signupmsgboxsuccess == DialogResult.OK)
                {
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Unsuccessfull Signing Up\nCheck Your Password", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
