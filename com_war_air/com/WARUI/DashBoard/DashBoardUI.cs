using com_war_air.com.WARPRO.Glob.CacheData;
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
using com_war_air.com.WARUI.Agents_Customers;
using com_war_air.com.WARUI.Bookings_Payments;
using com_war_air.com.WARUI.Packages;

namespace com_war_air.com.WARUI.DashBoard
{
    public partial class DashBoardUI : WarFramework.Forms.WarForm
    {
        public DashBoardUI()
        {
            InitializeComponent();
        }

        private void TileInProviderGrid_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyGridUI c = new CompanyGridUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInProviderAddNew_Click(object sender, EventArgs e)
        {

            try
            {
                CompanyUI c = new CompanyUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInCustomerGrid_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerGridUI c = new CustomerGridUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInCuctomerAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerUI c = new CustomerUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInAgentAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                AgentUI c = new AgentUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInBookingAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                NewBookigUI c = new NewBookigUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInBookingsGrid_Click(object sender, EventArgs e)
        {
            try
            {
                BookingGridUI c = new BookingGridUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInBillsGrid_Click(object sender, EventArgs e)
        {
            try
            {
                BillGridUI c = new BillGridUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void PanelsHideAll()
        {
            Panel_Bills.Hide();
            Panel_Bookings.Hide();
            Panel_Customers.Hide();
            Panel_Payables.Hide();
            Panel_Provider.Hide();
            Panel_Packages.Hide();
           
        }

        private void Tilescolorreset()
        {
            TileSideProvider.UseCustomBackColor = false;
            TileSideProvider.BackColor = DefaultBackColor;
            TileSideCustomer.UseCustomBackColor = false;
            TileSideCustomer.BackColor = DefaultBackColor;
            TileSideBookings.UseCustomBackColor = false;
            TileSideBookings.BackColor = DefaultBackColor;
            TileSideBills.UseCustomBackColor    = false;
            TileSideBills.BackColor = DefaultBackColor;
            TileSidePayAbles.UseCustomBackColor = false;
            TileSidePayAbles.BackColor = DefaultBackColor;
            TileSidePackages.UseCustomBackColor = false;
            TileSidePackages.BackColor = DefaultBackColor;
        }


        private void WarTile1_Click(object sender, EventArgs e)
        {
            try
            {
                PayAbleGridUI c = new PayAbleGridUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileSideProvider_Click(object sender, EventArgs e)
        {
            try
            {
                PanelsHideAll();
                Tilescolorreset();
                TileSideProvider.UseCustomBackColor = true;
                TileSideProvider.BackColor = Color.DimGray;
                Panel_Provider.Show();

                
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileSideCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                PanelsHideAll();
                Tilescolorreset();
                TileSideCustomer.UseCustomBackColor = true;
                TileSideCustomer.BackColor = Color.DimGray;
                Panel_Customers.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileSideBookings_Click(object sender, EventArgs e)
        {
            try
            {
                PanelsHideAll();
                Tilescolorreset();
                TileSideBookings.UseCustomBackColor = true;
                TileSideBookings.BackColor = Color.DimGray;
                Panel_Bookings.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileSideBills_Click(object sender, EventArgs e)
        {
            try
            {
                PanelsHideAll();
                Tilescolorreset();
                TileSideBills.UseCustomBackColor = true;
                TileSideBills.BackColor = Color.DimGray;
                Panel_Bills.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileSidePayAbles_Click(object sender, EventArgs e)
        {
            try
            {
                PanelsHideAll();
                Tilescolorreset();
                TileSidePayAbles.UseCustomBackColor = true;
                TileSidePayAbles.BackColor = Color.DimGray;
                Panel_Payables.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileSidePackages_Click(object sender, EventArgs e)
        {
            try
            {
                PanelsHideAll();
                Tilescolorreset();
                TileSidePackages.UseCustomBackColor = true;
                TileSidePackages.BackColor = Color.DimGray;
                Panel_Packages.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInPackageGrid_Click(object sender, EventArgs e)
        {
            try
            {
                PackagesGridUI c = new PackagesGridUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInPackageAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                PackageUI c = new PackageUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileSideOurCompanyProfile_Click(object sender, EventArgs e)
        {
            
            try
            {
                OurCompanyProfileUI p = new OurCompanyProfileUI();
                p.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInTicketAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                TicketUI c = new TicketUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInTicketsGrid_Click(object sender, EventArgs e)
        {
            try
            {
                TicketGridUI c = new TicketGridUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInSaudiVisaNewAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SaudiVisaStampUI c = new SaudiVisaStampUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInSaudiVisaStampGrid_Click(object sender, EventArgs e)
        {
            try
            {
                SaudiVisaStampGridUI c = new SaudiVisaStampGridUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInProtectorAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                ProtectorUI c = new ProtectorUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInProtectorGrid_Click(object sender, EventArgs e)
        {
            try
            {
                ProtectorGridUI c = new ProtectorGridUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInDubaiVisitAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                DubaiVisitUI c = new DubaiVisitUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInDubaiVisitGrid_Click(object sender, EventArgs e)
        {
            try
            {
                DubaiVisitGridUI c = new DubaiVisitGridUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        WidgetCustomer1UI w = new WidgetCustomer1UI();
        private void WidgetToggle_Click(object sender, EventArgs e)
        {
            try
            {

                if (WidgetToggle.Checked == true)
                {
                    
                    w.Show();

                    WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("WIDGET ON", "WIDGET SUCCESSFULLY ON");
                }
                else if (WidgetToggle.Checked == false)
                {
                    if (w != null)
                    {
                        w.widgetClose();
                    }
                   


                    WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("WIDGET OFF", "WIDGET SUCCESSFULLY OFF");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInOtherPayableAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                OtherPayableUI c = new OtherPayableUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileInOtherPayableGrid_Click(object sender, EventArgs e)
        {
            try
            {
                OtherPayableGridUI c = new OtherPayableGridUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TileSideLedger_Click(object sender, EventArgs e)
        {



            try
            {
                LedgerGridUI c = new LedgerGridUI();
                c.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void DashBoardUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {


            }
        }
    }
}
