namespace com_war_air.com.WARUI.Agents_Customers
{
    partial class CompanyGridUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyGridUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.STATUS_ComboBox = new WarFramework.Controls.WarComboBox();
            this.PASSPORT_NO_Txt = new WarFramework.Controls.WarTextBox();
            this.companyID_Txt = new WarFramework.Controls.WarTextBox();
            this.EXTRA_DETAILS_Txt = new WarFramework.Controls.WarTextBox();
            this.Address_Txt = new WarFramework.Controls.WarTextBox();
            this.EMAIL_Txt = new WarFramework.Controls.WarTextBox();
            this.Company_mobileNo_Txt = new WarFramework.Controls.WarTextBox();
            this.DateTime1 = new WarFramework.Controls.WarDateTime();
            this.Owner_MOBILE_NO_Txt = new WarFramework.Controls.WarTextBox();
            this.Owner_NAME_Txt = new WarFramework.Controls.WarTextBox();
            this.WarPanel1 = new WarFramework.Controls.WarPanel();
            this.WarGrid1 = new WarFramework.Controls.WarGrid();
            this.Extra_MobileNo_Txt = new WarFramework.Controls.WarTextBox();
            this.Extra_Email_Txt = new WarFramework.Controls.WarTextBox();
            this.CompanyName_Txt = new WarFramework.Controls.WarTextBox();
            this.groupBox1.SuspendLayout();
            this.WarPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CompanyName_Txt);
            this.groupBox1.Controls.Add(this.Extra_Email_Txt);
            this.groupBox1.Controls.Add(this.Extra_MobileNo_Txt);
            this.groupBox1.Controls.Add(this.STATUS_ComboBox);
            this.groupBox1.Controls.Add(this.PASSPORT_NO_Txt);
            this.groupBox1.Controls.Add(this.companyID_Txt);
            this.groupBox1.Controls.Add(this.EXTRA_DETAILS_Txt);
            this.groupBox1.Controls.Add(this.Address_Txt);
            this.groupBox1.Controls.Add(this.EMAIL_Txt);
            this.groupBox1.Controls.Add(this.Company_mobileNo_Txt);
            this.groupBox1.Controls.Add(this.DateTime1);
            this.groupBox1.Controls.Add(this.Owner_MOBILE_NO_Txt);
            this.groupBox1.Controls.Add(this.Owner_NAME_Txt);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(11, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1236, 146);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADVANCE SEARCH";
            // 
            // STATUS_ComboBox
            // 
            this.STATUS_ComboBox.FormattingEnabled = true;
            this.STATUS_ComboBox.ItemHeight = 23;
            this.STATUS_ComboBox.Items.AddRange(new object[] {
            "ALL",
            "ACTIVE",
            "INACTIVE"});
            this.STATUS_ComboBox.Location = new System.Drawing.Point(1007, 25);
            this.STATUS_ComboBox.Name = "STATUS_ComboBox";
            this.STATUS_ComboBox.Size = new System.Drawing.Size(215, 29);
            this.STATUS_ComboBox.TabIndex = 73;
            this.STATUS_ComboBox.UseSelectable = true;
            this.STATUS_ComboBox.SelectedIndexChanged += new System.EventHandler(this.STATUS_ComboBox_SelectedIndexChanged);
            // 
            // PASSPORT_NO_Txt
            // 
            // 
            // 
            // 
            this.PASSPORT_NO_Txt.CustomButton.Image = null;
            this.PASSPORT_NO_Txt.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.PASSPORT_NO_Txt.CustomButton.Name = "";
            this.PASSPORT_NO_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PASSPORT_NO_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.PASSPORT_NO_Txt.CustomButton.TabIndex = 1;
            this.PASSPORT_NO_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.PASSPORT_NO_Txt.CustomButton.UseSelectable = true;
            this.PASSPORT_NO_Txt.CustomButton.Visible = false;
            this.PASSPORT_NO_Txt.Lines = new string[0];
            this.PASSPORT_NO_Txt.Location = new System.Drawing.Point(1007, 25);
            this.PASSPORT_NO_Txt.MaxLength = 13;
            this.PASSPORT_NO_Txt.Name = "PASSPORT_NO_Txt";
            this.PASSPORT_NO_Txt.PasswordChar = '\0';
            this.PASSPORT_NO_Txt.PromptText = "PASSPORT NO";
            this.PASSPORT_NO_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PASSPORT_NO_Txt.SelectedText = "";
            this.PASSPORT_NO_Txt.SelectionLength = 0;
            this.PASSPORT_NO_Txt.SelectionStart = 0;
            this.PASSPORT_NO_Txt.ShortcutsEnabled = true;
            this.PASSPORT_NO_Txt.ShowClearButton = true;
            this.PASSPORT_NO_Txt.Size = new System.Drawing.Size(215, 23);
            this.PASSPORT_NO_Txt.TabIndex = 70;
            this.PASSPORT_NO_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PASSPORT_NO_Txt.UseSelectable = true;
            this.PASSPORT_NO_Txt.WaterMark = "PASSPORT NO";
            this.PASSPORT_NO_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PASSPORT_NO_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // companyID_Txt
            // 
            // 
            // 
            // 
            this.companyID_Txt.CustomButton.Image = null;
            this.companyID_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.companyID_Txt.CustomButton.Name = "";
            this.companyID_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.companyID_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.companyID_Txt.CustomButton.TabIndex = 1;
            this.companyID_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.companyID_Txt.CustomButton.UseSelectable = true;
            this.companyID_Txt.CustomButton.Visible = false;
            this.companyID_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("companyID_Txt.Icon")));
            this.companyID_Txt.Lines = new string[0];
            this.companyID_Txt.Location = new System.Drawing.Point(46, 19);
            this.companyID_Txt.MaxLength = 32767;
            this.companyID_Txt.Name = "companyID_Txt";
            this.companyID_Txt.PasswordChar = '\0';
            this.companyID_Txt.PromptText = "COMPANY  ID";
            this.companyID_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.companyID_Txt.SelectedText = "";
            this.companyID_Txt.SelectionLength = 0;
            this.companyID_Txt.SelectionStart = 0;
            this.companyID_Txt.ShortcutsEnabled = true;
            this.companyID_Txt.ShowClearButton = true;
            this.companyID_Txt.Size = new System.Drawing.Size(287, 23);
            this.companyID_Txt.TabIndex = 62;
            this.companyID_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.companyID_Txt.UseSelectable = true;
            this.companyID_Txt.WaterMark = "COMPANY  ID";
            this.companyID_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.companyID_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.companyID_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyName_Txt_KeyDown);
            this.companyID_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.companyID_Txt_KeyPress);
            // 
            // EXTRA_DETAILS_Txt
            // 
            // 
            // 
            // 
            this.EXTRA_DETAILS_Txt.CustomButton.Image = null;
            this.EXTRA_DETAILS_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.EXTRA_DETAILS_Txt.CustomButton.Name = "";
            this.EXTRA_DETAILS_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EXTRA_DETAILS_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.EXTRA_DETAILS_Txt.CustomButton.TabIndex = 1;
            this.EXTRA_DETAILS_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.EXTRA_DETAILS_Txt.CustomButton.UseSelectable = true;
            this.EXTRA_DETAILS_Txt.CustomButton.Visible = false;
            this.EXTRA_DETAILS_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("EXTRA_DETAILS_Txt.Icon")));
            this.EXTRA_DETAILS_Txt.Lines = new string[0];
            this.EXTRA_DETAILS_Txt.Location = new System.Drawing.Point(662, 87);
            this.EXTRA_DETAILS_Txt.MaxLength = 13;
            this.EXTRA_DETAILS_Txt.Name = "EXTRA_DETAILS_Txt";
            this.EXTRA_DETAILS_Txt.PasswordChar = '\0';
            this.EXTRA_DETAILS_Txt.PromptText = "EXTRA DETAILS";
            this.EXTRA_DETAILS_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EXTRA_DETAILS_Txt.SelectedText = "";
            this.EXTRA_DETAILS_Txt.SelectionLength = 0;
            this.EXTRA_DETAILS_Txt.SelectionStart = 0;
            this.EXTRA_DETAILS_Txt.ShortcutsEnabled = true;
            this.EXTRA_DETAILS_Txt.ShowClearButton = true;
            this.EXTRA_DETAILS_Txt.Size = new System.Drawing.Size(287, 23);
            this.EXTRA_DETAILS_Txt.TabIndex = 63;
            this.EXTRA_DETAILS_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EXTRA_DETAILS_Txt.UseSelectable = true;
            this.EXTRA_DETAILS_Txt.WaterMark = "EXTRA DETAILS";
            this.EXTRA_DETAILS_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EXTRA_DETAILS_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.EXTRA_DETAILS_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyName_Txt_KeyDown);
            // 
            // Address_Txt
            // 
            // 
            // 
            // 
            this.Address_Txt.CustomButton.Image = null;
            this.Address_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.Address_Txt.CustomButton.Name = "";
            this.Address_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Address_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.Address_Txt.CustomButton.TabIndex = 1;
            this.Address_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.Address_Txt.CustomButton.UseSelectable = true;
            this.Address_Txt.CustomButton.Visible = false;
            this.Address_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("Address_Txt.Icon")));
            this.Address_Txt.Lines = new string[0];
            this.Address_Txt.Location = new System.Drawing.Point(46, 118);
            this.Address_Txt.MaxLength = 32767;
            this.Address_Txt.Name = "Address_Txt";
            this.Address_Txt.PasswordChar = '\0';
            this.Address_Txt.PromptText = "ADDRESS";
            this.Address_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Address_Txt.SelectedText = "";
            this.Address_Txt.SelectionLength = 0;
            this.Address_Txt.SelectionStart = 0;
            this.Address_Txt.ShortcutsEnabled = true;
            this.Address_Txt.ShowClearButton = true;
            this.Address_Txt.Size = new System.Drawing.Size(287, 23);
            this.Address_Txt.TabIndex = 57;
            this.Address_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address_Txt.UseSelectable = true;
            this.Address_Txt.WaterMark = "ADDRESS";
            this.Address_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Address_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Address_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyName_Txt_KeyDown);
            // 
            // EMAIL_Txt
            // 
            // 
            // 
            // 
            this.EMAIL_Txt.CustomButton.Image = null;
            this.EMAIL_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.EMAIL_Txt.CustomButton.Name = "";
            this.EMAIL_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EMAIL_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.EMAIL_Txt.CustomButton.TabIndex = 1;
            this.EMAIL_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.EMAIL_Txt.CustomButton.UseSelectable = true;
            this.EMAIL_Txt.CustomButton.Visible = false;
            this.EMAIL_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("EMAIL_Txt.Icon")));
            this.EMAIL_Txt.Lines = new string[0];
            this.EMAIL_Txt.Location = new System.Drawing.Point(663, 19);
            this.EMAIL_Txt.MaxLength = 32767;
            this.EMAIL_Txt.Name = "EMAIL_Txt";
            this.EMAIL_Txt.PasswordChar = '\0';
            this.EMAIL_Txt.PromptText = "EMAIL";
            this.EMAIL_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EMAIL_Txt.SelectedText = "";
            this.EMAIL_Txt.SelectionLength = 0;
            this.EMAIL_Txt.SelectionStart = 0;
            this.EMAIL_Txt.ShortcutsEnabled = true;
            this.EMAIL_Txt.ShowClearButton = true;
            this.EMAIL_Txt.Size = new System.Drawing.Size(287, 23);
            this.EMAIL_Txt.TabIndex = 59;
            this.EMAIL_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EMAIL_Txt.UseSelectable = true;
            this.EMAIL_Txt.WaterMark = "EMAIL";
            this.EMAIL_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EMAIL_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.EMAIL_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyName_Txt_KeyDown);
            // 
            // Company_mobileNo_Txt
            // 
            // 
            // 
            // 
            this.Company_mobileNo_Txt.CustomButton.Image = null;
            this.Company_mobileNo_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.Company_mobileNo_Txt.CustomButton.Name = "";
            this.Company_mobileNo_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Company_mobileNo_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.Company_mobileNo_Txt.CustomButton.TabIndex = 1;
            this.Company_mobileNo_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.Company_mobileNo_Txt.CustomButton.UseSelectable = true;
            this.Company_mobileNo_Txt.CustomButton.Visible = false;
            this.Company_mobileNo_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("Company_mobileNo_Txt.Icon")));
            this.Company_mobileNo_Txt.Lines = new string[0];
            this.Company_mobileNo_Txt.Location = new System.Drawing.Point(354, 87);
            this.Company_mobileNo_Txt.MaxLength = 13;
            this.Company_mobileNo_Txt.Name = "Company_mobileNo_Txt";
            this.Company_mobileNo_Txt.PasswordChar = '\0';
            this.Company_mobileNo_Txt.PromptText = "COMPANY MOBILE NO";
            this.Company_mobileNo_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Company_mobileNo_Txt.SelectedText = "";
            this.Company_mobileNo_Txt.SelectionLength = 0;
            this.Company_mobileNo_Txt.SelectionStart = 0;
            this.Company_mobileNo_Txt.ShortcutsEnabled = true;
            this.Company_mobileNo_Txt.ShowClearButton = true;
            this.Company_mobileNo_Txt.Size = new System.Drawing.Size(287, 23);
            this.Company_mobileNo_Txt.TabIndex = 61;
            this.Company_mobileNo_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Company_mobileNo_Txt.UseSelectable = true;
            this.Company_mobileNo_Txt.WaterMark = "COMPANY MOBILE NO";
            this.Company_mobileNo_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Company_mobileNo_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Company_mobileNo_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyName_Txt_KeyDown);
            this.Company_mobileNo_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.companyID_Txt_KeyPress);
            // 
            // DateTime1
            // 
            this.DateTime1.Checked = false;
            this.DateTime1.Location = new System.Drawing.Point(981, 80);
            this.DateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTime1.Name = "DateTime1";
            this.DateTime1.ShowCheckBox = true;
            this.DateTime1.Size = new System.Drawing.Size(243, 29);
            this.DateTime1.TabIndex = 55;
            this.DateTime1.ValueChanged += new System.EventHandler(this.DateTime1_ValueChanged);
            // 
            // Owner_MOBILE_NO_Txt
            // 
            // 
            // 
            // 
            this.Owner_MOBILE_NO_Txt.CustomButton.Image = null;
            this.Owner_MOBILE_NO_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.Owner_MOBILE_NO_Txt.CustomButton.Name = "";
            this.Owner_MOBILE_NO_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Owner_MOBILE_NO_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.Owner_MOBILE_NO_Txt.CustomButton.TabIndex = 1;
            this.Owner_MOBILE_NO_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.Owner_MOBILE_NO_Txt.CustomButton.UseSelectable = true;
            this.Owner_MOBILE_NO_Txt.CustomButton.Visible = false;
            this.Owner_MOBILE_NO_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("Owner_MOBILE_NO_Txt.Icon")));
            this.Owner_MOBILE_NO_Txt.Lines = new string[0];
            this.Owner_MOBILE_NO_Txt.Location = new System.Drawing.Point(355, 19);
            this.Owner_MOBILE_NO_Txt.MaxLength = 32767;
            this.Owner_MOBILE_NO_Txt.Name = "Owner_MOBILE_NO_Txt";
            this.Owner_MOBILE_NO_Txt.PasswordChar = '\0';
            this.Owner_MOBILE_NO_Txt.PromptText = "OWNER MOBILE NO";
            this.Owner_MOBILE_NO_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Owner_MOBILE_NO_Txt.SelectedText = "";
            this.Owner_MOBILE_NO_Txt.SelectionLength = 0;
            this.Owner_MOBILE_NO_Txt.SelectionStart = 0;
            this.Owner_MOBILE_NO_Txt.ShortcutsEnabled = true;
            this.Owner_MOBILE_NO_Txt.ShowClearButton = true;
            this.Owner_MOBILE_NO_Txt.Size = new System.Drawing.Size(287, 23);
            this.Owner_MOBILE_NO_Txt.TabIndex = 56;
            this.Owner_MOBILE_NO_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Owner_MOBILE_NO_Txt.UseSelectable = true;
            this.Owner_MOBILE_NO_Txt.WaterMark = "OWNER MOBILE NO";
            this.Owner_MOBILE_NO_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Owner_MOBILE_NO_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Owner_MOBILE_NO_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyName_Txt_KeyDown);
            this.Owner_MOBILE_NO_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.companyID_Txt_KeyPress);
            // 
            // Owner_NAME_Txt
            // 
            // 
            // 
            // 
            this.Owner_NAME_Txt.CustomButton.Image = null;
            this.Owner_NAME_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.Owner_NAME_Txt.CustomButton.Name = "";
            this.Owner_NAME_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Owner_NAME_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.Owner_NAME_Txt.CustomButton.TabIndex = 1;
            this.Owner_NAME_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.Owner_NAME_Txt.CustomButton.UseSelectable = true;
            this.Owner_NAME_Txt.CustomButton.Visible = false;
            this.Owner_NAME_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("Owner_NAME_Txt.Icon")));
            this.Owner_NAME_Txt.Lines = new string[0];
            this.Owner_NAME_Txt.Location = new System.Drawing.Point(46, 53);
            this.Owner_NAME_Txt.MaxLength = 32767;
            this.Owner_NAME_Txt.Name = "Owner_NAME_Txt";
            this.Owner_NAME_Txt.PasswordChar = '\0';
            this.Owner_NAME_Txt.PromptText = "OWNER NAME";
            this.Owner_NAME_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Owner_NAME_Txt.SelectedText = "";
            this.Owner_NAME_Txt.SelectionLength = 0;
            this.Owner_NAME_Txt.SelectionStart = 0;
            this.Owner_NAME_Txt.ShortcutsEnabled = true;
            this.Owner_NAME_Txt.ShowClearButton = true;
            this.Owner_NAME_Txt.Size = new System.Drawing.Size(287, 23);
            this.Owner_NAME_Txt.TabIndex = 60;
            this.Owner_NAME_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Owner_NAME_Txt.UseSelectable = true;
            this.Owner_NAME_Txt.WaterMark = "OWNER NAME";
            this.Owner_NAME_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Owner_NAME_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Owner_NAME_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyName_Txt_KeyDown);
            // 
            // WarPanel1
            // 
            this.WarPanel1.Controls.Add(this.WarGrid1);
            this.WarPanel1.HorizontalScrollbarBarColor = true;
            this.WarPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.WarPanel1.HorizontalScrollbarSize = 10;
            this.WarPanel1.Location = new System.Drawing.Point(11, 215);
            this.WarPanel1.Name = "WarPanel1";
            this.WarPanel1.Size = new System.Drawing.Size(1230, 425);
            this.WarPanel1.TabIndex = 69;
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
            this.WarGrid1.Size = new System.Drawing.Size(1230, 425);
            this.WarGrid1.TabIndex = 3;
            this.WarGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarGrid1_CellClick);
            // 
            // Extra_MobileNo_Txt
            // 
            // 
            // 
            // 
            this.Extra_MobileNo_Txt.CustomButton.Image = null;
            this.Extra_MobileNo_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.Extra_MobileNo_Txt.CustomButton.Name = "";
            this.Extra_MobileNo_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Extra_MobileNo_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.Extra_MobileNo_Txt.CustomButton.TabIndex = 1;
            this.Extra_MobileNo_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.Extra_MobileNo_Txt.CustomButton.UseSelectable = true;
            this.Extra_MobileNo_Txt.CustomButton.Visible = false;
            this.Extra_MobileNo_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("Extra_MobileNo_Txt.Icon")));
            this.Extra_MobileNo_Txt.Lines = new string[0];
            this.Extra_MobileNo_Txt.Location = new System.Drawing.Point(355, 53);
            this.Extra_MobileNo_Txt.MaxLength = 32767;
            this.Extra_MobileNo_Txt.Name = "Extra_MobileNo_Txt";
            this.Extra_MobileNo_Txt.PasswordChar = '\0';
            this.Extra_MobileNo_Txt.PromptText = "EXTRA MOBILE NO";
            this.Extra_MobileNo_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Extra_MobileNo_Txt.SelectedText = "";
            this.Extra_MobileNo_Txt.SelectionLength = 0;
            this.Extra_MobileNo_Txt.SelectionStart = 0;
            this.Extra_MobileNo_Txt.ShortcutsEnabled = true;
            this.Extra_MobileNo_Txt.ShowClearButton = true;
            this.Extra_MobileNo_Txt.Size = new System.Drawing.Size(287, 23);
            this.Extra_MobileNo_Txt.TabIndex = 74;
            this.Extra_MobileNo_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Extra_MobileNo_Txt.UseSelectable = true;
            this.Extra_MobileNo_Txt.WaterMark = "EXTRA MOBILE NO";
            this.Extra_MobileNo_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Extra_MobileNo_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Extra_MobileNo_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyName_Txt_KeyDown);
            this.Extra_MobileNo_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.companyID_Txt_KeyPress);
            // 
            // Extra_Email_Txt
            // 
            // 
            // 
            // 
            this.Extra_Email_Txt.CustomButton.Image = null;
            this.Extra_Email_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.Extra_Email_Txt.CustomButton.Name = "";
            this.Extra_Email_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Extra_Email_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.Extra_Email_Txt.CustomButton.TabIndex = 1;
            this.Extra_Email_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.Extra_Email_Txt.CustomButton.UseSelectable = true;
            this.Extra_Email_Txt.CustomButton.Visible = false;
            this.Extra_Email_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("Extra_Email_Txt.Icon")));
            this.Extra_Email_Txt.Lines = new string[0];
            this.Extra_Email_Txt.Location = new System.Drawing.Point(663, 53);
            this.Extra_Email_Txt.MaxLength = 32767;
            this.Extra_Email_Txt.Name = "Extra_Email_Txt";
            this.Extra_Email_Txt.PasswordChar = '\0';
            this.Extra_Email_Txt.PromptText = "EXTRA EMAIL";
            this.Extra_Email_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Extra_Email_Txt.SelectedText = "";
            this.Extra_Email_Txt.SelectionLength = 0;
            this.Extra_Email_Txt.SelectionStart = 0;
            this.Extra_Email_Txt.ShortcutsEnabled = true;
            this.Extra_Email_Txt.ShowClearButton = true;
            this.Extra_Email_Txt.Size = new System.Drawing.Size(287, 23);
            this.Extra_Email_Txt.TabIndex = 75;
            this.Extra_Email_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Extra_Email_Txt.UseSelectable = true;
            this.Extra_Email_Txt.WaterMark = "EXTRA EMAIL";
            this.Extra_Email_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Extra_Email_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Extra_Email_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyName_Txt_KeyDown);
            // 
            // CompanyName_Txt
            // 
            // 
            // 
            // 
            this.CompanyName_Txt.CustomButton.Image = null;
            this.CompanyName_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.CompanyName_Txt.CustomButton.Name = "";
            this.CompanyName_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CompanyName_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.CompanyName_Txt.CustomButton.TabIndex = 1;
            this.CompanyName_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.CompanyName_Txt.CustomButton.UseSelectable = true;
            this.CompanyName_Txt.CustomButton.Visible = false;
            this.CompanyName_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("CompanyName_Txt.Icon")));
            this.CompanyName_Txt.Lines = new string[0];
            this.CompanyName_Txt.Location = new System.Drawing.Point(46, 87);
            this.CompanyName_Txt.MaxLength = 32767;
            this.CompanyName_Txt.Name = "CompanyName_Txt";
            this.CompanyName_Txt.PasswordChar = '\0';
            this.CompanyName_Txt.PromptText = "COMPANY NAME";
            this.CompanyName_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CompanyName_Txt.SelectedText = "";
            this.CompanyName_Txt.SelectionLength = 0;
            this.CompanyName_Txt.SelectionStart = 0;
            this.CompanyName_Txt.ShortcutsEnabled = true;
            this.CompanyName_Txt.ShowClearButton = true;
            this.CompanyName_Txt.Size = new System.Drawing.Size(287, 23);
            this.CompanyName_Txt.TabIndex = 76;
            this.CompanyName_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CompanyName_Txt.UseSelectable = true;
            this.CompanyName_Txt.WaterMark = "COMPANY NAME";
            this.CompanyName_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CompanyName_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CompanyName_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyName_Txt_KeyDown);
            // 
            // CompanyGridUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WarPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CompanyGridUI";
            this.Resizable = false;
            this.Text = "COMPANIES";
            this.TextAlign = WarFramework.Forms.WarFormTextAlign.Right;
            this.groupBox1.ResumeLayout(false);
            this.WarPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WarGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WarFramework.Controls.WarComboBox STATUS_ComboBox;
        private WarFramework.Controls.WarTextBox PASSPORT_NO_Txt;
        private WarFramework.Controls.WarTextBox companyID_Txt;
        private WarFramework.Controls.WarTextBox EXTRA_DETAILS_Txt;
        private WarFramework.Controls.WarTextBox Address_Txt;
        private WarFramework.Controls.WarTextBox EMAIL_Txt;
        private WarFramework.Controls.WarTextBox Company_mobileNo_Txt;
        private WarFramework.Controls.WarDateTime DateTime1;
        private WarFramework.Controls.WarTextBox Owner_MOBILE_NO_Txt;
        private WarFramework.Controls.WarTextBox Owner_NAME_Txt;
        private WarFramework.Controls.WarPanel WarPanel1;
        private WarFramework.Controls.WarGrid WarGrid1;
        private WarFramework.Controls.WarTextBox Extra_Email_Txt;
        private WarFramework.Controls.WarTextBox Extra_MobileNo_Txt;
        private WarFramework.Controls.WarTextBox CompanyName_Txt;
    }
}