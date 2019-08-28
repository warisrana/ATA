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
using com_war_air.com.WARPRO.WARUI.Agents;

namespace com_war_air.com.WARUI.Agents_Customers
{
    public partial class CustomerGridUI : WarFramework.Forms.WarForm
    {
        public CustomerGridUI()
        {
            InitializeComponent();
        }


        int SearchFor;

        private void CustomerGridUI_Load(object sender, EventArgs e)
        {
            STATUS_ComboBox.Hide();
            SearchFor = 1;
            Customer_Radio.Checked = true;
        }

        private void WarButton1_Click(object sender, EventArgs e)
        {
            //CustomersAndAgents_class.Table_Adapter_Cust.FillBy_Search_CustomerTable(CustomersAndAgents_class.dataSet_CustomersAndAgents_appdata.Customers,
            //                        WarTextBox1.Text,
            //                        WarTextBox2.Text,
            //                        WarTextBox3.Text,
            //                        WarTextBox4.Text,
            //                        WarTextBox5.Text,
            //                        WarTextBox6.Text,
            //                        WarTextBox7.Text,
            //                        WarTextBox8.Text,
            //                        WarTextBox9.Text

            //                        );
            MessageBox.Show(CustomersAndAgents_class.dataSet_CustomersAndAgents_appdata.Customers.Rows.Count.ToString());

            //WarGrid1.DataSource = WARPRO.Glob.CustomersAndAgents.CustomersAndAgents_class.Get_Customer_Table_DataFOrGrid(


            //                        WarTextBox1.Text,
            //                        WarTextBox2.Text,
            //                        WarTextBox3.Text,
            //                        WarTextBox4.Text,
            //                        WarTextBox5.Text,
            //                        WarTextBox6.Text,
            //                        WarTextBox7.Text,
            //                        WarTextBox8.Text,
            //                        WarTextBox9.Text
            //                                            );
        }



        private void Customer_Radio_Click(object sender, EventArgs e)
        {
            try
            {
                SearchFor = 1;

                EXTRA_DETAILS_Txt.Show();
                PASSPORT_NO_Txt.Show();

                STATUS_ComboBox.Hide();

                LoadData();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void Agent_Radio_Click(object sender, EventArgs e)
        {
            try
            {

                SearchFor = 2;

                EXTRA_DETAILS_Txt.Hide();
                PASSPORT_NO_Txt.Hide();

                STATUS_ComboBox.Show();

                LoadData();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ID_Txt_KeyPress(object sender, KeyPressEventArgs e)
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


            if (SearchFor == 1)
            {
                WarGrid1.DataSource = WARPRO.Glob.CustomersAndAgents.CustomersAndAgents_class.Get_Customer_Table_DataFOrGrid(ID_Txt.Text, FIRST_NAME_Txt.Text, LAST_NAME_Txt.Text, Address_Txt.Text, MOBILE_NO_Txt.Text, EMAIL_Txt.Text, EXTRA_DETAILS_Txt.Text, Date , PASSPORT_NO_Txt.Text);
                WarGrid1.Columns[7].Visible = false;
                WarGrid1.Columns[11].Visible = false;
            }

            else if (SearchFor == 2)
            {

                WarGrid1.DataSource = WARPRO.Glob.CustomersAndAgents.Agents_Partial.Get_Agent_Table_DataFOrGrid(ID_Txt.Text, FIRST_NAME_Txt.Text, LAST_NAME_Txt.Text, Address_Txt.Text, MOBILE_NO_Txt.Text, EMAIL_Txt.Text, Date, Status);
                WarGrid1.Columns[6].Visible = false;
                WarGrid1.Columns[8].Visible = false;

            }


        }



        internal void Cellcliick()
        {
            var value = WarGrid1.SelectedCells[0].Value.ToString();
           // var referencetype = Convert.ToInt32(WarGrid1.SelectedRows[0].Cells[1].Value.ToString());

            if (WarGrid1.SelectedCells[0].ColumnIndex == 0)
            {
                if (SearchFor == 1)
                {
                    CustomerUI bk = new CustomerUI(long.Parse(value));
                    bk.ShowDialog();
                }
                else if (SearchFor == 2)
                {
                    AgentUI bk = new AgentUI(long.Parse(value));
                    bk.ShowDialog();
                }

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
            else if (WarGrid1.SelectedCells[0].ColumnIndex == 10)
            {
                long v = long.Parse(value);
                if (v > 50000)
                {
                    AgentUI bk = new AgentUI(long.Parse(value));
                    bk.ShowDialog();
                }

            }
        }



        private void ID_Txt_KeyDown(object sender, KeyEventArgs e)
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
