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
    public partial class CompanyGridUI : WarFramework.Forms.WarForm
    {
        public CompanyGridUI()
        {
            InitializeComponent();
        }

        private void companyID_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13;

        }


        ///////////////////////////// .....
        internal void LoadData()
        {
            string Status = "";
            string Date = "";

            if (STATUS_ComboBox.SelectedIndex == 0)
            {
                Status = "";
            }
            else if (STATUS_ComboBox.SelectedIndex == 1)
            {
                Status = "true";
            }
            else if (STATUS_ComboBox.SelectedIndex == 2)
            {
                Status = "false";
            }


            if (DateTime1.Checked == false)
            {
                Date = "";
            }
            else if (DateTime1.Checked == true)
            {
                Date = DateTime1.Value.ToLongDateString();
            }


            
            

                WarGrid1.DataSource = WARPRO.Glob.CustomersAndAgents.Glob_mainCompany.Get_Company_Table_DataFOrGrid(companyID_Txt.Text, CompanyName_Txt.Text, Owner_NAME_Txt.Text, Address_Txt.Text, Company_mobileNo_Txt.Text,Owner_MOBILE_NO_Txt.Text,Extra_MobileNo_Txt.Text,EMAIL_Txt.Text,Extra_Email_Txt.Text, Date,EXTRA_DETAILS_Txt.Text, Status);
                WarGrid1.Columns[11].Visible = false;
               

            


        }

        private void CompanyName_Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    LoadData();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void STATUS_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadData();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void DateTime1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadData();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        internal void Cellcliick()
        {
            var value = WarGrid1.SelectedCells[0].Value.ToString();
            // var referencetype = Convert.ToInt32(WarGrid1.SelectedRows[0].Cells[1].Value.ToString());

            if (WarGrid1.SelectedCells[0].ColumnIndex == 0)
            {
                
                    CompanyUI bk = new CompanyUI(long.Parse(value));
                    bk.ShowDialog();
                

            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 1)
            {


            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 2)
            {



                //BookingInfoUI b = new BookingInfoUI(long.Parse(value));
                //b.ShowDialog();
            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 3)
            {

            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 4)
            {

            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 5)
            {

            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 6)
            {

            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 7)
            {

            }
        }


        private void WarGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cellcliick();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
