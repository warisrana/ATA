using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com_war_air.com.WARUI.Agents_Customers
{
    public partial class CompanyUI : WarFramework.Forms.WarForm
    {
        public CompanyUI()
        {
            InitializeComponent();
        }


        long orignalCompanyId;

        public CompanyUI(long companyid)
        {
            try
            {

                InitializeComponent();


                var rr = WARPRO.Glob.CustomersAndAgents.Glob_mainCompany.Get_CompanyRow(companyid);

                orignalCompanyId = rr.ID;

                StatusToggle.Show();
                Edit_Btn.Show();
                SAVE_New_COmpany_Btn.Hide();
                Cancel_Edit_btn.Show();
                Main_Info_Panel.Enabled = false;
                Panel_info_Extra.Show();

                this.Text = "COMPANY ID - " + rr.ID.ToString();

                StatusToggle.Checked = rr.STATUS;

                CompanyName_Txt.Text = rr.COMPANY_NAME;
                Owner_NAME_Txt.Text = rr.OWNER_NAME;

                Address_Txt.Text = rr.ADDRESS;
                Company_Mobile_Txt.Text = rr.COMPANY_MOBILE_NO;
                Extra_Mobile_Txt.Text = rr.EXTRA_MOBILE_NO;
                Owner_Mobile_Txt.Text = rr.OWNER_MOBILE_NO;

                EmailTxt.Text = rr.EMAIL;
                Extra_Email_Txt.Text = rr.EXTRA_EMAIL;

                Extra_Details_Txt.Text = rr.EXTRA_DETAILS;

                Company_From_Date_link.Text = rr.CONNECTION_DATE.ToLongDateString();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void CompanyUI_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SAVE_New_COmpany_Btn_Click(object sender, EventArgs e)
        {
            try
            {


                WARPRO.Glob.CustomersAndAgents.Glob_mainCompany.NewCompany(CompanyName_Txt.Text, Owner_NAME_Txt.Text, Address_Txt.Text, Company_Mobile_Txt.Text, Owner_Mobile_Txt.Text, Extra_Mobile_Txt.Text, EmailTxt.Text, Extra_Email_Txt.Text, Extra_Details_Txt.Text);


                    this.Close();
                WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("NEW COMPANY", "NEW COMPANY HAS BEEN SUCCESSFULLY ADDED ");
               
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void StatusToggle_Click(object sender, EventArgs e)
        {
            try
            {
                if (StatusToggle.Checked == true)
                {
                    WARPRO.Glob.CustomersAndAgents.Glob_mainCompany.UpdateCompanyStatus(true, orignalCompanyId);
                    WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("ACTIVATION", "ACTIVATION HAS BEEN ACTIVATED");
                }
                else if (StatusToggle.Checked == false)
                {
                    WARPRO.Glob.CustomersAndAgents.Glob_mainCompany.UpdateCompanyStatus(false, orignalCompanyId);
                    WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("ACTIVATION", "ACTIVATION HAS BEEN DEACTIVATED");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            Main_Info_Panel.Enabled = true;
            SAVE_Edit_Btn.Show();
            Edit_Btn.Hide();
          //  Panel_pictureControls.Show();
        }

        private void Cancel_Edit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SAVE_Edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {

                WARPRO.Glob.CustomersAndAgents.Glob_mainCompany.UpdateCompany_Info(CompanyName_Txt.Text, Owner_NAME_Txt.Text, Address_Txt.Text, Company_Mobile_Txt.Text, Owner_Mobile_Txt.Text, Extra_Mobile_Txt.Text, EmailTxt.Text, Extra_Email_Txt.Text, Extra_Details_Txt.Text, orignalCompanyId);
                this.Close();
                WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("UPDATED", "INFORMATION SUCCESSFULLY UPDATED");

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Company_Mobile_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13;
        }

        private void EmailTxt_Validating_1(object sender, CancelEventArgs e)
        {
            try
            {
                System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

                if (EmailTxt.Text.Length > 0)

                {

                    if (!rEMail.IsMatch(EmailTxt.Text))

                    {

                        MessageBox.Show("Invalid Email Address Please enter a valid Email Address", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        EmailTxt.SelectAll();

                        e.Cancel = true;

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
