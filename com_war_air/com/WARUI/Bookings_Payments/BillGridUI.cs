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
using com_war_air.com.WARUI.Print;

namespace com_war_air.com.WARUI.Bookings_Payments
{
    public partial class BillGridUI : WarFramework.Forms.WarForm
    {
        public BillGridUI()
        {
            InitializeComponent();
        }

        private void BillGridUI_Load(object sender, EventArgs e)
        {


        }


        ///////////////////////////// .....
        internal void LoadData()
        {
            string _ReferenceType = "";
            string _Date = "";
            string _IsPaidFull = "";
            string _isRefunded = "";
           

            if (Reference_Type_ComboBox.SelectedIndex == 0)
            {
                _ReferenceType = "";
            }
            else if (Reference_Type_ComboBox.SelectedIndex == 1)
            {
                _ReferenceType = "1";
            }
            else if (Reference_Type_ComboBox.SelectedIndex == 2)
            {
                _ReferenceType = "2";
            }
            //.............

            if (IsPaid_Full_ComboBox.SelectedIndex == 0)
            {
                _IsPaidFull = "";
            }
            else if (IsPaid_Full_ComboBox.SelectedIndex == 1)
            {
                _IsPaidFull = "true";
            }
            else if (IsPaid_Full_ComboBox.SelectedIndex == 2)
            {
                _IsPaidFull = "false";
            }

            //>>>>>>
            if (IsRefundedFullComboBox.SelectedIndex == 0)
            {
                _isRefunded = "";
            }
            else if (IsRefundedFullComboBox.SelectedIndex == 1)
            {
                _isRefunded = "false";
            }
            else if (IsRefundedFullComboBox.SelectedIndex == 2)
            {
                _isRefunded = "true";
            }


            //<<<<<<<
            if (DateTime1.Checked == false)
            {
                _Date = "";
            }
            else if (DateTime1.Checked == true)
            {
                _Date = DateTime1.Value.ToLongDateString();
            }
            ///------------------
           


            WarGrid1.DataSource = WARPRO.Glob.Bookings_And_Payments.Glob_Bill_Payments.Get_Bill_Table_DataFOrGrid(Bill_ID_Txt.Text,_ReferenceType,ReferenceCode_ID_Txt.Text,BookingID_Txt.Text,_Date,TotalOrignalAmountAmount_Txt.Text,SpecialOfferDiscount_Txt.Text,Extra_Discouunt_Txt.Text,Total_Discount_Txt.Text,PaidAmount_Txt.Text, RemainingAmount_Txt.Text,_IsPaidFull,_isRefunded);
            WarGrid1.Columns[1].Visible  = false;
            WarGrid1.Columns[11].Visible = false;
            WarGrid1.Columns[12].Visible = false;
            
        }

        private void Bill_ID_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13;
        }

        private void Total_Discount_Txt_KeyDown(object sender, KeyEventArgs e)
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

        private void Reference_Type_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
            var referencetype = Convert.ToInt32(WarGrid1.Rows[WarGrid1.SelectedCells[0].RowIndex].Cells[1].Value.ToString());

            if (WarGrid1.SelectedCells[0].ColumnIndex == 0)
            {

                PrintUI p = new PrintUI(long.Parse(value));
                p.ShowDialog();
            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 1)
            {


            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 2)
            {
                if (referencetype == 1)
                {
                    CustomerUI bk = new CustomerUI(long.Parse(value));
                    bk.ShowDialog();
                }
                else if (referencetype == 2)
                {
                    AgentUI bk = new AgentUI(long.Parse(value));
                    bk.ShowDialog();
                }


                
            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 3)
            {
                BookingInfoUI b = new BookingInfoUI(long.Parse(value));
                b.ShowDialog();
            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 4)
            {
                //PackageUI bk = new PackageUI(long.Parse(value));
                //bk.ShowDialog();
            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 5)
            {

            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 6)
            {
                //long bookingidrec = long.Parse(WarGrid1.SelectedRows[0].Cells[0].Value.ToString());

                //PrintUI bk = new PrintUI(bookingidrec);
                //bk.ShowDialog();
            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 7)
            {

            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 8)
            {

            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 9)
            {

            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 10)
            {

            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 11)
            {

            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 12)
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

        private void WarGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //long bookingid = long.Parse(WarGrid1.SelectedRows[0].Cells[3].Value.ToString());
                var bookingid = Convert.ToInt32(WarGrid1.Rows[WarGrid1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());

                PrintUI p = new PrintUI(bookingid);
                p.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}