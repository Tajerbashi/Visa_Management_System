namespace StoreMarket_V1
{
    partial class ProductPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ADMIN = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Save = new System.Windows.Forms.Button();
            this.DGV1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.PicS = new System.Windows.Forms.PictureBox();
            this.ResultPic = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SearchTxt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Searchbtn = new DevComponents.DotNetBar.ButtonX();
            this.Details = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Reloadbtn = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicS)).BeginInit();
            this.SuspendLayout();
            // 
            // ADMIN
            // 
            this.ADMIN.AutoSize = true;
            this.ADMIN.Location = new System.Drawing.Point(5, 384);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(13, 13);
            this.ADMIN.TabIndex = 23;
            this.ADMIN.Text = "1";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("MRT_Mitra_3", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(101, 351);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(189, 30);
            this.Save.TabIndex = 28;
            this.Save.Text = "ذخیره";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToResizeColumns = false;
            this.DGV1.AllowUserToResizeRows = false;
            this.DGV1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MRT_Mitra_3", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MRT_Mitra_3", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGV1.Location = new System.Drawing.Point(296, 0);
            this.DGV1.Name = "DGV1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(44)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MRT_Mitra_3", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV1.RowHeadersVisible = false;
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.Size = new System.Drawing.Size(477, 542);
            this.DGV1.TabIndex = 29;
            this.DGV1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV1_CellMouseClick);
            this.DGV1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGV1_KeyDown);
            this.DGV1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV1_KeyPress);
            this.DGV1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DGV1_KeyUp);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "N";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "نام";
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "برند";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "نوع";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "موجود";
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "قیمت";
            this.Column7.Name = "Column7";
            // 
            // Pic
            // 
            this.Pic.Image = global::StoreMarket_V1.Properties.Resources.help_icon;
            this.Pic.Location = new System.Drawing.Point(5, 45);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(285, 297);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic.TabIndex = 27;
            this.Pic.TabStop = false;
            // 
            // PicS
            // 
            this.PicS.Image = global::StoreMarket_V1.Properties.Resources.help_icon;
            this.PicS.Location = new System.Drawing.Point(5, 45);
            this.PicS.Name = "PicS";
            this.PicS.Size = new System.Drawing.Size(285, 297);
            this.PicS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicS.TabIndex = 30;
            this.PicS.TabStop = false;
            // 
            // ResultPic
            // 
            this.ResultPic.AutoSize = true;
            this.ResultPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultPic.Font = new System.Drawing.Font("MRT_Mitra_3", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ResultPic.Location = new System.Drawing.Point(8, 316);
            this.ResultPic.Name = "ResultPic";
            this.ResultPic.Size = new System.Drawing.Size(278, 25);
            this.ResultPic.TabIndex = 31;
            this.ResultPic.Text = "--------------------------------------";
            this.ResultPic.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MRT_Mitra_3", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(52, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 30);
            this.button1.TabIndex = 32;
            this.button1.Text = "فایل";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MRT_Mitra_3", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(5, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 30);
            this.button2.TabIndex = 33;
            this.button2.Text = "فولدر";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchTxt
            // 
            this.SearchTxt.BackColor = System.Drawing.Color.DarkOrchid;
            // 
            // 
            // 
            this.SearchTxt.Border.BackColor = System.Drawing.Color.Purple;
            this.SearchTxt.Border.BackColor2 = System.Drawing.Color.Violet;
            this.SearchTxt.Border.Class = "TextBoxBorder";
            this.SearchTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SearchTxt.Font = new System.Drawing.Font("MRT_Mitra_3", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SearchTxt.Location = new System.Drawing.Point(67, 10);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PreventEnterBeep = true;
            this.SearchTxt.Size = new System.Drawing.Size(223, 30);
            this.SearchTxt.TabIndex = 34;
            this.SearchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Searchbtn
            // 
            this.Searchbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Searchbtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.Searchbtn.HoverImage = global::StoreMarket_V1.Properties.Resources.Custom_Icon_Design_Flatastic_1_Search;
            this.Searchbtn.Image = global::StoreMarket_V1.Properties.Resources.Awicons_Vista_Artistic_Chart_search;
            this.Searchbtn.Location = new System.Drawing.Point(36, 10);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(25, 25);
            this.Searchbtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Searchbtn.TabIndex = 35;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Details
            // 
            this.Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            // 
            // 
            // 
            this.Details.Border.BackColor = System.Drawing.SystemColors.ControlText;
            this.Details.Border.BackColor2 = System.Drawing.Color.Violet;
            this.Details.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.Details.Border.Class = "TextBoxBorder";
            this.Details.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Details.Font = new System.Drawing.Font("MRT_Mitra_3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Details.ForeColor = System.Drawing.Color.White;
            this.Details.Location = new System.Drawing.Point(5, 387);
            this.Details.Multiline = true;
            this.Details.Name = "Details";
            this.Details.PreventEnterBeep = true;
            this.Details.Size = new System.Drawing.Size(285, 155);
            this.Details.TabIndex = 36;
            // 
            // Reloadbtn
            // 
            this.Reloadbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Reloadbtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.Reloadbtn.HoverImage = global::StoreMarket_V1.Properties.Resources.Graphicloads_Polygon_Reload_2;
            this.Reloadbtn.Image = global::StoreMarket_V1.Properties.Resources.Graphicloads_Polygon_Refresh_3;
            this.Reloadbtn.Location = new System.Drawing.Point(5, 11);
            this.Reloadbtn.Name = "Reloadbtn";
            this.Reloadbtn.Size = new System.Drawing.Size(25, 25);
            this.Reloadbtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Reloadbtn.TabIndex = 37;
            this.Reloadbtn.Click += new System.EventHandler(this.Reloadbtn_Click);
            // 
            // ProductPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.Reloadbtn);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultPic);
            this.Controls.Add(this.PicS);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.ADMIN);
            this.Name = "ProductPanel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(776, 545);
            this.Load += new System.EventHandler(this.ProductPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label ADMIN;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Button Save;
        private DevComponents.DotNetBar.Controls.DataGridViewX DGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.PictureBox PicS;
        private System.Windows.Forms.Label ResultPic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DevComponents.DotNetBar.Controls.TextBoxX SearchTxt;
        private DevComponents.DotNetBar.ButtonX Searchbtn;
        private DevComponents.DotNetBar.Controls.TextBoxX Details;
        private DevComponents.DotNetBar.ButtonX Reloadbtn;
    }
}
