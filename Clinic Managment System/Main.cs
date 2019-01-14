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
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            frmInsert f = new frmInsert();
            f.ShowDialog(this);
        }

        private void btninsertperson_Click(object sender, EventArgs e)
        {
            frmInsertperson f = new frmInsertperson();
            f.ShowDialog(this);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            frmlogin f = new frmlogin();
            f.ShowDialog(this);
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("این نرم افزار با موضوع سیستم مدیریت مرکز فیزیوتراپی جهت ارائه به عنوان پروژه برنامه نویسی دانشگاه سما کرج نوشته شده است");
        }
    }
}
