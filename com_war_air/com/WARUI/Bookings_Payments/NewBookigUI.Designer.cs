namespace com_war_air.com.WARUI.Bookings_Payments
{
    partial class NewBookigUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBookigUI));
            this.Package_NamesComboBox = new WarFramework.Controls.WarComboBox();
            this.Package_CodeComboBox = new WarFramework.Controls.WarComboBox();
            this.groupBoxAll_costs = new System.Windows.Forms.GroupBox();
            this.WarLabel4 = new WarFramework.Controls.WarLabel();
            this.WarLabel3 = new WarFramework.Controls.WarLabel();
            this.WarLabel2 = new WarFramework.Controls.WarLabel();
            this.WarLabel1 = new WarFramework.Controls.WarLabel();
            this.Cost4_Radio = new WarFramework.Controls.WarRadioButton();
            this.Cost3_Radio = new WarFramework.Controls.WarRadioButton();
            this.Cost2_Radio = new WarFramework.Controls.WarRadioButton();
            this.Cost1_Radio = new WarFramework.Controls.WarRadioButton();
            this.WarToolTip1 = new WarFramework.Components.WarToolTip();
            this.Customer_referenceType1_Radio = new WarFramework.Controls.WarRadioButton();
            this.Customer_referenceType2_Agent_Radio = new WarFramework.Controls.WarRadioButton();
            this.Custmer_Or_Agent_ID_Txt = new WarFramework.Controls.WarTextBox();
            this.Orignal_Total_Txt = new WarFramework.Controls.WarTextBox();
            this.For_No_of_Persons_Txt = new WarFramework.Controls.WarTextBox();
            this.Extra_Discount_Txt = new WarFramework.Controls.WarTextBox();
            this.Grand_Total_Txt = new WarFramework.Controls.WarTextBox();
            this.Collected_Amount_Txt = new WarFramework.Controls.WarTextBox();
            this.Remaining_Amount_Txt = new WarFramework.Controls.WarTextBox();
            this.Tatal_Discount_Txt = new WarFramework.Controls.WarTextBox();
            this.For_No_Of_Days_linkTxt = new WarFramework.Controls.WarLink();
            this.SpecialOffer_Discount_link_Txt = new WarFramework.Controls.WarLink();
            this.WarLabel5 = new WarFramework.Controls.WarLabel();
            this.WarLabel6 = new WarFramework.Controls.WarLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ImageR = new System.Windows.Forms.PictureBox();
            this.Id_info_nameLink = new WarFramework.Controls.WarLink();
            this.groupBox_payments = new System.Windows.Forms.GroupBox();
            this.WarLabel12 = new WarFramework.Controls.WarLabel();
            this.SAVE_New_Booking_Btn = new System.Windows.Forms.Button();
            this.WarCheckBox1 = new WarFramework.Controls.WarCheckBox();
            this.WarLabel11 = new WarFramework.Controls.WarLabel();
            this.WarLabel10 = new WarFramework.Controls.WarLabel();
            this.WarLabel9 = new WarFramework.Controls.WarLabel();
            this.WarLabel8 = new WarFramework.Controls.WarLabel();
            this.WarLabel7 = new WarFramework.Controls.WarLabel();
            this.groupBox_noofpersons = new System.Windows.Forms.GroupBox();
            this.Minus_person_Btn = new System.Windows.Forms.Button();
            this.Add_person_Btn = new System.Windows.Forms.Button();
            this.groupBoxPackageMain = new System.Windows.Forms.GroupBox();
            this.canceledLable = new WarFramework.Controls.WarLabel();
            this.cancelagentLable = new WarFramework.Controls.WarLabel();
            this.ButtonForCustmerRegister = new System.Windows.Forms.Button();
            this.groupBoxAll_costs.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageR)).BeginInit();
            this.groupBox_payments.SuspendLayout();
            this.groupBox_noofpersons.SuspendLayout();
            this.groupBoxPackageMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // Package_NamesComboBox
            // 
            this.Package_NamesComboBox.FormattingEnabled = true;
            this.Package_NamesComboBox.ItemHeight = 23;
            this.Package_NamesComboBox.Location = new System.Drawing.Point(25, 26);
            this.Package_NamesComboBox.Name = "Package_NamesComboBox";
            this.Package_NamesComboBox.Size = new System.Drawing.Size(194, 29);
            this.Package_NamesComboBox.TabIndex = 0;
            this.WarToolTip1.SetToolTip(this.Package_NamesComboBox, "PACKAGE NAME");
            this.Package_NamesComboBox.UseSelectable = true;
            this.Package_NamesComboBox.SelectedIndexChanged += new System.EventHandler(this.Package_NamesComboBox_SelectedIndexChanged);
            // 
            // Package_CodeComboBox
            // 
            this.Package_CodeComboBox.FormattingEnabled = true;
            this.Package_CodeComboBox.ItemHeight = 23;
            this.Package_CodeComboBox.Location = new System.Drawing.Point(289, 26);
            this.Package_CodeComboBox.Name = "Package_CodeComboBox";
            this.Package_CodeComboBox.Size = new System.Drawing.Size(194, 29);
            this.Package_CodeComboBox.TabIndex = 1;
            this.WarToolTip1.SetToolTip(this.Package_CodeComboBox, "PACKAGE CODE");
            this.Package_CodeComboBox.UseSelectable = true;
            this.Package_CodeComboBox.SelectedIndexChanged += new System.EventHandler(this.Package_CodeComboBox_SelectedIndexChanged);
            this.Package_CodeComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Package_CodeComboBox_MouseClick);
            // 
            // groupBoxAll_costs
            // 
            this.groupBoxAll_costs.Controls.Add(this.WarLabel4);
            this.groupBoxAll_costs.Controls.Add(this.WarLabel3);
            this.groupBoxAll_costs.Controls.Add(this.WarLabel2);
            this.groupBoxAll_costs.Controls.Add(this.WarLabel1);
            this.groupBoxAll_costs.Controls.Add(this.Cost4_Radio);
            this.groupBoxAll_costs.Controls.Add(this.Cost3_Radio);
            this.groupBoxAll_costs.Controls.Add(this.Cost2_Radio);
            this.groupBoxAll_costs.Controls.Add(this.Cost1_Radio);
            this.groupBoxAll_costs.Enabled = false;
            this.groupBoxAll_costs.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBoxAll_costs.Location = new System.Drawing.Point(25, 64);
            this.groupBoxAll_costs.Name = "groupBoxAll_costs";
            this.groupBoxAll_costs.Size = new System.Drawing.Size(244, 162);
            this.groupBoxAll_costs.TabIndex = 35;
            this.groupBoxAll_costs.TabStop = false;
            this.groupBoxAll_costs.Text = "PACKGE COSTS";
            // 
            // WarLabel4
            // 
            this.WarLabel4.AutoSize = true;
            this.WarLabel4.Location = new System.Drawing.Point(7, 125);
            this.WarLabel4.Name = "WarLabel4";
            this.WarLabel4.Size = new System.Drawing.Size(66, 19);
            this.WarLabel4.TabIndex = 43;
            this.WarLabel4.Text = "COST # 4";
            // 
            // WarLabel3
            // 
            this.WarLabel3.AutoSize = true;
            this.WarLabel3.Location = new System.Drawing.Point(7, 96);
            this.WarLabel3.Name = "WarLabel3";
            this.WarLabel3.Size = new System.Drawing.Size(66, 19);
            this.WarLabel3.TabIndex = 42;
            this.WarLabel3.Text = "COST # 3";
            // 
            // WarLabel2
            // 
            this.WarLabel2.AutoSize = true;
            this.WarLabel2.Location = new System.Drawing.Point(7, 63);
            this.WarLabel2.Name = "WarLabel2";
            this.WarLabel2.Size = new System.Drawing.Size(66, 19);
            this.WarLabel2.TabIndex = 41;
            this.WarLabel2.Text = "COST # 2";
            // 
            // WarLabel1
            // 
            this.WarLabel1.AutoSize = true;
            this.WarLabel1.Location = new System.Drawing.Point(7, 31);
            this.WarLabel1.Name = "WarLabel1";
            this.WarLabel1.Size = new System.Drawing.Size(64, 19);
            this.WarLabel1.TabIndex = 40;
            this.WarLabel1.Text = "COST # 1";
            // 
            // Cost4_Radio
            // 
            this.Cost4_Radio.AutoSize = true;
            this.Cost4_Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cost4_Radio.Location = new System.Drawing.Point(124, 129);
            this.Cost4_Radio.Name = "Cost4_Radio";
            this.Cost4_Radio.Size = new System.Drawing.Size(68, 15);
            this.Cost4_Radio.TabIndex = 39;
            this.Cost4_Radio.Text = "0000.000";
            this.WarToolTip1.SetToolTip(this.Cost4_Radio, "COST # 4");
            this.Cost4_Radio.UseSelectable = true;
            this.Cost4_Radio.CheckedChanged += new System.EventHandler(this.Cost1_Radio_CheckedChanged);
            // 
            // Cost3_Radio
            // 
            this.Cost3_Radio.AutoSize = true;
            this.Cost3_Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cost3_Radio.Location = new System.Drawing.Point(124, 96);
            this.Cost3_Radio.Name = "Cost3_Radio";
            this.Cost3_Radio.Size = new System.Drawing.Size(68, 15);
            this.Cost3_Radio.TabIndex = 38;
            this.Cost3_Radio.Text = "0000.000";
            this.WarToolTip1.SetToolTip(this.Cost3_Radio, "COST # 3");
            this.Cost3_Radio.UseSelectable = true;
            this.Cost3_Radio.CheckedChanged += new System.EventHandler(this.Cost1_Radio_CheckedChanged);
            // 
            // Cost2_Radio
            // 
            this.Cost2_Radio.AutoSize = true;
            this.Cost2_Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cost2_Radio.Location = new System.Drawing.Point(124, 63);
            this.Cost2_Radio.Name = "Cost2_Radio";
            this.Cost2_Radio.Size = new System.Drawing.Size(68, 15);
            this.Cost2_Radio.TabIndex = 37;
            this.Cost2_Radio.Text = "0000.000";
            this.WarToolTip1.SetToolTip(this.Cost2_Radio, "COST # 2");
            this.Cost2_Radio.UseSelectable = true;
            this.Cost2_Radio.CheckedChanged += new System.EventHandler(this.Cost1_Radio_CheckedChanged);
            // 
            // Cost1_Radio
            // 
            this.Cost1_Radio.AutoSize = true;
            this.Cost1_Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cost1_Radio.Location = new System.Drawing.Point(124, 31);
            this.Cost1_Radio.Name = "Cost1_Radio";
            this.Cost1_Radio.Size = new System.Drawing.Size(68, 15);
            this.Cost1_Radio.TabIndex = 36;
            this.Cost1_Radio.Text = "0000.000";
            this.WarToolTip1.SetToolTip(this.Cost1_Radio, "COST #1");
            this.Cost1_Radio.UseSelectable = true;
            this.Cost1_Radio.CheckedChanged += new System.EventHandler(this.Cost1_Radio_CheckedChanged);
            // 
            // WarToolTip1
            // 
            this.WarToolTip1.Style = WarFramework.WarColorStyle.Blue;
            this.WarToolTip1.StyleManager = null;
            this.WarToolTip1.Theme = WarFramework.WarThemeStyle.Light;
            // 
            // Customer_referenceType1_Radio
            // 
            this.Customer_referenceType1_Radio.AutoSize = true;
            this.Customer_referenceType1_Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Customer_referenceType1_Radio.Location = new System.Drawing.Point(25, 32);
            this.Customer_referenceType1_Radio.Name = "Customer_referenceType1_Radio";
            this.Customer_referenceType1_Radio.Size = new System.Drawing.Size(84, 15);
            this.Customer_referenceType1_Radio.TabIndex = 46;
            this.Customer_referenceType1_Radio.Text = "CUSTOMER";
            this.WarToolTip1.SetToolTip(this.Customer_referenceType1_Radio, "COST #1");
            this.Customer_referenceType1_Radio.UseSelectable = true;
            this.Customer_referenceType1_Radio.CheckedChanged += new System.EventHandler(this.Customer_referenceType1_Radio_CheckedChanged);
            // 
            // Customer_referenceType2_Agent_Radio
            // 
            this.Customer_referenceType2_Agent_Radio.AutoSize = true;
            this.Customer_referenceType2_Agent_Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Customer_referenceType2_Agent_Radio.Enabled = false;
            this.Customer_referenceType2_Agent_Radio.Location = new System.Drawing.Point(25, 62);
            this.Customer_referenceType2_Agent_Radio.Name = "Customer_referenceType2_Agent_Radio";
            this.Customer_referenceType2_Agent_Radio.Size = new System.Drawing.Size(61, 15);
            this.Customer_referenceType2_Agent_Radio.TabIndex = 48;
            this.Customer_referenceType2_Agent_Radio.Text = "AGENT";
            this.WarToolTip1.SetToolTip(this.Customer_referenceType2_Agent_Radio, "COST #1");
            this.Customer_referenceType2_Agent_Radio.UseSelectable = true;
            this.Customer_referenceType2_Agent_Radio.CheckedChanged += new System.EventHandler(this.Customer_referenceType1_Radio_CheckedChanged);
            // 
            // Custmer_Or_Agent_ID_Txt
            // 
            // 
            // 
            // 
            this.Custmer_Or_Agent_ID_Txt.CustomButton.Image = null;
            this.Custmer_Or_Agent_ID_Txt.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.Custmer_Or_Agent_ID_Txt.CustomButton.Name = "";
            this.Custmer_Or_Agent_ID_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Custmer_Or_Agent_ID_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.Custmer_Or_Agent_ID_Txt.CustomButton.TabIndex = 1;
            this.Custmer_Or_Agent_ID_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.Custmer_Or_Agent_ID_Txt.CustomButton.UseSelectable = true;
            this.Custmer_Or_Agent_ID_Txt.CustomButton.Visible = false;
            this.Custmer_Or_Agent_ID_Txt.Enabled = false;
            this.Custmer_Or_Agent_ID_Txt.Lines = new string[0];
            this.Custmer_Or_Agent_ID_Txt.Location = new System.Drawing.Point(20, 140);
            this.Custmer_Or_Agent_ID_Txt.MaxLength = 32767;
            this.Custmer_Or_Agent_ID_Txt.Name = "Custmer_Or_Agent_ID_Txt";
            this.Custmer_Or_Agent_ID_Txt.PasswordChar = '\0';
            this.Custmer_Or_Agent_ID_Txt.PromptText = "CUSTOMER  ID";
            this.Custmer_Or_Agent_ID_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Custmer_Or_Agent_ID_Txt.SelectedText = "";
            this.Custmer_Or_Agent_ID_Txt.SelectionLength = 0;
            this.Custmer_Or_Agent_ID_Txt.SelectionStart = 0;
            this.Custmer_Or_Agent_ID_Txt.ShortcutsEnabled = true;
            this.Custmer_Or_Agent_ID_Txt.ShowClearButton = true;
            this.Custmer_Or_Agent_ID_Txt.Size = new System.Drawing.Size(227, 23);
            this.Custmer_Or_Agent_ID_Txt.TabIndex = 49;
            this.Custmer_Or_Agent_ID_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WarToolTip1.SetToolTip(this.Custmer_Or_Agent_ID_Txt, "CUSTOMER  ID");
            this.Custmer_Or_Agent_ID_Txt.UseSelectable = true;
            this.Custmer_Or_Agent_ID_Txt.WaterMark = "CUSTOMER  ID";
            this.Custmer_Or_Agent_ID_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Custmer_Or_Agent_ID_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Custmer_Or_Agent_ID_Txt.TextChanged += new System.EventHandler(this.Custmer_Or_Agent_ID_Txt_TextChanged);
            this.Custmer_Or_Agent_ID_Txt.Enter += new System.EventHandler(this.Custmer_Or_Agent_ID_Txt_Enter);
            this.Custmer_Or_Agent_ID_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Custmer_Or_Agent_ID_Txt_KeyPress);
            // 
            // Orignal_Total_Txt
            // 
            // 
            // 
            // 
            this.Orignal_Total_Txt.CustomButton.Image = null;
            this.Orignal_Total_Txt.CustomButton.Location = new System.Drawing.Point(181, 2);
            this.Orignal_Total_Txt.CustomButton.Name = "";
            this.Orignal_Total_Txt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Orignal_Total_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.Orignal_Total_Txt.CustomButton.TabIndex = 1;
            this.Orignal_Total_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.Orignal_Total_Txt.CustomButton.UseSelectable = true;
            this.Orignal_Total_Txt.CustomButton.Visible = false;
            this.Orignal_Total_Txt.FontSize = WarFramework.WarTextBoxSize.Tall;
            this.Orignal_Total_Txt.FontWeight = WarFramework.WarTextBoxWeight.Bold;
            this.Orignal_Total_Txt.Lines = new string[] {
        "000000"};
            this.Orignal_Total_Txt.Location = new System.Drawing.Point(268, 19);
            this.Orignal_Total_Txt.MaxLength = 32767;
            this.Orignal_Total_Txt.Name = "Orignal_Total_Txt";
            this.Orignal_Total_Txt.PasswordChar = '\0';
            this.Orignal_Total_Txt.PromptText = "ORGNAL TOTAL";
            this.Orignal_Total_Txt.ReadOnly = true;
            this.Orignal_Total_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Orignal_Total_Txt.SelectedText = "";
            this.Orignal_Total_Txt.SelectionLength = 0;
            this.Orignal_Total_Txt.SelectionStart = 0;
            this.Orignal_Total_Txt.ShortcutsEnabled = true;
            this.Orignal_Total_Txt.ShowClearButton = true;
            this.Orignal_Total_Txt.Size = new System.Drawing.Size(209, 30);
            this.Orignal_Total_Txt.TabIndex = 50;
            this.Orignal_Total_Txt.Text = "000000";
            this.Orignal_Total_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WarToolTip1.SetToolTip(this.Orignal_Total_Txt, "ORIGNAL TOTAL");
            this.Orignal_Total_Txt.UseSelectable = true;
            this.Orignal_Total_Txt.WaterMark = "ORGNAL TOTAL";
            this.Orignal_Total_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Orignal_Total_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // For_No_of_Persons_Txt
            // 
            // 
            // 
            // 
            this.For_No_of_Persons_Txt.CustomButton.Image = null;
            this.For_No_of_Persons_Txt.CustomButton.Location = new System.Drawing.Point(23, 1);
            this.For_No_of_Persons_Txt.CustomButton.Name = "";
            this.For_No_of_Persons_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.For_No_of_Persons_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.For_No_of_Persons_Txt.CustomButton.TabIndex = 1;
            this.For_No_of_Persons_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.For_No_of_Persons_Txt.CustomButton.UseSelectable = true;
            this.For_No_of_Persons_Txt.CustomButton.Visible = false;
            this.For_No_of_Persons_Txt.Lines = new string[] {
        "1"};
            this.For_No_of_Persons_Txt.Location = new System.Drawing.Point(71, 45);
            this.For_No_of_Persons_Txt.MaxLength = 32767;
            this.For_No_of_Persons_Txt.Name = "For_No_of_Persons_Txt";
            this.For_No_of_Persons_Txt.PasswordChar = '\0';
            this.For_No_of_Persons_Txt.ReadOnly = true;
            this.For_No_of_Persons_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.For_No_of_Persons_Txt.SelectedText = "";
            this.For_No_of_Persons_Txt.SelectionLength = 0;
            this.For_No_of_Persons_Txt.SelectionStart = 0;
            this.For_No_of_Persons_Txt.ShortcutsEnabled = true;
            this.For_No_of_Persons_Txt.ShowClearButton = true;
            this.For_No_of_Persons_Txt.Size = new System.Drawing.Size(45, 23);
            this.For_No_of_Persons_Txt.TabIndex = 52;
            this.For_No_of_Persons_Txt.Text = "1";
            this.For_No_of_Persons_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WarToolTip1.SetToolTip(this.For_No_of_Persons_Txt, "CUSTOMER/AGENT  ID");
            this.For_No_of_Persons_Txt.UseSelectable = true;
            this.For_No_of_Persons_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.For_No_of_Persons_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Extra_Discount_Txt
            // 
            // 
            // 
            // 
            this.Extra_Discount_Txt.CustomButton.Image = null;
            this.Extra_Discount_Txt.CustomButton.Location = new System.Drawing.Point(181, 2);
            this.Extra_Discount_Txt.CustomButton.Name = "";
            this.Extra_Discount_Txt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Extra_Discount_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.Extra_Discount_Txt.CustomButton.TabIndex = 1;
            this.Extra_Discount_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.Extra_Discount_Txt.CustomButton.UseSelectable = true;
            this.Extra_Discount_Txt.CustomButton.Visible = false;
            this.Extra_Discount_Txt.FontSize = WarFramework.WarTextBoxSize.Tall;
            this.Extra_Discount_Txt.Lines = new string[] {
        "000000"};
            this.Extra_Discount_Txt.Location = new System.Drawing.Point(268, 55);
            this.Extra_Discount_Txt.MaxLength = 32767;
            this.Extra_Discount_Txt.Name = "Extra_Discount_Txt";
            this.Extra_Discount_Txt.PasswordChar = '\0';
            this.Extra_Discount_Txt.PromptText = "EXTRA DISCOUNT";
            this.Extra_Discount_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Extra_Discount_Txt.SelectedText = "";
            this.Extra_Discount_Txt.SelectionLength = 0;
            this.Extra_Discount_Txt.SelectionStart = 0;
            this.Extra_Discount_Txt.ShortcutsEnabled = true;
            this.Extra_Discount_Txt.Size = new System.Drawing.Size(209, 30);
            this.Extra_Discount_Txt.TabIndex = 51;
            this.Extra_Discount_Txt.Text = "000000";
            this.Extra_Discount_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WarToolTip1.SetToolTip(this.Extra_Discount_Txt, "EXTRA DISCOUNT");
            this.Extra_Discount_Txt.UseSelectable = true;
            this.Extra_Discount_Txt.WaterMark = "EXTRA DISCOUNT";
            this.Extra_Discount_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Extra_Discount_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Extra_Discount_Txt.TextChanged += new System.EventHandler(this.Extra_Discount_Txt_TextChanged);
            this.Extra_Discount_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Custmer_Or_Agent_ID_Txt_KeyPress);
            // 
            // Grand_Total_Txt
            // 
            // 
            // 
            // 
            this.Grand_Total_Txt.CustomButton.Image = null;
            this.Grand_Total_Txt.CustomButton.Location = new System.Drawing.Point(181, 2);
            this.Grand_Total_Txt.CustomButton.Name = "";
            this.Grand_Total_Txt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Grand_Total_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.Grand_Total_Txt.CustomButton.TabIndex = 1;
            this.Grand_Total_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.Grand_Total_Txt.CustomButton.UseSelectable = true;
            this.Grand_Total_Txt.CustomButton.Visible = false;
            this.Grand_Total_Txt.FontSize = WarFramework.WarTextBoxSize.Tall;
            this.Grand_Total_Txt.Lines = new string[] {
        "000000"};
            this.Grand_Total_Txt.Location = new System.Drawing.Point(268, 146);
            this.Grand_Total_Txt.MaxLength = 32767;
            this.Grand_Total_Txt.Name = "Grand_Total_Txt";
            this.Grand_Total_Txt.PasswordChar = '\0';
            this.Grand_Total_Txt.PromptText = "GRAND TOTAL";
            this.Grand_Total_Txt.ReadOnly = true;
            this.Grand_Total_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Grand_Total_Txt.SelectedText = "";
            this.Grand_Total_Txt.SelectionLength = 0;
            this.Grand_Total_Txt.SelectionStart = 0;
            this.Grand_Total_Txt.ShortcutsEnabled = true;
            this.Grand_Total_Txt.Size = new System.Drawing.Size(209, 30);
            this.Grand_Total_Txt.TabIndex = 54;
            this.Grand_Total_Txt.Text = "000000";
            this.Grand_Total_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WarToolTip1.SetToolTip(this.Grand_Total_Txt, "GRAND TOTAL");
            this.Grand_Total_Txt.UseSelectable = true;
            this.Grand_Total_Txt.WaterMark = "GRAND TOTAL";
            this.Grand_Total_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Grand_Total_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Collected_Amount_Txt
            // 
            // 
            // 
            // 
            this.Collected_Amount_Txt.CustomButton.Image = null;
            this.Collected_Amount_Txt.CustomButton.Location = new System.Drawing.Point(181, 2);
            this.Collected_Amount_Txt.CustomButton.Name = "";
            this.Collected_Amount_Txt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Collected_Amount_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.Collected_Amount_Txt.CustomButton.TabIndex = 1;
            this.Collected_Amount_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.Collected_Amount_Txt.CustomButton.UseSelectable = true;
            this.Collected_Amount_Txt.CustomButton.Visible = false;
            this.Collected_Amount_Txt.FontSize = WarFramework.WarTextBoxSize.Tall;
            this.Collected_Amount_Txt.Lines = new string[] {
        "000000"};
            this.Collected_Amount_Txt.Location = new System.Drawing.Point(799, 55);
            this.Collected_Amount_Txt.MaxLength = 32767;
            this.Collected_Amount_Txt.Name = "Collected_Amount_Txt";
            this.Collected_Amount_Txt.PasswordChar = '\0';
            this.Collected_Amount_Txt.PromptText = "COLLECTED AMOUNT";
            this.Collected_Amount_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Collected_Amount_Txt.SelectedText = "";
            this.Collected_Amount_Txt.SelectionLength = 0;
            this.Collected_Amount_Txt.SelectionStart = 0;
            this.Collected_Amount_Txt.ShortcutsEnabled = true;
            this.Collected_Amount_Txt.Size = new System.Drawing.Size(209, 30);
            this.Collected_Amount_Txt.TabIndex = 56;
            this.Collected_Amount_Txt.Text = "000000";
            this.Collected_Amount_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WarToolTip1.SetToolTip(this.Collected_Amount_Txt, "COLLECTED AMOUNT");
            this.Collected_Amount_Txt.UseSelectable = true;
            this.Collected_Amount_Txt.WaterMark = "COLLECTED AMOUNT";
            this.Collected_Amount_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Collected_Amount_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Collected_Amount_Txt.TextChanged += new System.EventHandler(this.Collected_Amount_Txt_TextChanged);
            this.Collected_Amount_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Custmer_Or_Agent_ID_Txt_KeyPress);
            // 
            // Remaining_Amount_Txt
            // 
            // 
            // 
            // 
            this.Remaining_Amount_Txt.CustomButton.Image = null;
            this.Remaining_Amount_Txt.CustomButton.Location = new System.Drawing.Point(181, 2);
            this.Remaining_Amount_Txt.CustomButton.Name = "";
            this.Remaining_Amount_Txt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Remaining_Amount_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.Remaining_Amount_Txt.CustomButton.TabIndex = 1;
            this.Remaining_Amount_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.Remaining_Amount_Txt.CustomButton.UseSelectable = true;
            this.Remaining_Amount_Txt.CustomButton.Visible = false;
            this.Remaining_Amount_Txt.FontSize = WarFramework.WarTextBoxSize.Tall;
            this.Remaining_Amount_Txt.Lines = new string[] {
        "000000"};
            this.Remaining_Amount_Txt.Location = new System.Drawing.Point(799, 98);
            this.Remaining_Amount_Txt.MaxLength = 32767;
            this.Remaining_Amount_Txt.Name = "Remaining_Amount_Txt";
            this.Remaining_Amount_Txt.PasswordChar = '\0';
            this.Remaining_Amount_Txt.PromptText = "REMAIINING AMOUNT";
            this.Remaining_Amount_Txt.ReadOnly = true;
            this.Remaining_Amount_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Remaining_Amount_Txt.SelectedText = "";
            this.Remaining_Amount_Txt.SelectionLength = 0;
            this.Remaining_Amount_Txt.SelectionStart = 0;
            this.Remaining_Amount_Txt.ShortcutsEnabled = true;
            this.Remaining_Amount_Txt.Size = new System.Drawing.Size(209, 30);
            this.Remaining_Amount_Txt.TabIndex = 58;
            this.Remaining_Amount_Txt.Text = "000000";
            this.Remaining_Amount_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WarToolTip1.SetToolTip(this.Remaining_Amount_Txt, "REMAIINING AMOUNT");
            this.Remaining_Amount_Txt.UseSelectable = true;
            this.Remaining_Amount_Txt.WaterMark = "REMAIINING AMOUNT";
            this.Remaining_Amount_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Remaining_Amount_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Tatal_Discount_Txt
            // 
            // 
            // 
            // 
            this.Tatal_Discount_Txt.CustomButton.Image = null;
            this.Tatal_Discount_Txt.CustomButton.Location = new System.Drawing.Point(181, 2);
            this.Tatal_Discount_Txt.CustomButton.Name = "";
            this.Tatal_Discount_Txt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Tatal_Discount_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.Tatal_Discount_Txt.CustomButton.TabIndex = 1;
            this.Tatal_Discount_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.Tatal_Discount_Txt.CustomButton.UseSelectable = true;
            this.Tatal_Discount_Txt.CustomButton.Visible = false;
            this.Tatal_Discount_Txt.FontSize = WarFramework.WarTextBoxSize.Tall;
            this.Tatal_Discount_Txt.Lines = new string[] {
        "000000"};
            this.Tatal_Discount_Txt.Location = new System.Drawing.Point(268, 98);
            this.Tatal_Discount_Txt.MaxLength = 32767;
            this.Tatal_Discount_Txt.Name = "Tatal_Discount_Txt";
            this.Tatal_Discount_Txt.PasswordChar = '\0';
            this.Tatal_Discount_Txt.PromptText = "TOTAL DISCOUNT";
            this.Tatal_Discount_Txt.ReadOnly = true;
            this.Tatal_Discount_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Tatal_Discount_Txt.SelectedText = "";
            this.Tatal_Discount_Txt.SelectionLength = 0;
            this.Tatal_Discount_Txt.SelectionStart = 0;
            this.Tatal_Discount_Txt.ShortcutsEnabled = true;
            this.Tatal_Discount_Txt.Size = new System.Drawing.Size(209, 30);
            this.Tatal_Discount_Txt.TabIndex = 79;
            this.Tatal_Discount_Txt.Text = "000000";
            this.Tatal_Discount_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WarToolTip1.SetToolTip(this.Tatal_Discount_Txt, "TOTAL DISCOUNT");
            this.Tatal_Discount_Txt.UseSelectable = true;
            this.Tatal_Discount_Txt.WaterMark = "TOTAL DISCOUNT";
            this.Tatal_Discount_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Tatal_Discount_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // For_No_Of_Days_linkTxt
            // 
            this.For_No_Of_Days_linkTxt.Location = new System.Drawing.Point(239, 247);
            this.For_No_Of_Days_linkTxt.Name = "For_No_Of_Days_linkTxt";
            this.For_No_Of_Days_linkTxt.Size = new System.Drawing.Size(75, 23);
            this.For_No_Of_Days_linkTxt.TabIndex = 36;
            this.For_No_Of_Days_linkTxt.Text = "NO VALUE";
            this.For_No_Of_Days_linkTxt.UseSelectable = true;
            // 
            // SpecialOffer_Discount_link_Txt
            // 
            this.SpecialOffer_Discount_link_Txt.Location = new System.Drawing.Point(239, 276);
            this.SpecialOffer_Discount_link_Txt.Name = "SpecialOffer_Discount_link_Txt";
            this.SpecialOffer_Discount_link_Txt.Size = new System.Drawing.Size(75, 23);
            this.SpecialOffer_Discount_link_Txt.TabIndex = 37;
            this.SpecialOffer_Discount_link_Txt.Text = "0000.00";
            this.SpecialOffer_Discount_link_Txt.UseSelectable = true;
            // 
            // WarLabel5
            // 
            this.WarLabel5.AutoSize = true;
            this.WarLabel5.Location = new System.Drawing.Point(32, 247);
            this.WarLabel5.Name = "WarLabel5";
            this.WarLabel5.Size = new System.Drawing.Size(111, 19);
            this.WarLabel5.TabIndex = 44;
            this.WarLabel5.Text = "PACKAGE DAYS : ";
            // 
            // WarLabel6
            // 
            this.WarLabel6.AutoSize = true;
            this.WarLabel6.Location = new System.Drawing.Point(32, 276);
            this.WarLabel6.Name = "WarLabel6";
            this.WarLabel6.Size = new System.Drawing.Size(171, 19);
            this.WarLabel6.TabIndex = 45;
            this.WarLabel6.Text = "SPECIAL OFFER DISCOUNT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonForCustmerRegister);
            this.groupBox2.Controls.Add(this.Customer_referenceType2_Agent_Radio);
            this.groupBox2.Controls.Add(this.Customer_referenceType1_Radio);
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(20, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 92);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BOOKING FOR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.Custmer_Or_Agent_ID_Txt);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(11, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 304);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CUSTOMER ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ImageR);
            this.groupBox4.Controls.Add(this.Id_info_nameLink);
            this.groupBox4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox4.Location = new System.Drawing.Point(20, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 122);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ID VIEW CONFIRM";
            // 
            // ImageR
            // 
            this.ImageR.BackColor = System.Drawing.Color.Transparent;
            this.ImageR.Location = new System.Drawing.Point(138, 18);
            this.ImageR.Name = "ImageR";
            this.ImageR.Size = new System.Drawing.Size(79, 72);
            this.ImageR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageR.TabIndex = 50;
            this.ImageR.TabStop = false;
            // 
            // Id_info_nameLink
            // 
            this.Id_info_nameLink.Location = new System.Drawing.Point(11, 93);
            this.Id_info_nameLink.Name = "Id_info_nameLink";
            this.Id_info_nameLink.Size = new System.Drawing.Size(210, 23);
            this.Id_info_nameLink.TabIndex = 50;
            this.Id_info_nameLink.Text = "SELECT CUSTOMER TYPE AND ID";
            this.Id_info_nameLink.UseSelectable = true;
            // 
            // groupBox_payments
            // 
            this.groupBox_payments.Controls.Add(this.WarLabel12);
            this.groupBox_payments.Controls.Add(this.Tatal_Discount_Txt);
            this.groupBox_payments.Controls.Add(this.SAVE_New_Booking_Btn);
            this.groupBox_payments.Controls.Add(this.WarCheckBox1);
            this.groupBox_payments.Controls.Add(this.WarLabel11);
            this.groupBox_payments.Controls.Add(this.Remaining_Amount_Txt);
            this.groupBox_payments.Controls.Add(this.WarLabel10);
            this.groupBox_payments.Controls.Add(this.Collected_Amount_Txt);
            this.groupBox_payments.Controls.Add(this.WarLabel9);
            this.groupBox_payments.Controls.Add(this.Grand_Total_Txt);
            this.groupBox_payments.Controls.Add(this.WarLabel8);
            this.groupBox_payments.Controls.Add(this.WarLabel7);
            this.groupBox_payments.Controls.Add(this.Extra_Discount_Txt);
            this.groupBox_payments.Controls.Add(this.Orignal_Total_Txt);
            this.groupBox_payments.Enabled = false;
            this.groupBox_payments.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox_payments.Location = new System.Drawing.Point(11, 422);
            this.groupBox_payments.Name = "groupBox_payments";
            this.groupBox_payments.Size = new System.Drawing.Size(1014, 210);
            this.groupBox_payments.TabIndex = 51;
            this.groupBox_payments.TabStop = false;
            this.groupBox_payments.Text = "PAYMENT";
            // 
            // WarLabel12
            // 
            this.WarLabel12.AutoSize = true;
            this.WarLabel12.FontSize = WarFramework.WarLabelSize.Tall;
            this.WarLabel12.FontWeight = WarFramework.WarLabelWeight.Bold;
            this.WarLabel12.Location = new System.Drawing.Point(84, 98);
            this.WarLabel12.Name = "WarLabel12";
            this.WarLabel12.Size = new System.Drawing.Size(164, 25);
            this.WarLabel12.TabIndex = 80;
            this.WarLabel12.Text = "TOTAL DISCOUNT";
            // 
            // SAVE_New_Booking_Btn
            // 
            this.SAVE_New_Booking_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SAVE_New_Booking_Btn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SAVE_New_Booking_Btn.FlatAppearance.BorderSize = 2;
            this.SAVE_New_Booking_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.SAVE_New_Booking_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SAVE_New_Booking_Btn.Location = new System.Drawing.Point(902, 167);
            this.SAVE_New_Booking_Btn.Name = "SAVE_New_Booking_Btn";
            this.SAVE_New_Booking_Btn.Size = new System.Drawing.Size(106, 37);
            this.SAVE_New_Booking_Btn.TabIndex = 78;
            this.SAVE_New_Booking_Btn.Text = "SAVE BOOKING";
            this.SAVE_New_Booking_Btn.UseVisualStyleBackColor = true;
            this.SAVE_New_Booking_Btn.Click += new System.EventHandler(this.SAVE_New_Booking_Btn_Click);
            // 
            // WarCheckBox1
            // 
            this.WarCheckBox1.AutoSize = true;
            this.WarCheckBox1.Location = new System.Drawing.Point(799, 21);
            this.WarCheckBox1.Name = "WarCheckBox1";
            this.WarCheckBox1.Size = new System.Drawing.Size(136, 15);
            this.WarCheckBox1.TabIndex = 60;
            this.WarCheckBox1.Text = "AUTO FULL COLLECT";
            this.WarCheckBox1.UseSelectable = true;
            this.WarCheckBox1.CheckedChanged += new System.EventHandler(this.WarCheckBox1_CheckedChanged);
            // 
            // WarLabel11
            // 
            this.WarLabel11.AutoSize = true;
            this.WarLabel11.FontSize = WarFramework.WarLabelSize.Tall;
            this.WarLabel11.FontWeight = WarFramework.WarLabelWeight.Bold;
            this.WarLabel11.Location = new System.Drawing.Point(588, 98);
            this.WarLabel11.Name = "WarLabel11";
            this.WarLabel11.Size = new System.Drawing.Size(210, 25);
            this.WarLabel11.TabIndex = 59;
            this.WarLabel11.Text = "REMAIINING AMOUNT";
            // 
            // WarLabel10
            // 
            this.WarLabel10.AutoSize = true;
            this.WarLabel10.FontSize = WarFramework.WarLabelSize.Tall;
            this.WarLabel10.FontWeight = WarFramework.WarLabelWeight.Bold;
            this.WarLabel10.Location = new System.Drawing.Point(588, 58);
            this.WarLabel10.Name = "WarLabel10";
            this.WarLabel10.Size = new System.Drawing.Size(197, 25);
            this.WarLabel10.TabIndex = 57;
            this.WarLabel10.Text = "COLLECTED AMOUNT";
            // 
            // WarLabel9
            // 
            this.WarLabel9.AutoSize = true;
            this.WarLabel9.FontSize = WarFramework.WarLabelSize.Tall;
            this.WarLabel9.FontWeight = WarFramework.WarLabelWeight.Bold;
            this.WarLabel9.Location = new System.Drawing.Point(84, 146);
            this.WarLabel9.Name = "WarLabel9";
            this.WarLabel9.Size = new System.Drawing.Size(137, 25);
            this.WarLabel9.TabIndex = 55;
            this.WarLabel9.Text = "GRAND TOTAL";
            // 
            // WarLabel8
            // 
            this.WarLabel8.AutoSize = true;
            this.WarLabel8.FontSize = WarFramework.WarLabelSize.Tall;
            this.WarLabel8.FontWeight = WarFramework.WarLabelWeight.Bold;
            this.WarLabel8.Location = new System.Drawing.Point(84, 58);
            this.WarLabel8.Name = "WarLabel8";
            this.WarLabel8.Size = new System.Drawing.Size(167, 25);
            this.WarLabel8.TabIndex = 53;
            this.WarLabel8.Text = "EXTRA DISCOUNT";
            // 
            // WarLabel7
            // 
            this.WarLabel7.AutoSize = true;
            this.WarLabel7.FontSize = WarFramework.WarLabelSize.Tall;
            this.WarLabel7.FontWeight = WarFramework.WarLabelWeight.Bold;
            this.WarLabel7.Location = new System.Drawing.Point(84, 21);
            this.WarLabel7.Name = "WarLabel7";
            this.WarLabel7.Size = new System.Drawing.Size(153, 25);
            this.WarLabel7.TabIndex = 52;
            this.WarLabel7.Text = "ORIGNAL TOTAL";
            // 
            // groupBox_noofpersons
            // 
            this.groupBox_noofpersons.Controls.Add(this.Minus_person_Btn);
            this.groupBox_noofpersons.Controls.Add(this.Add_person_Btn);
            this.groupBox_noofpersons.Controls.Add(this.For_No_of_Persons_Txt);
            this.groupBox_noofpersons.Enabled = false;
            this.groupBox_noofpersons.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox_noofpersons.Location = new System.Drawing.Point(499, 58);
            this.groupBox_noofpersons.Name = "groupBox_noofpersons";
            this.groupBox_noofpersons.Size = new System.Drawing.Size(184, 104);
            this.groupBox_noofpersons.TabIndex = 53;
            this.groupBox_noofpersons.TabStop = false;
            this.groupBox_noofpersons.Text = "SELECT NO OF PERSONS";
            // 
            // Minus_person_Btn
            // 
            this.Minus_person_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minus_person_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Minus_person_Btn.FlatAppearance.BorderSize = 0;
            this.Minus_person_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Minus_person_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus_person_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Minus_person_Btn.Image")));
            this.Minus_person_Btn.Location = new System.Drawing.Point(34, 40);
            this.Minus_person_Btn.Name = "Minus_person_Btn";
            this.Minus_person_Btn.Size = new System.Drawing.Size(31, 31);
            this.Minus_person_Btn.TabIndex = 76;
            this.Minus_person_Btn.UseVisualStyleBackColor = true;
            this.Minus_person_Btn.Click += new System.EventHandler(this.Minus_person_Btn_Click);
            // 
            // Add_person_Btn
            // 
            this.Add_person_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_person_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Add_person_Btn.FlatAppearance.BorderSize = 0;
            this.Add_person_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Add_person_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_person_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Add_person_Btn.Image")));
            this.Add_person_Btn.Location = new System.Drawing.Point(121, 40);
            this.Add_person_Btn.Name = "Add_person_Btn";
            this.Add_person_Btn.Size = new System.Drawing.Size(31, 31);
            this.Add_person_Btn.TabIndex = 75;
            this.Add_person_Btn.UseVisualStyleBackColor = true;
            this.Add_person_Btn.Click += new System.EventHandler(this.Add_person_Btn_Click);
            // 
            // groupBoxPackageMain
            // 
            this.groupBoxPackageMain.Controls.Add(this.groupBox_noofpersons);
            this.groupBoxPackageMain.Controls.Add(this.Package_NamesComboBox);
            this.groupBoxPackageMain.Controls.Add(this.Package_CodeComboBox);
            this.groupBoxPackageMain.Controls.Add(this.groupBoxAll_costs);
            this.groupBoxPackageMain.Controls.Add(this.WarLabel6);
            this.groupBoxPackageMain.Controls.Add(this.For_No_Of_Days_linkTxt);
            this.groupBoxPackageMain.Controls.Add(this.WarLabel5);
            this.groupBoxPackageMain.Controls.Add(this.SpecialOffer_Discount_link_Txt);
            this.groupBoxPackageMain.Enabled = false;
            this.groupBoxPackageMain.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBoxPackageMain.Location = new System.Drawing.Point(336, 73);
            this.groupBoxPackageMain.Name = "groupBoxPackageMain";
            this.groupBoxPackageMain.Size = new System.Drawing.Size(689, 304);
            this.groupBoxPackageMain.TabIndex = 77;
            this.groupBoxPackageMain.TabStop = false;
            this.groupBoxPackageMain.Text = "PACKAGE";
            // 
            // canceledLable
            // 
            this.canceledLable.AutoSize = true;
            this.canceledLable.FontSize = WarFramework.WarLabelSize.Tall;
            this.canceledLable.FontWeight = WarFramework.WarLabelWeight.Bold;
            this.canceledLable.ForeColor = System.Drawing.Color.Red;
            this.canceledLable.Location = new System.Drawing.Point(170, 293);
            this.canceledLable.Name = "canceledLable";
            this.canceledLable.Size = new System.Drawing.Size(739, 25);
            this.canceledLable.TabIndex = 100;
            this.canceledLable.Text = "SORRY COMPANY IS NO LONGER ACTIVE CHOOSE DIFFERENT COMPANY\'S PACKAGE";
            this.canceledLable.UseCustomForeColor = true;
            this.canceledLable.Visible = false;
            // 
            // cancelagentLable
            // 
            this.cancelagentLable.AutoSize = true;
            this.cancelagentLable.FontSize = WarFramework.WarLabelSize.Tall;
            this.cancelagentLable.FontWeight = WarFramework.WarLabelWeight.Bold;
            this.cancelagentLable.ForeColor = System.Drawing.Color.Red;
            this.cancelagentLable.Location = new System.Drawing.Point(373, 313);
            this.cancelagentLable.Name = "cancelagentLable";
            this.cancelagentLable.Size = new System.Drawing.Size(349, 25);
            this.cancelagentLable.TabIndex = 101;
            this.cancelagentLable.Text = "SORRY THIS AGENT IS LONGER ACTIVE";
            this.cancelagentLable.UseCustomForeColor = true;
            this.cancelagentLable.Visible = false;
            // 
            // ButtonForCustmerRegister
            // 
            this.ButtonForCustmerRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonForCustmerRegister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonForCustmerRegister.FlatAppearance.BorderSize = 0;
            this.ButtonForCustmerRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonForCustmerRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonForCustmerRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonForCustmerRegister.Image = ((System.Drawing.Image)(resources.GetObject("ButtonForCustmerRegister.Image")));
            this.ButtonForCustmerRegister.Location = new System.Drawing.Point(125, 29);
            this.ButtonForCustmerRegister.Name = "ButtonForCustmerRegister";
            this.ButtonForCustmerRegister.Size = new System.Drawing.Size(19, 19);
            this.ButtonForCustmerRegister.TabIndex = 89;
            this.ButtonForCustmerRegister.UseVisualStyleBackColor = true;
            this.ButtonForCustmerRegister.Click += new System.EventHandler(this.ButtonForCustmerRegister_Click);
            // 
            // NewBookigUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 644);
            this.Controls.Add(this.cancelagentLable);
            this.Controls.Add(this.canceledLable);
            this.Controls.Add(this.groupBox_payments);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxPackageMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewBookigUI";
            this.Resizable = false;
            this.Text = "NEW BOOKING";
            this.TextAlign = WarFramework.Forms.WarFormTextAlign.Right;
            this.Load += new System.EventHandler(this.NewBookigUI_Load);
            this.groupBoxAll_costs.ResumeLayout(false);
            this.groupBoxAll_costs.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageR)).EndInit();
            this.groupBox_payments.ResumeLayout(false);
            this.groupBox_payments.PerformLayout();
            this.groupBox_noofpersons.ResumeLayout(false);
            this.groupBoxPackageMain.ResumeLayout(false);
            this.groupBoxPackageMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WarFramework.Controls.WarComboBox Package_NamesComboBox;
        private WarFramework.Controls.WarComboBox Package_CodeComboBox;
        private System.Windows.Forms.GroupBox groupBoxAll_costs;
        private WarFramework.Controls.WarRadioButton Cost4_Radio;
        private WarFramework.Controls.WarRadioButton Cost3_Radio;
        private WarFramework.Controls.WarRadioButton Cost2_Radio;
        private WarFramework.Controls.WarRadioButton Cost1_Radio;
        private WarFramework.Components.WarToolTip WarToolTip1;
        private WarFramework.Controls.WarLabel WarLabel4;
        private WarFramework.Controls.WarLabel WarLabel3;
        private WarFramework.Controls.WarLabel WarLabel2;
        private WarFramework.Controls.WarLabel WarLabel1;
        private WarFramework.Controls.WarLink For_No_Of_Days_linkTxt;
        private WarFramework.Controls.WarLink SpecialOffer_Discount_link_Txt;
        private WarFramework.Controls.WarLabel WarLabel5;
        private WarFramework.Controls.WarLabel WarLabel6;
        private WarFramework.Controls.WarRadioButton Customer_referenceType1_Radio;
        private System.Windows.Forms.GroupBox groupBox2;
        private WarFramework.Controls.WarRadioButton Customer_referenceType2_Agent_Radio;
        private WarFramework.Controls.WarTextBox Custmer_Or_Agent_ID_Txt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox ImageR;
        private WarFramework.Controls.WarLink Id_info_nameLink;
        private WarFramework.Controls.WarTextBox Orignal_Total_Txt;
        private System.Windows.Forms.GroupBox groupBox_payments;
        private WarFramework.Controls.WarTextBox For_No_of_Persons_Txt;
        private System.Windows.Forms.GroupBox groupBox_noofpersons;
        private System.Windows.Forms.Button Minus_person_Btn;
        private System.Windows.Forms.Button Add_person_Btn;
        private System.Windows.Forms.GroupBox groupBoxPackageMain;
        private WarFramework.Controls.WarLabel WarLabel11;
        private WarFramework.Controls.WarTextBox Remaining_Amount_Txt;
        private WarFramework.Controls.WarLabel WarLabel10;
        private WarFramework.Controls.WarTextBox Collected_Amount_Txt;
        private WarFramework.Controls.WarLabel WarLabel9;
        private WarFramework.Controls.WarTextBox Grand_Total_Txt;
        private WarFramework.Controls.WarLabel WarLabel8;
        private WarFramework.Controls.WarLabel WarLabel7;
        private WarFramework.Controls.WarTextBox Extra_Discount_Txt;
        private WarFramework.Controls.WarCheckBox WarCheckBox1;
        private System.Windows.Forms.Button SAVE_New_Booking_Btn;
        private WarFramework.Controls.WarLabel WarLabel12;
        private WarFramework.Controls.WarTextBox Tatal_Discount_Txt;
        private WarFramework.Controls.WarLabel canceledLable;
        private WarFramework.Controls.WarLabel cancelagentLable;
        private System.Windows.Forms.Button ButtonForCustmerRegister;
    }
}