namespace StoreMarket_V1
{
    partial class AccessCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessCodeForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ADMINNUMBER = new System.Windows.Forms.Label();
            this.ADMINNAME = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(32, 35);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "کد دسترسی :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(132, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "ورود";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ADMINNUMBER
            // 
            this.ADMINNUMBER.AutoSize = true;
            this.ADMINNUMBER.BackColor = System.Drawing.Color.Transparent;
            this.ADMINNUMBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADMINNUMBER.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ADMINNUMBER.Location = new System.Drawing.Point(1, 3);
            this.ADMINNUMBER.Name = "ADMINNUMBER";
            this.ADMINNUMBER.Size = new System.Drawing.Size(18, 7);
            this.ADMINNUMBER.TabIndex = 21;
            this.ADMINNUMBER.Text = "شماره";
            // 
            // ADMINNAME
            // 
            this.ADMINNAME.AutoSize = true;
            this.ADMINNAME.BackColor = System.Drawing.Color.Transparent;
            this.ADMINNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADMINNAME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ADMINNAME.Location = new System.Drawing.Point(3, 10);
            this.ADMINNAME.Name = "ADMINNAME";
            this.ADMINNAME.Size = new System.Drawing.Size(10, 7);
            this.ADMINNAME.TabIndex = 20;
            this.ADMINNAME.Text = "نام";
            // 
            // AccessCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(299, 117);
            this.Controls.Add(this.ADMINNUMBER);
            this.Controls.Add(this.ADMINNAME);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccessCodeForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "AccessCodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label ADMINNUMBER;
        public System.Windows.Forms.Label ADMINNAME;
    }
}