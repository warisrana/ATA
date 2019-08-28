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
using com_war_air.com.WARUI.Packages;
using com_war_air.com.WARUI.Print;

namespace com_war_air.com.WARUI.Bookings_Payments
{
    public partial class BookingGridUI : WarFramework.Forms.WarForm
    {
        public BookingGridUI()
        {
            InitializeComponent();
        }




        private void BookingGridUI_Load(object sender, EventArgs e)
        {

        }




        ///////////////////////////// .....
        internal void LoadData()
        {
            string _ReferenceType = "";
            string _Date = "";
            string _bookingstatus = "";



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

            if (BookingSTATUS_ComboBox.SelectedIndex == 0)
            {
                _bookingstatus = "";
            }
            else if (BookingSTATUS_ComboBox.SelectedIndex == 1)
            {
                _bookingstatus = "true";
            }
            else if (BookingSTATUS_ComboBox.SelectedIndex == 2)
            {
                _bookingstatus = "false";
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



            WarGrid1.DataSource = WARPRO.Glob.Bookings_And_Payments.Glob_Bookings.Get_Booking_Table_DataFOrGrid(BookingID_Txt.Text, _ReferenceType, ReferenceCode_ID_Txt.Text, _Date, PackageCode_Txt.Text, ForNoOfPersons_Txt.Text, Bill_ID_Txt.Text, _bookingstatus);
            WarGrid1.Columns[1].Visible = false;
            WarGrid1.Columns[7].Visible = false;


        }

        private void BookingID_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13;

        }

        private void BookingID_Txt_KeyDown(object sender, KeyEventArgs e)
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
                BookingInfoUI bk = new BookingInfoUI(long.Parse(value));
                bk.ShowDialog();
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
                

                //BookingInfoUI b = new BookingInfoUI(long.Parse(value));
                //b.ShowDialog();
            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 3)
            {

            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 4)
            {
                PackageUI bk = new PackageUI(long.Parse(value));
                bk.ShowDialog();
            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 5)
            {

            }
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 6)
            {
                // long bookingidrec = long.Parse(  WarGrid1.SelectedRows[0].Cells[0].Value.ToString());
                var bookingidrec = long.Parse(WarGrid1.Rows[WarGrid1.SelectedCells[0].RowIndex].Cells[6].Value.ToString());

                PrintUI bk = new PrintUI(bookingidrec);
                bk.ShowDialog();
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
