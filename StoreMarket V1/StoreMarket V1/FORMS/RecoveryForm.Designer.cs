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
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.accesscodetxt = new System.Windows.Forms.TextBox();
            this.OLDPASS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkbtn = new System.Windows.Forms.Button();
            this.changebtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.familytxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(37, 157);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(193, 20);
            this.phonetxt.TabIndex = 4;
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(37, 105);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(193, 20);
            this.usernametxt.TabIndex = 2;
            // 
            // accesscodetxt
            // 
            this.accesscodetxt.Location = new System.Drawing.Point(37, 131);
            this.accesscodetxt.Name = "accesscodetxt";
            this.accesscodetxt.Size = new System.Drawing.Size(193, 20);
            this.accesscodetxt.TabIndex = 3;
            // 
            // OLDPASS
            // 
            this.OLDPASS.AutoSize = true;
            this.OLDPASS.Location = new System.Drawing.Point(12, 9);
            this.OLDPASS.Name = "OLDPASS";
            this.OLDPASS.Size = new System.Drawing.Size(51, 13);
            this.OLDPASS.TabIndex = 7;
            this.OLDPASS.Text = "نمایش رمز";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "شماره تماس :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "نام کاربری :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "کد دسترسی :";
            // 
            // checkbtn
            // 
            this.checkbtn.Location = new System.Drawing.Point(144, 198);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(75, 23);
            this.checkbtn.TabIndex = 5;
            this.checkbtn.Text = "بررسی";
            this.checkbtn.UseVisualStyleBackColor = true;
            this.checkbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // changebtn
            // 
            this.changebtn.Location = new System.Drawing.Point(54, 198);
            this.changebtn.Name = "changebtn";
            this.changebtn.Size = new System.Drawing.Size(75, 23);
            this.changebtn.TabIndex = 6;
            this.changebtn.Text = "تغییر رمز";
            this.changebtn.UseVisualStyleBackColor = true;
            this.changebtn.Click += new System.EventHandler(this.changebtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "فامیلی :";
            // 
            // familytxt
            // 
            this.familytxt.Location = new System.Drawing.Point(37, 79);
            this.familytxt.Name = "familytxt";
            this.familytxt.Size = new System.Drawing.Size(193, 20);
            this.familytxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "نام :";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(37, 53);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(193, 20);
            this.nametxt.TabIndex = 0;
            // 
            // RecoveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 250);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.familytxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.changebtn);
            this.Controls.Add(this.checkbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OLDPASS);
            this.Controls.Add(this.accesscodetxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.phonetxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecoveryForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "بازیابی اطلاعات";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox accesscodetxt;
        private System.Windows.Forms.Label OLDPASS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button checkbtn;
        private System.Windows.Forms.Button changebtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox familytxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametxt;
    }
}