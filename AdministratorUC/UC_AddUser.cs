using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.AdministratorUC
{
    public partial class UC_AddUser : UserControl
    {
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            txtName.Clear();
            DateTimePickerDOB.ResetText();
            txtMobile.Clear();
            txtEmail.Clear();
            txtusername.Clear();
            txtPassword.Clear();
            cmbUserRole.SelectedIndex = -1;
        }

        private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String userRole = cmbUserRole.Text;
            String name = txtName.Text;
            String dob = DateTimePickerDOB.Text;
            String mobile = txtMobile.Text;
            String email = txtEmail.Text;
            String username = txtusername.Text;
            String pass = txtPassword.Text;

            try
            {
                DataSet ds = Connection.GetData("Insert into mst_adduser (userRole, name, dob, mobile, email, username, pass) values ('" + userRole + "', '" + name + "', '" + dob + "', '" + mobile + "', '" + email + "', '" + username + "', '" + pass + "') ");
                MessageBox.Show("SignUp Successfull..");
            }
            catch (Exception)
            {
                MessageBox.Show("Username already exists..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select * from mst_adduser where username = '" + txtusername.Text + "' ");
            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"D:\Align Project\Pharmacy_Management_System\img\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"D:\Align Project\Pharmacy_Management_System\img\no.png";
            }
        }
    }
}
