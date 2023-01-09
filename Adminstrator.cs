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
    public partial class Adminstrator : Form
    {
        String user = "";
       
        public Adminstrator()
        {
            InitializeComponent();
           
        }
        public Adminstrator(String username)
        {
            InitializeComponent();
            lblusername.Text = user;
            lblusername.Text = user;
            user = username;
            uc_ViewUser1.ID = ID;
            uc_Profile1.ID = ID;
        }
        public string ID
        {
            get
            {
                return user.ToString();
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

       
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uc_ViewUser1.Visible = true;
            uc_ViewUser1.BringToFront();
        }

        private void Adminstrator_Load_1(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_AddUser1.Visible = false;
            uc_ViewUser1.Visible = false;
            uc_Profile1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uc_Profile1.Visible = true;
            uc_Profile1.BringToFront();
        }
    }
}
