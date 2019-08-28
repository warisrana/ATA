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

namespace com_war_air.com.WARUI.DashBoard
{
    public partial class WidgetCustomer1UI : Form
    {
        public WidgetCustomer1UI()
        {
            InitializeComponent();
        }

        private void passportNo_Txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Custmer_Or_Agent_ID_Txt.Text = "";
                Edit_Btn.Hide();
                button1.Hide();
                if (passportNo_Txt.Text.Length >= 1)
                {

                    var cr = WARPRO.Glob.CustomersAndAgents.Glob_Passport.Get_Select_FOrWidgetRowByPassportNo_Passport(passportNo_Txt.Text);
                    if (cr != null)
                    {

                        Custmer_Or_Agent_ID_Txt.Text = cr.CUSTOMER_ID.ToString();
                        Clipboard.SetText(cr.CUSTOMER_ID.ToString());
                        Edit_Btn.Show();
                        button1.Show();
                        WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("COPIED", "CUSTOMER ID COPIED SUCCESSFULLY");

                    }
                    else
                    {
                        Clipboard.Clear();
                        Custmer_Or_Agent_ID_Txt.Text = "";
                        Edit_Btn.Hide();
                        button1.Hide();
                    }

                }

                else
                {

                    //WarFramework.WarMessageBox.Show(this, "PLEASE ENTER CUSTOMER ID", "CUSTOMER ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Custmer_Or_Agent_ID_Txt.Text);
            WARPRO.Glob.CacheData.Glob_Veriables.Show_NotiFiCation("COPIED", "CUSTOMER ID COPIED SUCCESSFULLY");

        }

        private void WidgetCustomer1UI_Load(object sender, EventArgs e)
        {
            Point p = new Point(0,0);
            
            this.Location = p;

        }


        internal  void widgetClose()
        {
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerUI bk = new CustomerUI(long.Parse(Custmer_Or_Agent_ID_Txt.Text));
                bk.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
