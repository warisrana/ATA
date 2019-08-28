using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace com_war_air.com.WARPRO.Glob.CacheData
{
    class Glob_Veriables
    {
        private static long Current_LoggedIn_Admin_Id;
        private static string Current_LoggedIn_Admin_Name;

        private static bool Current_IsMainAdmin;

        private static Bitmap Current_Loggedin_Admin_Image;

        private static string Recovery_Random_Code;
        private static long Recovery_Random_Code_User_Admin_Id;




        internal static void Set_IsMainAdmin(bool _isMain)
        {
            Current_IsMainAdmin = _isMain;
        }
        internal static bool Get_IsMainAdmin()
        {
            // if (Current_LoggedIn_Adnin_Id !=  0)
            return Current_IsMainAdmin;

        }


        internal static void Set_Recovery_Random_Code_User_Admin_Id(long _Recovery_Random_Code_User_Admin_Id)
        {
            Recovery_Random_Code_User_Admin_Id = _Recovery_Random_Code_User_Admin_Id;
        }
        internal static long Get_Recovery_Random_Code_User_Admin_Id()
        {
            // if (Current_LoggedIn_Adnin_Id !=  0)
            return Recovery_Random_Code_User_Admin_Id;

        }




        internal static void Set_Current_LoggedIn_Admin_Id(long _Current_LoggedIn_Adnin_ID)
        {
            Current_LoggedIn_Admin_Id = _Current_LoggedIn_Adnin_ID;
        }
        internal static long Get_Current_LoggedIn_Admin_Id()
        {
            // if (Current_LoggedIn_Adnin_Id !=  0)
            return Current_LoggedIn_Admin_Id;

        }

        internal static void Set_Current_LoggedIn_Admin_Name(string _Current_LoggedIn_Admin_Name)
        {
            Current_LoggedIn_Admin_Name = _Current_LoggedIn_Admin_Name;
        }
        internal static string Get_Current_LoggedIn_Admin_Name()
        {
            // if (Current_LoggedIn_Adnin_Id !=  0)
            return Current_LoggedIn_Admin_Name;

        }




        internal static void Set_Recovery_Random_Code(string _Recovery_Random_Code)
        {
            Recovery_Random_Code = _Recovery_Random_Code;
        }
        internal static string Get_Recovery_Random_Code()
        {
            // if (Current_LoggedIn_Adnin_Id !=  0)
            return Recovery_Random_Code;

        }

        internal static void Set_Current_Admin_Image(byte[] _bytearray)
        {
            Current_Loggedin_Admin_Image = GetImageFromByteArray(_bytearray);
        }

        internal static Bitmap Get_Current_Admin_Image()
        {
            // if (Current_LoggedIn_Adnin_Id !=  0)
            return Current_Loggedin_Admin_Image;

        }


        internal static Region GetRoundRegion(float width, float height)
        {

            System.Drawing.Drawing2D.GraphicsPath gp1 = new System.Drawing.Drawing2D.GraphicsPath();
            gp1.AddEllipse(0, 0, width, height);
            Region rg1 = new Region(gp1);
            return rg1;


        }



        public static byte[] ImageToByte(System.Drawing.Image img1)
        {


            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img1, typeof(byte[]));

        }
        internal static Bitmap GetImageFromByteArray(byte[] byteArray)
        {
            ImageConverter _imageConverter = new ImageConverter();

            Bitmap bm = (Bitmap)_imageConverter.ConvertFrom(byteArray);

            if (bm != null && (bm.HorizontalResolution != (int)bm.HorizontalResolution ||
                               bm.VerticalResolution != (int)bm.VerticalResolution))
            {
                // Correct a strange glitch that has been observed in the test program when converting 
                //  from a PNG file image created by CopyImageToByteArray() - the dpi value "drifts" 
                //  slightly away from the nominal integer value
                bm.SetResolution((int)(bm.HorizontalResolution + 0.5f),
                                 (int)(bm.VerticalResolution + 0.5f));
            }

            return bm;
        }

      //  private static SoundPlayer sp = new SoundPlayer(Properties.Resources.WARnotSound);

        private static PopupNotifier np = new PopupNotifier();
        internal static void Show_NotiFiCation(string titleTxt, string BodyContextTxt)
        {

            np.HeaderColor = Color.DodgerBlue;
          //  np.Image = Properties.Resources.WAR_LOGO_png;
            np.ImageSize = new Size(40, 40); // 35,35
            //np.ImagePadding = ;
            np.ShowGrip = false;
            np.BorderColor = Color.WhiteSmoke;
            np.ImagePadding = new System.Windows.Forms.Padding(5, 25, 25, 25);
            np.TitleText = titleTxt;
            np.ContentText = BodyContextTxt;
            np.ShowCloseButton = false;
            np.AnimationDuration = 500;
            np.Delay = 1500;

            np.Popup(); //ShowNotification
           // sp.Play();
        }

    }
}
