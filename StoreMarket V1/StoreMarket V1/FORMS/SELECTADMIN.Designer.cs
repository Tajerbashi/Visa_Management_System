namespace StoreMarket_V1
{
    partial class SELECTADMIN
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
            this.ADMINA = new System.Windows.Forms.CheckBox();
            this.ADMINB = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ADMINA
            // 
            this.ADMINA.AutoSize = true;
            this.ADMINA.Location = new System.Drawing.Point(66, 6);
            this.ADMINA.Name = "ADMINA";
            this.ADMINA.Size = new System.Drawing.Size(42, 17);
            this.ADMINA.TabIndex = 0;
            this.ADMINA.Text = "اول";
            this.ADMINA.UseVisualStyleBackColor = true;
            // 
            // ADMINB
            // 
            this.ADMINB.AutoSize = true;
            this.ADMINB.Location = new System.Drawing.Point(66, 29);
            this.ADMINB.Name = "ADMINB";
            this.ADMINB.Size = new System.Drawing.Size(42, 17);
            this.ADMINB.TabIndex = 1;
            this.ADMINB.Text = "دوم";
            this.ADMINB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::StoreMarket_V1.Properties.Resources.Everaldo_Crystal_Clear_Action_ok__1_;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 34);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SELECTADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 58);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ADMINB);
            this.Controls.Add(this.ADMINA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SELECTADMIN";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "SELECTADMIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox ADMINA;
        public System.Windows.Forms.CheckBox ADMINB;
        private System.Windows.Forms.Button button1;
    }
}