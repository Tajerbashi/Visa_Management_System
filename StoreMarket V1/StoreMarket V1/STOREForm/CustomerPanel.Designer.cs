namespace StoreMarket_V1
{
    partial class CustomerPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SAVEBTN = new System.Windows.Forms.Button();
            this.NAME = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.FAMILY = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PHONE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.NEWBUY = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ADMIN = new System.Windows.Forms.Label();
            this.Search = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.SEABTN = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.EDITBTN = new System.Windows.Forms.Button();
            this.DELETBTN = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // SAVEBTN
            // 
            this.SAVEBTN.Location = new System.Drawing.Point(10, 202);
            this.SAVEBTN.Name = "SAVEBTN";
            this.SAVEBTN.Size = new System.Drawing.Size(250, 38);
            this.SAVEBTN.TabIndex = 0;
            this.SAVEBTN.Text = "ذخیره";
            this.SAVEBTN.UseVisualStyleBackColor = true;
            this.SAVEBTN.Click += new System.EventHandler(this.SAVEBTN_Click);
            // 
            // NAME
            // 
            // 
            // 
            // 
            this.NAME.Border.Class = "TextBoxBorder";
            this.NAME.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NAME.Location = new System.Drawing.Point(26, 65);
            this.NAME.Name = "NAME";
            this.NAME.PreventEnterBeep = true;
            this.NAME.Size = new System.Drawing.Size(172, 20);
            this.NAME.TabIndex = 1;
            this.NAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NAME_KeyPress);
            // 
            // FAMILY
            // 
            // 
            // 
            // 
            this.FAMILY.Border.Class = "TextBoxBorder";
            this.FAMILY.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.FAMILY.Location = new System.Drawing.Point(26, 93);
            this.FAMILY.Name = "FAMILY";
            this.FAMILY.PreventEnterBeep = true;
            this.FAMILY.Size = new System.Drawing.Size(172, 20);
            this.FAMILY.TabIndex = 2;
            this.FAMILY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NAME_KeyPress);
            // 
            // PHONE
            // 
            // 
            // 
            // 
            this.PHONE.Border.Class = "TextBoxBorder";
            this.PHONE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PHONE.Location = new System.Drawing.Point(26, 121);
            this.PHONE.Name = "PHONE";
            this.PHONE.PreventEnterBeep = true;
            this.PHONE.Size = new System.Drawing.Size(172, 20);
            this.PHONE.TabIndex = 3;
            this.PHONE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NAME_KeyPress);
            // 
            // NEWBUY
            // 
            // 
            // 
            // 
            this.NEWBUY.Border.Class = "TextBoxBorder";
            this.NEWBUY.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NEWBUY.Location = new System.Drawing.Point(26, 147);
            this.NEWBUY.Name = "NEWBUY";
            this.NEWBUY.PreventEnterBeep = true;
            this.NEWBUY.Size = new System.Drawing.Size(172, 20);
            this.NEWBUY.TabIndex = 6;
            this.NEWBUY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NAME_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "خرید جدید  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "تلفن :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "فامیل :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "نام :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ADMIN);
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SEABTN);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.EDITBTN);
            this.groupBox1.Controls.Add(this.DELETBTN);
            this.groupBox1.Controls.Add(this.SAVEBTN);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.NAME);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.FAMILY);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PHONE);
            this.groupBox1.Controls.Add(this.NEWBUY);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(507, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 467);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات مشتریان";
            // 
            // ADMIN
            // 
            this.ADMIN.AutoSize = true;
            this.ADMIN.Location = new System.Drawing.Point(14, 381);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(26, 13);
            this.ADMIN.TabIndex = 22;
            this.ADMIN.Text = "نام :";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.Search.Border.Class = "TextBoxBorder";
            this.Search.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Search.Location = new System.Drawing.Point(14, 397);
            this.Search.Name = "Search";
            this.Search.PreventEnterBeep = true;
            this.Search.Size = new System.Drawing.Size(187, 20);
            this.Search.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "جستجو :";
            // 
            // SEABTN
            // 
            this.SEABTN.Location = new System.Drawing.Point(10, 423);
            this.SEABTN.Name = "SEABTN";
            this.SEABTN.Size = new System.Drawing.Size(250, 38);
            this.SEABTN.TabIndex = 19;
            this.SEABTN.Text = "جستجو نتایج";
            this.SEABTN.UseVisualStyleBackColor = true;
            this.SEABTN.Click += new System.EventHandler(this.SEABTN_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 38);
            this.button4.TabIndex = 18;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // EDITBTN
            // 
            this.EDITBTN.Location = new System.Drawing.Point(10, 290);
            this.EDITBTN.Name = "EDITBTN";
            this.EDITBTN.Size = new System.Drawing.Size(250, 38);
            this.EDITBTN.TabIndex = 17;
            this.EDITBTN.Text = "ویرایش";
            this.EDITBTN.UseVisualStyleBackColor = true;
            this.EDITBTN.Click += new System.EventHandler(this.EDITBTN_Click);
            // 
            // DELETBTN
            // 
            this.DELETBTN.Location = new System.Drawing.Point(10, 246);
            this.DELETBTN.Name = "DELETBTN";
            this.DELETBTN.Size = new System.Drawing.Size(250, 38);
            this.DELETBTN.TabIndex = 16;
            this.DELETBTN.Text = "حذف";
            this.DELETBTN.UseVisualStyleBackColor = true;
            this.DELETBTN.Click += new System.EventHandler(this.DELETBTN_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DGV1);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 467);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "نمایش";
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.AllowUserToOrderColumns = true;
            this.DGV1.AllowUserToResizeColumns = false;
            this.DGV1.AllowUserToResizeRows = false;
            this.DGV1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MRT_Mitra_3", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MRT_Mitra_3", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV1.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV1.EnableHeadersVisualStyles = false;
            this.DGV1.Location = new System.Drawing.Point(6, 22);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersVisible = false;
            this.DGV1.Size = new System.Drawing.Size(487, 438);
            this.DGV1.TabIndex = 0;
            this.DGV1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV1_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "نام";
            this.Column2.Name = "Column2";
            this.Column2.Width = 115;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "فامیل";
            this.Column3.Name = "Column3";
            this.Column3.Width = 115;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "تلفن";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "خرید کل";
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // CustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerPanel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(776, 473);
            this.Load += new System.EventHandler(this.CustomerPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SAVEBTN;
        private DevComponents.DotNetBar.Controls.TextBoxX NAME;
        private DevComponents.DotNetBar.Controls.TextBoxX FAMILY;
        private DevComponents.DotNetBar.Controls.TextBoxX PHONE;
        private DevComponents.DotNetBar.Controls.TextBoxX NEWBUY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SEABTN;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button EDITBTN;
        private System.Windows.Forms.Button DELETBTN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.Label ADMIN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
