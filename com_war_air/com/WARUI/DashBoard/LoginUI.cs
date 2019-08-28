using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com_war_air.com.WARUI.DashBoard
{
    public partial class LoginUI : WarFramework.Forms.WarForm
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {

                MessageBox.Show("Please enter your username.".ToUpper(), "Message".ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {

                if (string.IsNullOrWhiteSpace(txtUser.Text))
                {

                    MessageBox.Show("Please enter your username.".ToUpper(), "Message".ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Please enter your Password.".ToUpper(), "Message".ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }
            }

            try
            {



                if (txtUser.Text.ToLower() == "userzee1" && txtPassword.Text == "77712aZqA")
                {
                    // MessageBox.Show("you have been successfuly logged in.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // code process login here
                    this.Hide();
                    this.Enabled = false;

                    DashBoardUI f = new DashBoardUI();
                    f.Show();


                    //Application.OpenForms["Form3"].Close();

                }


                else
                {

                    MessageBox.Show("Your username or password is incorrect.".ToUpper(), "Message".ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Text = "";
                    txtUser.Text = "";
                    txtUser.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
//set password
                if (txtPassword.Text == "")
                {
                    ConnectionsUI cc = new ConnectionsUI();
                    cc.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
