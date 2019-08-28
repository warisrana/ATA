using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com_war_air.com.WARUI.Bookings_Payments
{
    public partial class OtherPayableGridUI : WarFramework.Forms.WarForm
    {
        public OtherPayableGridUI()
        {
            InitializeComponent();
        }


        ///////////////////////////// .....
        internal void LoadData()
        {
            
            string _Date = "";
           


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



            WarGrid1.DataSource = WARPRO.Glob.CustomersAndAgents.Glob_OtherPayables.Get_OtherPayable_Table_DataFOrGrid(PaidToName_Txt.Text, _Date);
           
        }

        internal void Cellcliick()
        {
               long ss = long.Parse(WarGrid1.Rows[WarGrid1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());

           // var value = WarGrid1.SelectedCells[0].Value.ToString();

            OtherPayableUI bk = new OtherPayableUI(ss);
               bk.ShowDialog();



            //if (WarGrid1.SelectedCells[0].ColumnIndex == 1)
            //{

            //    CustomerUI bk = new CustomerUI(long.Parse(value));
            //    bk.ShowDialog();
            //}

            //else
            //{
            //    long ss = long.Parse(WarGrid1.Rows[WarGrid1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            //    ProtectorUI bk = new ProtectorUI(ss);
            //    bk.ShowDialog();

            //}

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

        private void PaidToName_Txt_KeyDown(object sender, KeyEventArgs e)
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
    }
}
