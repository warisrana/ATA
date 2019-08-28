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
    public partial class AgentUI : WarFramework.Forms.WarForm
    {
        
        WebCam webcam;

        long AgentIDForUpdateUse;

        public AgentUI()
        {
            try
            {
                InitializeComponent();

                
            webcam = new WebCam();
            webcam.InitializeWebCam(ref ImageR);
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public AgentUI(long AgentID)
        {
            try
            {
                InitializeComponent();


                var c = Glob.CustomersAndAgents.Agents_Partial.Select_Row_Agent(AgentID);

                AgentIDForUpdateUse = c.ID;

                FirstName_Txt.Text = c.FIRST_NAME;
                LAST_NAMETxt.Text = c.LAST_NAME;
                Address_Txt.Text = c.ADDRESS;
                Mobile_Txt.Text = c.MOBILE_NO;
                EmailTxt.Text = c.EMAIL;
                StatusToggle.Checked = c.STATUS;
                Agent_From_Date_link.Text = c.AGENT_FROM.ToLongDateString();
                ImageR.Image = Glob.CacheData.Glob_Veriables.GetImageFromByteArray(c.PICTURE);








                webcam = new WebCam();
                webcam.InitializeWebCam(ref ImageR);

                
                Panel_info_Extra.Show();
               // Availibility_Toggle.Show();
                Panel_pictureControls.Hide();
                Edit_Btn.Show();
                Cancel_Edit_btn.Show();
                StatusToggle.Show();

                Main_Info_Panel.Enabled = false;
                SAVE_New_Customer_Btn.Hide();

                ImageR.Region = Glob.CacheData.Glob_Veriables.GetRoundRegion(ImageR.Width, ImageR.Height);
                this.Text ="AGENT "  +c.FIRST_NAME.ToUpper() + " ID# " + c.ID.ToString()  ;
                



            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


        //Zoom image file
        //Image Zoom(Image img, Size size)
        //{
        //    Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
        //    Graphics g = Graphics.FromImage(bmp);
        //    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        //    return bmp;
        //}
        ////private void TrackBar_Zoom_Scroll(object sender, ScrollEventArgs e)
        ////{
        ////    try
        ////    {
        ////        if (TrackBar_Zoom.Value > 0)
        ////        {
        ////            ImageR.Image = Zoom(imgOriginal, new Size(TrackBar_Zoom.Value, TrackBar_Zoom.Value));
        ////        }

        ////    }
        ////    catch (Exception ex)
        ////    {

        ////        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        ////    }
        ////}

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


                if ((string.IsNullOrWhiteSpace(FirstName_Txt.Text) == false) && (string.IsNullOrWhiteSpace(LAST_NAMETxt.Text) == false) && (string.IsNullOrWhiteSpace(Address_Txt.Text) == false) && (string.IsNullOrWhiteSpace(Mobile_Txt.Text) == false)   && (ImageR.Image != null))
                {
                    ///////////////

                    Glob.CustomersAndAgents.Agents_Partial.NewAgent(FirstName_Txt.Text, LAST_NAMETxt.Text, Address_Txt.Text, Mobile_Txt.Text, EmailTxt.Text,  Glob.CacheData.Glob_Veriables.ImageToByte(ImageR.Image) );

              
                    this.Close();
                    Glob.CacheData.Glob_Veriables.Show_NotiFiCation("NEW AGENT" , "NEW AGENT HAS BEEN SUCCESSFULLY ADDED ");
                }
                else
                {
                    MessageBox.Show("Sorry All fields And A Photo Required".ToUpper(), "Sorry!".ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
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


                if ((string.IsNullOrWhiteSpace(FirstName_Txt.Text) == false) && (string.IsNullOrWhiteSpace(LAST_NAMETxt.Text) == false) && (string.IsNullOrWhiteSpace(Address_Txt.Text) == false) && (string.IsNullOrWhiteSpace(Mobile_Txt.Text) == false)   && (ImageR.Image != null))
                {

                    Glob.CustomersAndAgents.Agents_Partial.update_Agent_info(FirstName_Txt.Text, LAST_NAMETxt.Text, Address_Txt.Text, Mobile_Txt.Text, EmailTxt.Text,  Glob.CacheData.Glob_Veriables.ImageToByte(ImageR.Image), AgentIDForUpdateUse);
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

        private void StatusToggle_Click(object sender, EventArgs e)
        {
            try
            {
                if (StatusToggle.Checked == true)
                {
                    Glob.CustomersAndAgents.Agents_Partial.update_Agent_Activation_Status(true,AgentIDForUpdateUse);
                    Glob.CacheData.Glob_Veriables.Show_NotiFiCation("ACTIVATION", "ACTIVATION HAS BEEN ACTIVATED");
                }
                else if (StatusToggle.Checked == false)
                {
                    Glob.CustomersAndAgents.Agents_Partial.update_Agent_Activation_Status(false,AgentIDForUpdateUse);
                    Glob.CacheData.Glob_Veriables.Show_NotiFiCation("ACTIVATION", "ACTIVATION HAS BEEN DEACTIVATED");
                }
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
