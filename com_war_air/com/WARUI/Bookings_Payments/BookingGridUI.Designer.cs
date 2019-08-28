namespace com_war_air.com.WARUI.Bookings_Payments
{
    partial class BookingGridUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingGridUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Reference_Type_ComboBox = new WarFramework.Controls.WarComboBox();
            this.Bill_ID_Txt = new WarFramework.Controls.WarTextBox();
            this.PackageCode_Txt = new WarFramework.Controls.WarTextBox();
            this.BookingID_Txt = new WarFramework.Controls.WarTextBox();
            this.DateTime1 = new WarFramework.Controls.WarDateTime();
            this.ForNoOfPersons_Txt = new WarFramework.Controls.WarTextBox();
            this.ReferenceCode_ID_Txt = new WarFramework.Controls.WarTextBox();
            this.WarPanel1 = new WarFramework.Controls.WarPanel();
            this.WarGrid1 = new WarFramework.Controls.WarGrid();
            this.BookingSTATUS_ComboBox = new WarFramework.Controls.WarComboBox();
            this.WarToolTip1 = new WarFramework.Components.WarToolTip();
            this.groupBox1.SuspendLayout();
            this.WarPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BookingSTATUS_ComboBox);
            this.groupBox1.Controls.Add(this.Reference_Type_ComboBox);
            this.groupBox1.Controls.Add(this.Bill_ID_Txt);
            this.groupBox1.Controls.Add(this.PackageCode_Txt);
            this.groupBox1.Controls.Add(this.BookingID_Txt);
            this.groupBox1.Controls.Add(this.DateTime1);
            this.groupBox1.Controls.Add(this.ForNoOfPersons_Txt);
            this.groupBox1.Controls.Add(this.ReferenceCode_ID_Txt);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(13, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1352, 129);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADVANCE SEARCH";
            // 
            // Reference_Type_ComboBox
            // 
            this.Reference_Type_ComboBox.FormattingEnabled = true;
            this.Reference_Type_ComboBox.ItemHeight = 23;
            this.Reference_Type_ComboBox.Items.AddRange(new object[] {
            "ALL",
            "CUSTOMER\'S ONLY",
            "AGENT\'S ONLY"});
            this.Reference_Type_ComboBox.Location = new System.Drawing.Point(1131, 12);
            this.Reference_Type_ComboBox.Name = "Reference_Type_ComboBox";
            this.Reference_Type_ComboBox.Size = new System.Drawing.Size(215, 29);
            this.Reference_Type_ComboBox.TabIndex = 80;
            this.Reference_Type_ComboBox.UseSelectable = true;
            this.Reference_Type_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Reference_Type_ComboBox_SelectedIndexChanged);
            // 
            // Bill_ID_Txt
            // 
            // 
            // 
            // 
            this.Bill_ID_Txt.CustomButton.Image = null;
            this.Bill_ID_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.Bill_ID_Txt.CustomButton.Name = "";
            this.Bill_ID_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Bill_ID_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.Bill_ID_Txt.CustomButton.TabIndex = 1;
            this.Bill_ID_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.Bill_ID_Txt.CustomButton.UseSelectable = true;
            this.Bill_ID_Txt.CustomButton.Visible = false;
            this.Bill_ID_Txt.Lines = new string[0];
            this.Bill_ID_Txt.Location = new System.Drawing.Point(331, 88);
            this.Bill_ID_Txt.MaxLength = 32767;
            this.Bill_ID_Txt.Name = "Bill_ID_Txt";
            this.Bill_ID_Txt.PasswordChar = '\0';
            this.Bill_ID_Txt.PromptText = "BILL ID";
            this.Bill_ID_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Bill_ID_Txt.SelectedText = "";
            this.Bill_ID_Txt.SelectionLength = 0;
            this.Bill_ID_Txt.SelectionStart = 0;
            this.Bill_ID_Txt.ShortcutsEnabled = true;
            this.Bill_ID_Txt.ShowClearButton = true;
            this.Bill_ID_Txt.Size = new System.Drawing.Size(287, 23);
            this.Bill_ID_Txt.TabIndex = 62;
            this.Bill_ID_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bill_ID_Txt.UseSelectable = true;
            this.Bill_ID_Txt.WaterMark = "BILL ID";
            this.Bill_ID_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Bill_ID_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Bill_ID_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BookingID_Txt_KeyDown);
            this.Bill_ID_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookingID_Txt_KeyPress);
            // 
            // PackageCode_Txt
            // 
            // 
            // 
            // 
            this.PackageCode_Txt.CustomButton.Image = null;
            this.PackageCode_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.PackageCode_Txt.CustomButton.Name = "";
            this.PackageCode_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PackageCode_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.PackageCode_Txt.CustomButton.TabIndex = 1;
            this.PackageCode_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.PackageCode_Txt.CustomButton.UseSelectable = true;
            this.PackageCode_Txt.CustomButton.Visible = false;
            this.PackageCode_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("PackageCode_Txt.Icon")));
            this.PackageCode_Txt.Lines = new string[0];
            this.PackageCode_Txt.Location = new System.Drawing.Point(26, 53);
            this.PackageCode_Txt.MaxLength = 32767;
            this.PackageCode_Txt.Name = "PackageCode_Txt";
            this.PackageCode_Txt.PasswordChar = '\0';
            this.PackageCode_Txt.PromptText = "PACKAGE CODE/ID";
            this.PackageCode_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PackageCode_Txt.SelectedText = "";
            this.PackageCode_Txt.SelectionLength = 0;
            this.PackageCode_Txt.SelectionStart = 0;
            this.PackageCode_Txt.ShortcutsEnabled = true;
            this.PackageCode_Txt.ShowClearButton = true;
            this.PackageCode_Txt.Size = new System.Drawing.Size(287, 23);
            this.PackageCode_Txt.TabIndex = 57;
            this.PackageCode_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PackageCode_Txt.UseSelectable = true;
            this.PackageCode_Txt.WaterMark = "PACKAGE CODE/ID";
            this.PackageCode_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PackageCode_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PackageCode_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BookingID_Txt_KeyDown);
            this.PackageCode_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookingID_Txt_KeyPress);
            // 
            // BookingID_Txt
            // 
            // 
            // 
            // 
            this.BookingID_Txt.CustomButton.Image = null;
            this.BookingID_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.BookingID_Txt.CustomButton.Name = "";
            this.BookingID_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BookingID_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.BookingID_Txt.CustomButton.TabIndex = 1;
            this.BookingID_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.BookingID_Txt.CustomButton.UseSelectable = true;
            this.BookingID_Txt.CustomButton.Visible = false;
            this.BookingID_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("BookingID_Txt.Icon")));
            this.BookingID_Txt.Lines = new string[0];
            this.BookingID_Txt.Location = new System.Drawing.Point(26, 18);
            this.BookingID_Txt.MaxLength = 13;
            this.BookingID_Txt.Name = "BookingID_Txt";
            this.BookingID_Txt.PasswordChar = '\0';
            this.BookingID_Txt.PromptText = "BOOKING ID";
            this.BookingID_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BookingID_Txt.SelectedText = "";
            this.BookingID_Txt.SelectionLength = 0;
            this.BookingID_Txt.SelectionStart = 0;
            this.BookingID_Txt.ShortcutsEnabled = true;
            this.BookingID_Txt.ShowClearButton = true;
            this.BookingID_Txt.Size = new System.Drawing.Size(287, 23);
            this.BookingID_Txt.TabIndex = 61;
            this.BookingID_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BookingID_Txt.UseSelectable = true;
            this.BookingID_Txt.WaterMark = "BOOKING ID";
            this.BookingID_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BookingID_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BookingID_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BookingID_Txt_KeyDown);
            this.BookingID_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookingID_Txt_KeyPress);
            // 
            // DateTime1
            // 
            this.DateTime1.Checked = false;
            this.DateTime1.Location = new System.Drawing.Point(1103, 82);
            this.DateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTime1.Name = "DateTime1";
            this.DateTime1.ShowCheckBox = true;
            this.DateTime1.Size = new System.Drawing.Size(243, 29);
            this.DateTime1.TabIndex = 55;
            this.DateTime1.ValueChanged += new System.EventHandler(this.DateTime1_ValueChanged);
            // 
            // ForNoOfPersons_Txt
            // 
            // 
            // 
            // 
            this.ForNoOfPersons_Txt.CustomButton.Image = null;
            this.ForNoOfPersons_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.ForNoOfPersons_Txt.CustomButton.Name = "";
            this.ForNoOfPersons_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ForNoOfPersons_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.ForNoOfPersons_Txt.CustomButton.TabIndex = 1;
            this.ForNoOfPersons_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.ForNoOfPersons_Txt.CustomButton.UseSelectable = true;
            this.ForNoOfPersons_Txt.CustomButton.Visible = false;
            this.ForNoOfPersons_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("ForNoOfPersons_Txt.Icon")));
            this.ForNoOfPersons_Txt.Lines = new string[0];
            this.ForNoOfPersons_Txt.Location = new System.Drawing.Point(331, 53);
            this.ForNoOfPersons_Txt.MaxLength = 32767;
            this.ForNoOfPersons_Txt.Name = "ForNoOfPersons_Txt";
            this.ForNoOfPersons_Txt.PasswordChar = '\0';
            this.ForNoOfPersons_Txt.PromptText = "FOR NO OF PERSONS";
            this.ForNoOfPersons_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ForNoOfPersons_Txt.SelectedText = "";
            this.ForNoOfPersons_Txt.SelectionLength = 0;
            this.ForNoOfPersons_Txt.SelectionStart = 0;
            this.ForNoOfPersons_Txt.ShortcutsEnabled = true;
            this.ForNoOfPersons_Txt.ShowClearButton = true;
            this.ForNoOfPersons_Txt.Size = new System.Drawing.Size(287, 23);
            this.ForNoOfPersons_Txt.TabIndex = 56;
            this.ForNoOfPersons_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ForNoOfPersons_Txt.UseSelectable = true;
            this.ForNoOfPersons_Txt.WaterMark = "FOR NO OF PERSONS";
            this.ForNoOfPersons_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ForNoOfPersons_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ForNoOfPersons_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BookingID_Txt_KeyDown);
            this.ForNoOfPersons_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookingID_Txt_KeyPress);
            // 
            // ReferenceCode_ID_Txt
            // 
            // 
            // 
            // 
            this.ReferenceCode_ID_Txt.CustomButton.Image = null;
            this.ReferenceCode_ID_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.ReferenceCode_ID_Txt.CustomButton.Name = "";
            this.ReferenceCode_ID_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ReferenceCode_ID_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.ReferenceCode_ID_Txt.CustomButton.TabIndex = 1;
            this.ReferenceCode_ID_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.ReferenceCode_ID_Txt.CustomButton.UseSelectable = true;
            this.ReferenceCode_ID_Txt.CustomButton.Visible = false;
            this.ReferenceCode_ID_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("ReferenceCode_ID_Txt.Icon")));
            this.ReferenceCode_ID_Txt.Lines = new string[0];
            this.ReferenceCode_ID_Txt.Location = new System.Drawing.Point(26, 88);
            this.ReferenceCode_ID_Txt.MaxLength = 32767;
            this.ReferenceCode_ID_Txt.Name = "ReferenceCode_ID_Txt";
            this.ReferenceCode_ID_Txt.PasswordChar = '\0';
            this.ReferenceCode_ID_Txt.PromptText = "CUSTOMER/REFERENCE CODE/ID";
            this.ReferenceCode_ID_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ReferenceCode_ID_Txt.SelectedText = "";
            this.ReferenceCode_ID_Txt.SelectionLength = 0;
            this.ReferenceCode_ID_Txt.SelectionStart = 0;
            this.ReferenceCode_ID_Txt.ShortcutsEnabled = true;
            this.ReferenceCode_ID_Txt.ShowClearButton = true;
            this.ReferenceCode_ID_Txt.Size = new System.Drawing.Size(287, 23);
            this.ReferenceCode_ID_Txt.TabIndex = 60;
            this.ReferenceCode_ID_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReferenceCode_ID_Txt.UseSelectable = true;
            this.ReferenceCode_ID_Txt.WaterMark = "CUSTOMER/REFERENCE CODE/ID";
            this.ReferenceCode_ID_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ReferenceCode_ID_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ReferenceCode_ID_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BookingID_Txt_KeyDown);
            this.ReferenceCode_ID_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookingID_Txt_KeyPress);
            // 
            // WarPanel1
            // 
            this.WarPanel1.Controls.Add(this.WarGrid1);
            this.WarPanel1.HorizontalScrollbarBarColor = true;
            this.WarPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.WarPanel1.HorizontalScrollbarSize = 10;
            this.WarPanel1.Location = new System.Drawing.Point(13, 201);
            this.WarPanel1.Name = "WarPanel1";
            this.WarPanel1.Size = new System.Drawing.Size(1352, 355);
            this.WarPanel1.TabIndex = 73;
            this.WarPanel1.VerticalScrollbarBarColor = true;
            this.WarPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.WarPanel1.VerticalScrollbarSize = 10;
            // 
            // WarGrid1
            // 
            this.WarGrid1.AllowUserToAddRows = false;
            this.WarGrid1.AllowUserToDeleteRows = false;
            this.WarGrid1.AllowUserToResizeRows = false;
            this.WarGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WarGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WarGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.WarGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WarGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.WarGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WarGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.WarGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarGrid1.EnableHeadersVisualStyles = false;
            this.WarGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WarGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WarGrid1.Location = new System.Drawing.Point(0, 0);
            this.WarGrid1.MultiSelect = false;
            this.WarGrid1.Name = "WarGrid1";
            this.WarGrid1.ReadOnly = true;
            this.WarGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WarGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.WarGrid1.RowHeadersVisible = false;
            this.WarGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.WarGrid1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.WarGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.WarGrid1.ShowCellErrors = false;
            this.WarGrid1.ShowRowErrors = false;
            this.WarGrid1.Size = new System.Drawing.Size(1352, 355);
            this.WarGrid1.TabIndex = 3;
            this.WarGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarGrid1_CellClick);
            // 
            // BookingSTATUS_ComboBox
            // 
            this.BookingSTATUS_ComboBox.FormattingEnabled = true;
            this.BookingSTATUS_ComboBox.ItemHeight = 23;
            this.BookingSTATUS_ComboBox.Items.AddRange(new object[] {
            "ALL",
            "ACTIVE",
            "CANCELLED"});
            this.BookingSTATUS_ComboBox.Location = new System.Drawing.Point(1131, 47);
            this.BookingSTATUS_ComboBox.Name = "BookingSTATUS_ComboBox";
            this.BookingSTATUS_ComboBox.Size = new System.Drawing.Size(215, 29);
            this.BookingSTATUS_ComboBox.TabIndex = 81;
            this.BookingSTATUS_ComboBox.UseSelectable = true;
            this.BookingSTATUS_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Reference_Type_ComboBox_SelectedIndexChanged);
            // 
            // WarToolTip1
            // 
            this.WarToolTip1.Style = WarFramework.WarColorStyle.Blue;
            this.WarToolTip1.StyleManager = null;
            this.WarToolTip1.Theme = WarFramework.WarThemeStyle.Light;
            // 
            // BookingGridUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WarPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "BookingGridUI";
            this.Resizable = false;
            this.Text = "BOOKINGS";
            this.TextAlign = WarFramework.Forms.WarFormTextAlign.Right;
            this.Load += new System.EventHandler(this.BookingGridUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.WarPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WarGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WarFramework.Controls.WarComboBox Reference_Type_ComboBox;
        private WarFramework.Controls.WarTextBox Bill_ID_Txt;
        private WarFramework.Controls.WarTextBox PackageCode_Txt;
        private WarFramework.Controls.WarTextBox BookingID_Txt;
        private WarFramework.Controls.WarDateTime DateTime1;
        private WarFramework.Controls.WarTextBox ForNoOfPersons_Txt;
        private WarFramework.Controls.WarTextBox ReferenceCode_ID_Txt;
        private WarFramework.Controls.WarPanel WarPanel1;
        private WarFramework.Controls.WarGrid WarGrid1;
        private WarFramework.Controls.WarComboBox BookingSTATUS_ComboBox;
        private WarFramework.Components.WarToolTip WarToolTip1;
    }
}