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
    public partial class OtherPayableUI : WarFramework.Forms.WarForm
    {
        long OrignalPayableIDForUpdates;

        public OtherPayableUI()
        {
            InitializeComponent();

            CATEGORYTxt.AutoCompleteCustomSource.AddRange ( WARPRO.Glob.CustomersAndAgents.Glob_OtherPayables.GetCategories_Coloumn());

        }


        public OtherPayableUI(long OrignalOtherpayableId )
        {
            InitializeComponent();


            var rr = WARPRO.Glob.CustomersAndAgents.Glob_OtherPayables.Get_OtherPayable_Row(OrignalOtherpayableId);

            OrignalPayableIDForUpdates = rr.ID;

            SAVE_New_Btn.Hide();
            WarPanel1.Enabled = false;

            this.Text ="PAID DATE :"+ rr.DATE.ToLongDateString();

            CATEGORYTxt.Text = rr.CATEGORY;
            PAID_AMOUNT_Txt.Text = rr.PAID.ToString();
            PaidToTxt.Text = rr.TO;
            ExtraDetails_Txt.Text = rr.EXTRA_INFO;



        }

        private void SAVE_NewTicket_Btn_Click(object sender, EventArgs e)
        {
            try
            {
               


                    WARPRO.Glob.CustomersAndAgents.Glob_OtherPayables.NewOtherPayableInsert(CATEGORYTxt.Text, decimal.Parse(PAID_AMOUNT_Txt.Text), PaidToTxt.Text, ExtraDetails_Txt.Text);

                    this.Close();
                    WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("SUCCESSFULL", "SAVED SUCCESSFULLY");

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void PAID_AMOUNT_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13;

        }
    }
}
