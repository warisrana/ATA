using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com_war_air.com.WARPRO.Glob.CacheData;
using com_war_air.com.WARPRO.Glob.Packages;
using com_war_air.com.WARPRO.WARUI.Agents;

namespace com_war_air.com.WARUI.Bookings_Payments
{
    public partial class NewBookigUI : WarFramework.Forms.WarForm
    {
        decimal payableVeriable;
        long PackageOfferedByCompanyID;

        public NewBookigUI()
        {
            InitializeComponent();
        }

        private void NewBookigUI_Load(object sender, EventArgs e)
        {
            Package_NamesComboBox.Items.AddRange(Glob_Packages.GetPackage_Names());
            ImageR.Region = WARPRO.Glob.CacheData.Glob_Veriables.GetRoundRegion(ImageR.Width, ImageR.Height);

        }
        int ReferenceTypeVeriable;

        decimal orignalTotalVeriable;

        int     NoOfPersonsVeriable;
        decimal SpecialOfferDiscountVeriable;
        decimal CostSelectedVeriable;
        decimal extrd;
        /// <summary>
        /// Orignal Total Calculate And Get
        /// </summary>
        /// <returns></returns>
        /// 
        decimal ourprofit;
        internal decimal TotalCalculate()
        {
            NoOfPersonsVeriable = int.Parse(For_No_of_Persons_Txt.Text);
            SpecialOfferDiscountVeriable = decimal.Parse(SpecialOffer_Discount_link_Txt.Text) * NoOfPersonsVeriable;

            extrd = decimal.Parse(Extra_Discount_Txt.Text );
            //CostCheckChangeFunc();
            Tatal_Discount_Txt.Text = (SpecialOfferDiscountVeriable + extrd).ToString();

            orignalTotalVeriable = (NoOfPersonsVeriable * CostSelectedVeriable);//- SpecialOfferDiscountVeriable ;
            Orignal_Total_Txt.Text = orignalTotalVeriable.ToString();
            Grand_Total_Txt.Text = (orignalTotalVeriable - SpecialOfferDiscountVeriable).ToString();

             ourprofit = NoOfPersonsVeriable * proftSelectedVeriable;

            payableVeriable = (orignalTotalVeriable - (ourprofit + SpecialOfferDiscountVeriable));

            return orignalTotalVeriable;

           

        }


        decimal ExtraDiscountVeriable;
        decimal NewGrandTotalVeriable;
                     
        private void AfterDiscount()
        {
            TotalCalculate();

            NewGrandTotalVeriable = orignalTotalVeriable - (decimal.Parse(Extra_Discount_Txt.Text) + SpecialOfferDiscountVeriable);

            Grand_Total_Txt.Text = NewGrandTotalVeriable.ToString();

        }

        decimal RemainingVeriable;
        decimal CollectedVeriable;

        private void RemainingCOunt()
        {
            TotalCalculate();
            AfterDiscount();

            CollectedVeriable = decimal.Parse(Collected_Amount_Txt.Text);
            RemainingVeriable = NewGrandTotalVeriable - CollectedVeriable;

            Remaining_Amount_Txt.Text = RemainingVeriable.ToString();


        }



        private void Minus_person_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                int p = int.Parse(For_No_of_Persons_Txt.Text);
                
                if (p > 1)
                {
                    int newp = p - 1;
                    For_No_of_Persons_Txt.Text = newp.ToString();


                }
                else if (p == 1)
                {
                    Glob_Veriables.Show_NotiFiCation("STOP!", "MINIMUM ONE PERSON REQUIRED");
                }

                Calculations();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Add_person_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                int p = int.Parse(For_No_of_Persons_Txt.Text);

                
                    int newp = p + 1;
                    For_No_of_Persons_Txt.Text = newp.ToString();

                Calculations();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void WarCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (WarCheckBox1.Checked == true)
                {
                    Collected_Amount_Txt.Text = Grand_Total_Txt.Text;
                    Collected_Amount_Txt.ReadOnly = true;
                }
                else if (WarCheckBox1.Checked == false)
                {
                    Collected_Amount_Txt.ReadOnly = false;
                }
                
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

        private void Custmer_Or_Agent_ID_Txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cancelagentLable.Hide();

