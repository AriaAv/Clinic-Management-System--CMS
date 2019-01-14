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
    public partial class frmInsert : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        CurrencyManager cr;
        public frmInsert()
        {
            InitializeComponent();
        }
        private void btninsertexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInsert_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\clinic.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            fillgrid("");
            ToolTip tp = new ToolTip();
            tp.AutoPopDelay = 5000;
            tp.InitialDelay = 1000;
            tp.ReshowDelay = 500;
            tp.ShowAlways = true;
            tp.SetToolTip(this.btnsearch, "جستجو بر اساس شماره پرونده می باشد");
            tp.SetToolTip(this.btnedit, "ویرایش شماره پرونده امکان پذیر نیست");


        }
        void fillgrid(string s)
        {
            if (s == "")
                s = "select * from tb_case";
            cmd.CommandText = s;
            cmd.Connection = con;
            da.SelectCommand = cmd;
            ds.Clear();
            da.Fill(ds, "tb_case");
            dgvinsert.DataBindings.Clear();
            dgvinsert.DataBindings.Add("datasource", ds, "tb_case");
            txtnumber.DataBindings.Clear();
            txtnumber.DataBindings.Add("text", ds, "tb_case.شماره پرونده");
            txtname.DataBindings.Clear();
            txtname.DataBindings.Add("text", ds, "tb_case.نام");
            txtfamily.DataBindings.Clear();
            txtfamily.DataBindings.Add("text", ds, "tb_case.نام خانوادگی");
            txtsx.DataBindings.Clear();
            txtsx.DataBindings.Add("text", ds, "tb_case.جنسیت");
            txtinsurancename.DataBindings.Clear();
            txtinsurancename.DataBindings.Add("text", ds, "tb_case.نوع بیمه");
            txtinsurancenum.DataBindings.Clear();
            txtinsurancenum.DataBindings.Add("text", ds, "tb_case.شماره بیمه");
            txtbirth.DataBindings.Clear();
            txtbirth.DataBindings.Add("text", ds, "tb_case.تاریخ تولد");
            txtidnum.DataBindings.Clear();
            txtidnum.DataBindings.Add("text", ds, "tb_case.کد ملی");
            txttell.DataBindings.Clear();
            txttell.DataBindings.Add("text", ds, "tb_case.تلفن");
            txtcodetashkhis.DataBindings.Clear();
            txtcodetashkhis.DataBindings.Add("text", ds, "tb_case.کد تشخیص");
            txtcodeaza.DataBindings.Clear();
            txtcodeaza.DataBindings.Add("text", ds, "tb_case.کد اعضا");
            txtcodedarman.DataBindings.Clear();
            txtcodedarman.DataBindings.Add("text", ds, "tb_case.کدهای درمانی");
            txtaddress.DataBindings.Clear();
            txtaddress.DataBindings.Add("text", ds, "tb_case.آدرس");
            txtother.DataBindings.Clear();
            txtother.DataBindings.Add("text", ds, "tb_case.توضیحات");
            cr = (CurrencyManager)this.BindingContext[ds, "tb_case"];
        }
        private void dgvinsert_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cr.Position = e.RowIndex;
        }
        private void btndelete_Click(object sender, EventArgs e)
    {
        DialogResult x;
        x = MessageBox.Show("آیا از حذف "+txtname.Text+" "+txtfamily.Text+"  اطمینان دارید؟", "حذف کردن", MessageBoxButtons.YesNo);
        if (x == DialogResult.Yes)
        {
        SqlCommand dc = new SqlCommand();
        dc.CommandText = "delete from tb_case where نام=@p1 and [نام خانوادگی]=@p2 and [شماره پرونده]=@p3";
        dc.Parameters.AddWithValue("p1", txtname.Text);
        dc.Parameters.AddWithValue("p2", txtfamily.Text);
        dc.Parameters.AddWithValue("p3", txtnumber.Text);
        dc.Connection = con;
        dc.ExecuteNonQuery();
        fillgrid("");
        }
    }
        private void btnadd_Click(object sender, EventArgs e)
        {
            txtnumber.Text = "";
            txtname.Text = "";
            txtfamily.Text = "";
            txtsx.Text = "";
            txtinsurancename.Text = "";
            txtinsurancenum.Text = "";
            txtbirth.Text = "";
            txtidnum.Text = "";
            txttell.Text = "";
            txtcodetashkhis.Text = "";
            txtcodeaza.Text = "";
            txtcodedarman.Text = "";
            txtaddress.Text = "";
            txtother.Text = "";
            txtname.Focus();

            SqlCommand w = new SqlCommand();
            w.CommandText = "select max([شماره پرونده]) from tb_case";
            w.Connection = con;
            int max = Convert.ToInt32(w.ExecuteScalar()) + 1;
            txtnumber.Text = Convert.ToString(max);
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand c1 = new SqlCommand();
            if (txtinsurancename.Text == "تامین اجتماعی")
            {
                if (txtinsurancenum.TextLength != 8)
                {
                    MessageBox.Show("شماره بیمه صحیح وارد نشده است. باید 8 رقم باشد");
                    goto j1;
                }
                else goto s1;
            }
            else if (txtinsurancename.Text == "خدمات درمانی")
            {
                if (txtinsurancenum.TextLength != 10)
                {
                    MessageBox.Show("شماره بیمه صحیح وارد نشده است. باید 10 رقم باشد");
                    goto j1;
                }
                else goto s1;
            }
            else if (txtinsurancename.Text == "نیروهای مسلح")
            {
                if (txtinsurancenum.TextLength != 7)
                {
                    MessageBox.Show("شماره بیمه صحیح وارد نشده است. باید 7 رقم باشد");
                    goto j1;
                }
                else goto s1;
            }
            else if (txtinsurancename.Text == "ایران")
            {
                if (txtinsurancenum.TextLength != 6)
                {
                    MessageBox.Show("شماره بیمه صحیح وارد نشده است. باید 6 رقم باشد");
                    goto j1;
                }
                else goto s1;
            }
            else goto s1;
        s1:
            c1.CommandText = "insert into tb_case values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)";
            c1.Parameters.AddWithValue("p1", txtnumber.Text);
            c1.Parameters.AddWithValue("p2", txtname.Text);
            c1.Parameters.AddWithValue("p3", txtfamily.Text);
            c1.Parameters.AddWithValue("p4", txtsx.Text);
            c1.Parameters.AddWithValue("p5", txtinsurancename.Text);
            c1.Parameters.AddWithValue("p6", txtinsurancenum.Text);
            c1.Parameters.AddWithValue("p7", txtbirth.Text);
            c1.Parameters.AddWithValue("p8", txtidnum.Text);
            c1.Parameters.AddWithValue("p9", txttell.Text);
            c1.Parameters.AddWithValue("p10", txtcodetashkhis.Text);
            c1.Parameters.AddWithValue("p11", txtcodeaza.Text);
            c1.Parameters.AddWithValue("p12", txtcodedarman.Text);
            c1.Parameters.AddWithValue("p13", txtaddress.Text);
            c1.Parameters.AddWithValue("p14", txtother.Text);
            c1.Connection = con;
            c1.ExecuteNonQuery();
            fillgrid("");
        j1:
            ;
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string s;
            s = "select * from tb_case where [شماره پرونده] like '" + txtsearch.Text + "%'";
            fillgrid(s);
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            btnsearch_Click(null, null);
        }
        private void txtsearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtsearch.Text = "";
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "update tb_case set نام=@p2, [نام خانوادگی]=@p3, جنسیت=@p4, [نوع بیمه]=@p5, [شماره بیمه]=@p6, [تاریخ تولد]=@p7, [کد ملی]=@p8, تلفن=@p9, [کد تشخیص]=@p10, [کد اعضا]=@p11, [کدهای درمانی]=@p12, آدرس=@p13, توضیحات=@p14 where [شماره پرونده]=@p1";
            c1.Parameters.AddWithValue("p1", txtnumber.Text);
            c1.Parameters.AddWithValue("p2", txtname.Text);
            c1.Parameters.AddWithValue("p3", txtfamily.Text);
            c1.Parameters.AddWithValue("p4", txtsx.Text);
            c1.Parameters.AddWithValue("p5", txtinsurancename.Text);
            c1.Parameters.AddWithValue("p6", txtinsurancenum.Text);
            c1.Parameters.AddWithValue("p7", txtbirth.Text);
            c1.Parameters.AddWithValue("p8", txtidnum.Text);
            c1.Parameters.AddWithValue("p9", txttell.Text);
            c1.Parameters.AddWithValue("p10", txtcodetashkhis.Text);
            c1.Parameters.AddWithValue("p11", txtcodeaza.Text);
            c1.Parameters.AddWithValue("p12", txtcodedarman.Text);
            c1.Parameters.AddWithValue("p13", txtaddress.Text);
            c1.Parameters.AddWithValue("p14", txtother.Text);
            c1.Connection = con;
            c1.ExecuteNonQuery();
            fillgrid("");
        }
    }
}
