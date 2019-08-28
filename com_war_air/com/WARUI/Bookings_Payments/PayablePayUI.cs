using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com_war_air.com.WARUI.Bookings_Payments
{
    public partial class PayablePayUI : WarFramework.Forms.WarForm
    {
        bool IspaidFullVar;
        long OrignalbookingiDVar;
        decimal RemainingVar;
        decimal PaidVar;

        public PayablePayUI(long BookingiD )
        {
            InitializeComponent();


           var rr =  WARPRO.Glob.Bookings_And_Payments.Glob_Payable.Get_SelectPayableRow(BookingiD);

            RemainingVar = rr.REMAINING_AMOUNT;
            PaidVar = rr.PAID_AMOUNT;

            IspaidFullVar = rr.IsPAID_FULL;
            OrignalbookingiDVar = rr.BOOKING_ID;

            this.Text = "PAYABLE ID - " + rr.PAYABLE_ID.ToString() + " : : BOOKING ID - " + rr.BOOKING_ID.ToString();

            Orignal_Total_Txt.Text = rr.PAYABLE_AMOUNT.ToString();
            Paid_Total_Txt.Text = rr.PAID_AMOUNT.ToString();
            Remaining_Total_Txt.Text = rr.REMAINING_AMOUNT.ToString();

            status_txt.Text = "PENDING PAYABLE";
            status_txt.ForeColor = Color.DodgerBlue;

            if (rr.IsPAID_FULL == true )
            {
                PayAmount_Txt.Hide();
                SAVE_Btn.Hide();
                status_txt.Text = "ALREADY CLEARED PAYABLE";
                status_txt.ForeColor = Color.Green;
            }



            if (rr.DEAL_STATUS == false)
            {
                PayAmount_Txt.Hide();
                SAVE_Btn.Hide();
                status_txt.Text = "CANCELLED";
                status_txt.ForeColor = Color.Red;


            }

        }

        private void PayablePayUI_Load(object sender, EventArgs e)
        {

        }

        private void SAVE_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                decimal t = decimal.Parse(Orignal_Total_Txt.Text);
                decimal a =  decimal.Parse(Paid_Total_Txt.Text);

                decimal b = decimal.Parse(Remaining_Total_Txt.Text);

                bool isfullpaid = false;

                if (t == a)
                {
                    isfullpaid = true;

                }

                else if (t > a)
                {
                    isfullpaid = false;
                }

                WARPRO.Glob.Bookings_And_Payments.Glob_Payable.UpdatePayablePayments(a,b , isfullpaid, OrignalbookingiDVar);
                this.Close();
                WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("UPDATED", "PAYABLE HAS BEEN SUCCESSFULLY UPDATED ");


            }
            catch (Exception)
            {

                throw;
            }
        }

        decimal IspaidFullChecking;
        decimal newremain;
        decimal newpaid;
        private void calculation()
        {
            decimal totalOrignalPayable = decimal.Parse(Orignal_Total_Txt.Text);

            if (PayAmount_Txt.Text.Length < 1)
            {
                PayAmount_Txt.Text = "0";

            }
            if (decimal.Parse(PayAmount_Txt.Text) >= RemainingVar)
            {
                PayAmount_Txt.Text = RemainingVar.ToString();

            }

            
            decimal paycurrentamountCapture = decimal.Parse(PayAmount_Txt.Text);

            decimal remaining = decimal.Parse(Remaining_Total_Txt.Text);

            if (PayAmount_Txt.Text.Length <= 0 )
            {
                PayAmount_Txt.Text = "0";
                Paid_Total_Txt.Text = PaidVar.ToString();
                Remaining_Total_Txt.Text = RemainingVar.ToString();

            }
            if ((PayAmount_Txt.Text.Length > 0) && (paycurrentamountCapture <= RemainingVar))
            {
                newremain = RemainingVar - paycurrentamountCapture;
                newpaid = paycurrentamountCapture + PaidVar;


                //PayAmount_Txt.Text = "0";
                Paid_Total_Txt.Text = newpaid.ToString();
                Remaining_Total_Txt.Text = newremain.ToString();

            }
            if ((PayAmount_Txt.Text.Length > 0) && (paycurrentamountCapture > RemainingVar))
            {
                newremain = 0;
                newpaid = totalOrignalPayable;
                
                Paid_Total_Txt.Text = newpaid.ToString();
                Remaining_Total_Txt.Text = newremain.ToString();

            }
            ///
        }

        private void PayAmount_Txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                calculation();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void PayAmount_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13;

        }
    }
}
