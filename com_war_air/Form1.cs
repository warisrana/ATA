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
using com_war_air.com.WARPRO.WARUI;
using Invoicer.Services;
using Invoicer.Models;

namespace com_war_air
{
    public partial class Form1 : WarFramework.Forms.WarForm 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'bookings_And_payments_DataSet_appData.Bills' table. You can move, or remove it, as needed.
            //this.billsTableAdapter.Fill(this.bookings_And_payments_DataSet_appData.Bills);
            //// TODO: This line of code loads data into the 'bookings_And_payments_DataSet_appData.Bookings' table. You can move, or remove it, as needed.
            //this.bookingsTableAdapter.Fill(this.bookings_And_payments_DataSet_appData.Bookings);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerUI c = new CustomerUI();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerUI c = new CustomerUI(int.Parse(WarTextBox1.Text));
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgentUI a = new AgentUI();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgentUI a = new AgentUI(int.Parse(WarTextBox2.Text));
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

           // bookingsTableAdapter.insertQuery_AddNew_Bookings_Bill_StoreProcedure_Func(2, 5222, DateTime.Today, 75555, 5, DateTime.Today, 2135, 0, 3, 3, 545, 55, true);
            // TODO: This line of code loads data into the 'bookings_And_payments_DataSet_appData.Bills' table. You can move, or remove it, as needed.
            this.billsTableAdapter.Fill(this.bookings_And_payments_DataSet_appData.Bills);
            // TODO: This line of code loads data into the 'bookings_And_payments_DataSet_appData.Bookings' table. You can move, or remove it, as needed.
            this.bookingsTableAdapter.Fill(this.bookings_And_payments_DataSet_appData.Bookings);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            com.WARUI.Bookings_Payments.NewBookigUI n = new com.WARUI.Bookings_Payments.NewBookigUI();
            n.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PackageUI p = new PackageUI();
            p.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] ad = new string[0];
            //ad[0] = "dfsdf";
            //Invoicer.Models.Address.Make("Address", ad, "Compnay name", " Vat pta ni vat ");

            //Invoicer.Models.Invoice invcm = new Invoicer.Models.Invoice();
            //invcm.Title = "Title";
            //invcm.TextColor = "DodgerBlue";
            //invcm.Footer = "Footer";
            ////invcm.Client.Title = "clint";
            //invcm.BillingDate = DateTime.Now;
            //invcm

            //Invoicer.Services.Impl.PdfInvoice inv = new Invoicer.Services.Impl.PdfInvoice(invcm);
            //inv.Invoice.BillingDate = DateTime.Now;
            ////inv.Invoice.Client.Title = "Clint pdf title";
            
            //inv.("filenameasdsc");
    //        new InvoicerApi(SizeOption.A4, OrientationOption.Landscape, "£")
    //.TextColor("#CC0000")
    //.BackColor("#FFD6CC")
    //.Image(@"vodafone.jpg", 125, 27)
    //.Company(Address.Make("Address", ad, "Compnay name", " Vat pta ni vat ") )
    //.Client(Address.Make("Address", ad, "Compnay name", " Vat pta ni vat ") )
    //.Items(new List<ItemRow> {
    //    ItemRow.Make("Nexus 6", "Midnight Blue", (decimal)1, 20, (decimal)166.66, (decimal)199.99),
    //    ItemRow.Make("24 Months (£22.50pm)", "100 minutes, Unlimited texts, 100 MB data 3G plan with 3GB of UK Wi-Fi", (decimal)1, 20, (decimal)360.00, (decimal)432.00),
    //    ItemRow.Make("Special Offer", "Free case (blue)", (decimal)1, 0, (decimal)0, (decimal)0),
    //})
    //.Totals(new List<TotalRow> {
    //    TotalRow.Make("Sub Total", (decimal)526.66),
    //    TotalRow.Make("VAT @ 20%", (decimal)105.33),
    //    TotalRow.Make("Total", (decimal)631.99, true),
    //})
    //.Details(new List<DetailRow> {
    //    DetailRow.Make("PAYMENT INFORMATION", "Make all cheques payable to Vodafone UK Limited.", "", "If you have any questions concerning this invoice, contact our sales department at sales@vodafone.co.uk.", "", "Thank you for your business.")
    //})
    //.Footer("http://www.vodafone.co.uk")
    //.Save();




        }

        private void button9_Click(object sender, EventArgs e)
        {
            CustomerGridUI c = new CustomerGridUI();
            c.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CompanyUI c = new CompanyUI();
            if (c != null)
            {
                c.ShowDialog();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PayAbleGridUI p = new PayAbleGridUI();
            p.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BillGridUI b = new BillGridUI();
            b.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            BookingGridUI b = new BookingGridUI();
            b.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CompanyGridUI c = new CompanyGridUI();
            c.ShowDialog();
        }
    }
}
