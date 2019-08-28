using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormCharpWebCam;
using com_war_air.com.WARPRO;

namespace com_war_air.com.WARPRO.WARUI.Agents
{
    public partial class CustomerUI : WarFramework.Forms.WarForm
    {
        
        WebCam webcam;

        long OrignalCustomerIDForUpdateUse;
        bool NewRegestration = false;
        public CustomerUI()
        {
            try
            {
                InitializeComponent();

                NewRegestration = true;


            webcam = new WebCam();
            webcam.InitializeWebCam(ref ImageR);
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public CustomerUI(long CustomerID)
        {
            try
            {
                InitializeComponent();


                var c = Glob.CustomersAndAgents.CustomersAndAgents_class.Select_Row_Customer(CustomerID);
                var p = Glob.CustomersAndAgents.Glob_Passport.Get_Select_Row_Passport(CustomerID);

                OrignalCustomerIDForUpdateUse = c.ID;

                //for First Name
                string[] s = c.FIRST_NAME.Split('.');
                MrCombo.Text = s[0];
                FirstName_Txt.Text = s[1] ;


                LAST_NAMETxt.Text = c.LAST_NAME;
                Address_Txt.Text = c.ADDRESS;
                Mobile1_Txt.Text = c.MOBILE_NO;
                EmailTxt.Text = c.EMAIL;
                Details_Txt.Text = c.DETAILS;
                Customer_From_Date_link.Text = c.CUSTOMER_FROM.ToLongDateString();
                ImageR.Image = Glob.CacheData.Glob_Veriables.GetImageFromByteArray(c.PICTURE);
                passportNo_Txt.Text = c.PASSPORT_NO;
                IsRefferedByCheckBox.Checked = c.IsREFFERED;
                AgentID_Txt.Text = c.REFFERED_BY.ToString();
                if (c.IsREFFERED == true)
                {
                    AgentID_Txt.Show();
                                         
                }



                SrNoTxt.Text = p.SR_NO;
                Date.Value = p.DATE;
                NameTxt.Text = p.NAME;
                passportNo_Txt.Text = p.PASSPORT_NO;
                cnicTxt.Text = p.CNIC_NO;
                DateOfBirthDatetime.Value = p.DATE_OF_BIRTH;
                DateOfIssueDatetime.Value = p.DATE_OF_ISSUE;
                DateOfExpiryDatetime.Value = p.DATE_OF_EXPIRY;
                cnicTxt.Text = cnicTxt.Text;
                Mobile1_Txt.Text = p.CONTACT_NO_1;
                MobileNo2Txt.Text = p.CONTACT_NO_2;

                
                webcam = new WebCam();
                webcam.InitializeWebCam(ref ImageR);

                
                Panel_info_Extra.Show();
               // Availibility_Toggle.Show();
                Panel_pictureControls.Hide();
                Edit_Btn.Show();
                Cancel_Edit_btn.Show();

                Main_Info_Panel.Enabled = false;
                SAVE_New_Customer_Btn.Hide();

                ImageR.Region = Glob.CacheData.Glob_Veriables.GetRoundRegion(ImageR.Width, ImageR.Height);
                this.Text ="CUSTOMER "  +c.FIRST_NAME.ToUpper() + " ID# " + c.ID.ToString()  ;
                



            }
            catch (Exception ex)
            {
                this.Close();
                
            }
        }
            private void BookWARehouseUI_Load(object sender, EventArgs e)
        {
            

           
            

        }

        private void Cam_Start_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //ImageR.SizeMode = PictureBoxSizeMode.CenterImage;
                webcam.Start();
                Cam_Start_btn.Hide();
                Stop_Cam.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Capture_btn_Click(object sender, EventArgs e)
        {
            try
            {


                webcam.Stop();
                //ImageR.SizeMode = PictureBoxSizeMode.CenterImage;
                //imgOriginal = ImageR.Image;
                Cam_Start_btn.Show();
                //TrackBar_Zoom.Show();
                Stop_Cam.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Brows_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                       // ImageR.SizeMode = PictureBoxSizeMode.StretchImage;
                        ImageR.Image = System.Drawing.Image.FromFile(ofd.FileName);
                        //imgOriginal = ImageR.Image;
                        //TrackBar_Zoom.Hide();

                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Stop_Cam_Click(object sender, EventArgs e)
        {

            try
            {
                webcam.Stop();
                ImageR.Image = null;
                Stop_Cam.Hide();
                Cam_Start_btn.Show();
               // TrackBar_Zoom.Hide();
            }
            catch (Exception)
            {


            }
        }

        

        private void NO_OF_COPIES_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13;

        }

       
        private void SAVE_New_Book_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ImageR.Image == null)
                {
                    ImageR.Image = ImageR.InitialImage;
                }

                if ((string.IsNullOrWhiteSpace(FirstName_Txt.Text) == false) && (string.IsNullOrWhiteSpace(LAST_NAMETxt.Text) == false) && (string.IsNullOrWhiteSpace(Address_Txt.Text) == false) && (string.IsNullOrWhiteSpace(Mobile1_Txt.Text) == false)  && (string.IsNullOrWhiteSpace(passportNo_Txt.Text) == false) && (ImageR.Image != null))
                {
                    ///////////////

                    Glob.CustomersAndAgents.CustomersAndAgents_class.NewCustomer(MrCombo.Text + "." + FirstName_Txt.Text.Replace('.', ' '), LAST_NAMETxt.Text, Address_Txt.Text,  EmailTxt.Text, Details_Txt.Text, Glob.CacheData.Glob_Veriables.ImageToByte(ImageR.Image), passportNo_Txt.Text,long.Parse( AgentID_Txt.Text),IsRefferedByCheckBox.Checked, SrNoTxt.Text,Date.Value, NameTxt.Text,DateOfBirthDatetime.Value,DateOfIssueDatetime.Value,DateOfExpiryDatetime.Value,cnicTxt.Text,Mobile1_Txt.Text,MobileNo2Txt.Text);

              
                    this.Close();
                    Glob.CacheData.Glob_Veriables.Show_NotiFiCation("NEW CUSTOMER" , "NEW CUSTOMER HAS BEEN SUCCESSFULLY ADDED ");
                }
                else
                {
                    MessageBox.Show("Sorry Important fields And A Photo Required".ToUpper(), "Sorry!".ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        

        private void Cancel_Edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                // Main_Info_Panel.Enabled = false;
                //SAVE_Edit_Btn.Hide();
                //Edit_Btn.Show();
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
                

                Main_Info_Panel.Enabled = true;
                SAVE_Edit_Btn.Show();
                Edit_Btn.Hide();
                Panel_pictureControls.Show();

                NewRegestration = true;

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


                if (ImageR.Image == null)
                {
                    ImageR.Image = ImageR.InitialImage;
                }


                if ((string.IsNullOrWhiteSpace(FirstName_Txt.Text) == false) && (string.IsNullOrWhiteSpace(LAST_NAMETxt.Text) == false) && (string.IsNullOrWhiteSpace(Address_Txt.Text) == false) && (string.IsNullOrWhiteSpace(Mobile1_Txt.Text) == false) && (string.IsNullOrWhiteSpace(passportNo_Txt.Text) == false)  && (ImageR.Image != null))
                {

                    Glob.CustomersAndAgents.CustomersAndAgents_class.update_Customer_And_Passport_info(MrCombo.Text + "." + FirstName_Txt.Text.Replace('.',' '), LAST_NAMETxt.Text, Address_Txt.Text, EmailTxt.Text, Details_Txt.Text, Glob.CacheData.Glob_Veriables.ImageToByte(ImageR.Image), passportNo_Txt.Text, long.Parse(AgentID_Txt.Text), IsRefferedByCheckBox.Checked, SrNoTxt.Text, Date.Value, NameTxt.Text, DateOfBirthDatetime.Value, DateOfIssueDatetime.Value, DateOfExpiryDatetime.Value, cnicTxt.Text, Mobile1_Txt.Text, MobileNo2Txt.Text, OrignalCustomerIDForUpdateUse); 
                    this.Close();
                    WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("UPDATED", "INFORMATION SUCCESSFULLY UPDATED");

                }
                else
                {
                    MessageBox.Show("Sorry Dear Admin  All fields And Photo Required".ToUpper(), "Sorry!".ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        

        private void BookWARehouseUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Mobile_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13;
        }

        

        private void EmailTxt_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                //System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

                //if (EmailTxt.Text.Length > 0)

                //{

                //    if (!rEMail.IsMatch(EmailTxt.Text))

                //    {

                //        MessageBox.Show("Invalid Email Address Please enter a valid Email Address", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //        EmailTxt.SelectAll();

                //        e.Cancel = true;

                //    }

                //}

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void IsRefferedByCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsRefferedByCheckBox.Checked == true )
            {
                AgentID_Txt.Text = "";
                AgentID_Txt.Show();

                //"""""""""""""
                if (NewRegestration ==true)
                {
                    
                    SAVE_Edit_Btn.Enabled = false;
                    SAVE_New_Customer_Btn.Enabled = false;
                    labelAgentnotavail.Show();

                   
                }
                
                //????????????
                
            }

            else if (IsRefferedByCheckBox.Checked == false)
            {

                AgentID_Txt.Text = "0";
                AgentID_Txt.Hide();


                //"""""""""""""
                if (NewRegestration == true)
                {
                    SAVE_Edit_Btn.Enabled = true;
                    
                    SAVE_New_Customer_Btn.Enabled = true;
                   
                    labelAgentnotavail.Hide();


                }

                //????????????

            }
        }

        private void passportNo_Txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ( NewRegestration == true)

               {
                    SAVE_Edit_Btn.Enabled = true;
                    SAVE_New_Customer_Btn.Enabled = true;
                    
                    canceledLable.Hide();
                
                

                if (passportNo_Txt.Text.Length >= 1)
                {

                    var cr = WARPRO.Glob.CustomersAndAgents.Glob_Passport.Get_Select_FOrWidgetRowByPassportNo_Passport(passportNo_Txt.Text);
                    if (cr != null)
                    {
                            
                            SAVE_Edit_Btn.Enabled = false;
                            SAVE_New_Customer_Btn.Enabled = false;
                        
                        canceledLable.Show();
                    }
                    else
                    {
                            SAVE_Edit_Btn.Enabled = true;
                            
                            SAVE_New_Customer_Btn.Enabled = true;
                            
                        canceledLable.Hide();
                    }

                }

                else
                {

                    //WarFramework.WarMessageBox.Show(this, "PLEASE ENTER CUSTOMER ID", "CUSTOMER ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }


               }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void AgentID_Txt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                //"""""""""""""
                if ((NewRegestration == true ) && (IsRefferedByCheckBox.Checked == true ))
                {

                    
                    SAVE_Edit_Btn.Enabled = false;
                    SAVE_New_Customer_Btn.Enabled = false;
                    
                    labelAgentnotavail.Show();

                    if (AgentID_Txt.Text.Length >= 1)
                    {

                        var cr = WARPRO.Glob.CustomersAndAgents.Agents_Partial.Select_Row_Agent(long.Parse(AgentID_Txt.Text));
                        if (cr != null)
                        {
                            SAVE_New_Customer_Btn.Enabled = true;
                            SAVE_Edit_Btn.Enabled = true;
                            

                            labelAgentnotavail.Hide();
                        }
                        else
                        {


                            
                            SAVE_Edit_Btn.Enabled = false;
                            SAVE_New_Customer_Btn.Enabled = false;
                            labelAgentnotavail.Show();
                        }

                    }

                    else
                    {

                        //WarFramework.WarMessageBox.Show(this, "PLEASE ENTER CUSTOMER ID", "CUSTOMER ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }

                //????????????
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
