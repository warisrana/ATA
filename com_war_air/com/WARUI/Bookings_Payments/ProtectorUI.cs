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
using Properties;

namespace com_war_air.com.WARUI.Bookings_Payments
{
    public partial class ProtectorUI : WarFramework.Forms.WarForm
    {
        long orignalCustomerid;
        long OrignalProtectoriDForUpdates;

        public ProtectorUI()
        {
            InitializeComponent();
        }


        public ProtectorUI(long OrignalprotectorId )
        {
            InitializeComponent();
            try
            {

                // Availibility_Toggle.Show();
                ImageR.Region = WARPRO.Glob.CacheData.Glob_Veriables.GetRoundRegion(ImageR.Width, ImageR.Height);

                Edit_Btn.Show();
                Cancel_Edit_btn.Show();

                PrintBtn.Show();
                SAVE_NewTicket_Btn.Hide();
                Main_Info_Panel.Enabled = false;
                printpanel.Enabled = false;


                // TransecLoad
                var tt = WARPRO.Glob.Bookings_And_Payments.Glob_Transec.Get_Transec_Row(OrignalprotectorId.ToString());
                PanelStatus.Show();

                canceledLable.Show();
                transecGroup.Hide();

                StatusToggle.Checked = tt.STATUS;

                if (tt.STATUS == false)
                {
                    canceledLable.Text = "CANCELLED/REFUNDED";

                }
                if (tt.STATUS == true)
                {

                    if (tt.REMAINING > 0)
                    {
                        PayRemainingBtn.Show();
                    }


                    if (tt.REMAINING <= 0)
                    {
                        canceledLable.Text = "CLEARED";
                        canceledLable.ForeColor = Color.Green;


                    }
                    else if (tt.REMAINING > 0)
                    {
                        canceledLable.Text = "PENDING RECIEVABLE";
                        canceledLable.ForeColor = Color.DodgerBlue;
                    }
                }
                    //






                    var rr = WARPRO.Glob.CustomersAndAgents.Glob_Protector.Get_Protector_Row(OrignalprotectorId);
                    //'''''''''
                    OrignalProtectoriDForUpdates = rr.PROTECTOR_ID;

                    orignalCustomerid = rr.CUSTOMER_ID;


                    ProtectorId_Txt.Text = "PROTECTOR ID : " + rr.PROTECTOR_ID.ToString();
                    ProtectorId_Txt.Show();

                    Custmer_Or_Agent_ID_Txt.Text = rr.CUSTOMER_ID.ToString();
                    Profession_Txt.Text = rr.PROFESSION;
                    Country_Txt.Text = rr.COUNTRY;
                    ChargesTxt.Text = rr.CHARGES.ToString();

                    PayAbleTxt.Text = rr.PAYABLE.ToString();

                    PasspoetSendingDateTime.Value = rr.PASSPORT_SENDING_DATE;
                    PassportRecievingDateTime.Value = rr.PASSPORT_RECIEVING_DATE;


                    ProfitTxt.Text = rr.PROFIT.ToString();





                    //CustomerInfo
                    ImageR1.Region = WARPRO.Glob.CacheData.Glob_Veriables.GetRoundRegion(ImageR1.Width, ImageR1.Height);
                    var cr = WARPRO.Glob.CustomersAndAgents.CustomersAndAgents_class.Select_Row_Customer(rr.CUSTOMER_ID);

                    if (cr != null)
                    {
                        ImageR.Image = WARPRO.Glob.CacheData.Glob_Veriables.GetImageFromByteArray(cr.PICTURE);

                        Id_info_nameLink.Text = cr.FIRST_NAME.ToUpper() + " " + cr.LAST_NAME.ToUpper();
                        Id_info_PassportLink.Text = cr.PASSPORT_NO;

                    }

                    // OurCompany Info 

                    compnyProfilepanel.Show();
                    var oc = WARPRO.Glob.CustomersAndAgents.Glob_OurCompanyProfile.Get_Select_Row_OurCompanyProfile();

                    HeaderCompanyNameTxt.Text = oc.COMPANY_NAME.ToUpper();
                    FromBillOurcomp_Txt.Text = "CONTACT INFO: " + oc.COMPANY_MOBILE_NO.ToString() + " - " + oc.OWNER_MOBILE_NO.ToString() + "ADDRESS- " + oc.ADDRESS;
                    if (oc.IMAGE != null)
                    {
                        ImageR1.Image = WARPRO.Glob.CacheData.Glob_Veriables.GetImageFromByteArray(oc.IMAGE);
                    }



                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }


        private void SAVE_NewTicket_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ImageR.Image != null)
                {



                    WARPRO.Glob.CustomersAndAgents.Glob_Protector.NewProtectorInsert(long.Parse(Custmer_Or_Agent_ID_Txt.Text), Profession_Txt.Text, Country_Txt.Text,decimal.Parse(ChargesTxt.Text), decimal.Parse(PayAbleTxt.Text), PasspoetSendingDateTime.Value, PassportRecievingDateTime.Value,decimal.Parse(ProfitTxt.Text));

                    WARPRO.Glob.Bookings_And_Payments.Glob_Transec.NewTransec(WARPRO.Glob.CustomersAndAgents.Glob_Protector.GetLastID() ,  Custmer_Or_Agent_ID_Txt.Text, RecievableTxt.Text , T_RecieveAmount.Text, RemainingTxt.Text, "PROTECTOR" );

                    this.Close();
                    WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("SUCCESSFULL", "SAVED SUCCESSFULLY");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {

                Edit_Btn.Hide();
                PrintBtn.Hide();
                Main_Info_Panel.Enabled = true;

                printpanel.Enabled = true;

                SAVE_Edit_Btn.Show();
                Cancel_Edit_btn.Show();

                // Panel_pictureControls.Show();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SAVE_Edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {


                if (ImageR.Image != null)
                {



                    WARPRO.Glob.CustomersAndAgents.Glob_Protector.Update_ProtectorInfo(long.Parse(Custmer_Or_Agent_ID_Txt.Text), Profession_Txt.Text, Country_Txt.Text, decimal.Parse(ChargesTxt.Text), decimal.Parse(PayAbleTxt.Text), PasspoetSendingDateTime.Value, PassportRecievingDateTime.Value, decimal.Parse(ProfitTxt.Text), OrignalProtectoriDForUpdates);

                    this.Close();
                    WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("UPDATED", "INFORMATION SUCCESSFULLY UPDATED");
                }
                else
                {
                    WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("PLEASE CHECK", "SOME IMPORTANT INFORMATION IS MISSING");
                }
                //'''''''''''''''''''''''''''

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Cancel_Edit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImageR_Click(object sender, EventArgs e)
        {
            try
            {

                if (orignalCustomerid > 80000)
                {
                    CustomerUI bk = new CustomerUI(orignalCustomerid);
                    if (bk != null)
                    {

                        bk.ShowDialog();
                    }
                }

                else
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Custmer_Or_Agent_ID_Txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                orignalCustomerid = 0;

                if (Custmer_Or_Agent_ID_Txt.Text.Length >= 1)
                {

                    var cr = WARPRO.Glob.CustomersAndAgents.CustomersAndAgents_class.Select_Row_Customer(long.Parse(Custmer_Or_Agent_ID_Txt.Text));
                    if (cr != null)
                    {
                        ImageR.Image = WARPRO.Glob.CacheData.Glob_Veriables.GetImageFromByteArray(cr.PICTURE);

                        Id_info_nameLink.Text = cr.FIRST_NAME.ToUpper() + " " + cr.LAST_NAME.ToUpper();
                        Id_info_PassportLink.Text = cr.PASSPORT_NO;

                        orignalCustomerid = cr.ID;
                    }
                    else
                    {
                        ImageR.Image = null;

                        Id_info_nameLink.Text = "NO CUSTOMER FOUND";
                        Id_info_PassportLink.Text = "";

                        orignalCustomerid = 0;
                    }

                }

                else
                {

                    WarFramework.WarMessageBox.Show(this, "PLEASE ENTER CUSTOMER ID", "CUSTOMER ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;

        private void PrintScreen()
        {
            Graphics mygraphics = printpanel.CreateGraphics();
            Size s = printpanel.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, printpanel.ClientRectangle.Width, printpanel.ClientRectangle.Height, dc1, 0, 0, 13369376);
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

        private void Custmer_Or_Agent_ID_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13;
           
        }

        private void Custmer_Or_Agent_ID_Txt_Enter(object sender, EventArgs e)
        {
            Custmer_Or_Agent_ID_Txt.Text = Clipboard.GetText();

        }

        private void ButtonForCustmerRegister_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerUI c = new CustomerUI();
                c.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void calcu()
        {
            if (RecievableTxt.Text.Length<=0)
            {
                RecievableTxt.Text = "0";

            }
            if (RemainingTxt.Text.Length <= 0)
            {
                RemainingTxt.Text = "0";

            }
            if (T_RecieveAmount.Text.Length <= 0)
            {
                T_RecieveAmount.Text = "0";

            }


            //;;;;;;;;;;;;;;;;

            decimal totalrecievable = decimal.Parse(RecievableTxt.Text);
            
            decimal remaining = decimal.Parse(RemainingTxt.Text);
            decimal currentRecieve = decimal.Parse(T_RecieveAmount.Text);

            if (currentRecieve > totalrecievable)
            {
                RemainingTxt.Text = "0";

                T_RecieveAmount.Text = totalrecievable.ToString();


                currentRecieve = totalrecievable;


            }


            RemainingTxt.Text = (totalrecievable - currentRecieve).ToString();
            //RecievedTxt.Text = (currentRecieve + recieved).ToString();

            //'''''''''''''''''''
        }

        private void RecievableTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RemainingTxt.Text = RecievableTxt.Text;
                T_RecieveAmount.Text = "0";
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

                WARPRO.Glob.Bookings_And_Payments.Glob_Transec.UpdateStatus(StatusToggle.Checked, OrignalProtectoriDForUpdates.ToString());

                this.Close();
                WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("UPDATED", "UPDATED SUCCESSFULLY");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void PayRemainingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TransecUI tt = new TransecUI(OrignalProtectoriDForUpdates.ToString());
                tt.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void T_RecieveAmount_TextChanged(object sender, EventArgs e)
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
    }
}
