namespace com_war_air.com.WARUI.Bookings_Payments
{
    partial class OtherPayableGridUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherPayableGridUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PaidToName_Txt = new WarFramework.Controls.WarTextBox();
            this.WarPanel1 = new WarFramework.Controls.WarPanel();
            this.WarGrid1 = new WarFramework.Controls.WarGrid();
            this.DateTime1 = new WarFramework.Controls.WarDateTime();
            this.groupBox1.SuspendLayout();
            this.WarPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DateTime1);
            this.groupBox1.Controls.Add(this.PaidToName_Txt);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(19, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 57);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH";
            // 
            // PaidToName_Txt
            // 
            // 
            // 
            // 
            this.PaidToName_Txt.CustomButton.Image = null;
            this.PaidToName_Txt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.PaidToName_Txt.CustomButton.Name = "";
            this.PaidToName_Txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PaidToName_Txt.CustomButton.Style = WarFramework.WarColorStyle.Blue;
            this.PaidToName_Txt.CustomButton.TabIndex = 1;
            this.PaidToName_Txt.CustomButton.Theme = WarFramework.WarThemeStyle.Light;
            this.PaidToName_Txt.CustomButton.UseSelectable = true;
            this.PaidToName_Txt.CustomButton.Visible = false;
            this.PaidToName_Txt.Lines = new string[0];
            this.PaidToName_Txt.Location = new System.Drawing.Point(26, 19);
            this.PaidToName_Txt.MaxLength = 32767;
            this.PaidToName_Txt.Name = "PaidToName_Txt";
            this.PaidToName_Txt.PasswordChar = '\0';
            this.PaidToName_Txt.PromptText = "PAID TO (NAME)";
            this.PaidToName_Txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PaidToName_Txt.SelectedText = "";
            this.PaidToName_Txt.SelectionLength = 0;
            this.PaidToName_Txt.SelectionStart = 0;
            this.PaidToName_Txt.ShortcutsEnabled = true;
            this.PaidToName_Txt.ShowClearButton = true;
            this.PaidToName_Txt.Size = new System.Drawing.Size(287, 23);
            this.PaidToName_Txt.TabIndex = 62;
            this.PaidToName_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PaidToName_Txt.UseSelectable = true;
            this.PaidToName_Txt.WaterMark = "PAID TO (NAME)";
            this.PaidToName_Txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PaidToName_Txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PaidToName_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaidToName_Txt_KeyDown);
            // 
            // WarPanel1
            // 
            this.WarPanel1.Controls.Add(this.WarGrid1);
            this.WarPanel1.HorizontalScrollbarBarColor = true;
            this.WarPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.WarPanel1.HorizontalScrollbarSize = 10;
            this.WarPanel1.Location = new System.Drawing.Point(15, 80);
            this.WarPanel1.Name = "WarPanel1";
            this.WarPanel1.Size = new System.Drawing.Size(1299, 514);
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
            this.WarGrid1.Size = new System.Drawing.Size(1299, 514);
            this.WarGrid1.TabIndex = 3;
            this.WarGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarGrid1_CellClick);
            // 
            // DateTime1
            // 
            this.DateTime1.Checked = false;
            this.DateTime1.Location = new System.Drawing.Point(386, 19);
            this.DateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTime1.Name = "DateTime1";
            this.DateTime1.ShowCheckBox = true;
            this.DateTime1.Size = new System.Drawing.Size(243, 29);
            this.DateTime1.TabIndex = 63;
            this.DateTime1.ValueChanged += new System.EventHandler(this.DateTime1_ValueChanged);
            // 
            // OtherPayableGridUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 602);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WarPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OtherPayableGridUI";
            this.Resizable = false;
            this.Text = "OTHER PAYABLES";
            this.TextAlign = WarFramework.Forms.WarFormTextAlign.Right;
            this.groupBox1.ResumeLayout(false);
            this.WarPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WarGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WarFramework.Controls.WarTextBox PaidToName_Txt;
        private WarFramework.Controls.WarPanel WarPanel1;
        private WarFramework.Controls.WarGrid WarGrid1;
        private WarFramework.Controls.WarDateTime DateTime1;
    }
}