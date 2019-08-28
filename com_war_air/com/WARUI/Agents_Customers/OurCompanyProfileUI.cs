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
using WinFormCharpWebCam;

namespace com_war_air.com.WARUI.Agents_Customers
{
    public partial class OurCompanyProfileUI : WarFramework.Forms.WarForm
    {
        WebCam webcam;

        public OurCompanyProfileUI()
        {
            InitializeComponent();

            webcam = new WebCam();
            webcam.InitializeWebCam(ref ImageR);

            var rr = WARPRO.Glob.CustomersAndAgents.Glob_OurCompanyProfile.Get_Select_Row_OurCompanyProfile();




            Edit_Btn.Show();
            
            Cancel_Edit_btn.Show();
            Main_Info_Panel.Enabled = false;
            Panel_info_Extra.Show();

           //

           

            CompanyName_Txt.Text = rr.COMPANY_NAME;
            Owner_NAME_Txt.Text = rr.OWNER_NAME;

            Address_Txt.Text = rr.ADDRESS;
            Company_Mobile_Txt.Text = rr.COMPANY_MOBILE_NO;
            Extra_Mobile_Txt.Text = rr.EXTRA_MOBILE_NO;
            Owner_Mobile_Txt.Text = rr.OWNER_MOBILE_NO;

            EmailTxt.Text = rr.EMAIL;
            Extra_Email_Txt.Text = rr.EXTRA_EMAIL;

            Extra_Details_Txt.Text = rr.EXTRA_DETAILS;

            Company_From_Date_link.Text = rr.LAST_CHANGE_DATE.ToLongDateString();

            if (rr.IMAGE != null)
            {
                ImageR.Image = WARPRO.Glob.CacheData.Glob_Veriables.GetImageFromByteArray(rr.IMAGE);
            }


        }

        private void Cancel_Edit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            

            Main_Info_Panel.Enabled = true;
            SAVE_Edit_Btn.Show();
            Edit_Btn.Hide();
            Panel_pictureControls.Show();
        }

        private void SAVE_Edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {

                WARPRO.Glob.CustomersAndAgents.Glob_OurCompanyProfile.UpdateOurCompany_Info(CompanyName_Txt.Text, Owner_NAME_Txt.Text, Address_Txt.Text, Company_Mobile_Txt.Text, Owner_Mobile_Txt.Text, Extra_Mobile_Txt.Text, EmailTxt.Text, Extra_Email_Txt.Text, Extra_Details_Txt.Text, Glob_Veriables.ImageToByte(ImageR.Image));
                this.Close();
                WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("UPDATED", "INFORMATION HAS BEEN SUCCESSFULLY UPDATED");

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
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

        private void OurCompanyProfileUI_Load(object sender, EventArgs e)
        {

        }
    }
}
