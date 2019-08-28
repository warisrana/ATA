using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com_war_air.com.WARPRO.Glob.Bookings_And_Payments;
using com_war_air.com.WARUI.Bookings_Payments;
using Properties;
using com_war_air.com.WARPRO.Glob;

namespace com_war_air.com.WARUI.Print
{
    public partial class PrintUI : WarFramework.Forms.WarForm
    {

        long orignalBillid;

        public PrintUI(long bookingId )
        {
            InitializeComponent();

            var br = Glob_Bill_Payments.Select_Row_Bill_Payment(bookingId);

            orignalBillid = br.BILL_ID;


            BillNoTxt.Text = br.BILL_ID.ToString();
            BillingDateTxt.Text = br.BILL_DATE.ToLongDateString();
            OrignaltotalTxt.Text = br.TOTAL_ORIGNAL_AMOUNT.ToString();
            GrandTotal_Txt.Text = br.TOTAL_ORIGNAL_AMOUNT.ToString();
            Special_OfferTxt.Text = br.SPECIAL_OFFER_DISCOUNT.ToString();
            ExtraDiscountTxt.Text = br.EXTRA_DISCOUNT.ToString();
            Total_Discount.Text = br.TOTAL_DISCOUNT.ToString();
            GrandTotal_Txt.Text = (br.TOTAL_ORIGNAL_AMOUNT - br.TOTAL_DISCOUNT).ToString();
            Collected_Amount_Txt.Text = ((br.TOTAL_ORIGNAL_AMOUNT - br.TOTAL_DISCOUNT) - br.REMAINING_AMOUNT).ToString();
            Remaining_Amount_Txt.Text = br.REMAINING_AMOUNT.ToString();
            if (br.IsREFUNDED == true)
            {
                canceledLable.Show();
            }

            //for RemainingBillbutton
            if ((br.IsPAID_FULL == false) && (br.IsREFUNDED == false))
            {
                PayRemainingBtn.Show();


            }


            // OurCompany Info 
            var oc = WARPRO.Glob.CustomersAndAgents.Glob_OurCompanyProfile.Get_Select_Row_OurCompanyProfile();

            HeaderCompanyNameTxt.Text = oc.COMPANY_NAME.ToUpper();
            FromBillOurcomp_Txt.Text =oc.COMPANY_NAME +"\nCONTACT INFO:\n"+oc.COMPANY_MOBILE_NO.ToString()+" - " +oc.OWNER_MOBILE_NO.ToString() +"\n"+oc.ADDRESS;
            if (oc.IMAGE != null)
            {
                ImageR.Image = WARPRO.Glob.CacheData.Glob_Veriables.GetImageFromByteArray(oc.IMAGE);
            }

            var bkr = Glob_Bookings.Select_Row_Booking(br.BOOKING_ID_NO);
            int custtype = br.REFERENCE_TYPE;
            BookingFor_NoOfPersonsTxt.Text = bkr.FOR_NO_OF_PERSONS.ToString();

            var pkgr = WARPRO.Glob.Packages.Glob_Packages.Get_Select_Row_Package(bkr.PACKAGE_CODE);
            Package_InfoHeadTxt.Text = ("PACKAGE :" + pkgr.PACKAGE_NAME + "\nWITH PACKAGE ID # " + pkgr.PACKAGE_CODE.ToString() + "\nAND PACKAGE DAYS :" + pkgr.FOR_NO_OF_DAYS.ToString()).ToUpper();
            if (custtype == 1)
            {
                var custrow = WARPRO.Glob.CustomersAndAgents.CustomersAndAgents_class.Select_Row_Customer(br.REFERENCE_CODE);
                BillingTo_Txt.Text = (custrow.FIRST_NAME + " " + custrow.LAST_NAME + "\n" + "CUSTOMER ID # " + custrow.ID.ToString() + "\n" + custrow.ADDRESS).ToUpper();

            }

            else if (custtype == 2)
            {
                var custrow = WARPRO.Glob.CustomersAndAgents.Agents_Partial.Select_Row_Agent(br.REFERENCE_CODE);
                BillingTo_Txt.Text = (custrow.FIRST_NAME + " " + custrow.LAST_NAME + "\n" + "AGENT ID # " + custrow.ID.ToString() + "\n" + custrow.ADDRESS).ToUpper();

            }
            
            
        }

        private void PrintUI_Load(object sender, EventArgs e)
        {
            //HeaderCompanyNameTxt.Text = Application.ProductName;
            //FromBillOurcomp_Txt.Text  =  Application.ProductName;
            PrintDateTxt.Text = DateTime.Now.ToString();
            ImageR.Region = WARPRO.Glob.CacheData.Glob_Veriables.GetRoundRegion(ImageR.Width,ImageR.Height);
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

        private void PayRemainingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BillRemainingPay b = new BillRemainingPay(orignalBillid);
                b.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show( ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
