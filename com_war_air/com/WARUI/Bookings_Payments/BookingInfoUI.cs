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
using com_war_air.com.WARPRO.WARUI.Agents;
using com_war_air.com.WARUI.Packages;
using com_war_air.com.WARUI.Print;

namespace com_war_air.com.WARUI.Bookings_Payments
{
    public partial class BookingInfoUI : WarFramework.Forms.WarForm
    {
        long orignalbookingno;

        int referencetypeVar;

        public BookingInfoUI(long _bookingNo )
        {
            InitializeComponent();

            var rr = Glob_Bookings.Select_Row_Booking(_bookingNo);

            orignalbookingno = rr.BOOKING_ID;
            referencetypeVar = rr.REFERENCE_TYPE ;


            bookingid_Link.Text = rr.BOOKING_ID.ToString();

            BookedBy_ReferenceCode_Link.Text = rr.REFERENCE_CODE.ToString();
            BookingData_Link.Text = rr.BOOKING_DATE.ToLongDateString();
            PackageCode_Link.Text = rr.PACKAGE_CODE.ToString();
            FornoofPersons_Link.Text = rr.FOR_NO_OF_PERSONS.ToString();
            BillId_Link.Text = rr.BILL_ID.ToString();
           
            StatusToggle.Checked = rr.BOOKING_STATUS;
            StatusToggle.Show();
            if (rr.BOOKING_STATUS == false)
            {
                StatusToggle.Hide();
                canceledLable.Show();
            }

        }

    private void BookingInfoUI_Load(object sender, EventArgs e)
        {

        }

        private void bookingid_Link_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BookedBy_ReferenceCode_Link_Click(object sender, EventArgs e)
        {
            try
            {
                if (referencetypeVar == 1)
                {
                    CustomerUI c = new CustomerUI(long.Parse(BookedBy_ReferenceCode_Link.Text));
                    c.ShowDialog();

                }
                else if (referencetypeVar == 2)
                {
                    AgentUI a = new AgentUI(long.Parse(BookedBy_ReferenceCode_Link.Text));
                    a.ShowDialog();

                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void PackageCode_Link_Click(object sender, EventArgs e)
        {
            try
            {
                PackageUI p = new PackageUI(long.Parse(PackageCode_Link.Text));
                p.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BillId_Link_Click(object sender, EventArgs e)
        {
            try
            {
                PrintUI p = new PrintUI(long.Parse(BillId_Link.Text));
                p.ShowDialog();
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
                bool statusval = StatusToggle.Checked;

                if ((statusval == true) && (MessageBox.Show(this,"DO YOU REALLY WANT TO CANCEL THIS BOOKING\n\nNOTE: YOU WILL NOT BE ABLE TO ENABLE THIS AGAIN","CONFIRM AGAIN!",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes ))
                {

                    WARPRO.Glob.Bookings_And_Payments.Glob_Bookings.CancelPackageRefundbillAndCancelPayable(orignalbookingno);

                    WARPRO.Glob.Bookings_And_Payments.Glob_Transec.UpdateStatus(StatusToggle.Checked, orignalbookingno.ToString());




                    this.Close();
                    WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("SUCCESSFULLY CANCELLED", "BOOKING HAS BEEN SUCCESSFULLY CANCELLED ");


                }
                else 
                {
                    StatusToggle.Checked = statusval;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}