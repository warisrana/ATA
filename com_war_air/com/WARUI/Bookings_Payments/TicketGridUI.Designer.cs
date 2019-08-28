namespace com_war_air.com.WARUI.Bookings_Payments
{
    partial class TicketGridUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketGridUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pnr_Txt = new WarFramework.Controls.WarTextBox();
            this.CustomerID_Txt = new WarFramework.Controls.WarTextBox();
            this.WarPanel1 = new WarFramework.Controls.WarPanel();
            this.WarGrid1 = new WarFramework.Controls.WarGrid();
            this.groupBox1.SuspendLayout();
            this.WarPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pnr_Txt);
            this.groupBox1.Controls.Add(this.CustomerID_Txt);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(11, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 57);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH";
            // 
            // Pnr_Txt
            // 
            // 
            // 
            // 
            this.Pnr_Txt.CustomButton.Image = null;
            this.Pnr_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.Pnr_Txt.CustomButton.Name = "";
            this.Pnr_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Pnr_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.Pnr_Txt.CustomButton.TabIndex = 1;
            this.Pnr_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.Pnr_Txt.CustomButton.UseSelectable = true;
            this.Pnr_Txt.CustomButton.Visible = false;
            this.Pnr_Txt.Lines = new string[0];
            this.Pnr_Txt.Location = new System.Drawing.Point(26, 19);
            this.Pnr_Txt.MaxLength = 32767;
            this.Pnr_Txt.Name = "Pnr_Txt";
            this.Pnr_Txt.PasswordChar = '\0';
            this.Pnr_Txt.PromptText = "PNR";
            this.Pnr_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Pnr_Txt.SelectedText = "";
            this.Pnr_Txt.SelectionLength = 0;
            this.Pnr_Txt.SelectionStart = 0;
            this.Pnr_Txt.ShortcutsEnabled = true;
            this.Pnr_Txt.ShowClearButton = true;
            this.Pnr_Txt.Size = new System.Drawing.Size(287, 23);
            this.Pnr_Txt.TabIndex = 62;
            this.Pnr_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pnr_Txt.UseSelectable = true;
            this.Pnr_Txt.WaterMark = "PNR";
            this.Pnr_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Pnr_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Pnr_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerID_Txt_KeyDown);
            // 
            // CustomerID_Txt
            // 
            // 
            // 
            // 
            this.CustomerID_Txt.CustomButton.Image = null;
            this.CustomerID_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.CustomerID_Txt.CustomButton.Name = "";
            this.CustomerID_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CustomerID_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.CustomerID_Txt.CustomButton.TabIndex = 1;
            this.CustomerID_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.CustomerID_Txt.CustomButton.UseSelectable = true;
            this.CustomerID_Txt.CustomButton.Visible = false;
            this.CustomerID_Txt.Icon = ((System.Drawing.Image)(resources.GetObject("CustomerID_Txt.Icon")));
            this.CustomerID_Txt.Lines = new string[0];
            this.CustomerID_Txt.Location = new System.Drawing.Point(355, 19);
            this.CustomerID_Txt.MaxLength = 32767;
            this.CustomerID_Txt.Name = "CustomerID_Txt";
            this.CustomerID_Txt.PasswordChar = '\0';
            this.CustomerID_Txt.PromptText = "CUSTOMER ID";
            this.CustomerID_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerID_Txt.SelectedText = "";
            this.CustomerID_Txt.SelectionLength = 0;
            this.CustomerID_Txt.SelectionStart = 0;
            this.CustomerID_Txt.ShortcutsEnabled = true;
            this.CustomerID_Txt.ShowClearButton = true;
            this.CustomerID_Txt.Size = new System.Drawing.Size(287, 23);
            this.CustomerID_Txt.TabIndex = 60;
            this.CustomerID_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerID_Txt.UseSelectable = true;
            this.CustomerID_Txt.WaterMark = "CUSTOMER ID";
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
            this.WarPanel1.Location = new System.Drawing.Point(7, 98);
            this.WarPanel1.Name = "WarPanel1";
            this.WarPanel1.Size = new System.Drawing.Size(1330, 471);
            this.WarPanel1.TabIndex = 71;
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
            this.WarGrid1.Size = new System.Drawing.Size(1330, 471);
            this.WarGrid1.TabIndex = 3;
            this.WarGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarGrid1_CellClick);
            // 
            // TicketGridUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WarPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TicketGridUI";
            this.Resizable = false;
            this.Text = "TICKETS";
            this.TextAlign = WarFramework.Forms.WarFormTextAlign.Right;
            this.groupBox1.ResumeLayout(false);
            this.WarPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WarGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WarFramework.Controls.WarTextBox Pnr_Txt;
        private WarFramework.Controls.WarTextBox CustomerID_Txt;
        private WarFramework.Controls.WarPanel WarPanel1;
        private WarFramework.Controls.WarGrid WarGrid1;
    }
}