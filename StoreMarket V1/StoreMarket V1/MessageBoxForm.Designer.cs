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
            this.title = new System.Windows.Forms.Label();
            this.titelpic = new System.Windows.Forms.PictureBox();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.OKbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Subject = new System.Windows.Forms.Label();
            this.RC1 = new System.Windows.Forms.RadioButton();
            this.RC2 = new System.Windows.Forms.RadioButton();
            this.tick = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.PictureBox();
            this.question = new System.Windows.Forms.PictureBox();
            this.warning = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titelpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.question)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.titelpic);
            this.panel1.Controls.Add(this.buttonX2);
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 36);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            // titelpic
            // 
            this.titelpic.Image = global::StoreMarket_V1.Properties.Resources.help_file_icon;
            this.titelpic.Location = new System.Drawing.Point(6, 3);
            this.titelpic.Name = "titelpic";
            this.titelpic.Size = new System.Drawing.Size(30, 30);
            this.titelpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titelpic.TabIndex = 4;
            this.titelpic.TabStop = false;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX2.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.buttonX2.Image = global::StoreMarket_V1.Properties.Resources.Rimshotdesign_Milkanodised_Mac_mini;
            this.buttonX2.Location = new System.Drawing.Point(317, 6);
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
            this.buttonX1.Location = new System.Drawing.Point(348, 6);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(25, 25);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // OKbtn
            // 
            this.OKbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OKbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OKbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OKbtn.Location = new System.Drawing.Point(200, 164);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(81, 30);
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
            this.Cancelbtn.Location = new System.Drawing.Point(98, 164);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(81, 30);
            this.Cancelbtn.TabIndex = 2;
            this.Cancelbtn.Text = "لغو";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subject.Font = new System.Drawing.Font("MRT_Mitra_3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Subject.ForeColor = System.Drawing.Color.White;
            this.Subject.Location = new System.Drawing.Point(190, 64);
            this.Subject.Name = "Subject";
            this.Subject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Subject.Size = new System.Drawing.Size(148, 24);
            this.Subject.TabIndex = 6;
            this.Subject.Text = "نوع تغییرات انتخاب کنید؟\r\n";
            this.Subject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RC1
            // 
            this.RC1.AutoSize = true;
            this.RC1.Font = new System.Drawing.Font("MRT_Mitra_3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RC1.Location = new System.Drawing.Point(129, 91);
            this.RC1.Name = "RC1";
            this.RC1.Size = new System.Drawing.Size(211, 28);
            this.RC1.TabIndex = 8;
            this.RC1.TabStop = true;
            this.RC1.Text = "ویرایش نوشتاری اطلاعات دتابس";
            this.RC1.UseVisualStyleBackColor = true;
            this.RC1.Visible = false;
            // 
            // RC2
            // 
            this.RC2.AutoSize = true;
            this.RC2.Font = new System.Drawing.Font("MRT_Mitra_3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RC2.Location = new System.Drawing.Point(150, 116);
            this.RC2.Name = "RC2";
            this.RC2.Size = new System.Drawing.Size(190, 28);
            this.RC2.TabIndex = 9;
            this.RC2.TabStop = true;
            this.RC2.Text = "ویرایش کامل اطلاعات دتابس";
            this.RC2.UseVisualStyleBackColor = true;
            this.RC2.Visible = false;
            // 
            // tick
            // 
            this.tick.Image = global::StoreMarket_V1.Properties.Resources.Check_2_icon__1_;
            this.tick.Location = new System.Drawing.Point(17, 69);
            this.tick.Name = "tick";
            this.tick.Size = new System.Drawing.Size(75, 75);
            this.tick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tick.TabIndex = 13;
            this.tick.TabStop = false;
            this.tick.Visible = false;
            // 
            // error
            // 
            this.error.Image = global::StoreMarket_V1.Properties.Resources.Problem_icon;
            this.error.Location = new System.Drawing.Point(17, 69);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(75, 75);
            this.error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.error.TabIndex = 12;
            this.error.TabStop = false;
            this.error.Visible = false;
            // 
            // question
            // 
            this.question.Image = global::StoreMarket_V1.Properties.Resources.faq_icon;
            this.question.Location = new System.Drawing.Point(17, 69);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(75, 75);
            this.question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.question.TabIndex = 11;
            this.question.TabStop = false;
            this.question.Visible = false;
            // 
            // warning
            // 
            this.warning.Image = global::StoreMarket_V1.Properties.Resources.Warning_icon__2_;
            this.warning.Location = new System.Drawing.Point(17, 69);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(75, 75);
            this.warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.warning.TabIndex = 10;
            this.warning.TabStop = false;
            this.warning.Visible = false;
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(44)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(378, 221);
            this.Controls.Add(this.tick);
            this.Controls.Add(this.error);
            this.Controls.Add(this.question);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.RC2);
            this.Controls.Add(this.RC1);
            this.Controls.Add(this.Subject);
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
            ((System.ComponentModel.ISupportInitialize)(this.titelpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.question)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.PictureBox titelpic;
        public System.Windows.Forms.Label Subject;
        public System.Windows.Forms.Button OKbtn;
        public System.Windows.Forms.Button Cancelbtn;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.RadioButton RC1;
        public System.Windows.Forms.RadioButton RC2;
        public System.Windows.Forms.PictureBox warning;
        public System.Windows.Forms.PictureBox question;
        public System.Windows.Forms.PictureBox error;
        public System.Windows.Forms.PictureBox tick;
    }
}