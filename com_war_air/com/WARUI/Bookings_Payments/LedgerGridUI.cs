using com_war_air.com.WARPRO.WARUI.Agents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Properties;

namespace com_war_air.com.WARUI.Bookings_Payments
{
    public partial class LedgerGridUI : WarFramework.Forms.WarForm
    {
        public LedgerGridUI()
        {
            InitializeComponent();
        }


        internal void Cellcliick()
        {
            //var value = WarGrid1.SelectedCells[0].Value.ToString();

            //if (WarGrid1.SelectedCells[0].ColumnIndex == 1)
            //{

            //    CustomerUI bk = new CustomerUI(long.Parse(value));
            //    bk.ShowDialog();
            //}

            //else
            //{
            string check = WarGrid1.Rows[WarGrid1.SelectedCells[0].RowIndex].Cells[7].Value.ToString();

            var value = WarGrid1.Rows[WarGrid1.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                
            if (check.ToLower().Contains("protector") == true)
            {
                ProtectorUI bk = new ProtectorUI(long.Parse(value));
                bk.ShowDialog();
            }
            else if (check.ToLower().Contains("dubai") == true)
            {
                DubaiVisitUI bk = new DubaiVisitUI(long.Parse(value));
                bk.ShowDialog();
            }
            else if (check.ToLower().Contains("saudi") == true)
            {
                SaudiVisaStampUI bk = new SaudiVisaStampUI(value);
                bk.ShowDialog();
            }
            else if (check.ToLower().Contains("ticket") == true)
            {
                TicketUI bk = new TicketUI(value);
                bk.ShowDialog();
            }
            else if (check.ToLower().Contains("booking") == true)
            {
                BookingInfoUI bk = new BookingInfoUI(long.Parse(value));
                bk.ShowDialog();
            }

            //}

        }

        internal void LoadDataAgentLedger()
        {
            WarGrid1.DataSource = WARPRO.Glob.CustomersAndAgents.Glob_Ledger.Get_AgentLedger_Table_DataFOrGrid(long.Parse(AgentID_Txt.Text));
            WarGrid1.Columns[0].Visible = false;
            WarGrid1.Columns[1].Visible = false;
            WarGrid1.Columns[4].Visible = false;

            WarGrid1.Columns[7].Visible = false;
            WarGrid1.Columns[8].Visible = false;


            var r = WARPRO.Glob.Bookings_And_Payments.Glob_Transec.Get_TotalRecieveableAgent(long.Parse(AgentID_Txt.Text));
            var p = WARPRO.Glob.Bookings_And_Payments.Glob_Transec.Get_TotalPaidAgent(long.Parse(AgentID_Txt.Text));



            GrandTotal_Txt.Text = r.ToString();
            Collected_Paid_Amount_Txt.Text = p.ToString();
            RemainingTxt.Text = (r - p).ToString();



            //Callcculate();
            InfoOfLedgerCustomerAndAgent(2);
            //WarGrid1.Columns[0].Visible = false;
            //WarGrid1.Columns[6].Visible = false;
            //WarGrid1.Columns[7].Visible = false;

        }

        internal void LoadDataCustomerLedger()
        {
            WarGrid1.DataSource = WARPRO.Glob.CustomersAndAgents.Glob_Ledger.Get_CustomerLedger_Table_DataFOrGrid(long.Parse(CustomerID_Txt.Text));
            WarGrid1.Columns[0].Visible = false;
            WarGrid1.Columns[1].Visible = false;
            WarGrid1.Columns[4].Visible = false;

            WarGrid1.Columns[7].Visible = false;
            WarGrid1.Columns[8].Visible = false;


            var r = WARPRO.Glob.Bookings_And_Payments.Glob_Transec.Get_TotalRecieveableCustomer(long.Parse(CustomerID_Txt.Text));
            var p = WARPRO.Glob.Bookings_And_Payments.Glob_Transec.Get_TotalPaidCustomer(long.Parse(CustomerID_Txt.Text));



            GrandTotal_Txt.Text = r.ToString();
            Collected_Paid_Amount_Txt.Text = p.ToString();
            RemainingTxt.Text = (r - p).ToString();

            // Callcculate();
            InfoOfLedgerCustomerAndAgent(1);

            //WarGrid1.Columns[0].Visible = false;
            //WarGrid1.Columns[6].Visible = false;
            //WarGrid1.Columns[7].Visible = false;

        }

        private void AgentID_Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (AgentID_Txt.Text.Length > 0)
                    {
                        LoadDataAgentLedger();
                    }
                    

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void CustomerID_Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (CustomerID_Txt.Text.Length > 0)
                    {
                        LoadDataCustomerLedger();
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }



        private void Callcculate()
        {

            GrandTotal_Txt.Text = "0";
            Collected_Paid_Amount_Txt.Text = "0";

            int rows = WarGrid1.RowCount;

            decimal total = 0;
            decimal paid  = 0;


            if (rows <= 0)
            {
                GrandTotal_Txt.Text = "0";
                Collected_Paid_Amount_Txt.Text = "0";
            }
            else if (rows > 0)
            {

                for (int i = 0; i < rows; i++)
                {

                    total += decimal.Parse(WarGrid1.Rows[i].Cells[2].Value.ToString());
                    paid  += decimal.Parse(WarGrid1.Rows[i].Cells[3].Value.ToString());

                }

            }


            GrandTotal_Txt.Text       = total.ToString();
            Collected_Paid_Amount_Txt.Text = paid.ToString();

        }

        private void InfoOfLedgerCustomerAndAgent( int OneForCustomerTwoForAgentinfo)
        {
            ImageR.Image = null;
            Name_Txt.Text = "";
            if (OneForCustomerTwoForAgentinfo == 1)
            {
              var rr =   WARPRO.Glob.CustomersAndAgents.CustomersAndAgents_class.Select_Row_Customer(long.Parse( CustomerID_Txt.Text));

                if (rr != null)
                {
                    ImageR.Image = WARPRO.Glob.CacheData.Glob_Veriables.GetImageFromByteArray( rr.PICTURE);
                    Name_Txt.Text = "CUSTOMER\n"+rr.FIRST_NAME.ToUpper() + " " + rr.LAST_NAME.ToUpper();

                }
            }


            else if (OneForCustomerTwoForAgentinfo == 2)
            {
                var rr = WARPRO.Glob.CustomersAndAgents.Agents_Partial.Select_Row_Agent(long.Parse(AgentID_Txt.Text));

                if (rr != null)
                {
                    ImageR.Image = WARPRO.Glob.CacheData.Glob_Veriables.GetImageFromByteArray(rr.PICTURE);
                    Name_Txt.Text = "AGENT\n" + rr.FIRST_NAME.ToUpper() + " " + rr.LAST_NAME.ToUpper();

                }
            }

        }

        private void WarGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cellcliick();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void CustomerID_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13;

        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;

        private void PrintScreen()
        {
            Graphics mygraphics = Panel1.CreateGraphics();
            Size s = Panel1.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, Panel1.ClientRectangle.Width, Panel1.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            //printPreviewDialog1.ShowIcon = false;
            (printPreviewDialog1 as Form).Icon = Resources.warlogoic;
        }

        private void LedgerGridUI_Load(object sender, EventArgs e)
        {
            ImageR.Region = WARPRO.Glob.CacheData.Glob_Veriables.GetRoundRegion(ImageR.Width, ImageR.Height);

        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PrintScreen();
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WarGrid1.DataSource =    WARPRO.Glob.Bookings_And_Payments.Glob_Transec.Get_Transec_Table_DataFOrGrid(CustomerID_Txt.Text);
        }
    }
}
