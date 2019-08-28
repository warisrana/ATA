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
    public partial class ProtectorGridUI : WarFramework.Forms.WarForm
    {
        public ProtectorGridUI()
        {
            InitializeComponent();
        }


        internal void LoadData()
        {
            WarGrid1.DataSource = WARPRO.Glob.CustomersAndAgents.Glob_Protector.Get_Protector_Table_DataFOrGrid(VisaNo_Txt.Text, CustomerID_Txt.Text);

            //WarGrid1.Columns[0].Visible = false;
            //WarGrid1.Columns[6].Visible = false;
            //WarGrid1.Columns[7].Visible = false;

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
                long ss =long.Parse( WarGrid1.Rows[WarGrid1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                ProtectorUI bk = new ProtectorUI(ss);
                bk.ShowDialog();

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

        private void CustomerID_Txt_KeyDown(object sender, KeyEventArgs e)
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
    }
}


