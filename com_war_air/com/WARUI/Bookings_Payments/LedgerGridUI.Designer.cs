namespace com_war_air.com.WARUI.Bookings_Payments
{
    partial class LedgerGridUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LedgerGridUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgentID_Txt = new WarFramework.Controls.WarTextBox();
            this.CustomerID_Txt = new WarFramework.Controls.WarTextBox();
            this.WarPanel1 = new WarFramework.Controls.WarPanel();
            this.WarGrid1 = new WarFramework.Controls.WarGrid();
            this.Panel1 = new WarFramework.Controls.WarPanel();
            this.RemainingTxt = new WarFramework.Controls.WarLabel();
            this.WarLabel3 = new WarFramework.Controls.WarLabel();
            this.WarLabel1 = new WarFramework.Controls.WarLabel();
            this.Name_Txt = new WarFramework.Controls.WarLabel();
            this.ImageR = new System.Windows.Forms.PictureBox();
            this.Collected_Paid_Amount_Txt = new WarFramework.Controls.WarLabel();
            this.GrandTotal_Txt = new WarFramework.Controls.WarLabel();
            this.WarLabel15 = new WarFramework.Controls.WarLabel();
            this.WarLabel16 = new WarFramework.Controls.WarLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.WarPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarGrid1)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AgentID_Txt);
            this.groupBox1.Controls.Add(this.CustomerID_Txt);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 41);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            // 
            // AgentID_Txt
            // 
            // 
            // 
            // 
            this.AgentID_Txt.CustomButton.Image = null;
            this.AgentID_Txt.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.AgentID_Txt.CustomButton.Name = "";
            this.AgentID_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AgentID_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.AgentID_Txt.CustomButton.TabIndex = 1;
            this.AgentID_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.AgentID_Txt.CustomButton.UseSelectable = true;
            this.AgentID_Txt.CustomButton.Visible = false;
            this.AgentID_Txt.Lines = new string[0];
            this.AgentID_Txt.Location = new System.Drawing.Point(6, 11);
            this.AgentID_Txt.MaxLength = 32767;
            this.AgentID_Txt.Name = "AgentID_Txt";
            this.AgentID_Txt.PasswordChar = '\0';
            this.AgentID_Txt.PromptText = "FOR AN AGENT";
            this.AgentID_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AgentID_Txt.SelectedText = "";
            this.AgentID_Txt.SelectionLength = 0;
            this.AgentID_Txt.SelectionStart = 0;
            this.AgentID_Txt.ShortcutsEnabled = true;
            this.AgentID_Txt.ShowClearButton = true;
            this.AgentID_Txt.Size = new System.Drawing.Size(231, 23);
            this.AgentID_Txt.TabIndex = 62;
            this.AgentID_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AgentID_Txt.UseSelectable = true;
            this.AgentID_Txt.WaterMark = "FOR AN AGENT";
            this.AgentID_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AgentID_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.AgentID_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AgentID_Txt_KeyDown);
            this.AgentID_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerID_Txt_KeyPress);
            // 
            // CustomerID_Txt
            // 
            // 
            // 
            // 
            this.CustomerID_Txt.CustomButton.Image = null;
            this.CustomerID_Txt.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.CustomerID_Txt.CustomButton.Name = "";
            this.CustomerID_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CustomerID_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.CustomerID_Txt.CustomButton.TabIndex = 1;
            this.CustomerID_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.CustomerID_Txt.CustomButton.UseSelectable = true;
            this.CustomerID_Txt.CustomButton.Visible = false;
            this.CustomerID_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("CustomerID_Txt.Icon")));
            this.CustomerID_Txt.Lines = new string[0];
            this.CustomerID_Txt.Location = new System.Drawing.Point(243, 11);
            this.CustomerID_Txt.MaxLength = 32767;
            this.CustomerID_Txt.Name = "CustomerID_Txt";
            this.CustomerID_Txt.PasswordChar = '\0';
            this.CustomerID_Txt.PromptText = "FOR CUSTOMER";
            this.CustomerID_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerID_Txt.SelectedText = "";
            this.CustomerID_Txt.SelectionLength = 0;
            this.CustomerID_Txt.SelectionStart = 0;
            this.CustomerID_Txt.ShortcutsEnabled = true;
            this.CustomerID_Txt.ShowClearButton = true;
            this.CustomerID_Txt.Size = new System.Drawing.Size(231, 23);
            this.CustomerID_Txt.TabIndex = 60;
            this.CustomerID_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerID_Txt.UseSelectable = true;
            this.CustomerID_Txt.WaterMark = "FOR CUSTOMER";
            this.CustomerID_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomerID_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CustomerID_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerID_Txt_KeyDown);
            this.CustomerID_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerID_Txt_KeyPress);
            // 
            // WarPanel1
            // 
            this.WarPanel1.Controls.Add(this.WarGrid1);
            this.WarPanel1.HorizontalScrollbarBarColor = true;
            this.WarPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.WarPanel1.HorizontalScrollbarSize = 10;
            this.WarPanel1.Location = new System.Drawing.Point(4, 102);
            this.WarPanel1.Name = "WarPanel1";
            this.WarPanel1.Size = new System.Drawing.Size(788, 618);
            this.WarPanel1.TabIndex = 77;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WarGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.WarGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WarGrid1.DefaultCellStyle = dataGridViewCellStyle6;
            this.WarGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarGrid1.EnableHeadersVisualStyles = false;
            this.WarGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WarGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WarGrid1.Location = new System.Drawing.Point(0, 0);
            this.WarGrid1.MultiSelect = false;
            this.WarGrid1.Name = "WarGrid1";
            this.WarGrid1.ReadOnly = true;
            this.WarGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WarGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.WarGrid1.RowHeadersVisible = false;
            this.WarGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.WarGrid1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.WarGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.WarGrid1.ShowCellErrors = false;
            this.WarGrid1.ShowRowErrors = false;
            this.WarGrid1.Size = new System.Drawing.Size(788, 618);
            this.WarGrid1.TabIndex = 3;
            this.WarGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarGrid1_CellClick);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.RemainingTxt);
            this.Panel1.Controls.Add(this.WarLabel3);
            this.Panel1.Controls.Add(this.WarLabel1);
            this.Panel1.Controls.Add(this.Name_Txt);
            this.Panel1.Controls.Add(this.ImageR);
            this.Panel1.Controls.Add(this.Collected_Paid_Amount_Txt);
            this.Panel1.Controls.Add(this.GrandTotal_Txt);
            this.Panel1.Controls.Add(this.WarLabel15);
            this.Panel1.Controls.Add(this.WarLabel16);
            this.Panel1.Controls.Add(this.WarPanel1);
            this.Panel1.HorizontalScrollbarBarColor = true;
            this.Panel1.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel1.HorizontalScrollbarSize = 10;
            this.Panel1.Location = new System.Drawing.Point(6, 56);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(795, 720);
            this.Panel1.TabIndex = 79;
            this.Panel1.VerticalScrollbarBarColor = true;
            this.Panel1.VerticalScrollbarHighlightOnWheel = false;
            this.Panel1.VerticalScrollbarSize = 10;
            // 
            // RemainingTxt
            // 
            this.RemainingTxt.AutoSize = true;
            this.RemainingTxt.FontWeight = WarFramework.WarLabelWeight.Regular;
            this.RemainingTxt.ForeColor = System.Drawing.Color.DimGray;
            this.RemainingTxt.Location = new System.Drawing.Point(677, 62);
            this.RemainingTxt.Name = "RemainingTxt";
            this.RemainingTxt.Size = new System.Drawing.Size(17, 19);
            this.RemainingTxt.TabIndex = 102;
            this.RemainingTxt.Text = "0";
            this.RemainingTxt.UseCustomForeColor = true;
            // 
            // WarLabel3
            // 
            this.WarLabel3.AutoSize = true;
            this.WarLabel3.FontWeight = WarFramework.WarLabelWeight.Regular;
            this.WarLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.WarLabel3.Location = new System.Drawing.Point(524, 62);
            this.WarLabel3.Name = "WarLabel3";
            this.WarLabel3.Size = new System.Drawing.Size(84, 19);
            this.WarLabel3.TabIndex = 101;
            this.WarLabel3.Text = "REMAINING";
            this.WarLabel3.UseCustomForeColor = true;
            // 
            // WarLabel1
            // 
            this.WarLabel1.AutoSize = true;
            this.WarLabel1.FontWeight = WarFramework.WarLabelWeight.Bold;
            this.WarLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.WarLabel1.Location = new System.Drawing.Point(5, 2);
            this.WarLabel1.Name = "WarLabel1";
            this.WarLabel1.Size = new System.Drawing.Size(59, 19);
            this.WarLabel1.TabIndex = 100;
            this.WarLabel1.Text = "LEDGER";
            this.WarLabel1.UseCustomForeColor = true;
            // 
            // Name_Txt
            // 
            this.Name_Txt.AutoSize = true;
            this.Name_Txt.FontWeight = WarFramework.WarLabelWeight.Regular;
            this.Name_Txt.ForeColor = System.Drawing.Color.DimGray;
            this.Name_Txt.Location = new System.Drawing.Point(90, 24);
            this.Name_Txt.Name = "Name_Txt";
            this.Name_Txt.Size = new System.Drawing.Size(0, 0);
            this.Name_Txt.TabIndex = 99;
            this.Name_Txt.UseCustomForeColor = true;
            // 
            // ImageR
            // 
            this.ImageR.BackColor = System.Drawing.Color.Transparent;
            this.ImageR.Location = new System.Drawing.Point(5, 24);
            this.ImageR.Name = "ImageR";
            this.ImageR.Size = new System.Drawing.Size(79, 72);
            this.ImageR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageR.TabIndex = 98;
            this.ImageR.TabStop = false;
            // 
            // Collected_Paid_Amount_Txt
            // 
            this.Collected_Paid_Amount_Txt.AutoSize = true;
            this.Collected_Paid_Amount_Txt.FontWeight = WarFramework.WarLabelWeight.Regular;
            this.Collected_Paid_Amount_Txt.ForeColor = System.Drawing.Color.DimGray;
            this.Collected_Paid_Amount_Txt.Location = new System.Drawing.Point(677, 36);
            this.Collected_Paid_Amount_Txt.Name = "Collected_Paid_Amount_Txt";
            this.Collected_Paid_Amount_Txt.Size = new System.Drawing.Size(17, 19);
            this.Collected_Paid_Amount_Txt.TabIndex = 97;
            this.Collected_Paid_Amount_Txt.Text = "0";
            this.Collected_Paid_Amount_Txt.UseCustomForeColor = true;
            // 
            // GrandTotal_Txt
            // 
            this.GrandTotal_Txt.AutoSize = true;
            this.GrandTotal_Txt.FontWeight = WarFramework.WarLabelWeight.Bold;
            this.GrandTotal_Txt.ForeColor = System.Drawing.Color.DimGray;
            this.GrandTotal_Txt.Location = new System.Drawing.Point(677, 6);
            this.GrandTotal_Txt.Name = "GrandTotal_Txt";
            this.GrandTotal_Txt.Size = new System.Drawing.Size(17, 19);
            this.GrandTotal_Txt.TabIndex = 96;
            this.GrandTotal_Txt.Text = "0";
            this.GrandTotal_Txt.UseCustomForeColor = true;
            // 
            // WarLabel15
            // 
            this.WarLabel15.AutoSize = true;
            this.WarLabel15.FontWeight = WarFramework.WarLabelWeight.Regular;
            this.WarLabel15.ForeColor = System.Drawing.Color.DimGray;
            this.WarLabel15.Location = new System.Drawing.Point(524, 36);
            this.WarLabel15.Name = "WarLabel15";
            this.WarLabel15.Size = new System.Drawing.Size(134, 19);
            this.WarLabel15.TabIndex = 95;
            this.WarLabel15.Text = "RECIEVED AMOUNT";
            this.WarLabel15.UseCustomForeColor = true;
            // 
            // WarLabel16
            // 
            this.WarLabel16.AutoSize = true;
            this.WarLabel16.FontWeight = WarFramework.WarLabelWeight.Bold;
            this.WarLabel16.ForeColor = System.Drawing.Color.DimGray;
            this.WarLabel16.Location = new System.Drawing.Point(524, 6);
            this.WarLabel16.Name = "WarLabel16";
            this.WarLabel16.Size = new System.Drawing.Size(50, 19);
            this.WarLabel16.TabIndex = 94;
            this.WarLabel16.Text = "TOTAL";
            this.WarLabel16.UseCustomForeColor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PrintBtn.FlatAppearance.BorderSize = 0;
            this.PrintBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PrintBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrintBtn.Image")));
            this.PrintBtn.Location = new System.Drawing.Point(614, 19);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(61, 31);
            this.PrintBtn.TabIndex = 80;
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // LedgerGridUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 780);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LedgerGridUI";
            this.Resizable = false;
            this.Text = "LEDGER";
            this.TextAlign = WarFramework.Forms.WarFormTextAlign.Right;
            this.Load += new System.EventHandler(this.LedgerGridUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.WarPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WarGrid1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WarFramework.Controls.WarTextBox AgentID_Txt;
        private WarFramework.Controls.WarTextBox CustomerID_Txt;
        private WarFramework.Controls.WarPanel WarPanel1;
        private WarFramework.Controls.WarGrid WarGrid1;
        private WarFramework.Controls.WarPanel Panel1;
        private WarFramework.Controls.WarLabel Collected_Paid_Amount_Txt;
        private WarFramework.Controls.WarLabel GrandTotal_Txt;
        private WarFramework.Controls.WarLabel WarLabel15;
        private WarFramework.Controls.WarLabel WarLabel16;
        private WarFramework.Controls.WarLabel WarLabel1;
        private WarFramework.Controls.WarLabel Name_Txt;
        private System.Windows.Forms.PictureBox ImageR;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button PrintBtn;
        private WarFramework.Controls.WarLabel RemainingTxt;
        private WarFramework.Controls.WarLabel WarLabel3;
    }
}