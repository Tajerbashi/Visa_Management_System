namespace StoreMarket_V1
{
    partial class StoreManagmentForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ADMINNUMBER = new System.Windows.Forms.Label();
            this.ADMINNAME = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(52, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "مالک فروشگاه";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(52, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "کنترل ادمین";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(52, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 59);
            this.button4.TabIndex = 3;
            this.button4.Text = "گزارش های ورود و خروج";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(264, 357);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "خروج";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ADMINNUMBER
            // 
            this.ADMINNUMBER.AutoSize = true;
            this.ADMINNUMBER.BackColor = System.Drawing.Color.Transparent;
            this.ADMINNUMBER.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ADMINNUMBER.Location = new System.Drawing.Point(12, 28);
            this.ADMINNUMBER.Name = "ADMINNUMBER";
            this.ADMINNUMBER.Size = new System.Drawing.Size(36, 13);
            this.ADMINNUMBER.TabIndex = 23;
            this.ADMINNUMBER.Text = "شماره";
            // 
            // ADMINNAME
            // 
            this.ADMINNAME.AutoSize = true;
            this.ADMINNAME.BackColor = System.Drawing.Color.Transparent;
            this.ADMINNAME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ADMINNAME.Location = new System.Drawing.Point(12, 9);
            this.ADMINNAME.Name = "ADMINNAME";
            this.ADMINNAME.Size = new System.Drawing.Size(20, 13);
            this.ADMINNAME.TabIndex = 22;
            this.ADMINNAME.Text = "نام";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(52, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 59);
            this.button3.TabIndex = 24;
            this.button3.Text = "حساب بانکی";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // StoreManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(330, 403);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ADMINNUMBER);
            this.Controls.Add(this.ADMINNAME);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoreManagmentForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "StoreManagmentForm";
            this.Load += new System.EventHandler(this.StoreManagmentForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StoreManagmentForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Label ADMINNUMBER;
        public System.Windows.Forms.Label ADMINNAME;
        private System.Windows.Forms.Button button3;
    }
}