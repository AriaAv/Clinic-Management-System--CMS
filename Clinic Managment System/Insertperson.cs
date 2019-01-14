using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Clinic_Managment_System
{
    public partial class frmInsertperson : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        CurrencyManager cr;
        public frmInsertperson()
        {
            InitializeComponent();
        }
        private void btninsertpersonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmInsertperson_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\clinic.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            fillgrid("");
            ToolTip tp = new ToolTip();
            tp.AutoPopDelay = 5000;
            tp.InitialDelay = 1000;
            tp.ReshowDelay = 500;
            tp.ShowAlways = true;
            tp.SetToolTip(this.btninsertpersonsearch, "جستجو بر اساس کد ملی می باشد");
            tp.SetToolTip(this.btninsertpersonedit, "ویرایش کد ملی امکان پذیر نیست");
        }
        void fillgrid(string s)
        {
            if (s == "")
                s = "select * from tb_person";
            cmd.CommandText = s;
            cmd.Connection = con;
            da.SelectCommand = cmd;
            ds.Clear();
            da.Fill(ds, "tb_person");
            dgvinsertperson.DataBindings.Clear();
            dgvinsertperson.DataBindings.Add("datasource", ds, "tb_person");
            txtpersonname.DataBindings.Clear();
            txtpersonname.DataBindings.Add("text", ds, "tb_person.نام");
            txtpersonfamily.DataBindings.Clear();
            txtpersonfamily.DataBindings.Add("text", ds, "tb_person.نام خانوادگی");
            txtpersonidnum.DataBindings.Clear();
            txtpersonidnum.DataBindings.Add("text", ds, "tb_person.کد ملی");
            txtpersonid.DataBindings.Clear();
            txtpersonid.DataBindings.Add("text", ds, "tb_person.کد نظام پزشکی");
            txtpersoncode.DataBindings.Clear();
            txtpersoncode.DataBindings.Add("text", ds, "tb_person.کد تخصص");
            txtpersonskill.DataBindings.Clear();
            txtpersonskill.DataBindings.Add("text", ds, "tb_person.تخصص");
            txtpersonlevel.DataBindings.Clear();
            txtpersonlevel.DataBindings.Add("text", ds, "tb_person.سطح");
            txtpersonaddress.DataBindings.Clear();
            txtpersonaddress.DataBindings.Add("text", ds, "tb_person.آدرس");
            txtpersontell.DataBindings.Clear();
            txtpersontell.DataBindings.Add("text", ds, "tb_person.تلفن");
            txtpersonother.DataBindings.Clear();
            txtpersonother.DataBindings.Add("text", ds, "tb_person.توضیحات");
            cr = (CurrencyManager)this.BindingContext[ds, "tb_person"];
        }
        private void dgvinsertperson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cr.Position = e.RowIndex;
        }
        private void btninsertpersondelete_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("آیا از حذف "+txtpersonname.Text+" "+txtpersonfamily.Text+"  اطمینان دارید؟", "حذف کردن", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
            SqlCommand dc = new SqlCommand();
            dc.CommandText = "delete from tb_person where نام=@p1 and [نام خانوادگی]=@p2";
            dc.Parameters.AddWithValue("p1", txtpersonname.Text);
            dc.Parameters.AddWithValue("p2", txtpersonfamily.Text);
            dc.Connection = con;
            dc.ExecuteNonQuery();
            fillgrid("");
            }
        }
        private void btninsertpersonadd_Click(object sender, EventArgs e)
        {
            txtpersonname.Text = "";
            txtpersonfamily.Text = "";
            txtpersonidnum.Text = "";
            txtpersonid.Text = "";
            txtpersoncode.Text = "";
            txtpersonskill.Text = "";
            txtpersonlevel.Text = "";
            txtpersonaddress.Text = "";
            txtpersontell.Text = "";
            txtpersonother.Text = "";
            txtpersonname.Focus();
        }
        private void btnpersonsave_Click(object sender, EventArgs e)
        {
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "insert into tb_person values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
            c1.Parameters.AddWithValue("p1", txtpersonname.Text);
            c1.Parameters.AddWithValue("p2", txtpersonfamily.Text);
            c1.Parameters.AddWithValue("p3", txtpersonidnum.Text);
            c1.Parameters.AddWithValue("p4", txtpersonid.Text);
            c1.Parameters.AddWithValue("p5", txtpersoncode.Text);
            c1.Parameters.AddWithValue("p6", txtpersonskill.Text);
            c1.Parameters.AddWithValue("p7", txtpersonlevel.Text);
            c1.Parameters.AddWithValue("p8", txtpersonaddress.Text);
            c1.Parameters.AddWithValue("p9", txtpersontell.Text);
            c1.Parameters.AddWithValue("p10", txtpersonother.Text);
            c1.Connection = con;
            c1.ExecuteNonQuery();
            fillgrid("");
        }
        private void btninsertpersonsearch_Click(object sender, EventArgs e)
        {
            string s;
            s = "select * from tb_person where [کد ملی] like '" + txtpersonsearch.Text + "%'";
            fillgrid(s);
        }
        private void txtpersonsearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtpersonsearch.Text = "";
        }
        private void btninsertpersonedit_Click(object sender, EventArgs e)
        {
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "update tb_person set نام=@p1, [نام خانوادگی]=@p2, [کد نظام پزشکی]=@p4, [کد تخصص]=@p5, تخصص=@p6, سطح=@p7, آدرس=@p8, تلفن=@p9, توضیحات=@p10 where [کد ملی]=@p3";
            c1.Parameters.AddWithValue("p1", txtpersonname.Text);
            c1.Parameters.AddWithValue("p2", txtpersonfamily.Text);
            c1.Parameters.AddWithValue("p3", txtpersonidnum.Text);
            c1.Parameters.AddWithValue("p4", txtpersonid.Text);
            c1.Parameters.AddWithValue("p5", txtpersoncode.Text);
            c1.Parameters.AddWithValue("p6", txtpersonskill.Text);
            c1.Parameters.AddWithValue("p7", txtpersonlevel.Text);
            c1.Parameters.AddWithValue("p8", txtpersonaddress.Text);
            c1.Parameters.AddWithValue("p9", txtpersontell.Text);
            c1.Parameters.AddWithValue("p10", txtpersonother.Text);
            c1.Connection = con;
            c1.ExecuteNonQuery();
            fillgrid("");
        }
        private void txtpersonsearch_TextChanged(object sender, EventArgs e)
        {
            btninsertpersonsearch_Click(null, null);
        }
    }
}
