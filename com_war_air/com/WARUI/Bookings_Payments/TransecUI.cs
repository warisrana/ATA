using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com_war_air.com.WARPRO.WARUI.Agents;

namespace com_war_air.com.WARUI.Bookings_Payments
{
    public partial class TransecUI : WarFramework.Forms.WarForm
    {

        decimal totalrecievable;
        decimal recieved;

        public TransecUI()
        {
            InitializeComponent();
        }

        public TransecUI(string serviceid )
        {
            try
            {
                
                    InitializeComponent();
                canceledLable.Show();

                var rr = WARPRO.Glob.Bookings_And_Payments.Glob_Transec.Get_Transec_Row(serviceid);

                totalrecievable = rr.REMAINING;
                recieved = rr.T_RECIEVED;

                ServiceIdLinkTxt.Text = rr.SERVICE_ID.ToString();
                CustomerIdLinkTxt.Text = rr.CUSTOMER_ID.ToString();

                RecievableTxt.Text = rr.ORIGNAL_RECIEVABLE.ToString();
                RecievedTxt.Text = rr.T_RECIEVED.ToString();
                RemainingTxt.Text = rr.REMAINING.ToString();

                ServiceNameLinkTxt.Text = rr.SERVICE_NAME;


                StatusToggle.Checked = rr.STATUS;


                if (rr.STATUS == false )
                {
                    canceledLable.Text = "CANCELLED/REFUNDED";
                    SAVE_Btn.Hide();
                    CurrentT_RecieveAmount.Hide();
                    recLable.Hide();
                }
                if (rr.STATUS == true)
                {
                    if (rr.REMAINING <= 0)
                    {
                        canceledLable.Text = "CLEARED";
                        canceledLable.ForeColor = Color.Green;

                        CurrentT_RecieveAmount.Hide();
                        recLable.Hide();
                        SAVE_Btn.Hide();
                    }
                    else if (rr.REMAINING > 0)
                    {
                        canceledLable.Text = "PENDING";
                        canceledLable.ForeColor = Color.DodgerBlue;
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void calcu()
        {


            if (RecievableTxt.Text.Length <= 0)
            {
                RecievableTxt.Text = "0";
            }
            if (RecievedTxt.Text.Length <= 0)
            {
                RecievedTxt.Text = "0";
            }
            if (RemainingTxt.Text.Length <= 0)
            {
                RemainingTxt.Text = "0";
            }
            if (CurrentT_RecieveAmount.Text.Length <= 0)
            {
                CurrentT_RecieveAmount.Text = "0";
            }


            //decimal totalrecievable = decimal.Parse(RecievableTxt.Text);
            //decimal recieved = decimal.Parse(RecievedTxt.Text);
             //totalrecievable = decimal.Parse(RemainingTxt.Text);
            decimal currentRecieve = decimal.Parse(CurrentT_RecieveAmount.Text);

            if (currentRecieve > totalrecievable)
            {
                CurrentT_RecieveAmount.Text = totalrecievable.ToString();

                currentRecieve = totalrecievable;


            }


            RemainingTxt.Text = (totalrecievable - currentRecieve).ToString();
            RecievedTxt.Text = (currentRecieve + recieved).ToString();






        }

        private void ServiceIdLinkTxt_Click(object sender, EventArgs e)
        {
            try
            {
                var value = ServiceIdLinkTxt.Text; 
                var check = ServiceNameLinkTxt.Text;

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

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void CurrentT_RecieveAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                calcu();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SAVE_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                WARPRO.Glob.Bookings_And_Payments.Glob_Transec.NewTransec(ServiceIdLinkTxt.Text, CustomerIdLinkTxt.Text, "0",  CurrentT_RecieveAmount.Text,  RemainingTxt.Text, ServiceNameLinkTxt.Text);

                this.Close();
                WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("SUCCESSFULL", "SAVED SUCCESSFULLY");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void StatusToggle_Click(object sender, EventArgs e)
        {
            try
            {

                WARPRO.Glob.Bookings_And_Payments.Glob_Transec.UpdateStatus(StatusToggle.Checked, ServiceIdLinkTxt.Text);

                this.Close();
                WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("UPDATED", "UPDATED SUCCESSFULLY");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void CustomerIdLinkTxt_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerUI bk = new CustomerUI(long.Parse(CustomerIdLinkTxt.Text));
                bk.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
