namespace com_war_air.com.WARUI.Bookings_Payments
{
    partial class PayAbleGridUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayAbleGridUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Company_Name_Id_ComboBox = new WarFramework.Controls.WarComboBox();
            this.IsPaidFullComboBox = new WarFramework.Controls.WarComboBox();
            this.DealSTATUS_ComboBox = new WarFramework.Controls.WarComboBox();
            this.Payable_ID_Txt = new WarFramework.Controls.WarTextBox();
            this.EXTRA_DETAILS_Txt = new WarFramework.Controls.WarTextBox();
            this.PayableAmount_Txt = new WarFramework.Controls.WarTextBox();
            this.RemainingAmount_Txt = new WarFramework.Controls.WarTextBox();
            this.BookingID_Txt = new WarFramework.Controls.WarTextBox();
            this.DateTime1 = new WarFramework.Controls.WarDateTime();
            this.PaidAmount_Txt = new WarFramework.Controls.WarTextBox();
            this.CompanyID_Txt = new WarFramework.Controls.WarTextBox();
            this.WarPanel1 = new WarFramework.Controls.WarPanel();
            this.WarGrid1 = new WarFramework.Controls.WarGrid();
            this.WarToolTip1 = new WarFramework.Components.WarToolTip();
            this.groupBox1.SuspendLayout();
            this.WarPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Company_Name_Id_ComboBox);
            this.groupBox1.Controls.Add(this.IsPaidFullComboBox);
            this.groupBox1.Controls.Add(this.DealSTATUS_ComboBox);
            this.groupBox1.Controls.Add(this.Payable_ID_Txt);
            this.groupBox1.Controls.Add(this.EXTRA_DETAILS_Txt);
            this.groupBox1.Controls.Add(this.PayableAmount_Txt);
            this.groupBox1.Controls.Add(this.RemainingAmount_Txt);
            this.groupBox1.Controls.Add(this.BookingID_Txt);
            this.groupBox1.Controls.Add(this.DateTime1);
            this.groupBox1.Controls.Add(this.PaidAmount_Txt);
            this.groupBox1.Controls.Add(this.CompanyID_Txt);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(4, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 146);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADVANCE SEARCH";
            // 
            // Company_Name_Id_ComboBox
            // 
            this.Company_Name_Id_ComboBox.FormattingEnabled = true;
            this.Company_Name_Id_ComboBox.ItemHeight = 23;
            this.Company_Name_Id_ComboBox.Items.AddRange(new object[] {
            "ALL"});
            this.Company_Name_Id_ComboBox.Location = new System.Drawing.Point(683, 17);
            this.Company_Name_Id_ComboBox.Name = "Company_Name_Id_ComboBox";
            this.Company_Name_Id_ComboBox.Size = new System.Drawing.Size(273, 29);
            this.Company_Name_Id_ComboBox.TabIndex = 80;
            this.WarToolTip1.SetToolTip(this.Company_Name_Id_ComboBox, "PACKAGE OFFERED BY COMPANY");
            this.Company_Name_Id_ComboBox.UseSelectable = true;
            this.Company_Name_Id_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Company_Name_Id_ComboBox_SelectedIndexChanged);
            // 
            // IsPaidFullComboBox
            // 
            this.IsPaidFullComboBox.FormattingEnabled = true;
            this.IsPaidFullComboBox.ItemHeight = 23;
            this.IsPaidFullComboBox.Items.AddRange(new object[] {
            "ALL",
            "CLEAR PAYMENT ONLY",
            "UNCLEAR ONLY"});
            this.IsPaidFullComboBox.Location = new System.Drawing.Point(741, 109);
            this.IsPaidFullComboBox.Name = "IsPaidFullComboBox";
            this.IsPaidFullComboBox.Size = new System.Drawing.Size(215, 29);
            this.IsPaidFullComboBox.TabIndex = 74;
            this.WarToolTip1.SetToolTip(this.IsPaidFullComboBox, "BY PAYMENT");
            this.IsPaidFullComboBox.UseSelectable = true;
            this.IsPaidFullComboBox.SelectedIndexChanged += new System.EventHandler(this.IsPaidFullComboBox_SelectedIndexChanged);
            // 
            // DealSTATUS_ComboBox
            // 
            this.DealSTATUS_ComboBox.FormattingEnabled = true;
            this.DealSTATUS_ComboBox.ItemHeight = 23;
            this.DealSTATUS_ComboBox.Items.AddRange(new object[] {
            "ALL",
            "ACTIVE",
            "CANCELLED"});
            this.DealSTATUS_ComboBox.Location = new System.Drawing.Point(741, 63);
            this.DealSTATUS_ComboBox.Name = "DealSTATUS_ComboBox";
            this.DealSTATUS_ComboBox.Size = new System.Drawing.Size(215, 29);
            this.DealSTATUS_ComboBox.TabIndex = 73;
            this.WarToolTip1.SetToolTip(this.DealSTATUS_ComboBox, "DEAL STATUS");
            this.DealSTATUS_ComboBox.UseSelectable = true;
            this.DealSTATUS_ComboBox.SelectedIndexChanged += new System.EventHandler(this.IsPaidFullComboBox_SelectedIndexChanged);
            // 
            // Payable_ID_Txt
            // 
            // 
            // 
            // 
            this.Payable_ID_Txt.CustomButton.Image = null;
            this.Payable_ID_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.Payable_ID_Txt.CustomButton.Name = "";
            this.Payable_ID_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Payable_ID_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.Payable_ID_Txt.CustomButton.TabIndex = 1;
            this.Payable_ID_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.Payable_ID_Txt.CustomButton.UseSelectable = true;
            this.Payable_ID_Txt.CustomButton.Visible = false;
            this.Payable_ID_Txt.Lines = new string[0];
            this.Payable_ID_Txt.Location = new System.Drawing.Point(26, 19);
            this.Payable_ID_Txt.MaxLength = 32767;
            this.Payable_ID_Txt.Name = "Payable_ID_Txt";
            this.Payable_ID_Txt.PasswordChar = '\0';
            this.Payable_ID_Txt.PromptText = "PAYABLE ID";
            this.Payable_ID_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Payable_ID_Txt.SelectedText = "";
            this.Payable_ID_Txt.SelectionLength = 0;
            this.Payable_ID_Txt.SelectionStart = 0;
            this.Payable_ID_Txt.ShortcutsEnabled = true;
            this.Payable_ID_Txt.ShowClearButton = true;
            this.Payable_ID_Txt.Size = new System.Drawing.Size(287, 23);
            this.Payable_ID_Txt.TabIndex = 62;
            this.Payable_ID_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Payable_ID_Txt.UseSelectable = true;
            this.Payable_ID_Txt.WaterMark = "PAYABLE ID";
            this.Payable_ID_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Payable_ID_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Payable_ID_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Payable_ID_Txt_KeyDown);
            this.Payable_ID_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Payable_ID_Txt_KeyPress);
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
            this.EXTRA_DETAILS_Txt.Location = new System.Drawing.Point(350, 77);
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
            this.EXTRA_DETAILS_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Payable_ID_Txt_KeyDown);
            // 
            // PayableAmount_Txt
            // 
            // 
            // 
            // 
            this.PayableAmount_Txt.CustomButton.Image = null;
            this.PayableAmount_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.PayableAmount_Txt.CustomButton.Name = "";
            this.PayableAmount_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PayableAmount_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.PayableAmount_Txt.CustomButton.TabIndex = 1;
            this.PayableAmount_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.PayableAmount_Txt.CustomButton.UseSelectable = true;
            this.PayableAmount_Txt.CustomButton.Visible = false;
            this.PayableAmount_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("PayableAmount_Txt.Icon")));
            this.PayableAmount_Txt.Lines = new string[0];
            this.PayableAmount_Txt.Location = new System.Drawing.Point(26, 109);
            this.PayableAmount_Txt.MaxLength = 32767;
            this.PayableAmount_Txt.Name = "PayableAmount_Txt";
            this.PayableAmount_Txt.PasswordChar = '\0';
            this.PayableAmount_Txt.PromptText = "PAYABLE AMOUNT";
            this.PayableAmount_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PayableAmount_Txt.SelectedText = "";
            this.PayableAmount_Txt.SelectionLength = 0;
            this.PayableAmount_Txt.SelectionStart = 0;
            this.PayableAmount_Txt.ShortcutsEnabled = true;
            this.PayableAmount_Txt.ShowClearButton = true;
            this.PayableAmount_Txt.Size = new System.Drawing.Size(287, 23);
            this.PayableAmount_Txt.TabIndex = 57;
            this.PayableAmount_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PayableAmount_Txt.UseSelectable = true;
            this.PayableAmount_Txt.WaterMark = "PAYABLE AMOUNT";
            this.PayableAmount_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PayableAmount_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PayableAmount_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Payable_ID_Txt_KeyDown);
            this.PayableAmount_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Payable_ID_Txt_KeyPress);
            // 
            // RemainingAmount_Txt
            // 
            // 
            // 
            // 
            this.RemainingAmount_Txt.CustomButton.Image = null;
            this.RemainingAmount_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.RemainingAmount_Txt.CustomButton.Name = "";
            this.RemainingAmount_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RemainingAmount_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.RemainingAmount_Txt.CustomButton.TabIndex = 1;
            this.RemainingAmount_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.RemainingAmount_Txt.CustomButton.UseSelectable = true;
            this.RemainingAmount_Txt.CustomButton.Visible = false;
            this.RemainingAmount_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("RemainingAmount_Txt.Icon")));
            this.RemainingAmount_Txt.Lines = new string[0];
            this.RemainingAmount_Txt.Location = new System.Drawing.Point(350, 48);
            this.RemainingAmount_Txt.MaxLength = 32767;
            this.RemainingAmount_Txt.Name = "RemainingAmount_Txt";
            this.RemainingAmount_Txt.PasswordChar = '\0';
            this.RemainingAmount_Txt.PromptText = "REMAINING AMOUNT";
            this.RemainingAmount_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RemainingAmount_Txt.SelectedText = "";
            this.RemainingAmount_Txt.SelectionLength = 0;
            this.RemainingAmount_Txt.SelectionStart = 0;
            this.RemainingAmount_Txt.ShortcutsEnabled = true;
            this.RemainingAmount_Txt.ShowClearButton = true;
            this.RemainingAmount_Txt.Size = new System.Drawing.Size(287, 23);
            this.RemainingAmount_Txt.TabIndex = 59;
            this.RemainingAmount_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RemainingAmount_Txt.UseSelectable = true;
            this.RemainingAmount_Txt.WaterMark = "REMAINING AMOUNT";
            this.RemainingAmount_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RemainingAmount_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.RemainingAmount_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Payable_ID_Txt_KeyDown);
            this.RemainingAmount_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Payable_ID_Txt_KeyPress);
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
            this.BookingID_Txt.Location = new System.Drawing.Point(26, 77);
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
            this.BookingID_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Payable_ID_Txt_KeyDown);
            this.BookingID_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Payable_ID_Txt_KeyPress);
            // 
            // DateTime1
            // 
            this.DateTime1.Checked = false;
            this.DateTime1.Location = new System.Drawing.Point(394, 109);
            this.DateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTime1.Name = "DateTime1";
            this.DateTime1.ShowCheckBox = true;
            this.DateTime1.Size = new System.Drawing.Size(243, 29);
            this.DateTime1.TabIndex = 55;
            this.DateTime1.ValueChanged += new System.EventHandler(this.DateTime1_ValueChanged);
            // 
            // PaidAmount_Txt
            // 
            // 
            // 
            // 
            this.PaidAmount_Txt.CustomButton.Image = null;
            this.PaidAmount_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.PaidAmount_Txt.CustomButton.Name = "";
            this.PaidAmount_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PaidAmount_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.PaidAmount_Txt.CustomButton.TabIndex = 1;
            this.PaidAmount_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.PaidAmount_Txt.CustomButton.UseSelectable = true;
            this.PaidAmount_Txt.CustomButton.Visible = false;
            this.PaidAmount_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("PaidAmount_Txt.Icon")));
            this.PaidAmount_Txt.Lines = new string[0];
            this.PaidAmount_Txt.Location = new System.Drawing.Point(350, 19);
            this.PaidAmount_Txt.MaxLength = 32767;
            this.PaidAmount_Txt.Name = "PaidAmount_Txt";
            this.PaidAmount_Txt.PasswordChar = '\0';
            this.PaidAmount_Txt.PromptText = "PAID AMOUNT";
            this.PaidAmount_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PaidAmount_Txt.SelectedText = "";
            this.PaidAmount_Txt.SelectionLength = 0;
            this.PaidAmount_Txt.SelectionStart = 0;
            this.PaidAmount_Txt.ShortcutsEnabled = true;
            this.PaidAmount_Txt.ShowClearButton = true;
            this.PaidAmount_Txt.Size = new System.Drawing.Size(287, 23);
            this.PaidAmount_Txt.TabIndex = 56;
            this.PaidAmount_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PaidAmount_Txt.UseSelectable = true;
            this.PaidAmount_Txt.WaterMark = "PAID AMOUNT";
            this.PaidAmount_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PaidAmount_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PaidAmount_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Payable_ID_Txt_KeyDown);
            this.PaidAmount_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Payable_ID_Txt_KeyPress);
            // 
            // CompanyID_Txt
            // 
            // 
            // 
            // 
            this.CompanyID_Txt.CustomButton.Image = null;
            this.CompanyID_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.CompanyID_Txt.CustomButton.Name = "";
            this.CompanyID_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CompanyID_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.CompanyID_Txt.CustomButton.TabIndex = 1;
            this.CompanyID_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.CompanyID_Txt.CustomButton.UseSelectable = true;
            this.CompanyID_Txt.CustomButton.Visible = false;
            this.CompanyID_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("CompanyID_Txt.Icon")));
            this.CompanyID_Txt.Lines = new string[0];
            this.CompanyID_Txt.Location = new System.Drawing.Point(26, 48);
            this.CompanyID_Txt.MaxLength = 32767;
            this.CompanyID_Txt.Name = "CompanyID_Txt";
            this.CompanyID_Txt.PasswordChar = '\0';
            this.CompanyID_Txt.PromptText = "COMPANY ID";
            this.CompanyID_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CompanyID_Txt.SelectedText = "";
            this.CompanyID_Txt.SelectionLength = 0;
            this.CompanyID_Txt.SelectionStart = 0;
            this.CompanyID_Txt.ShortcutsEnabled = true;
            this.CompanyID_Txt.ShowClearButton = true;
            this.CompanyID_Txt.Size = new System.Drawing.Size(287, 23);
            this.CompanyID_Txt.TabIndex = 60;
            this.CompanyID_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CompanyID_Txt.UseSelectable = true;
            this.CompanyID_Txt.WaterMark = "COMPANY ID";
            this.CompanyID_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CompanyID_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CompanyID_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Payable_ID_Txt_KeyDown);
            this.CompanyID_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Payable_ID_Txt_KeyPress);
            // 
            // WarPanel1
            // 
            this.WarPanel1.Controls.Add(this.WarGrid1);
            this.WarPanel1.HorizontalScrollbarBarColor = true;
            this.WarPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.WarPanel1.HorizontalScrollbarSize = 10;
            this.WarPanel1.Location = new System.Drawing.Point(16, 203);
            this.WarPanel1.Name = "WarPanel1";
            this.WarPanel1.Size = new System.Drawing.Size(961, 362);
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
            this.WarGrid1.Size = new System.Drawing.Size(961, 362);
            this.WarGrid1.TabIndex = 3;
            this.WarGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarGrid1_CellClick);
            this.WarGrid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarGrid1_CellDoubleClick);
            // 
            // WarToolTip1
            // 
            this.WarToolTip1.Style = WarFramework.WarColorStyle.Blue;
            this.WarToolTip1.StyleManager = null;
            this.WarToolTip1.Theme = WarFramework.WarThemeStyle.Light;
            // 
            // PayAbleGridUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 574);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WarPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PayAbleGridUI";
            this.Resizable = false;
            this.Text = "PAYABLE\'S";
            this.TextAlign = WarFramework.Forms.WarFormTextAlign.Right;
            this.Load += new System.EventHandler(this.PayAbleGridUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.WarPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WarGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WarFramework.Controls.WarComboBox DealSTATUS_ComboBox;
        private WarFramework.Controls.WarTextBox Payable_ID_Txt;
        private WarFramework.Controls.WarTextBox PayableAmount_Txt;
        private WarFramework.Controls.WarTextBox RemainingAmount_Txt;
        private WarFramework.Controls.WarTextBox BookingID_Txt;
        private WarFramework.Controls.WarDateTime DateTime1;
        private WarFramework.Controls.WarTextBox PaidAmount_Txt;
        private WarFramework.Controls.WarTextBox CompanyID_Txt;
        private WarFramework.Controls.WarPanel WarPanel1;
        private WarFramework.Controls.WarGrid WarGrid1;
        private WarFramework.Controls.WarComboBox IsPaidFullComboBox;
        private WarFramework.Components.WarToolTip WarToolTip1;
        private WarFramework.Controls.WarTextBox EXTRA_DETAILS_Txt;
        private WarFramework.Controls.WarComboBox Company_Name_Id_ComboBox;
    }
}