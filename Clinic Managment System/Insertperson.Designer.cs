namespace Clinic_Managment_System
{
    partial class frmInsertperson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertperson));
            this.lblpersonname = new System.Windows.Forms.Label();
            this.lblpersonid = new System.Windows.Forms.Label();
            this.lblpersonlevel = new System.Windows.Forms.Label();
            this.lblpersonfamily = new System.Windows.Forms.Label();
            this.lblpersoncode = new System.Windows.Forms.Label();
            this.lblpersonidnum = new System.Windows.Forms.Label();
            this.lblpersonskill = new System.Windows.Forms.Label();
            this.lblpersonaddress = new System.Windows.Forms.Label();
            this.txtpersonlevel = new System.Windows.Forms.TextBox();
            this.txtpersonid = new System.Windows.Forms.TextBox();
            this.txtpersonname = new System.Windows.Forms.TextBox();
            this.txtpersonaddress = new System.Windows.Forms.TextBox();
            this.txtpersoncode = new System.Windows.Forms.TextBox();
            this.txtpersonfamily = new System.Windows.Forms.TextBox();
            this.txtpersonidnum = new System.Windows.Forms.TextBox();
            this.txtpersonskill = new System.Windows.Forms.TextBox();
            this.btninsertpersonsearch = new System.Windows.Forms.Button();
            this.btninsertpersonexit = new System.Windows.Forms.Button();
            this.btninsertpersonadd = new System.Windows.Forms.Button();
            this.btninsertpersonedit = new System.Windows.Forms.Button();
            this.btninsertpersondelete = new System.Windows.Forms.Button();
            this.dgvinsertperson = new System.Windows.Forms.DataGridView();
            this.lblpersontell = new System.Windows.Forms.Label();
            this.txtpersontell = new System.Windows.Forms.TextBox();
            this.txtpersonother = new System.Windows.Forms.TextBox();
            this.lblpersonother = new System.Windows.Forms.Label();
            this.btnpersonsave = new System.Windows.Forms.Button();
            this.txtpersonsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinsertperson)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpersonname
            // 
            this.lblpersonname.AutoSize = true;
            this.lblpersonname.Location = new System.Drawing.Point(491, 26);
            this.lblpersonname.Name = "lblpersonname";
            this.lblpersonname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblpersonname.Size = new System.Drawing.Size(23, 13);
            this.lblpersonname.TabIndex = 0;
            this.lblpersonname.Text = "نام:";
            // 
            // lblpersonid
            // 
            this.lblpersonid.AutoSize = true;
            this.lblpersonid.Location = new System.Drawing.Point(491, 52);
            this.lblpersonid.Name = "lblpersonid";
            this.lblpersonid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblpersonid.Size = new System.Drawing.Size(83, 13);
            this.lblpersonid.TabIndex = 1;
            this.lblpersonid.Text = "کد نظام پزشکی:";
            // 
            // lblpersonlevel
            // 
            this.lblpersonlevel.AutoSize = true;
            this.lblpersonlevel.Location = new System.Drawing.Point(491, 78);
            this.lblpersonlevel.Name = "lblpersonlevel";
            this.lblpersonlevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblpersonlevel.Size = new System.Drawing.Size(34, 13);
            this.lblpersonlevel.TabIndex = 2;
            this.lblpersonlevel.Text = "سطح:";
            // 
            // lblpersonfamily
            // 
            this.lblpersonfamily.AutoSize = true;
            this.lblpersonfamily.Location = new System.Drawing.Point(293, 26);
            this.lblpersonfamily.Name = "lblpersonfamily";
            this.lblpersonfamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblpersonfamily.Size = new System.Drawing.Size(72, 13);
            this.lblpersonfamily.TabIndex = 3;
            this.lblpersonfamily.Text = "نام خانوادگی:";
            // 
            // lblpersoncode
            // 
            this.lblpersoncode.AutoSize = true;
            this.lblpersoncode.Location = new System.Drawing.Point(293, 52);
            this.lblpersoncode.Name = "lblpersoncode";
            this.lblpersoncode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblpersoncode.Size = new System.Drawing.Size(56, 13);
            this.lblpersoncode.TabIndex = 4;
            this.lblpersoncode.Text = "کد تخصص:";
            // 
            // lblpersonidnum
            // 
            this.lblpersonidnum.AutoSize = true;
            this.lblpersonidnum.Location = new System.Drawing.Point(127, 26);
            this.lblpersonidnum.Name = "lblpersonidnum";
            this.lblpersonidnum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblpersonidnum.Size = new System.Drawing.Size(43, 13);
            this.lblpersonidnum.TabIndex = 5;
            this.lblpersonidnum.Text = "کد ملی:";
            // 
            // lblpersonskill
            // 
            this.lblpersonskill.AutoSize = true;
            this.lblpersonskill.Location = new System.Drawing.Point(129, 52);
            this.lblpersonskill.Name = "lblpersonskill";
            this.lblpersonskill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblpersonskill.Size = new System.Drawing.Size(41, 13);
            this.lblpersonskill.TabIndex = 6;
            this.lblpersonskill.Text = "تخصص:";
            // 
            // lblpersonaddress
            // 
            this.lblpersonaddress.AutoSize = true;
            this.lblpersonaddress.Location = new System.Drawing.Point(293, 78);
            this.lblpersonaddress.Name = "lblpersonaddress";
            this.lblpersonaddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblpersonaddress.Size = new System.Drawing.Size(33, 13);
            this.lblpersonaddress.TabIndex = 7;
            this.lblpersonaddress.Text = "آدرس:";
            // 
            // txtpersonlevel
            // 
            this.txtpersonlevel.Location = new System.Drawing.Point(385, 75);
            this.txtpersonlevel.Name = "txtpersonlevel";
            this.txtpersonlevel.Size = new System.Drawing.Size(100, 20);
            this.txtpersonlevel.TabIndex = 6;
            // 
            // txtpersonid
            // 
            this.txtpersonid.Location = new System.Drawing.Point(385, 49);
            this.txtpersonid.Name = "txtpersonid";
            this.txtpersonid.Size = new System.Drawing.Size(100, 20);
            this.txtpersonid.TabIndex = 3;
            // 
            // txtpersonname
            // 
            this.txtpersonname.Location = new System.Drawing.Point(385, 23);
            this.txtpersonname.Name = "txtpersonname";
            this.txtpersonname.Size = new System.Drawing.Size(100, 20);
            this.txtpersonname.TabIndex = 0;
            // 
            // txtpersonaddress
            // 
            this.txtpersonaddress.Location = new System.Drawing.Point(21, 75);
            this.txtpersonaddress.Name = "txtpersonaddress";
            this.txtpersonaddress.Size = new System.Drawing.Size(266, 20);
            this.txtpersonaddress.TabIndex = 7;
            // 
            // txtpersoncode
            // 
            this.txtpersoncode.Location = new System.Drawing.Point(187, 49);
            this.txtpersoncode.Name = "txtpersoncode";
            this.txtpersoncode.Size = new System.Drawing.Size(100, 20);
            this.txtpersoncode.TabIndex = 4;
            // 
            // txtpersonfamily
            // 
            this.txtpersonfamily.Location = new System.Drawing.Point(187, 23);
            this.txtpersonfamily.Name = "txtpersonfamily";
            this.txtpersonfamily.Size = new System.Drawing.Size(100, 20);
            this.txtpersonfamily.TabIndex = 1;
            // 
            // txtpersonidnum
            // 
            this.txtpersonidnum.Location = new System.Drawing.Point(21, 23);
            this.txtpersonidnum.Name = "txtpersonidnum";
            this.txtpersonidnum.Size = new System.Drawing.Size(100, 20);
            this.txtpersonidnum.TabIndex = 2;
            // 
            // txtpersonskill
            // 
            this.txtpersonskill.Location = new System.Drawing.Point(21, 49);
            this.txtpersonskill.Name = "txtpersonskill";
            this.txtpersonskill.Size = new System.Drawing.Size(100, 20);
            this.txtpersonskill.TabIndex = 5;
            // 
            // btninsertpersonsearch
            // 
            this.btninsertpersonsearch.AccessibleDescription = "جستجو بر اساس نام و نام خانوادگی";
            this.btninsertpersonsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btninsertpersonsearch.Location = new System.Drawing.Point(151, 137);
            this.btninsertpersonsearch.Name = "btninsertpersonsearch";
            this.btninsertpersonsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btninsertpersonsearch.Size = new System.Drawing.Size(75, 23);
            this.btninsertpersonsearch.TabIndex = 15;
            this.btninsertpersonsearch.Text = "جستجو";
            this.btninsertpersonsearch.UseVisualStyleBackColor = false;
            this.btninsertpersonsearch.Click += new System.EventHandler(this.btninsertpersonsearch_Click);
            // 
            // btninsertpersonexit
            // 
            this.btninsertpersonexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btninsertpersonexit.Location = new System.Drawing.Point(32, 459);
            this.btninsertpersonexit.Name = "btninsertpersonexit";
            this.btninsertpersonexit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btninsertpersonexit.Size = new System.Drawing.Size(75, 27);
            this.btninsertpersonexit.TabIndex = 32;
            this.btninsertpersonexit.Text = "خروج";
            this.btninsertpersonexit.UseVisualStyleBackColor = false;
            this.btninsertpersonexit.Click += new System.EventHandler(this.btninsertpersonexit_Click);
            // 
            // btninsertpersonadd
            // 
            this.btninsertpersonadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btninsertpersonadd.Location = new System.Drawing.Point(491, 137);
            this.btninsertpersonadd.Name = "btninsertpersonadd";
            this.btninsertpersonadd.Size = new System.Drawing.Size(75, 23);
            this.btninsertpersonadd.TabIndex = 11;
            this.btninsertpersonadd.Text = "جدید";
            this.btninsertpersonadd.UseVisualStyleBackColor = false;
            this.btninsertpersonadd.Click += new System.EventHandler(this.btninsertpersonadd_Click);
            // 
            // btninsertpersonedit
            // 
            this.btninsertpersonedit.AccessibleDescription = "";
            this.btninsertpersonedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btninsertpersonedit.Location = new System.Drawing.Point(410, 137);
            this.btninsertpersonedit.Name = "btninsertpersonedit";
            this.btninsertpersonedit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btninsertpersonedit.Size = new System.Drawing.Size(75, 23);
            this.btninsertpersonedit.TabIndex = 12;
            this.btninsertpersonedit.Tag = "";
            this.btninsertpersonedit.Text = "ویرایش";
            this.btninsertpersonedit.UseVisualStyleBackColor = false;
            this.btninsertpersonedit.Click += new System.EventHandler(this.btninsertpersonedit_Click);
            // 
            // btninsertpersondelete
            // 
            this.btninsertpersondelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btninsertpersondelete.Location = new System.Drawing.Point(248, 137);
            this.btninsertpersondelete.Name = "btninsertpersondelete";
            this.btninsertpersondelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btninsertpersondelete.Size = new System.Drawing.Size(75, 23);
            this.btninsertpersondelete.TabIndex = 14;
            this.btninsertpersondelete.Text = "حذف";
            this.btninsertpersondelete.UseVisualStyleBackColor = false;
            this.btninsertpersondelete.Click += new System.EventHandler(this.btninsertpersondelete_Click);
            // 
            // dgvinsertperson
            // 
            this.dgvinsertperson.AllowUserToAddRows = false;
            this.dgvinsertperson.AllowUserToDeleteRows = false;
            this.dgvinsertperson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvinsertperson.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvinsertperson.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.dgvinsertperson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinsertperson.Location = new System.Drawing.Point(14, 166);
            this.dgvinsertperson.Name = "dgvinsertperson";
            this.dgvinsertperson.ReadOnly = true;
            this.dgvinsertperson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvinsertperson.Size = new System.Drawing.Size(559, 287);
            this.dgvinsertperson.TabIndex = 28;
            this.dgvinsertperson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinsertperson_CellClick);
            // 
            // lblpersontell
            // 
            this.lblpersontell.AutoSize = true;
            this.lblpersontell.Location = new System.Drawing.Point(491, 104);
            this.lblpersontell.Name = "lblpersontell";
            this.lblpersontell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblpersontell.Size = new System.Drawing.Size(29, 13);
            this.lblpersontell.TabIndex = 34;
            this.lblpersontell.Text = "تلفن:";
            // 
            // txtpersontell
            // 
            this.txtpersontell.Location = new System.Drawing.Point(385, 101);
            this.txtpersontell.Name = "txtpersontell";
            this.txtpersontell.Size = new System.Drawing.Size(100, 20);
            this.txtpersontell.TabIndex = 8;
            // 
            // txtpersonother
            // 
            this.txtpersonother.Location = new System.Drawing.Point(21, 101);
            this.txtpersonother.Name = "txtpersonother";
            this.txtpersonother.Size = new System.Drawing.Size(266, 20);
            this.txtpersonother.TabIndex = 9;
            // 
            // lblpersonother
            // 
            this.lblpersonother.AutoSize = true;
            this.lblpersonother.Location = new System.Drawing.Point(293, 104);
            this.lblpersonother.Name = "lblpersonother";
            this.lblpersonother.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblpersonother.Size = new System.Drawing.Size(52, 13);
            this.lblpersonother.TabIndex = 36;
            this.lblpersonother.Text = "توضیحات:";
            // 
            // btnpersonsave
            // 
            this.btnpersonsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnpersonsave.Location = new System.Drawing.Point(329, 137);
            this.btnpersonsave.Name = "btnpersonsave";
            this.btnpersonsave.Size = new System.Drawing.Size(75, 23);
            this.btnpersonsave.TabIndex = 13;
            this.btnpersonsave.Text = "ذخیره";
            this.btnpersonsave.UseVisualStyleBackColor = false;
            this.btnpersonsave.Click += new System.EventHandler(this.btnpersonsave_Click);
            // 
            // txtpersonsearch
            // 
            this.txtpersonsearch.Location = new System.Drawing.Point(21, 139);
            this.txtpersonsearch.Name = "txtpersonsearch";
            this.txtpersonsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpersonsearch.Size = new System.Drawing.Size(124, 20);
            this.txtpersonsearch.TabIndex = 10;
            this.txtpersonsearch.Text = "جستجو با کد ملی...";
            this.txtpersonsearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtpersonsearch_MouseClick);
            this.txtpersonsearch.TextChanged += new System.EventHandler(this.txtpersonsearch_TextChanged);
            // 
            // frmInsertperson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(196)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(585, 491);
            this.Controls.Add(this.txtpersonsearch);
            this.Controls.Add(this.btnpersonsave);
            this.Controls.Add(this.txtpersonother);
            this.Controls.Add(this.lblpersonother);
            this.Controls.Add(this.txtpersontell);
            this.Controls.Add(this.lblpersontell);
            this.Controls.Add(this.btninsertpersonsearch);
            this.Controls.Add(this.btninsertpersonexit);
            this.Controls.Add(this.btninsertpersonadd);
            this.Controls.Add(this.btninsertpersonedit);
            this.Controls.Add(this.btninsertpersondelete);
            this.Controls.Add(this.dgvinsertperson);
            this.Controls.Add(this.txtpersonskill);
            this.Controls.Add(this.txtpersonidnum);
            this.Controls.Add(this.txtpersonaddress);
            this.Controls.Add(this.txtpersoncode);
            this.Controls.Add(this.txtpersonfamily);
            this.Controls.Add(this.txtpersonlevel);
            this.Controls.Add(this.txtpersonid);
            this.Controls.Add(this.txtpersonname);
            this.Controls.Add(this.lblpersonaddress);
            this.Controls.Add(this.lblpersonskill);
            this.Controls.Add(this.lblpersonidnum);
            this.Controls.Add(this.lblpersoncode);
            this.Controls.Add(this.lblpersonfamily);
            this.Controls.Add(this.lblpersonlevel);
            this.Controls.Add(this.lblpersonid);
            this.Controls.Add(this.lblpersonname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(601, 530);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(601, 530);
            this.Name = "frmInsertperson";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات پرسنل";
            this.Load += new System.EventHandler(this.frmInsertperson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinsertperson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpersonname;
        private System.Windows.Forms.Label lblpersonid;
        private System.Windows.Forms.Label lblpersonlevel;
        private System.Windows.Forms.Label lblpersonfamily;
        private System.Windows.Forms.Label lblpersoncode;
        private System.Windows.Forms.Label lblpersonidnum;
        private System.Windows.Forms.Label lblpersonskill;
        private System.Windows.Forms.Label lblpersonaddress;
        private System.Windows.Forms.TextBox txtpersonlevel;
        private System.Windows.Forms.TextBox txtpersonid;
        private System.Windows.Forms.TextBox txtpersonname;
        private System.Windows.Forms.TextBox txtpersonaddress;
        private System.Windows.Forms.TextBox txtpersoncode;
        private System.Windows.Forms.TextBox txtpersonfamily;
        private System.Windows.Forms.TextBox txtpersonidnum;
        private System.Windows.Forms.TextBox txtpersonskill;
        private System.Windows.Forms.Button btninsertpersonsearch;
        private System.Windows.Forms.Button btninsertpersonexit;
        private System.Windows.Forms.Button btninsertpersonadd;
        private System.Windows.Forms.Button btninsertpersonedit;
        private System.Windows.Forms.Button btninsertpersondelete;
        private System.Windows.Forms.DataGridView dgvinsertperson;
        private System.Windows.Forms.Label lblpersontell;
        private System.Windows.Forms.TextBox txtpersontell;
        private System.Windows.Forms.TextBox txtpersonother;
        private System.Windows.Forms.Label lblpersonother;
        private System.Windows.Forms.Button btnpersonsave;
        private System.Windows.Forms.TextBox txtpersonsearch;
    }
}