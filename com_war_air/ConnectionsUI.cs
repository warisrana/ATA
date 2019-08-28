using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com_war_air
{
    public partial class ConnectionsUI : WarFramework.Forms.WarForm
    {
        public ConnectionsUI()
        {
            InitializeComponent();
        }

        private void ConnectionsUI_Load(object sender, EventArgs e)
        {
            //Add server name to combobox
            cboServer.Items.Add(".");
            cboServer.Items.Add("(local)");
            cboServer.Items.Add(@".\SQLEXPRESS");
            cboServer.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cboServer.SelectedIndex = 3;
            txtDatabase.AutoCompleteCustomSource.Add("Customers__And_Agents");
            txtDatabase.AutoCompleteCustomSource.Add("Bookings_And_Payments");
            txtDatabase.AutoCompleteCustomSource.Add("Packages");

            



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Set connection string
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    //setting.SaveConnectionString("cn", connectionString);
                    setting.SaveConnectionString("com_war_air.Properties.Settings." + NameConCOmboTxt.Text+ "ConnectionString", connectionString);

                    MessageBox.Show("Your connection string has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                    MessageBox.Show("Test connection succeeded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
