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
    public partial class VerifyForm : Form
    {
        public VerifyForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtUsername.Focus();
        }

        private void lblSend_Click(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select * FROM mst_user Where user_name = '" + txtUsername.Text + " ' and email = '" + txtEmail.Text + " '");
            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Invalid Username or Email  , Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsername.Text = "";
                //txtPhone.Text = "";
                txtEmail.Text = "";
                txtUsername.Focus();


            }
            else
            {
                this.Hide();
                new ChangeYourPassword(txtUsername.Text).Show();
            }
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
