namespace StoreMarket_V1
{
    partial class CheckBankPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ADMINNUMBER = new System.Windows.Forms.Label();
            this.ADMINNAME = new System.Windows.Forms.Label();
            this.DGV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.CheckNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PassDate = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.DayDate = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.Details = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SariNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Price = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Customer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BankName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشچکToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفچکToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تغییروضعیتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ADMINNUMBER
            // 
            this.ADMINNUMBER.AutoSize = true;
            this.ADMINNUMBER.BackColor = System.Drawing.Color.Black;
            this.ADMINNUMBER.Font = new System.Drawing.Font("MRT_Matin", 1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ADMINNUMBER.ForeColor = System.Drawing.Color.White;
            this.ADMINNUMBER.Location = new System.Drawing.Point(4, 11);
            this.ADMINNUMBER.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ADMINNUMBER.Name = "ADMINNUMBER";
            this.ADMINNUMBER.Size = new System.Drawing.Size(12, 3);
            this.ADMINNUMBER.TabIndex = 95;
            this.ADMINNUMBER.Text = "شماره";
            // 
            // ADMINNAME
            // 
            this.ADMINNAME.AutoSize = true;
            this.ADMINNAME.BackColor = System.Drawing.Color.Black;
            this.ADMINNAME.Font = new System.Drawing.Font("MRT_Matin", 1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ADMINNAME.ForeColor = System.Drawing.Color.White;
            this.ADMINNAME.Location = new System.Drawing.Point(4, 3);
            this.ADMINNAME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ADMINNAME.Name = "ADMINNAME";
            this.ADMINNAME.Size = new System.Drawing.Size(8, 3);
            this.ADMINNAME.TabIndex = 94;
            this.ADMINNAME.Text = "نام";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.BackgroundColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MRT_Mitra_3", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGV.Location = new System.Drawing.Point(0, 193);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(776, 352);
            this.DGV.TabIndex = 96;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            this.DGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "شماره";
            this.Column2.Name = "Column2";
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "گیرنده";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "نام بانک";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "شماره چک";
            this.Column5.Name = "Column5";
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "مبلغ";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "شناسه";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "تاریخ";
            this.Column8.Name = "Column8";
            this.Column8.Width = 90;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "وضعیت";
            this.Column10.Name = "Column10";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "بابت";
            this.Column9.Name = "Column9";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.CheckNumber);
            this.groupPanel1.Controls.Add(this.PassDate);
            this.groupPanel1.Controls.Add(this.DayDate);
            this.groupPanel1.Controls.Add(this.Details);
            this.groupPanel1.Controls.Add(this.SariNumber);
            this.groupPanel1.Controls.Add(this.Price);
            this.groupPanel1.Controls.Add(this.Customer);
            this.groupPanel1.Controls.Add(this.BankName);
            this.groupPanel1.Controls.Add(this.label8);
            this.groupPanel1.Controls.Add(this.label7);
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(4, 1);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(768, 191);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.groupPanel1.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(44)))), ((int)(((byte)(191)))));
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(164)))), ((int)(((byte)(90)))));
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 101;
            this.groupPanel1.Text = "اطلاعات چک";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX1.HoverImage = global::StoreMarket_V1.Properties.Resources.Mattahan_Umicons_Check;
            this.buttonX1.Image = global::StoreMarket_V1.Properties.Resources.Designcontest_Ecommerce_Business_Notes;
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX1.Location = new System.Drawing.Point(13, 130);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(207, 38);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 8;
            this.buttonX1.Text = "ذخیره";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // CheckNumber
            // 
            // 
            // 
            // 
            this.CheckNumber.Border.Class = "TextBoxBorder";
            this.CheckNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckNumber.Font = new System.Drawing.Font("MRT_Mitra_3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CheckNumber.Location = new System.Drawing.Point(529, 87);
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.PreventEnterBeep = true;
            this.CheckNumber.Size = new System.Drawing.Size(160, 32);
            this.CheckNumber.TabIndex = 2;
            this.CheckNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CheckNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // PassDate
            // 
            // 
            // 
            // 
            this.PassDate.BackgroundStyle.Class = "TextBoxBorder";
            this.PassDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PassDate.ButtonClear.Visible = true;
            this.PassDate.Font = new System.Drawing.Font("MRT_Mitra_3", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PassDate.Location = new System.Drawing.Point(529, 49);
            this.PassDate.Mask = "0000/00/00";
            this.PassDate.Name = "PassDate";
            this.PassDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PassDate.Size = new System.Drawing.Size(160, 30);
            this.PassDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PassDate.TabIndex = 1;
            this.PassDate.Text = "";
            this.PassDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassDate.ValidatingType = typeof(System.DateTime);
            // 
            // DayDate
            // 
            // 
            // 
            // 
            this.DayDate.BackgroundStyle.Class = "TextBoxBorder";
            this.DayDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DayDate.ButtonClear.Visible = true;
            this.DayDate.Font = new System.Drawing.Font("MRT_Mitra_3", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DayDate.Location = new System.Drawing.Point(529, 11);
            this.DayDate.Mask = "0000/00/00";
            this.DayDate.Name = "DayDate";
            this.DayDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DayDate.Size = new System.Drawing.Size(160, 30);
            this.DayDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DayDate.TabIndex = 0;
            this.DayDate.Text = "";
            this.DayDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DayDate.ValidatingType = typeof(System.DateTime);
            // 
            // Details
            // 
            // 
            // 
            // 
            this.Details.Border.Class = "TextBoxBorder";
            this.Details.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Details.Font = new System.Drawing.Font("MRT_Mitra_3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Details.Location = new System.Drawing.Point(13, 9);
            this.Details.Multiline = true;
            this.Details.Name = "Details";
            this.Details.PreventEnterBeep = true;
            this.Details.Size = new System.Drawing.Size(207, 116);
            this.Details.TabIndex = 7;
            this.Details.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SariNumber
            // 
            // 
            // 
            // 
            this.SariNumber.Border.Class = "TextBoxBorder";
            this.SariNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SariNumber.Font = new System.Drawing.Font("MRT_Mitra_3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SariNumber.Location = new System.Drawing.Point(529, 127);
            this.SariNumber.Name = "SariNumber";
            this.SariNumber.PreventEnterBeep = true;
            this.SariNumber.Size = new System.Drawing.Size(160, 32);
            this.SariNumber.TabIndex = 3;
            this.SariNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SariNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // Price
            // 
            // 
            // 
            // 
            this.Price.Border.Class = "TextBoxBorder";
            this.Price.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Price.Font = new System.Drawing.Font("MRT_Mitra_3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Price.Location = new System.Drawing.Point(270, 93);
            this.Price.Name = "Price";
            this.Price.PreventEnterBeep = true;
            this.Price.Size = new System.Drawing.Size(197, 32);
            this.Price.TabIndex = 6;
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // Customer
            // 
            // 
            // 
            // 
            this.Customer.Border.Class = "TextBoxBorder";
            this.Customer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Customer.Font = new System.Drawing.Font("MRT_Mitra_3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Customer.Location = new System.Drawing.Point(270, 51);
            this.Customer.Name = "Customer";
            this.Customer.PreventEnterBeep = true;
            this.Customer.Size = new System.Drawing.Size(197, 32);
            this.Customer.TabIndex = 5;
            this.Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BankName
            // 
            // 
            // 
            // 
            this.BankName.Border.Class = "TextBoxBorder";
            this.BankName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BankName.Font = new System.Drawing.Font("MRT_Mitra_3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BankName.Location = new System.Drawing.Point(270, 9);
            this.BankName.Name = "BankName";
            this.BankName.PreventEnterBeep = true;
            this.BankName.Size = new System.Drawing.Size(197, 32);
            this.BankName.TabIndex = 4;
            this.BankName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MRT_Mitra_3", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(690, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "تاریخ امروز :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MRT_Mitra_3", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(226, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "بابت :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MRT_Mitra_3", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(688, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 42);
            this.label6.TabIndex = 5;
            this.label6.Text = "شماره ملی\r\nشناسه ملی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MRT_Mitra_3", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(688, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "شماره چک :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MRT_Mitra_3", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(690, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "تاریخ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MRT_Mitra_3", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(467, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "نام بانک :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MRT_Mitra_3", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(467, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "در وجه :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MRT_Mitra_3", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(467, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "مبلغ :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشچکToolStripMenuItem,
            this.حذفچکToolStripMenuItem,
            this.تغییروضعیتToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // ویرایشچکToolStripMenuItem
            // 
            this.ویرایشچکToolStripMenuItem.Name = "ویرایشچکToolStripMenuItem";
            this.ویرایشچکToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ویرایشچکToolStripMenuItem.Text = "ویرایش چک";
            this.ویرایشچکToolStripMenuItem.Click += new System.EventHandler(this.ویرایشچکToolStripMenuItem_Click);
            // 
            // حذفچکToolStripMenuItem
            // 
            this.حذفچکToolStripMenuItem.Name = "حذفچکToolStripMenuItem";
            this.حذفچکToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.حذفچکToolStripMenuItem.Text = "حذف چک";
            this.حذفچکToolStripMenuItem.Click += new System.EventHandler(this.حذفچکToolStripMenuItem_Click);
            // 
            // تغییروضعیتToolStripMenuItem
            // 
            this.تغییروضعیتToolStripMenuItem.Name = "تغییروضعیتToolStripMenuItem";
            this.تغییروضعیتToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.تغییروضعیتToolStripMenuItem.Text = "تغییر وضعیت";
            this.تغییروضعیتToolStripMenuItem.Click += new System.EventHandler(this.تغییروضعیتToolStripMenuItem_Click);
            // 
            // CheckBankPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.ADMINNUMBER);
            this.Controls.Add(this.ADMINNAME);
            this.Name = "CheckBankPanel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(776, 545);
            this.Load += new System.EventHandler(this.CheckBankPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label ADMINNUMBER;
        public System.Windows.Forms.Label ADMINNAME;
        private DevComponents.DotNetBar.Controls.DataGridViewX DGV;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX CheckNumber;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv PassDate;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv DayDate;
        private DevComponents.DotNetBar.Controls.TextBoxX Details;
        private DevComponents.DotNetBar.Controls.TextBoxX SariNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX Price;
        private DevComponents.DotNetBar.Controls.TextBoxX Customer;
        private DevComponents.DotNetBar.Controls.TextBoxX BankName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشچکToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفچکToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تغییروضعیتToolStripMenuItem;
    }
}
