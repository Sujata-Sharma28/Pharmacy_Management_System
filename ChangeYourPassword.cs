using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class ChangeYourPassword : Form
    {
        string m_user_name = "";
        public ChangeYourPassword(String username)
        {
            InitializeComponent();
            m_user_name = username;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPass.Text)
            {
                //String error = Connection.SetData("Insert into mst_user(password) values ('" + txtNewPassword + "')");
                //tring error = Connection.SetData("Update mst_user Set password = '" + txtNewPassword.Text + "' where user_name = " + m_user_name + "'");
                String error = Connection.SetData("Update mst_user Set password = '" + txtPassword.Text + "' where user_name = '" + m_user_name + "'");
                txtPassword.Text = "";
                txtConfirmPass.Text = "";
                txtPassword.Focus();

                MessageBox.Show("Reset Successfully");
            }
            else
            {
                MessageBox.Show("The new password do not match so enter same password");
            }
        }
    }
}
