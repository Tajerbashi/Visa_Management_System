namespace StoreMarket_V1
{
    partial class MessageBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.OKbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.TestBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.title = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.Label();
            this.RC1 = new System.Windows.Forms.RadioButton();
            this.RC2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonX2);
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 36);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // OKbtn
            // 
            this.OKbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OKbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OKbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OKbtn.Location = new System.Drawing.Point(228, 132);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(113, 30);
            this.OKbtn.TabIndex = 1;
            this.OKbtn.Text = "تایید";
            this.OKbtn.UseVisualStyleBackColor = false;
            this.OKbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancelbtn.ForeColor = System.Drawing.Color.Red;
            this.Cancelbtn.Location = new System.Drawing.Point(78, 132);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(113, 30);
            this.Cancelbtn.TabIndex = 2;
            this.Cancelbtn.Text = "لغو";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // TestBtn
            // 
            this.TestBtn.BackColor = System.Drawing.Color.Transparent;
            this.TestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TestBtn.Location = new System.Drawing.Point(12, 132);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(56, 30);
            this.TestBtn.TabIndex = 3;
            this.TestBtn.Text = "«";
            this.TestBtn.UseVisualStyleBackColor = false;
            this.TestBtn.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StoreMarket_V1.Properties.Resources.vintage_radio_05_orange_icon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX2.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.buttonX2.Image = global::StoreMarket_V1.Properties.Resources.Rimshotdesign_Milkanodised_Mac_mini;
            this.buttonX2.Location = new System.Drawing.Point(354, 6);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(25, 25);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 2;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.buttonX1.HoverImage = global::StoreMarket_V1.Properties.Resources.Everaldo_Crystal_Clear_Action_cancel;
            this.buttonX1.Image = global::StoreMarket_V1.Properties.Resources.Awicons_Vista_Artistic_Delete;
            this.buttonX1.Location = new System.Drawing.Point(385, 6);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(25, 25);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("MRT_Mitra_3", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(42, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(37, 18);
            this.title.TabIndex = 5;
            this.title.Text = "اطلاعیه";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subject.Font = new System.Drawing.Font("MRT_Mitra_3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Subject.ForeColor = System.Drawing.Color.White;
            this.Subject.Location = new System.Drawing.Point(78, 51);
            this.Subject.Name = "Subject";
            this.Subject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Subject.Size = new System.Drawing.Size(49, 24);
            this.Subject.TabIndex = 6;
            this.Subject.Text = "اطلاعیه";
            this.Subject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RC1
            // 
            this.RC1.AutoSize = true;
            this.RC1.Location = new System.Drawing.Point(256, 86);
            this.RC1.Name = "RC1";
            this.RC1.Size = new System.Drawing.Size(101, 17);
            this.RC1.TabIndex = 8;
            this.RC1.TabStop = true;
            this.RC1.Text = "ویرایش نوشتاری";
            this.RC1.UseVisualStyleBackColor = true;
            this.RC1.Visible = false;
            // 
            // RC2
            // 
            this.RC2.AutoSize = true;
            this.RC2.Location = new System.Drawing.Point(262, 109);
            this.RC2.Name = "RC2";
            this.RC2.Size = new System.Drawing.Size(95, 17);
            this.RC2.TabIndex = 9;
            this.RC2.TabStop = true;
            this.RC2.Text = "ویرایش اطلاعات";
            this.RC2.UseVisualStyleBackColor = true;
            this.RC2.Visible = false;
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(44)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(418, 202);
            this.Controls.Add(this.RC2);
            this.Controls.Add(this.RC1);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.TestBtn);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageBoxForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxForm";
            this.Load += new System.EventHandler(this.MessageBoxForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label Subject;
        public System.Windows.Forms.Button OKbtn;
        public System.Windows.Forms.Button Cancelbtn;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.RadioButton RC1;
        public System.Windows.Forms.RadioButton RC2;
    }
}