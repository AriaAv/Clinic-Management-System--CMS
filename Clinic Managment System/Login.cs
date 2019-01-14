using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinic_Managment_System
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnloginexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnloginok_Click(object sender, EventArgs e)
        {
            if (txtloginuser.Text == "1234" & txtloginpass.Text == "1234")
            {
                this.Close();
            }
            else
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
        }

        private void frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = e.CloseReason == CloseReason.TaskManagerClosing;
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void lblloginuser_Click(object sender, EventArgs e)
        {

        }

        private void lbllogintitle_Click(object sender, EventArgs e)
        {

        }

        private void lblloginpass_Click(object sender, EventArgs e)
        {

        }

        private void txtloginpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtloginuser_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
