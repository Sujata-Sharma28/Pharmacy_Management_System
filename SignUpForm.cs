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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
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
            txtMobileNo.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtConfirmPass.Text = "";
            txtUsername.Focus();
        }

        private void btnRgister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConfirmPass.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else if (txtPassword.Text == txtConfirmPass.Text)
            {
                String error = Connection.SetData("Insert into mst_user (user_name, phone_no, email, password) values ('" + txtUsername.Text + "', '" + txtMobileNo.Text + "', '" + txtEmail.Text + "','" + txtPassword.Text + "')");
                txtUsername.Text = "";
                txtMobileNo.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                txtConfirmPass.Text = "";

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password does not Match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConfirmPass.Text = "";
                txtPassword.Focus();

            }
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPass.PasswordChar = '*';
            }
        }
    }
}
