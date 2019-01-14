namespace Clinic_Managment_System
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.btninsert = new System.Windows.Forms.Button();
            this.btninsertperson = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btninfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btninsert
            // 
            this.btninsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btninsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btninsert.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.ForeColor = System.Drawing.Color.Black;
            this.btninsert.Location = new System.Drawing.Point(851, 44);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(124, 39);
            this.btninsert.TabIndex = 0;
            this.btninsert.Text = "اطلاعات بیماران";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btninsertperson
            // 
            this.btninsertperson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btninsertperson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btninsertperson.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertperson.ForeColor = System.Drawing.Color.Black;
            this.btninsertperson.Location = new System.Drawing.Point(851, 89);
            this.btninsertperson.Name = "btninsertperson";
            this.btninsertperson.Size = new System.Drawing.Size(124, 39);
            this.btninsertperson.TabIndex = 1;
            this.btninsertperson.Text = "اطلاعات پرسنل";
            this.btninsertperson.UseVisualStyleBackColor = false;
            this.btninsertperson.Click += new System.EventHandler(this.btninsertperson_Click);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnexit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(851, 255);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(124, 39);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "خروج";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btninfo
            // 
            this.btninfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btninfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btninfo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninfo.ForeColor = System.Drawing.Color.Black;
            this.btninfo.Location = new System.Drawing.Point(851, 134);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(124, 39);
            this.btninfo.TabIndex = 2;
            this.btninfo.Text = "درباره نرم افزار";
            this.btninfo.UseVisualStyleBackColor = false;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.btninfo);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btninsertperson);
            this.Controls.Add(this.btninsert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmmain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم مدیریت مرکز فیزیوتراپی";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btninsertperson;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btninfo;
    }
}

