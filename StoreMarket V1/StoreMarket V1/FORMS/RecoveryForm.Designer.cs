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
            this.SuspendLayout();
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(27, 114);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(193, 20);
            this.phonetxt.TabIndex = 4;
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(27, 62);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(193, 20);
            this.usernametxt.TabIndex = 2;
            // 
            // accesscodetxt
            // 
            this.accesscodetxt.Location = new System.Drawing.Point(27, 88);
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
            this.label2.Location = new System.Drawing.Point(226, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "شماره تماس :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "نام کاربری :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "کد دسترسی :";
            // 
            // checkbtn
            // 
            this.checkbtn.Location = new System.Drawing.Point(126, 163);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(75, 23);
            this.checkbtn.TabIndex = 5;
            this.checkbtn.Text = "بررسی";
            this.checkbtn.UseVisualStyleBackColor = true;
            this.checkbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // changebtn
            // 
            this.changebtn.Location = new System.Drawing.Point(40, 163);
            this.changebtn.Name = "changebtn";
            this.changebtn.Size = new System.Drawing.Size(75, 23);
            this.changebtn.TabIndex = 6;
            this.changebtn.Text = "تغییر رمز";
            this.changebtn.UseVisualStyleBackColor = true;
            this.changebtn.Click += new System.EventHandler(this.changebtn_Click);
            // 
            // RecoveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 213);
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
    }
}