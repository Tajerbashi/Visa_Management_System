namespace StoreMarket_V1
{
    partial class RecoveryForm
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
            this.OLDPASS = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkbtn = new System.Windows.Forms.Button();
            this.accesscodetxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OLDPASS
            // 
            this.OLDPASS.AutoSize = true;
            this.OLDPASS.BackColor = System.Drawing.Color.Transparent;
            this.OLDPASS.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OLDPASS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.OLDPASS.Location = new System.Drawing.Point(88, 230);
            this.OLDPASS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OLDPASS.Name = "OLDPASS";
            this.OLDPASS.Size = new System.Drawing.Size(41, 17);
            this.OLDPASS.TabIndex = 7;
            this.OLDPASS.Text = "نمایش";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.OLDPASS);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkbtn);
            this.groupBox2.Controls.Add(this.accesscodetxt);
            this.groupBox2.Controls.Add(this.usernametxt);
            this.groupBox2.Controls.Add(this.phonetxt);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(5, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 313);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بررسی اطلاعات";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MRT_Mitra_3", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(46, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 51);
            this.label8.TabIndex = 21;
            this.label8.Text = "متوجه به ورودی های کیبورد باشید \r\nاعداد فارسی با کیبورد فارسی \r\nاعداد انگلیسی با " +
    "کیبورد انگلیسی\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(1, 288);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "خروج";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(137, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "کد دسترسی :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(138, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "نام کاربری :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(129, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "شماره تماس :";
            // 
            // checkbtn
            // 
            this.checkbtn.BackColor = System.Drawing.Color.SlateBlue;
            this.checkbtn.ForeColor = System.Drawing.Color.White;
            this.checkbtn.Location = new System.Drawing.Point(49, 179);
            this.checkbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(127, 35);
            this.checkbtn.TabIndex = 3;
            this.checkbtn.Text = "دریافت رمز";
            this.checkbtn.UseVisualStyleBackColor = false;
            this.checkbtn.Click += new System.EventHandler(this.checkbtn_Click);
            // 
            // accesscodetxt
            // 
            this.accesscodetxt.BackColor = System.Drawing.Color.Thistle;
            this.accesscodetxt.ForeColor = System.Drawing.Color.Firebrick;
            this.accesscodetxt.Location = new System.Drawing.Point(12, 41);
            this.accesscodetxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accesscodetxt.MaxLength = 20;
            this.accesscodetxt.Name = "accesscodetxt";
            this.accesscodetxt.Size = new System.Drawing.Size(190, 27);
            this.accesscodetxt.TabIndex = 0;
            // 
            // usernametxt
            // 
            this.usernametxt.BackColor = System.Drawing.Color.Thistle;
            this.usernametxt.ForeColor = System.Drawing.Color.Firebrick;
            this.usernametxt.Location = new System.Drawing.Point(12, 91);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernametxt.MaxLength = 20;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(190, 27);
            this.usernametxt.TabIndex = 1;
            // 
            // phonetxt
            // 
            this.phonetxt.BackColor = System.Drawing.Color.Thistle;
            this.phonetxt.ForeColor = System.Drawing.Color.Firebrick;
            this.phonetxt.Location = new System.Drawing.Point(12, 142);
            this.phonetxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phonetxt.MaxLength = 11;
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(190, 27);
            this.phonetxt.TabIndex = 2;
            this.phonetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phonetxt_KeyPress);
            // 
            // RecoveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(227, 317);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("MRT_Mitra_3", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RecoveryForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بازیابی اطلاعات";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RecoveryForm_MouseDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label OLDPASS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkbtn;
        private System.Windows.Forms.TextBox accesscodetxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}