                if  (Customer_referenceType1_Radio.Checked == true && Custmer_Or_Agent_ID_Txt.Text.Length >=1)
                {
                    groupBoxPackageMain.Enabled = false;
                   var cr =  WARPRO.Glob.CustomersAndAgents.CustomersAndAgents_class.Select_Row_Customer(long.Parse(Custmer_Or_Agent_ID_Txt.Text));
                    if (cr != null)
                    {
                        ImageR.Image =WARPRO.Glob.CacheData.Glob_Veriables.GetImageFromByteArray( cr.PICTURE);

                        Id_info_nameLink.Text = cr.FIRST_NAME.ToUpper() + " " + cr.LAST_NAME.ToUpper();
                        groupBoxPackageMain.Enabled = true;

                    }
                    else
                    {
                        ImageR.Image = null ;

                        Id_info_nameLink.Text = "NO CUSTOMER FOUND";
                        groupBoxPackageMain.Enabled = false;
                    }

                }
                else if (Customer_referenceType2_Agent_Radio.Checked == true && Custmer_Or_Agent_ID_Txt.Text.Length >= 1)
                {
                    groupBoxPackageMain.Enabled = false;
                    var cr = WARPRO.Glob.CustomersAndAgents.Agents_Partial.Select_Row_Agent(long.Parse(Custmer_Or_Agent_ID_Txt.Text));
                    if (cr != null)
                    {
                        if (cr.STATUS == true)
                        {
                            cancelagentLable.Hide();
                            ImageR.Image = WARPRO.Glob.CacheData.Glob_Veriables.GetImageFromByteArray(cr.PICTURE);

                            Id_info_nameLink.Text = cr.FIRST_NAME.ToUpper() + " " + cr.LAST_NAME.ToUpper();

                            groupBoxPackageMain.Enabled = true;
                        }
                        else if (cr.STATUS == false)
                        {
                            cancelagentLable.Show();
                            groupBoxPackageMain.Enabled = false;
                            ImageR.Image = WARPRO.Glob.CacheData.Glob_Veriables.GetImageFromByteArray(cr.PICTURE);

                            Id_info_nameLink.Text = cr.FIRST_NAME.ToUpper() + " " + cr.LAST_NAME.ToUpper();

                        }
                        
                    }
                    else
                    {
                        ImageR.Image = null;

                        Id_info_nameLink.Text = "NO AGENT FOUND";
                        groupBoxPackageMain.Enabled = false;
                    }
                }
                else
                {
                    groupBoxPackageMain.Enabled = false;
                    WarFramework.WarMessageBox.Show(this,"PLEASE SELECT ONE OF CUSTOMER TYPES \nAGENT OR CUSTOMER","CUSTOMER SELECT", MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Package_NamesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Package_CodeComboBox.Items.Clear();
                Cost1_Radio.Text = "000.00";
                Cost2_Radio.Text = "000.00";
                Cost3_Radio.Text = "000.00";
                Cost4_Radio.Text = "000.00";

                For_No_Of_Days_linkTxt.Text = "0";
                SpecialOffer_Discount_link_Txt.Text = "000.00";
                Package_CodeComboBox.SelectedIndex  = -1;
                Package_CodeComboBox.Items.AddRange(WARPRO.Glob.Packages.Glob_Packages.GetPackage_Codes(Package_NamesComboBox.Text));


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        
        private void Package_CodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cr = WARPRO.Glob.Packages.Glob_Packages.Get_Select_Row_Package(long.Parse(Package_CodeComboBox.Text));

                if (cr!= null)
                {
                    bool companyStatus = WARPRO.Glob.CustomersAndAgents.Glob_mainCompany.Get_CompanyStatus(cr.OFFERED_BY);
                    if (companyStatus == true)
                    {
                        canceledLable.Hide();
                        groupBoxAll_costs.Enabled = true;

                        p1 = cr.PROFIT1_FORUS;
                        p2 = cr.PROFIT2_FORUS;
                        p3 = cr.PROFIT3_FORUS;
                        p4 = cr.PROFIT4_FORUS;

                        PackageOfferedByCompanyID = cr.OFFERED_BY;

                        Cost1_Radio.Text = cr.COST1.ToString();
                        Cost2_Radio.Text = cr.COST2.ToString();
                        Cost3_Radio.Text = cr.COST3.ToString();
                        Cost4_Radio.Text = cr.COST4.ToString();

                        For_No_Of_Days_linkTxt.Text = cr.FOR_NO_OF_DAYS.ToString();
                        SpecialOffer_Discount_link_Txt.Text = cr.SPECIAL_OFFER_DISCOUNT.ToString();



                    }
                    else if (companyStatus == false)
                    {
                        canceledLable.Show();
                        groupBoxAll_costs.Enabled = false;
                        groupBox_payments.Enabled = false;
                        
                    }



                }
                //if (Package_CodeComboBox.SelectedIndex>=0)
                //{
                //    groupBoxAll_costs.Enabled = true;
                //}
                //else
                //{
                //    groupBoxAll_costs.Enabled = false;
                //}

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Package_CodeComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Package_CodeComboBox.Items.Count <= 0)
                {
                   
                }

            }
            catch (Exception)
            {

               
            }
        }
        decimal p1;
        decimal p2;
        decimal p3;
        decimal p4;
        decimal proftSelectedVeriable;
        private void CostCheckChangeFunc()
        {
            Collected_Amount_Txt.Text = "0"; 
            groupBox_payments.Enabled = true;
            groupBox_noofpersons.Enabled = true;

            if (Cost1_Radio.Checked == true)
            {
                CostSelectedVeriable = decimal.Parse(Cost1_Radio.Text);
                proftSelectedVeriable = p1;
            }
            else if (Cost2_Radio.Checked == true)
            {
                CostSelectedVeriable = decimal.Parse(Cost2_Radio.Text);
                proftSelectedVeriable = p2;
            }
            else if (Cost3_Radio.Checked == true)
            {
                CostSelectedVeriable = decimal.Parse(Cost3_Radio.Text);
                proftSelectedVeriable = p3;
            }

            else if (Cost4_Radio.Checked == true)
            {
                CostSelectedVeriable = decimal.Parse(Cost4_Radio.Text);
                proftSelectedVeriable = p4;
            }

            Calculations();
        }
        private void Cost1_Radio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CostCheckChangeFunc();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CustomerTypeCheckChangeFunc()
        {
            Custmer_Or_Agent_ID_Txt.Enabled = true;

            if (Customer_referenceType1_Radio.Checked == true)
            {
                ReferenceTypeVeriable = 1;


            }
            else if (Customer_referenceType2_Agent_Radio.Checked == true)
            {
                ReferenceTypeVeriable = 2;

            }
        }
            private void Customer_referenceType1_Radio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CustomerTypeCheckChangeFunc();

            }
            catch (Exception)
            {

               
            }
        }

        private void Collected_Amount_Txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Collected_Amount_Txt.Text.Length < 1)
                {
                    Collected_Amount_Txt.Text = "0";

                }

                decimal grandt = decimal.Parse(Grand_Total_Txt.Text);
                decimal col = decimal.Parse(Collected_Amount_Txt.Text); 

                if (col > grandt )
                {
                    Collected_Amount_Txt.Text = Grand_Total_Txt.Text;
                    RemainingCOunt();

                }


                RemainingCOunt();
            }
            catch (Exception)
            {

                
            }
        }

        private void cc()
        {
            TotalCalculate();
            AfterDiscount();
            RemainingCOunt();
        }

        private void Calculations()
        {
            decimal orig = decimal.Parse(Orignal_Total_Txt.Text);

            decimal extdis = decimal.Parse(Extra_Discount_Txt.Text);

            if (Extra_Discount_Txt.Text.Length <= 0)
            {
                extdis = 0;
            }

            if (extdis > orig)
            {
                Extra_Discount_Txt.Text = Orignal_Total_Txt.Text;
            }

            Grand_Total_Txt.Text = (orig - extdis).ToString();

            TotalCalculate();
            AfterDiscount();
            RemainingCOunt();

           
        }
        private void Extra_Discount_Txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Extra_Discount_Txt.Text.Length < 1)
                {
                    Extra_Discount_Txt.Text = "0";

                }
                if (decimal.Parse(Extra_Discount_Txt.Text) >=  ourprofit)
                {
                    Extra_Discount_Txt.Text = ourprofit.ToString();

                }
                Calculations();
                

            }
            catch (Exception)
            {

                
            }
        }

        private void SAVE_New_Booking_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (WarFramework.WarMessageBox.Show(this, "AGAIN CONFIRM YOU REALLY WANT TO BOOK THIS PACKAGE", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (true)
                    {
                        bool ispaidFull = false;
                        if (decimal.Parse(Remaining_Amount_Txt.Text) <=0)
                        {
                            ispaidFull = true;
                        }
                        WARPRO.Glob.Bookings_And_Payments.Glob_Bookings.NewBookingAndBill(ReferenceTypeVeriable,long.Parse( Custmer_Or_Agent_ID_Txt.Text),long.Parse( Package_CodeComboBox.Text),int.Parse(For_No_of_Persons_Txt.Text),decimal.Parse(Orignal_Total_Txt.Text), SpecialOfferDiscountVeriable, decimal.Parse(Extra_Discount_Txt.Text), decimal.Parse(Tatal_Discount_Txt.Text), decimal.Parse(Collected_Amount_Txt.Text), decimal.Parse(Remaining_Amount_Txt.Text), ispaidFull, PackageOfferedByCompanyID ,payableVeriable);

                        // Transec
                        WARPRO.Glob.Bookings_And_Payments.Glob_Transec.NewTransec(WARPRO.Glob.Bookings_And_Payments.Glob_Bookings.GetLastID(), Custmer_Or_Agent_ID_Txt.Text, Grand_Total_Txt.Text,  Collected_Amount_Txt.Text, Remaining_Amount_Txt.Text, "BOOKING");





                        this.Close();
                        try
                        {
                           WARUI.Print.PrintUI p = new Print.PrintUI(WARPRO.Glob.Bookings_And_Payments.Glob_Bill_Payments.Get_LastAdded_Bill_ID());
                            p.ShowDialog();

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
    }
}
