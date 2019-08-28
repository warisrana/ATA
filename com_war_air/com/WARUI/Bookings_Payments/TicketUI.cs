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
    public partial class TicketUI : WarFramework.Forms.WarForm
    {

        string OrignalPNRForUpdates;
        long orignalCustomerid;

        public TicketUI()
        {
            InitializeComponent();
        }


        public TicketUI(string  Orignalpnr )
        {

            InitializeComponent();
            try
            {

                // Availibility_Toggle.Show();
                ImageR.Region = WARPRO.Glob.CacheData.Glob_Veriables.GetRoundRegion(ImageR.Width, ImageR.Height);

                Edit_Btn.Show();
                Cancel_Edit_btn.Show();
                StatusToggle.Show();
                PrintBtn.Show();
                SAVE_NewTicket_Btn.Hide();
                Main_Info_Panel.Enabled = false;
                printpanel.Enabled = false;



                




                var rr =  WARPRO.Glob.CustomersAndAgents.Glob_Tickets.Get_TicketRow(Orignalpnr);
                //'''''''''
                OrignalPNRForUpdates = rr.PNR;
                orignalCustomerid = rr.CUSTOMER_ID;

                Custmer_Or_Agent_ID_Txt.Text = rr.CUSTOMER_ID.ToString();
                PNR_Txt.Text = rr.PNR;
                CarrierAirline_Txt.Text = rr.CARRIER_AIRLINE;
                Sector_Txt.Text = rr.SECTOR;
                TravellingDatetime.Value = rr.TRAVELLING_DATE;
                IssuedFromText.Text = rr.ISSUED_FROM;
                FaceValueTxt.Text = rr.FACE_VALUE.ToString();
                PayAbleTxt.Text = rr.PAYABLE.ToString();
                ProfitTxt.Text = rr.PROFIT.ToString();
                OkToBoardCheckBox.Checked = rr.OK_TO_BOARD;

                Type_ComboBox.Text = rr.TYPE;
                DepartureDateTime.Value = rr.DEPARTURE_DATE;

                ReturnDateTime.Hide();
                if (rr.TYPE.ToLower().Contains("one") == true)
                {
                    ReturnDateTime.Hide();
                }

                else if ((rr.TYPE.ToLower().Contains("two") == true) && (rr.RETURN_DATE != null))
                {
                    ReturnDateTime.Show();
                    ReturnDateTime.Value =DateTime.Parse( rr.RETURN_DATE);
                }

                VisaTypeTxt.Text = rr.VISA_TYPE;
                PaymentTypeTxt.Text = rr.PAYMENT_TYPE;

                StatusToggle.Checked = rr.DEAL_STATUS;

                if (rr.DEAL_STATUS == false)
                {
                    canceledLable.Show();
                }

                TravellingFromPlaceTxt.Text = rr.TRAVELLING_FROM;
                DestinationTxt.Text = rr.DESTINATION;


                //CustomerInfo
                var cr = WARPRO.Glob.CustomersAndAgents.CustomersAndAgents_class.Select_Row_Customer(rr.CUSTOMER_ID);

                if (cr != null)
                {
                    ImageR.Image = WARPRO.Glob.CacheData.Glob_Veriables.GetImageFromByteArray(cr.PICTURE);

                    Id_info_nameLink.Text = cr.FIRST_NAME.ToUpper() + " " + cr.LAST_NAME.ToUpper();
                    Id_info_PassportLink.Text = cr.PASSPORT_NO;

                }



                // TransecLoad
                var tt = WARPRO.Glob.Bookings_And_Payments.Glob_Transec.Get_Transec_Row(Orignalpnr.ToString());
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
            catch (Exception)
            {

                this.Close();
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
                
                    /////.........................



                    if (ImageR.Image != null)
                    {
                        string returneddatetoenter = "";
                        if (Type_ComboBox.SelectedIndex == 0)
                        {
                            returneddatetoenter = "";
                        }
                        else if (Type_ComboBox.SelectedIndex == 1)
                        {
                            returneddatetoenter = ReturnDateTime.Value.ToLongDateString();
                        }


                        WARPRO.Glob.CustomersAndAgents.Glob_Tickets.Update_Ticketinfo(long.Parse(Custmer_Or_Agent_ID_Txt.Text), PNR_Txt.Text, CarrierAirline_Txt.Text, Sector_Txt.Text, TravellingDatetime.Value, IssuedFromText.Text, decimal.Parse(FaceValueTxt.Text), decimal.Parse(PayAbleTxt.Text), decimal.Parse(ProfitTxt.Text), OkToBoardCheckBox.Checked, Type_ComboBox.Text, DepartureDateTime.Value, returneddatetoenter, VisaTypeTxt.Text, PaymentTypeTxt.Text, TravellingFromPlaceTxt.Text, DestinationTxt.Text, OrignalPNRForUpdates);

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

        private void Custmer_Or_Agent_ID_Txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                orignalCustomerid = 0;

                if ( Custmer_Or_Agent_ID_Txt.Text.Length >= 1)
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

        private void SAVE_NewTicket_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ImageR.Image != null)
                {
                    string returneddatetoenter = "";
                    if (Type_ComboBox.SelectedIndex == 0)
                    {
                        returneddatetoenter = "";
                    }
                    else if(Type_ComboBox.SelectedIndex == 1)
                    {
                        returneddatetoenter = ReturnDateTime.Value.ToLongDateString();
                    }


                    WARPRO.Glob.CustomersAndAgents.Glob_Tickets.New_TicketInsert(long.Parse(Custmer_Or_Agent_ID_Txt.Text),PNR_Txt.Text,CarrierAirline_Txt.Text,Sector_Txt.Text,TravellingDatetime.Value,IssuedFromText.Text,decimal.Parse(FaceValueTxt.Text),decimal.Parse(PayAbleTxt.Text), decimal.Parse(ProfitTxt.Text),OkToBoardCheckBox.Checked, Type_ComboBox.Text,DepartureDateTime.Value, returneddatetoenter , VisaTypeTxt.Text,PaymentTypeTxt.Text,TravellingFromPlaceTxt.Text, DestinationTxt.Text);

                    WARPRO.Glob.Bookings_And_Payments.Glob_Transec.NewTransec(WARPRO.Glob.CustomersAndAgents.Glob_Tickets.GetLastID(), Custmer_Or_Agent_ID_Txt.Text, RecievableTxt.Text, T_RecieveAmount.Text, RemainingTxt.Text, "TICKET BOOKED");



                    this.Close();
                    WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("SUCCESSFULL", "SAVED SUCCESSFULLY");

                }

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
                if (StatusToggle.Checked == true)
                {
                    WARPRO.Glob.CustomersAndAgents.Glob_Tickets.update_Ticket__Deal_Activation_Status(true, OrignalPNRForUpdates);

                    WARPRO.Glob.Bookings_And_Payments.Glob_Transec.UpdateStatus(StatusToggle.Checked, OrignalPNRForUpdates.ToString());

                    this.Close();
                    // canceledLable.Hide();
                    WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("ACTIVATION", "ACTIVATION HAS BEEN ACTIVATED");
                }
                else if (StatusToggle.Checked == false)
                {
                    WARPRO.Glob.CustomersAndAgents.Glob_Tickets.update_Ticket__Deal_Activation_Status(false, OrignalPNRForUpdates);
                    
                    WARPRO.Glob.Bookings_And_Payments.Glob_Transec.UpdateStatus(StatusToggle.Checked, OrignalPNRForUpdates.ToString());

                    this.Close();
                    //canceledLable.Show();
                    WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("ACTIVATION", "ACTIVATION HAS BEEN DEACTIVATED");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Type_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Type_ComboBox.SelectedIndex == 0)
            {
                ReturnDateTime.Hide();
                WarLabel11.Hide();
            }
            else if (Type_ComboBox.SelectedIndex == 1)
            {
                ReturnDateTime.Show();
                WarLabel11.Show();
            }
        }

        private void ImageR_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (orignalCustomerid > 80001)
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

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            //printPreviewDialog1.ShowIcon = false;
            (printPreviewDialog1 as Form).Icon = Resources.warlogoic;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void Custmer_Or_Agent_ID_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13;
        }

        private void Custmer_Or_Agent_ID_Txt_MouseHover(object sender, EventArgs e)
        {
           // Custmer_Or_Agent_ID_Txt.Text = Clipboard.GetText();
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
            if (RecievableTxt.Text.Length <= 0)
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

        private void PayRemainingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TransecUI tt = new TransecUI(OrignalPNRForUpdates.ToString());
                tt.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void WarToggle1_Click(object sender, EventArgs e)
        {

        }
    }
}
