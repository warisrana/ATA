namespace com_war_air.com.WARUI.Agents_Customers
{
    partial class CustomerGridUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerGridUI));
            this.WarPanel1 = new WarFramework.Controls.WarPanel();
            this.WarGrid1 = new WarFramework.Controls.WarGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.STATUS_ComboBox = new WarFramework.Controls.WarComboBox();
            this.PASSPORT_NO_Txt = new WarFramework.Controls.WarTextBox();
            this.ID_Txt = new WarFramework.Controls.WarTextBox();
            this.Customer_Radio = new WarFramework.Controls.WarRadioButton();
            this.EXTRA_DETAILS_Txt = new WarFramework.Controls.WarTextBox();
            this.Address_Txt = new WarFramework.Controls.WarTextBox();
            this.EMAIL_Txt = new WarFramework.Controls.WarTextBox();
            this.LAST_NAME_Txt = new WarFramework.Controls.WarTextBox();
            this.DateTime1 = new WarFramework.Controls.WarDateTime();
            this.Agent_Radio = new WarFramework.Controls.WarRadioButton();
            this.MOBILE_NO_Txt = new WarFramework.Controls.WarTextBox();
            this.FIRST_NAME_Txt = new WarFramework.Controls.WarTextBox();
            this.WarToolTip1 = new WarFramework.Components.WarToolTip();
            this.WarPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WarPanel1
            // 
            this.WarPanel1.Controls.Add(this.WarGrid1);
            this.WarPanel1.HorizontalScrollbarBarColor = true;
            this.WarPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.WarPanel1.HorizontalScrollbarSize = 10;
            this.WarPanel1.Location = new System.Drawing.Point(10, 230);
            this.WarPanel1.Name = "WarPanel1";
            this.WarPanel1.Size = new System.Drawing.Size(1332, 425);
            this.WarPanel1.TabIndex = 6;
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
            this.WarGrid1.Size = new System.Drawing.Size(1332, 425);
            this.WarGrid1.TabIndex = 3;
            this.WarGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarGrid1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.STATUS_ComboBox);
            this.groupBox1.Controls.Add(this.PASSPORT_NO_Txt);
            this.groupBox1.Controls.Add(this.ID_Txt);
            this.groupBox1.Controls.Add(this.Customer_Radio);
            this.groupBox1.Controls.Add(this.EXTRA_DETAILS_Txt);
            this.groupBox1.Controls.Add(this.Address_Txt);
            this.groupBox1.Controls.Add(this.EMAIL_Txt);
            this.groupBox1.Controls.Add(this.LAST_NAME_Txt);
            this.groupBox1.Controls.Add(this.DateTime1);
            this.groupBox1.Controls.Add(this.Agent_Radio);
            this.groupBox1.Controls.Add(this.MOBILE_NO_Txt);
            this.groupBox1.Controls.Add(this.FIRST_NAME_Txt);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(10, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1332, 146);
            this.groupBox1.TabIndex = 68;
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
            this.STATUS_ComboBox.Location = new System.Drawing.Point(1095, 24);
            this.STATUS_ComboBox.Name = "STATUS_ComboBox";
            this.STATUS_ComboBox.Size = new System.Drawing.Size(215, 29);
            this.STATUS_ComboBox.TabIndex = 73;
            this.WarToolTip1.SetToolTip(this.STATUS_ComboBox, "STATUS");
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
            this.PASSPORT_NO_Txt.Location = new System.Drawing.Point(1095, 24);
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
            this.WarToolTip1.SetToolTip(this.PASSPORT_NO_Txt, "PASSPORT NO");
            this.PASSPORT_NO_Txt.UseSelectable = true;
            this.PASSPORT_NO_Txt.WaterMark = "PASSPORT NO";
            this.PASSPORT_NO_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PASSPORT_NO_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PASSPORT_NO_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_Txt_KeyDown);
            this.PASSPORT_NO_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_Txt_KeyPress);
            // 
            // ID_Txt
            // 
            // 
            // 
            // 
            this.ID_Txt.CustomButton.Image = null;
            this.ID_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.ID_Txt.CustomButton.Name = "";
            this.ID_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ID_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.ID_Txt.CustomButton.TabIndex = 1;
            this.ID_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.ID_Txt.CustomButton.UseSelectable = true;
            this.ID_Txt.CustomButton.Visible = false;
            this.ID_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("ID_Txt.Icon")));
            this.ID_Txt.Lines = new string[0];
            this.ID_Txt.Location = new System.Drawing.Point(189, 19);
            this.ID_Txt.MaxLength = 32767;
            this.ID_Txt.Name = "ID_Txt";
            this.ID_Txt.PasswordChar = '\0';
            this.ID_Txt.PromptText = "CUSTOMER / AGENT  ID";
            this.ID_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ID_Txt.SelectedText = "";
            this.ID_Txt.SelectionLength = 0;
            this.ID_Txt.SelectionStart = 0;
            this.ID_Txt.ShortcutsEnabled = true;
            this.ID_Txt.ShowClearButton = true;
            this.ID_Txt.Size = new System.Drawing.Size(287, 23);
            this.ID_Txt.TabIndex = 62;
            this.ID_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WarToolTip1.SetToolTip(this.ID_Txt, "CUSTOMER / AGENT  ID");
            this.ID_Txt.UseSelectable = true;
            this.ID_Txt.WaterMark = "CUSTOMER / AGENT  ID";
            this.ID_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ID_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ID_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_Txt_KeyDown);
            this.ID_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_Txt_KeyPress);
            // 
            // Customer_Radio
            // 
            this.Customer_Radio.AutoSize = true;
            this.Customer_Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Customer_Radio.Location = new System.Drawing.Point(38, 25);
            this.Customer_Radio.Name = "Customer_Radio";
            this.Customer_Radio.Size = new System.Drawing.Size(84, 15);
            this.Customer_Radio.TabIndex = 66;
            this.Customer_Radio.Text = "CUSTOMER";
            this.Customer_Radio.UseSelectable = true;
            this.Customer_Radio.Click += new System.EventHandler(this.Customer_Radio_Click);
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
            this.EXTRA_DETAILS_Txt.Location = new System.Drawing.Point(513, 77);
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
            this.WarToolTip1.SetToolTip(this.EXTRA_DETAILS_Txt, "EXTRA DETAILS");
            this.EXTRA_DETAILS_Txt.UseSelectable = true;
            this.EXTRA_DETAILS_Txt.WaterMark = "EXTRA DETAILS";
            this.EXTRA_DETAILS_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EXTRA_DETAILS_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.EXTRA_DETAILS_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_Txt_KeyDown);
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
            this.Address_Txt.Location = new System.Drawing.Point(189, 109);
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
            this.WarToolTip1.SetToolTip(this.Address_Txt, "ADDRESS");
            this.Address_Txt.UseSelectable = true;
            this.Address_Txt.WaterMark = "ADDRESS";
            this.Address_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Address_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Address_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_Txt_KeyDown);
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
            this.EMAIL_Txt.Location = new System.Drawing.Point(513, 48);
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
            this.WarToolTip1.SetToolTip(this.EMAIL_Txt, "EMAIL");
            this.EMAIL_Txt.UseSelectable = true;
            this.EMAIL_Txt.WaterMark = "EMAIL";
            this.EMAIL_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EMAIL_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.EMAIL_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_Txt_KeyDown);
            // 
            // LAST_NAME_Txt
            // 
            // 
            // 
            // 
            this.LAST_NAME_Txt.CustomButton.Image = null;
            this.LAST_NAME_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.LAST_NAME_Txt.CustomButton.Name = "";
            this.LAST_NAME_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LAST_NAME_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.LAST_NAME_Txt.CustomButton.TabIndex = 1;
            this.LAST_NAME_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.LAST_NAME_Txt.CustomButton.UseSelectable = true;
            this.LAST_NAME_Txt.CustomButton.Visible = false;
            this.LAST_NAME_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("LAST_NAME_Txt.Icon")));
            this.LAST_NAME_Txt.Lines = new string[0];
            this.LAST_NAME_Txt.Location = new System.Drawing.Point(189, 77);
            this.LAST_NAME_Txt.MaxLength = 13;
            this.LAST_NAME_Txt.Name = "LAST_NAME_Txt";
            this.LAST_NAME_Txt.PasswordChar = '\0';
            this.LAST_NAME_Txt.PromptText = "LAST NAME";
            this.LAST_NAME_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LAST_NAME_Txt.SelectedText = "";
            this.LAST_NAME_Txt.SelectionLength = 0;
            this.LAST_NAME_Txt.SelectionStart = 0;
            this.LAST_NAME_Txt.ShortcutsEnabled = true;
            this.LAST_NAME_Txt.ShowClearButton = true;
            this.LAST_NAME_Txt.Size = new System.Drawing.Size(287, 23);
            this.LAST_NAME_Txt.TabIndex = 61;
            this.LAST_NAME_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WarToolTip1.SetToolTip(this.LAST_NAME_Txt, "LAST NAME");
            this.LAST_NAME_Txt.UseSelectable = true;
            this.LAST_NAME_Txt.WaterMark = "LAST NAME";
            this.LAST_NAME_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LAST_NAME_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.LAST_NAME_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_Txt_KeyDown);
            // 
            // DateTime1
            // 
            this.DateTime1.Checked = false;
            this.DateTime1.Location = new System.Drawing.Point(1067, 103);
            this.DateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTime1.Name = "DateTime1";
            this.DateTime1.ShowCheckBox = true;
            this.DateTime1.Size = new System.Drawing.Size(243, 29);
            this.DateTime1.TabIndex = 55;
            this.DateTime1.ValueChanged += new System.EventHandler(this.DateTime1_ValueChanged);
            // 
            // Agent_Radio
            // 
            this.Agent_Radio.AutoSize = true;
            this.Agent_Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Agent_Radio.Location = new System.Drawing.Point(38, 54);
            this.Agent_Radio.Name = "Agent_Radio";
            this.Agent_Radio.Size = new System.Drawing.Size(61, 15);
            this.Agent_Radio.TabIndex = 64;
            this.Agent_Radio.Text = "AGENT";
            this.Agent_Radio.UseSelectable = true;
            this.Agent_Radio.Click += new System.EventHandler(this.Agent_Radio_Click);
            // 
            // MOBILE_NO_Txt
            // 
            // 
            // 
            // 
            this.MOBILE_NO_Txt.CustomButton.Image = null;
            this.MOBILE_NO_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.MOBILE_NO_Txt.CustomButton.Name = "";
            this.MOBILE_NO_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MOBILE_NO_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.MOBILE_NO_Txt.CustomButton.TabIndex = 1;
            this.MOBILE_NO_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.MOBILE_NO_Txt.CustomButton.UseSelectable = true;
            this.MOBILE_NO_Txt.CustomButton.Visible = false;
            this.MOBILE_NO_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("MOBILE_NO_Txt.Icon")));
            this.MOBILE_NO_Txt.Lines = new string[0];
            this.MOBILE_NO_Txt.Location = new System.Drawing.Point(513, 19);
            this.MOBILE_NO_Txt.MaxLength = 32767;
            this.MOBILE_NO_Txt.Name = "MOBILE_NO_Txt";
            this.MOBILE_NO_Txt.PasswordChar = '\0';
            this.MOBILE_NO_Txt.PromptText = "MOBILE NO";
            this.MOBILE_NO_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MOBILE_NO_Txt.SelectedText = "";
            this.MOBILE_NO_Txt.SelectionLength = 0;
            this.MOBILE_NO_Txt.SelectionStart = 0;
            this.MOBILE_NO_Txt.ShortcutsEnabled = true;
            this.MOBILE_NO_Txt.ShowClearButton = true;
            this.MOBILE_NO_Txt.Size = new System.Drawing.Size(287, 23);
            this.MOBILE_NO_Txt.TabIndex = 56;
            this.MOBILE_NO_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WarToolTip1.SetToolTip(this.MOBILE_NO_Txt, "MOBILE NO");
            this.MOBILE_NO_Txt.UseSelectable = true;
            this.MOBILE_NO_Txt.WaterMark = "MOBILE NO";
            this.MOBILE_NO_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MOBILE_NO_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MOBILE_NO_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_Txt_KeyDown);
            this.MOBILE_NO_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_Txt_KeyPress);
            // 
            // FIRST_NAME_Txt
            // 
            // 
            // 
            // 
            this.FIRST_NAME_Txt.CustomButton.Image = null;
            this.FIRST_NAME_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.FIRST_NAME_Txt.CustomButton.Name = "";
            this.FIRST_NAME_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FIRST_NAME_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.FIRST_NAME_Txt.CustomButton.TabIndex = 1;
            this.FIRST_NAME_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.FIRST_NAME_Txt.CustomButton.UseSelectable = true;
            this.FIRST_NAME_Txt.CustomButton.Visible = false;
            this.FIRST_NAME_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("FIRST_NAME_Txt.Icon")));
            this.FIRST_NAME_Txt.Lines = new string[0];
            this.FIRST_NAME_Txt.Location = new System.Drawing.Point(189, 48);
            this.FIRST_NAME_Txt.MaxLength = 32767;
            this.FIRST_NAME_Txt.Name = "FIRST_NAME_Txt";
            this.FIRST_NAME_Txt.PasswordChar = '\0';
            this.FIRST_NAME_Txt.PromptText = "FIRST NAME";
            this.FIRST_NAME_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FIRST_NAME_Txt.SelectedText = "";
            this.FIRST_NAME_Txt.SelectionLength = 0;
            this.FIRST_NAME_Txt.SelectionStart = 0;
            this.FIRST_NAME_Txt.ShortcutsEnabled = true;
            this.FIRST_NAME_Txt.ShowClearButton = true;
            this.FIRST_NAME_Txt.Size = new System.Drawing.Size(287, 23);
            this.FIRST_NAME_Txt.TabIndex = 60;
            this.FIRST_NAME_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WarToolTip1.SetToolTip(this.FIRST_NAME_Txt, "FIRST NAME");
            this.FIRST_NAME_Txt.UseSelectable = true;
            this.FIRST_NAME_Txt.WaterMark = "FIRST NAME";
            this.FIRST_NAME_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FIRST_NAME_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.FIRST_NAME_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_Txt_KeyDown);
            // 
            // WarToolTip1
            // 
            this.WarToolTip1.Style = WarFramework.WarColorStyle.Blue;
            this.WarToolTip1.StyleManager = null;
            this.WarToolTip1.Theme = WarFramework.WarThemeStyle.Light;
            // 
            // CustomerGridUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 665);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WarPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerGridUI";
            this.Resizable = false;
            this.Text = "CUSTOMERS AND AGENTS";
            this.TextAlign = WarFramework.Forms.WarFormTextAlign.Right;
            this.Load += new System.EventHandler(this.CustomerGridUI_Load);
            this.WarPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WarGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WarFramework.Controls.WarPanel WarPanel1;
        private WarFramework.Controls.WarGrid WarGrid1;
        private System.Windows.Forms.GroupBox groupBox1;
        private WarFramework.Controls.WarTextBox PASSPORT_NO_Txt;
        private WarFramework.Controls.WarTextBox ID_Txt;
        private WarFramework.Controls.WarRadioButton Customer_Radio;
        private WarFramework.Controls.WarTextBox EXTRA_DETAILS_Txt;
        private WarFramework.Controls.WarTextBox Address_Txt;
        private WarFramework.Controls.WarTextBox EMAIL_Txt;
        private WarFramework.Controls.WarTextBox LAST_NAME_Txt;
        private WarFramework.Controls.WarDateTime DateTime1;
        private WarFramework.Controls.WarRadioButton Agent_Radio;
        private WarFramework.Controls.WarTextBox MOBILE_NO_Txt;
        private WarFramework.Controls.WarTextBox FIRST_NAME_Txt;
        private WarFramework.Components.WarToolTip WarToolTip1;
        private WarFramework.Controls.WarComboBox STATUS_ComboBox;
    }
}