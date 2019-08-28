namespace com_war_air
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.WarTextBox1 = new WarFramework.Controls.WarTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.WarTextBox2 = new WarFramework.Controls.WarTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bOOKINGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFERENCETYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFERENCECODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKINGDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pACKAGECODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORNOOFPERSONSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bILLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookings_And_payments_DataSet_appData = new com_war_air.com.WARPRO.DB.Bookings_And_payments_DataSet_appData();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bILLIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFERENCETYPEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFERENCECODEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKINGIDNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bILLDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALORIGNALAMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPECIALOFFERDISCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXTRADISCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALDISCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAIDAMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMAININGAMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPAIDFULLDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.billsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bookingsTableAdapter = new com_war_air.com.WARPRO.DB.Bookings_And_payments_DataSet_appDataTableAdapters.BookingsTableAdapter();
            this.billsTableAdapter = new com_war_air.com.WARPRO.DB.Bookings_And_payments_DataSet_appDataTableAdapters.BillsTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookings_And_payments_DataSet_appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // WarTextBox1
            // 
            // 
            // 
            // 
            this.WarTextBox1.CustomButton.Image = null;
            this.WarTextBox1.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.WarTextBox1.CustomButton.Name = "";
            this.WarTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.WarTextBox1.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.WarTextBox1.CustomButton.TabIndex = 1;
            this.WarTextBox1.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.WarTextBox1.CustomButton.UseSelectable = true;
            this.WarTextBox1.CustomButton.Visible = false;
            this.WarTextBox1.Lines = new string[] {
        "WarTextBox1"};
            this.WarTextBox1.Location = new System.Drawing.Point(98, 64);
            this.WarTextBox1.MaxLength = 32767;
            this.WarTextBox1.Name = "WarTextBox1";
            this.WarTextBox1.PasswordChar = '\0';
            this.WarTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WarTextBox1.SelectedText = "";
            this.WarTextBox1.SelectionLength = 0;
            this.WarTextBox1.SelectionStart = 0;
            this.WarTextBox1.ShortcutsEnabled = true;
            this.WarTextBox1.Size = new System.Drawing.Size(75, 23);
            this.WarTextBox1.TabIndex = 0;
            this.WarTextBox1.Text = "WarTextBox1";
            this.WarTextBox1.UseSelectable = true;
            this.WarTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WarTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WarTextBox2
            // 
            // 
            // 
            // 
            this.WarTextBox2.CustomButton.Image = null;
            this.WarTextBox2.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.WarTextBox2.CustomButton.Name = "";
            this.WarTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.WarTextBox2.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.WarTextBox2.CustomButton.TabIndex = 1;
            this.WarTextBox2.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.WarTextBox2.CustomButton.UseSelectable = true;
            this.WarTextBox2.CustomButton.Visible = false;
            this.WarTextBox2.Lines = new string[] {
        "WarTextBox2"};
            this.WarTextBox2.Location = new System.Drawing.Point(98, 93);
            this.WarTextBox2.MaxLength = 32767;
            this.WarTextBox2.Name = "WarTextBox2";
            this.WarTextBox2.PasswordChar = '\0';
            this.WarTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WarTextBox2.SelectedText = "";
            this.WarTextBox2.SelectionLength = 0;
            this.WarTextBox2.SelectionStart = 0;
            this.WarTextBox2.ShortcutsEnabled = true;
            this.WarTextBox2.Size = new System.Drawing.Size(75, 23);
            this.WarTextBox2.TabIndex = 2;
            this.WarTextBox2.Text = "WarTextBox2";
            this.WarTextBox2.UseSelectable = true;
            this.WarTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WarTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOOKINGIDDataGridViewTextBoxColumn,
            this.rEFERENCETYPEDataGridViewTextBoxColumn,
            this.rEFERENCECODEDataGridViewTextBoxColumn,
            this.bOOKINGDATEDataGridViewTextBoxColumn,
            this.pACKAGECODEDataGridViewTextBoxColumn,
            this.fORNOOFPERSONSDataGridViewTextBoxColumn,
            this.bILLIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookingsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(618, 99);
            this.dataGridView1.TabIndex = 6;
            // 
            // bOOKINGIDDataGridViewTextBoxColumn
            // 
            this.bOOKINGIDDataGridViewTextBoxColumn.DataPropertyName = "BOOKING_ID";
            this.bOOKINGIDDataGridViewTextBoxColumn.HeaderText = "BOOKING_ID";
            this.bOOKINGIDDataGridViewTextBoxColumn.Name = "bOOKINGIDDataGridViewTextBoxColumn";
            this.bOOKINGIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEFERENCETYPEDataGridViewTextBoxColumn
            // 
            this.rEFERENCETYPEDataGridViewTextBoxColumn.DataPropertyName = "REFERENCE_TYPE";
            this.rEFERENCETYPEDataGridViewTextBoxColumn.HeaderText = "REFERENCE_TYPE";
            this.rEFERENCETYPEDataGridViewTextBoxColumn.Name = "rEFERENCETYPEDataGridViewTextBoxColumn";
            // 
            // rEFERENCECODEDataGridViewTextBoxColumn
            // 
            this.rEFERENCECODEDataGridViewTextBoxColumn.DataPropertyName = "REFERENCE_CODE";
            this.rEFERENCECODEDataGridViewTextBoxColumn.HeaderText = "REFERENCE_CODE";
            this.rEFERENCECODEDataGridViewTextBoxColumn.Name = "rEFERENCECODEDataGridViewTextBoxColumn";
            // 
            // bOOKINGDATEDataGridViewTextBoxColumn
            // 
            this.bOOKINGDATEDataGridViewTextBoxColumn.DataPropertyName = "BOOKING_DATE";
            this.bOOKINGDATEDataGridViewTextBoxColumn.HeaderText = "BOOKING_DATE";
            this.bOOKINGDATEDataGridViewTextBoxColumn.Name = "bOOKINGDATEDataGridViewTextBoxColumn";
            // 
            // pACKAGECODEDataGridViewTextBoxColumn
            // 
            this.pACKAGECODEDataGridViewTextBoxColumn.DataPropertyName = "PACKAGE_CODE";
            this.pACKAGECODEDataGridViewTextBoxColumn.HeaderText = "PACKAGE_CODE";
            this.pACKAGECODEDataGridViewTextBoxColumn.Name = "pACKAGECODEDataGridViewTextBoxColumn";
            // 
            // fORNOOFPERSONSDataGridViewTextBoxColumn
            // 
            this.fORNOOFPERSONSDataGridViewTextBoxColumn.DataPropertyName = "FOR_NO_OF_PERSONS";
            this.fORNOOFPERSONSDataGridViewTextBoxColumn.HeaderText = "FOR_NO_OF_PERSONS";
            this.fORNOOFPERSONSDataGridViewTextBoxColumn.Name = "fORNOOFPERSONSDataGridViewTextBoxColumn";
            // 
            // bILLIDDataGridViewTextBoxColumn
            // 
            this.bILLIDDataGridViewTextBoxColumn.DataPropertyName = "BILL_ID";
            this.bILLIDDataGridViewTextBoxColumn.HeaderText = "BILL_ID";
            this.bILLIDDataGridViewTextBoxColumn.Name = "bILLIDDataGridViewTextBoxColumn";
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.bookings_And_payments_DataSet_appData;
            // 
            // bookings_And_payments_DataSet_appData
            // 
            this.bookings_And_payments_DataSet_appData.DataSetName = "Bookings_And_payments_DataSet_appData";
            this.bookings_And_payments_DataSet_appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bILLIDDataGridViewTextBoxColumn1,
            this.rEFERENCETYPEDataGridViewTextBoxColumn1,
            this.rEFERENCECODEDataGridViewTextBoxColumn1,
            this.bOOKINGIDNODataGridViewTextBoxColumn,
            this.bILLDATEDataGridViewTextBoxColumn,
            this.tOTALORIGNALAMOUNTDataGridViewTextBoxColumn,
            this.sPECIALOFFERDISCOUNTDataGridViewTextBoxColumn,
            this.eXTRADISCOUNTDataGridViewTextBoxColumn,
            this.tOTALDISCOUNTDataGridViewTextBoxColumn,
            this.pAIDAMOUNTDataGridViewTextBoxColumn,
            this.rEMAININGAMOUNTDataGridViewTextBoxColumn,
            this.isPAIDFULLDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.billsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(17, 246);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(618, 99);
            this.dataGridView2.TabIndex = 7;
            // 
            // bILLIDDataGridViewTextBoxColumn1
            // 
            this.bILLIDDataGridViewTextBoxColumn1.DataPropertyName = "BILL_ID";
            this.bILLIDDataGridViewTextBoxColumn1.HeaderText = "BILL_ID";
            this.bILLIDDataGridViewTextBoxColumn1.Name = "bILLIDDataGridViewTextBoxColumn1";
            this.bILLIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rEFERENCETYPEDataGridViewTextBoxColumn1
            // 
            this.rEFERENCETYPEDataGridViewTextBoxColumn1.DataPropertyName = "REFERENCE_TYPE";
            this.rEFERENCETYPEDataGridViewTextBoxColumn1.HeaderText = "REFERENCE_TYPE";
            this.rEFERENCETYPEDataGridViewTextBoxColumn1.Name = "rEFERENCETYPEDataGridViewTextBoxColumn1";
            // 
            // rEFERENCECODEDataGridViewTextBoxColumn1
            // 
            this.rEFERENCECODEDataGridViewTextBoxColumn1.DataPropertyName = "REFERENCE_CODE";
            this.rEFERENCECODEDataGridViewTextBoxColumn1.HeaderText = "REFERENCE_CODE";
            this.rEFERENCECODEDataGridViewTextBoxColumn1.Name = "rEFERENCECODEDataGridViewTextBoxColumn1";
            // 
            // bOOKINGIDNODataGridViewTextBoxColumn
            // 
            this.bOOKINGIDNODataGridViewTextBoxColumn.DataPropertyName = "BOOKING_ID_NO";
            this.bOOKINGIDNODataGridViewTextBoxColumn.HeaderText = "BOOKING_ID_NO";
            this.bOOKINGIDNODataGridViewTextBoxColumn.Name = "bOOKINGIDNODataGridViewTextBoxColumn";
            // 
            // bILLDATEDataGridViewTextBoxColumn
            // 
            this.bILLDATEDataGridViewTextBoxColumn.DataPropertyName = "BILL_DATE";
            this.bILLDATEDataGridViewTextBoxColumn.HeaderText = "BILL_DATE";
            this.bILLDATEDataGridViewTextBoxColumn.Name = "bILLDATEDataGridViewTextBoxColumn";
            // 
            // tOTALORIGNALAMOUNTDataGridViewTextBoxColumn
            // 
            this.tOTALORIGNALAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_ORIGNAL_AMOUNT";
            this.tOTALORIGNALAMOUNTDataGridViewTextBoxColumn.HeaderText = "TOTAL_ORIGNAL_AMOUNT";
            this.tOTALORIGNALAMOUNTDataGridViewTextBoxColumn.Name = "tOTALORIGNALAMOUNTDataGridViewTextBoxColumn";
            // 
            // sPECIALOFFERDISCOUNTDataGridViewTextBoxColumn
            // 
            this.sPECIALOFFERDISCOUNTDataGridViewTextBoxColumn.DataPropertyName = "SPECIAL_OFFER_DISCOUNT";
            this.sPECIALOFFERDISCOUNTDataGridViewTextBoxColumn.HeaderText = "SPECIAL_OFFER_DISCOUNT";
            this.sPECIALOFFERDISCOUNTDataGridViewTextBoxColumn.Name = "sPECIALOFFERDISCOUNTDataGridViewTextBoxColumn";
            // 
            // eXTRADISCOUNTDataGridViewTextBoxColumn
            // 
            this.eXTRADISCOUNTDataGridViewTextBoxColumn.DataPropertyName = "EXTRA_DISCOUNT";
            this.eXTRADISCOUNTDataGridViewTextBoxColumn.HeaderText = "EXTRA_DISCOUNT";
            this.eXTRADISCOUNTDataGridViewTextBoxColumn.Name = "eXTRADISCOUNTDataGridViewTextBoxColumn";
            // 
            // tOTALDISCOUNTDataGridViewTextBoxColumn
            // 
            this.tOTALDISCOUNTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_DISCOUNT";
            this.tOTALDISCOUNTDataGridViewTextBoxColumn.HeaderText = "TOTAL_DISCOUNT";
            this.tOTALDISCOUNTDataGridViewTextBoxColumn.Name = "tOTALDISCOUNTDataGridViewTextBoxColumn";
            // 
            // pAIDAMOUNTDataGridViewTextBoxColumn
            // 
            this.pAIDAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "PAID_AMOUNT";
            this.pAIDAMOUNTDataGridViewTextBoxColumn.HeaderText = "PAID_AMOUNT";
            this.pAIDAMOUNTDataGridViewTextBoxColumn.Name = "pAIDAMOUNTDataGridViewTextBoxColumn";
            // 
            // rEMAININGAMOUNTDataGridViewTextBoxColumn
            // 
            this.rEMAININGAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "REMAINING_AMOUNT";
            this.rEMAININGAMOUNTDataGridViewTextBoxColumn.HeaderText = "REMAINING_AMOUNT";
            this.rEMAININGAMOUNTDataGridViewTextBoxColumn.Name = "rEMAININGAMOUNTDataGridViewTextBoxColumn";
            // 
            // isPAIDFULLDataGridViewCheckBoxColumn
            // 
            this.isPAIDFULLDataGridViewCheckBoxColumn.DataPropertyName = "IsPAID_FULL";
            this.isPAIDFULLDataGridViewCheckBoxColumn.HeaderText = "IsPAID_FULL";
            this.isPAIDFULLDataGridViewCheckBoxColumn.Name = "isPAIDFULLDataGridViewCheckBoxColumn";
            // 
            // billsBindingSource
            // 
            this.billsBindingSource.DataMember = "Bills";
            this.billsBindingSource.DataSource = this.bookings_And_payments_DataSet_appData;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(459, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(264, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "newBooking";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // billsTableAdapter
            // 
            this.billsTableAdapter.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(267, 56);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "newPackage";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(540, 27);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(112, 27);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "custAgentGrid";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(348, 45);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "newCompany";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(348, 74);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 14;
            this.button11.Text = "payableGrid";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(459, 93);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 15;
            this.button12.Text = "billgrid";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(560, 93);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 16;
            this.button13.Text = "bookingGrid";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(459, 122);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 17;
            this.button14.Text = "companyGrid";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 358);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.WarTextBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WarTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookings_And_payments_DataSet_appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WarFramework.Controls.WarTextBox WarTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private WarFramework.Controls.WarTextBox WarTextBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private com.WARPRO.DB.Bookings_And_payments_DataSet_appData bookings_And_payments_DataSet_appData;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private com.WARPRO.DB.Bookings_And_payments_DataSet_appDataTableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKINGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFERENCETYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFERENCECODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKINGDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pACKAGECODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORNOOFPERSONSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource billsBindingSource;
        private com.WARPRO.DB.Bookings_And_payments_DataSet_appDataTableAdapters.BillsTableAdapter billsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILLIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFERENCETYPEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFERENCECODEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKINGIDNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILLDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALORIGNALAMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPECIALOFFERDISCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXTRADISCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDISCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAIDAMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMAININGAMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPAIDFULLDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}

