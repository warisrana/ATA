using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com_war_air.com.WARPRO.Glob.CustomersAndAgents;
using com_war_air.com.WARUI.Agents_Customers;

namespace com_war_air.com.WARUI.Bookings_Payments
{
    public partial class PayAbleGridUI : WarFramework.Forms.WarForm
    {
        public PayAbleGridUI()
        {
            InitializeComponent();

            Company_Name_Id_ComboBox.Items.AddRange(Glob_mainCompany.Get_CompanyName_And_ID_Coloumn(true));
            Company_Name_Id_ComboBox.Items.AddRange(Glob_mainCompany.Get_CompanyName_And_ID_Coloumn(false));
        }



        ///////////////////////////// .....
        internal void LoadData()
        {
            string _DealStatus = "";
            string _Date = "";
            string _ispaidfull = "";
            string _CompanyiD = "";

            if (Company_Name_Id_ComboBox.SelectedIndex == 0)
            {
                _CompanyiD = "";
            }
            else if (Company_Name_Id_ComboBox.SelectedIndex >= 1)
            {
                string[] ssp = Company_Name_Id_ComboBox.Text.Split('-');
                _CompanyiD = ssp[1];
            }
            //.............

            if (DealSTATUS_ComboBox.SelectedIndex == 0)
            {
                _DealStatus = "";
            }
            else if (DealSTATUS_ComboBox.SelectedIndex == 1)
            {
                _DealStatus = "true";
            }
            else if (DealSTATUS_ComboBox.SelectedIndex == 2)
            {
                _DealStatus = "false";
            }


            if (DateTime1.Checked == false)
            {
                _Date = "";
            }
            else if (DateTime1.Checked == true)
            {
                _Date = DateTime1.Value.ToLongDateString();
            }
            ///------------------
            if (IsPaidFullComboBox.SelectedIndex == 0)
            {
                _ispaidfull = "";
            }
            else if (IsPaidFullComboBox.SelectedIndex == 1)
            {
                _ispaidfull = "true";
            }
            else if (IsPaidFullComboBox.SelectedIndex == 2)
            {
                _ispaidfull = "false";
            }


            WarGrid1.DataSource = WARPRO.Glob.Bookings_And_Payments.Glob_Payable.Get_Payable_Table_DataFOrGrid(Payable_ID_Txt.Text, _CompanyiD, BookingID_Txt.Text, _Date, PayableAmount_Txt.Text, PaidAmount_Txt.Text, RemainingAmount_Txt.Text, _ispaidfull, _DealStatus);
                WarGrid1.Columns[7].Visible = false;
                WarGrid1.Columns[8].Visible = false;



        }


        internal void Cellcliick()
        {
            var value = WarGrid1.SelectedCells[0].Value.ToString();

            if (WarGrid1.SelectedCells[0].ColumnIndex == 0)
            {
                long bookingid = long.Parse(WarGrid1.Rows[WarGrid1.SelectedCells[0].RowIndex].Cells[2].Value.ToString());
                PayablePayUI bk = new PayablePayUI(bookingid);
                bk.ShowDialog();

            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 1)
            {
                
                CompanyUI bk = new CompanyUI(long.Parse(value));
                bk.ShowDialog();
            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 2)
            {
                BookingInfoUI b = new BookingInfoUI(long.Parse(value));
                b.ShowDialog();
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

        private void PayAbleGridUI_Load(object sender, EventArgs e)
        {

        }

        private void Payable_ID_Txt_KeyDown(object sender, KeyEventArgs e)
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

        private void IsPaidFullComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Company_Name_Id_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Payable_ID_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13;

        }

        private void WarGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                //long bookingid =long.Parse(WarGrid1.SelectedRows[0].Cells[2].Value.ToString());
                long bookingid = long.Parse(WarGrid1.Rows[WarGrid1.SelectedCells[0].RowIndex].Cells[2].Value.ToString());
                PayablePayUI p = new PayablePayUI(bookingid);
                p.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
