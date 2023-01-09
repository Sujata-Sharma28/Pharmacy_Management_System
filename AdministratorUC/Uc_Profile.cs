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
    public partial class Uc_Profile : UserControl
    {
        public Uc_Profile()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { lblusername.Text = value; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String role = cmbUserRole.Text;
            String name = txtName.Text;
            String dob = DateTimePickerDOB.Text;
            String mobile = txtMobile.Text;
            String email = txtEmail.Text;
            String username = lblusername.Text;
            String pass = txtPassword.Text;
            String error = Connection.SetData("Update mst_adduser set userRole = '" + role + "', name ='" + name + "', dob = '" + dob + "', mobile ='" + mobile + "', email = '" + email + "' , pass = '" + pass + "' where username ='" + username + "' ");
            if (error == "")
            {
               
                MessageBox.Show("Data Updation Successfull...");
               
            }
            else
            {
                MessageBox.Show("Error in updating: " + error);
            }
        }

        private void Uc_Profile_Enter(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select * from mst_adduser where username = '" + lblusername.Text + "'");
            cmbUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            DateTimePickerDOB.Text = ds.Tables[0].Rows[0][3].ToString();
            txtMobile.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtusername.Text = ds.Tables[0].Rows[0][6].ToString();
            txtPassword.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           Uc_Profile_Enter(this, null);
            //ClearAll();
        }

        private void Uc_Profile_Load(object sender, EventArgs e)
        {

        }
        //public void ClearAll()
        //{
        //    cmbUserRole.SelectedIndex = -1;
        //    txtName.Clear();
        //    DateTimePickerDOB.ResetText();
        //    txtMobile.Clear();
        //    txtEmail.Clear();
        //    txtusername.Clear();
        //    txtPassword.Clear();

        //}
    }
}
