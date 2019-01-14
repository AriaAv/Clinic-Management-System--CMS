namespace Clinic_Managment_System
{
    partial class frmInsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsert));
            this.lblnumber = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblfamily = new System.Windows.Forms.Label();
            this.lblsx = new System.Windows.Forms.Label();
            this.lblinsurancename = new System.Windows.Forms.Label();
            this.lblinsurancenum = new System.Windows.Forms.Label();
            this.lblbirth = new System.Windows.Forms.Label();
            this.lbltell = new System.Windows.Forms.Label();
            this.lblidnum = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblother = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtbirth = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtother = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txttell = new System.Windows.Forms.TextBox();
            this.txtfamily = new System.Windows.Forms.TextBox();
            this.txtinsurancenum = new System.Windows.Forms.TextBox();
            this.txtidnum = new System.Windows.Forms.TextBox();
            this.dgvinsert = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btninsertexit = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtcodeaza = new System.Windows.Forms.TextBox();
            this.txtcodedarman = new System.Windows.Forms.TextBox();
            this.txtcodetashkhis = new System.Windows.Forms.TextBox();
            this.lblcodeaza = new System.Windows.Forms.Label();
            this.lblcodedarman = new System.Windows.Forms.Label();
            this.lblcodetashkhis = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtsx = new System.Windows.Forms.ComboBox();
            this.txtinsurancename = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinsert)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(494, 27);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblnumber.Size = new System.Drawing.Size(72, 13);
            this.lblnumber.TabIndex = 0;
            this.lblnumber.Text = "شماره پرونده:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(313, 27);
            this.lblname.Name = "lblname";
            this.lblname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblname.Size = new System.Drawing.Size(23, 13);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "نام:";
            // 
            // lblfamily
            // 
            this.lblfamily.AutoSize = true;
            this.lblfamily.Location = new System.Drawing.Point(126, 27);
            this.lblfamily.Name = "lblfamily";
            this.lblfamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblfamily.Size = new System.Drawing.Size(72, 13);
            this.lblfamily.TabIndex = 2;
            this.lblfamily.Text = "نام حانوادگی:";
            // 
            // lblsx
            // 
            this.lblsx.AutoSize = true;
            this.lblsx.Location = new System.Drawing.Point(494, 53);
            this.lblsx.Name = "lblsx";
            this.lblsx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblsx.Size = new System.Drawing.Size(42, 13);
            this.lblsx.TabIndex = 3;
            this.lblsx.Text = "جنسیت:";
            // 
            // lblinsurancename
            // 
            this.lblinsurancename.AutoSize = true;
            this.lblinsurancename.Location = new System.Drawing.Point(313, 53);
            this.lblinsurancename.Name = "lblinsurancename";
            this.lblinsurancename.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblinsurancename.Size = new System.Drawing.Size(48, 13);
            this.lblinsurancename.TabIndex = 4;
            this.lblinsurancename.Text = "نوع بیمه:";
            // 
            // lblinsurancenum
            // 
            this.lblinsurancenum.AutoSize = true;
            this.lblinsurancenum.Location = new System.Drawing.Point(126, 53);
            this.lblinsurancenum.Name = "lblinsurancenum";
            this.lblinsurancenum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblinsurancenum.Size = new System.Drawing.Size(60, 13);
            this.lblinsurancenum.TabIndex = 5;
            this.lblinsurancenum.Text = "شماره بیمه:";
            // 
            // lblbirth
            // 
            this.lblbirth.AutoSize = true;
            this.lblbirth.Location = new System.Drawing.Point(490, 79);
            this.lblbirth.Name = "lblbirth";
            this.lblbirth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblbirth.Size = new System.Drawing.Size(56, 13);
            this.lblbirth.TabIndex = 6;
            this.lblbirth.Text = "تاریخ تولد:";
            // 
            // lbltell
            // 
            this.lbltell.AutoSize = true;
            this.lbltell.Location = new System.Drawing.Point(126, 79);
            this.lbltell.Name = "lbltell";
            this.lbltell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbltell.Size = new System.Drawing.Size(29, 13);
            this.lbltell.TabIndex = 7;
            this.lbltell.Text = "تلفن:";
            // 
            // lblidnum
            // 
            this.lblidnum.AutoSize = true;
            this.lblidnum.Location = new System.Drawing.Point(313, 79);
            this.lblidnum.Name = "lblidnum";
            this.lblidnum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblidnum.Size = new System.Drawing.Size(43, 13);
            this.lblidnum.TabIndex = 8;
            this.lblidnum.Text = "کد ملی:";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(494, 131);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbladdress.Size = new System.Drawing.Size(33, 13);
            this.lbladdress.TabIndex = 9;
            this.lbladdress.Text = "آدرس:";
            // 
            // lblother
            // 
            this.lblother.AutoSize = true;
            this.lblother.Location = new System.Drawing.Point(494, 157);
            this.lblother.Name = "lblother";
            this.lblother.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblother.Size = new System.Drawing.Size(52, 13);
            this.lblother.TabIndex = 10;
            this.lblother.Text = "توضیحات:";
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(388, 24);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtnumber.Size = new System.Drawing.Size(100, 20);
            this.txtnumber.TabIndex = 0;
            // 
            // txtbirth
            // 
            this.txtbirth.Location = new System.Drawing.Point(388, 76);
            this.txtbirth.Name = "txtbirth";
            this.txtbirth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbirth.Size = new System.Drawing.Size(100, 20);
            this.txtbirth.TabIndex = 6;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(20, 128);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtaddress.Size = new System.Drawing.Size(468, 20);
            this.txtaddress.TabIndex = 12;
            // 
            // txtother
            // 
            this.txtother.Location = new System.Drawing.Point(20, 154);
            this.txtother.Name = "txtother";
            this.txtother.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtother.Size = new System.Drawing.Size(468, 20);
            this.txtother.TabIndex = 13;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(207, 24);
            this.txtname.Name = "txtname";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 1;
            // 
            // txttell
            // 
            this.txttell.Location = new System.Drawing.Point(20, 76);
            this.txttell.Name = "txttell";
            this.txttell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttell.Size = new System.Drawing.Size(100, 20);
            this.txttell.TabIndex = 8;
            // 
            // txtfamily
            // 
            this.txtfamily.Location = new System.Drawing.Point(20, 24);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtfamily.Size = new System.Drawing.Size(100, 20);
            this.txtfamily.TabIndex = 2;
            // 
            // txtinsurancenum
            // 
            this.txtinsurancenum.Location = new System.Drawing.Point(20, 50);
            this.txtinsurancenum.Name = "txtinsurancenum";
            this.txtinsurancenum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtinsurancenum.Size = new System.Drawing.Size(100, 20);
            this.txtinsurancenum.TabIndex = 5;
            // 
            // txtidnum
            // 
            this.txtidnum.Location = new System.Drawing.Point(207, 76);
            this.txtidnum.Name = "txtidnum";
            this.txtidnum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtidnum.Size = new System.Drawing.Size(100, 20);
            this.txtidnum.TabIndex = 7;
            // 
            // dgvinsert
            // 
            this.dgvinsert.AllowUserToAddRows = false;
            this.dgvinsert.AllowUserToDeleteRows = false;
            this.dgvinsert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvinsert.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvinsert.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.dgvinsert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinsert.Location = new System.Drawing.Point(12, 229);
            this.dgvinsert.Name = "dgvinsert";
            this.dgvinsert.ReadOnly = true;
            this.dgvinsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvinsert.Size = new System.Drawing.Size(559, 287);
            this.dgvinsert.TabIndex = 20;
            this.dgvinsert.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinsert_CellClick);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btndelete.Location = new System.Drawing.Point(326, 189);
            this.btndelete.Name = "btndelete";
            this.btndelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 17;
            this.btndelete.Text = "حذف";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnedit.Location = new System.Drawing.Point(407, 189);
            this.btnedit.Name = "btnedit";
            this.btnedit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 16;
            this.btnedit.Text = "ویرایش";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnadd.Location = new System.Drawing.Point(488, 189);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 15;
            this.btnadd.Text = "جدید";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btninsertexit
            // 
            this.btninsertexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btninsertexit.Location = new System.Drawing.Point(20, 525);
            this.btninsertexit.Name = "btninsertexit";
            this.btninsertexit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btninsertexit.Size = new System.Drawing.Size(75, 28);
            this.btninsertexit.TabIndex = 26;
            this.btninsertexit.Text = "خروج";
            this.btninsertexit.UseVisualStyleBackColor = false;
            this.btninsertexit.Click += new System.EventHandler(this.btninsertexit_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnsearch.Location = new System.Drawing.Point(150, 189);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 19;
            this.btnsearch.Text = "جستجو";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtcodeaza
            // 
            this.txtcodeaza.Location = new System.Drawing.Point(207, 102);
            this.txtcodeaza.Name = "txtcodeaza";
            this.txtcodeaza.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcodeaza.Size = new System.Drawing.Size(100, 20);
            this.txtcodeaza.TabIndex = 10;
            // 
            // txtcodedarman
            // 
            this.txtcodedarman.Location = new System.Drawing.Point(20, 102);
            this.txtcodedarman.Name = "txtcodedarman";
            this.txtcodedarman.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcodedarman.Size = new System.Drawing.Size(100, 20);
            this.txtcodedarman.TabIndex = 11;
            // 
            // txtcodetashkhis
            // 
            this.txtcodetashkhis.Location = new System.Drawing.Point(388, 102);
            this.txtcodetashkhis.Name = "txtcodetashkhis";
            this.txtcodetashkhis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcodetashkhis.Size = new System.Drawing.Size(100, 20);
            this.txtcodetashkhis.TabIndex = 9;
            // 
            // lblcodeaza
            // 
            this.lblcodeaza.AutoSize = true;
            this.lblcodeaza.Location = new System.Drawing.Point(313, 105);
            this.lblcodeaza.Name = "lblcodeaza";
            this.lblcodeaza.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblcodeaza.Size = new System.Drawing.Size(48, 13);
            this.lblcodeaza.TabIndex = 30;
            this.lblcodeaza.Text = "کد اعضا:";
            // 
            // lblcodedarman
            // 
            this.lblcodedarman.AutoSize = true;
            this.lblcodedarman.Location = new System.Drawing.Point(126, 105);
            this.lblcodedarman.Name = "lblcodedarman";
            this.lblcodedarman.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblcodedarman.Size = new System.Drawing.Size(79, 13);
            this.lblcodedarman.TabIndex = 29;
            this.lblcodedarman.Text = "کدهای درمانی:";
            // 
            // lblcodetashkhis
            // 
            this.lblcodetashkhis.AutoSize = true;
            this.lblcodetashkhis.Location = new System.Drawing.Point(490, 105);
            this.lblcodetashkhis.Name = "lblcodetashkhis";
            this.lblcodetashkhis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblcodetashkhis.Size = new System.Drawing.Size(60, 13);
            this.lblcodetashkhis.TabIndex = 28;
            this.lblcodetashkhis.Text = "کد تشخیص:";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(20, 191);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsearch.Size = new System.Drawing.Size(124, 20);
            this.txtsearch.TabIndex = 14;
            this.txtsearch.Text = "جستجو با شماره پرونده...";
            this.txtsearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtsearch_MouseClick);
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnsave.Location = new System.Drawing.Point(245, 188);
            this.btnsave.Name = "btnsave";
            this.btnsave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "ذخیره";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtsx
            // 
            this.txtsx.FormattingEnabled = true;
            this.txtsx.Items.AddRange(new object[] {
            "زن",
            "مرد"});
            this.txtsx.Location = new System.Drawing.Point(388, 49);
            this.txtsx.Name = "txtsx";
            this.txtsx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsx.Size = new System.Drawing.Size(100, 21);
            this.txtsx.TabIndex = 31;
            // 
            // txtinsurancename
            // 
            this.txtinsurancename.FormattingEnabled = true;
            this.txtinsurancename.Items.AddRange(new object[] {
            "خدمات درمانی",
            "تامین اجتماعی",
            "نیروهای مسلح",
            "ایران"});
            this.txtinsurancename.Location = new System.Drawing.Point(207, 50);
            this.txtinsurancename.Name = "txtinsurancename";
            this.txtinsurancename.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtinsurancename.Size = new System.Drawing.Size(100, 21);
            this.txtinsurancename.TabIndex = 32;
            // 
            // frmInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(196)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(583, 560);
            this.Controls.Add(this.txtinsurancename);
            this.Controls.Add(this.txtsx);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txtcodeaza);
            this.Controls.Add(this.txtcodedarman);
            this.Controls.Add(this.txtcodetashkhis);
            this.Controls.Add(this.lblcodeaza);
            this.Controls.Add(this.lblcodedarman);
            this.Controls.Add(this.lblcodetashkhis);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btninsertexit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dgvinsert);
            this.Controls.Add(this.txtidnum);
            this.Controls.Add(this.txtinsurancenum);
            this.Controls.Add(this.txtfamily);
            this.Controls.Add(this.txttell);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtother);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtbirth);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.lblother);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblidnum);
            this.Controls.Add(this.lbltell);
            this.Controls.Add(this.lblbirth);
            this.Controls.Add(this.lblinsurancenum);
            this.Controls.Add(this.lblinsurancename);
            this.Controls.Add(this.lblsx);
            this.Controls.Add(this.lblfamily);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblnumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(599, 599);
            this.MinimumSize = new System.Drawing.Size(599, 599);
            this.Name = "frmInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات بیماران";
            this.Load += new System.EventHandler(this.frmInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinsert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblfamily;
        private System.Windows.Forms.Label lblsx;
        private System.Windows.Forms.Label lblinsurancename;
        private System.Windows.Forms.Label lblinsurancenum;
        private System.Windows.Forms.Label lblbirth;
        private System.Windows.Forms.Label lbltell;
        private System.Windows.Forms.Label lblidnum;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblother;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtbirth;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtother;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttell;
        private System.Windows.Forms.TextBox txtfamily;
        private System.Windows.Forms.TextBox txtinsurancenum;
        private System.Windows.Forms.TextBox txtidnum;
        private System.Windows.Forms.DataGridView dgvinsert;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btninsertexit;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtcodeaza;
        private System.Windows.Forms.TextBox txtcodedarman;
        private System.Windows.Forms.TextBox txtcodetashkhis;
        private System.Windows.Forms.Label lblcodeaza;
        private System.Windows.Forms.Label lblcodedarman;
        private System.Windows.Forms.Label lblcodetashkhis;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox txtsx;
        private System.Windows.Forms.ComboBox txtinsurancename;
    }
}