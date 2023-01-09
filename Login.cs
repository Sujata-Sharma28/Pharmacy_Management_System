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
    public partial class Login : Form
    {
        //public int logAttempt = 0;
        public Login()
        {
            InitializeComponent();
            //Init_Data();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblForget_Click(object sender, EventArgs e)
        {
            VerifyForm frm = new VerifyForm();
            frm.Show();
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm frm = new SignUpForm();
            frm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }
        public void Reset()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;

        }
        //private void Init_Data()
        //{
        //    if (Properties.Settings.Default.UserName != string.Empty)
        //    {
        //        if (Properties.Settings.Default.remme == "yes")
        //        {
        //            txtUsername.Text = Properties.Settings.Default.UserName;
        //            txtPassword.Text = Properties.Settings.Default.Password;
        //            checkBoxRemember.Checked = true;
        //        }
        //        else
        //        {
        //            txtUsername.Text = Properties.Settings.Default.UserName;


        //        }
        //    }
        //}

        //private void Save_Data()
        //{
        //    if (checkBoxRemember.Checked)
        //    {

        //        Properties.Settings.Default.UserName = txtUsername.Text;
        //        Properties.Settings.Default.Password = txtPassword.Text;
        //        Properties.Settings.Default.remme = "yes";
        //        Properties.Settings.Default.Save();
        //    }
        //    else
        //    {
        //        Properties.Settings.Default.UserName = txtUsername.Text;
        //        Properties.Settings.Default.Password = "";
        //        Properties.Settings.Default.remme = "no";
        //        Properties.Settings.Default.Save();
        //    }
        //}

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select * from mst_adduser ");
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtUsername.Text == "root" && txtPassword.Text == "root")
                {
                    Adminstrator d = new Adminstrator();
                    d.Show();
                    this.Hide();
                }
            }
            else
            {
                DataSet ds1 = Connection.GetData("Select * FROM mst_adduser Where username = '" + txtUsername.Text + " ' and pass = '" + txtPassword.Text + " '");
                if (ds1.Tables[0].Rows.Count != 0)
                {
                    String userRole = ds1.Tables[0].Rows[0][1].ToString();
                    if (userRole == "Administrator")
                    {
                        Adminstrator ad = new Adminstrator(txtUsername.Text);
                        ad.Show();
                        this.Hide();
                    }
                    else if (userRole == "Pharmicist")
                    {
                        Pharmacist pd = new Pharmacist();
                        pd.Show();
                        this.Hide();
                    }
                    else if (userRole == "Customer")
                    {

                    }
                }

                else
                {
                    MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // if(txtUsername.Text == "tushar" && txtPassword.Text == "tushar")
                //{
                //    Dashboard frm = new Dashboard();
                //    frm.Show();
                //    this.Hide();
                //}
                //{
                //    MessageBox.Show("Wrong Username Or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //}

                //**************************************************************************************//
                //    DataSet ds = Connection.GetData("Select * FROM mst_user Where user_name = '" + txtUsername.Text + " ' and password = '" + txtPassword.Text + " '");
                //    if (ds == null ||
                //        ds.Tables.Count <= 0 ||
                //        ds.Tables[0].Rows.Count <= 0)
                //    {
                //        MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        Reset();

                //        //txtUserName.Text = "";
                //        //txtPassword.Text = "";
                //        txtUsername.Focus();
                //        logAttempt += 1;
                //        if (logAttempt == 3)
                //        {
                //            MessageBox.Show("You have exceeded the maximum number of login attempts", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //            txtUsername.Enabled = false;
                //            txtPassword.Enabled = false;
                //            btnSignIn.Enabled = false;
                //        }


                //    }
                //    else
                //    {
                //        Save_Data();
                //        this.Hide();
                //        GeneralFunction.mdiForm = new Dashboard();
                //        GeneralFunction.mdiForm.Show();


                //    }
                //}

                //private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
                //{
                //    if (checkBoxShow.Checked)
                //    {
                //        txtPassword.PasswordChar = '\0';

                //    }
                //    else
                //    {
                //        txtPassword.PasswordChar = '*';

                //    }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
