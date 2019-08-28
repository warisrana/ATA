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

namespace com_war_air.com.WARUI.Bookings_Payments
{
    public partial class SaudiVisaStampGridUI : WarFramework.Forms.WarForm
    {
        public SaudiVisaStampGridUI()
        {
            InitializeComponent();
        }


        internal void Cellcliick()
        {
            var value = WarGrid1.SelectedCells[0].Value.ToString();

            if (WarGrid1.SelectedCells[0].ColumnIndex == 1)
            {

                CustomerUI bk = new CustomerUI(long.Parse(value));
                bk.ShowDialog();
            }

            else
            {
                string pnr = WarGrid1.Rows[WarGrid1.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                SaudiVisaStampUI bk = new SaudiVisaStampUI(pnr);
                bk.ShowDialog();

            }

        }

        internal void LoadData()
        {


            WarGrid1.DataSource = WARPRO.Glob.CustomersAndAgents.Glob_SaudiVisaStamp.Get_SaudiVisaStamp_Table_DataFOrGrid(VisaNo_Txt.Text, CustomerID_Txt.Text);

            WarGrid1.Columns[0].Visible = false;
            WarGrid1.Columns[6].Visible = false;
            WarGrid1.Columns[7].Visible = false;


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

        private void VisaNo_Txt_KeyDown(object sender, KeyEventArgs e)
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

        private void CustomerID_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13;

        }
    }
}
