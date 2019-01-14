namespace Clinic_Managment_System
{
    partial class frmlogin
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
            this.lblloginuser = new System.Windows.Forms.Label();
            this.lblloginpass = new System.Windows.Forms.Label();
            this.lbllogintitle = new System.Windows.Forms.Label();
            this.txtloginuser = new System.Windows.Forms.TextBox();
            this.txtloginpass = new System.Windows.Forms.TextBox();
            this.btnloginok = new System.Windows.Forms.Button();
            this.btnloginexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblloginuser
            // 
            this.lblloginuser.AutoSize = true;
            this.lblloginuser.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginuser.Location = new System.Drawing.Point(218, 54);
            this.lblloginuser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblloginuser.Name = "lblloginuser";
            this.lblloginuser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblloginuser.Size = new System.Drawing.Size(73, 16);
            this.lblloginuser.TabIndex = 0;
            this.lblloginuser.Text = "نام کاربری:";
            this.lblloginuser.Click += new System.EventHandler(this.lblloginuser_Click);
            // 
            // lblloginpass
            // 
            this.lblloginpass.AutoSize = true;
            this.lblloginpass.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginpass.Location = new System.Drawing.Point(218, 84);
            this.lblloginpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblloginpass.Name = "lblloginpass";
            this.lblloginpass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblloginpass.Size = new System.Drawing.Size(60, 16);
            this.lblloginpass.TabIndex = 1;
            this.lblloginpass.Text = "رمز عبور:";
            this.lblloginpass.Click += new System.EventHandler(this.lblloginpass_Click);
            // 
            // lbllogintitle
            // 
            this.lbllogintitle.AutoSize = true;
            this.lbllogintitle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogintitle.Location = new System.Drawing.Point(48, 18);
            this.lbllogintitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllogintitle.Name = "lbllogintitle";
            this.lbllogintitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbllogintitle.Size = new System.Drawing.Size(205, 16);
            this.lbllogintitle.TabIndex = 2;
            this.lbllogintitle.Text = "نام کاربری و رمز عبور را وارد کنید.";
            this.lbllogintitle.Click += new System.EventHandler(this.lbllogintitle_Click);
            // 
            // txtloginuser
            // 
            this.txtloginuser.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloginuser.Location = new System.Drawing.Point(24, 52);
            this.txtloginuser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtloginuser.Name = "txtloginuser";
            this.txtloginuser.Size = new System.Drawing.Size(169, 23);
            this.txtloginuser.TabIndex = 3;
            this.txtloginuser.TextChanged += new System.EventHandler(this.txtloginuser_TextChanged);
            // 
            // txtloginpass
            // 
            this.txtloginpass.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloginpass.Location = new System.Drawing.Point(24, 82);
            this.txtloginpass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtloginpass.Name = "txtloginpass";
            this.txtloginpass.Size = new System.Drawing.Size(169, 23);
            this.txtloginpass.TabIndex = 4;
            this.txtloginpass.TextChanged += new System.EventHandler(this.txtloginpass_TextChanged);
            // 
            // btnloginok
            // 
            this.btnloginok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnloginok.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloginok.Location = new System.Drawing.Point(116, 126);
            this.btnloginok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnloginok.Name = "btnloginok";
            this.btnloginok.Size = new System.Drawing.Size(78, 27);
            this.btnloginok.TabIndex = 5;
            this.btnloginok.Text = "تائید";
            this.btnloginok.UseVisualStyleBackColor = false;
            this.btnloginok.Click += new System.EventHandler(this.btnloginok_Click);
            // 
            // btnloginexit
            // 
            this.btnloginexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnloginexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnloginexit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloginexit.Location = new System.Drawing.Point(24, 126);
            this.btnloginexit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnloginexit.Name = "btnloginexit";
            this.btnloginexit.Size = new System.Drawing.Size(78, 27);
            this.btnloginexit.TabIndex = 6;
            this.btnloginexit.Text = "خروج";
            this.btnloginexit.UseVisualStyleBackColor = false;
            this.btnloginexit.Click += new System.EventHandler(this.btnloginexit_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(196)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(307, 166);
            this.ControlBox = false;
            this.Controls.Add(this.btnloginexit);
            this.Controls.Add(this.btnloginok);
            this.Controls.Add(this.txtloginpass);
            this.Controls.Add(this.txtloginuser);
            this.Controls.Add(this.lbllogintitle);
            this.Controls.Add(this.lblloginpass);
            this.Controls.Add(this.lblloginuser);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم مدیریت مرکز فیزیوتراپی";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmlogin_FormClosing);
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblloginuser;
        private System.Windows.Forms.Label lblloginpass;
        private System.Windows.Forms.Label lbllogintitle;
        private System.Windows.Forms.TextBox txtloginuser;
        private System.Windows.Forms.TextBox txtloginpass;
        private System.Windows.Forms.Button btnloginok;
        private System.Windows.Forms.Button btnloginexit;
    }
}