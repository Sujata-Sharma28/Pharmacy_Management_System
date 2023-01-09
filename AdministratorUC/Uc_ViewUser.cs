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
    public partial class Uc_ViewUser : UserControl
    {
        string userName;
        String currentUser = "";
       
        public Uc_ViewUser()
        {
            InitializeComponent();
        }
        public string ID
        {
            set
            {
                currentUser = value;
                
            }
        }

        private void Uc_ViewUser_Load(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select * from mst_adduser");
            DGVView.DataSource = ds.Tables[0];
        }

        private void btnUserName_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select * from mst_adduser where username like '" + txtUserName.Text + "%' ");
            DGVView.DataSource = ds.Tables[0];
        }

        private void DGVView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = DGVView.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(currentUser != userName)
            {
                if(MessageBox.Show("Are you Sure?", "Delete Confirmation !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    if(currentUser != userName)
                    {
                        DataSet ds = Connection.GetData("delete from mst_adduser where username = '" + userName + "' ");
                        MessageBox.Show("User Record Deleted. ");
                        Uc_ViewUser_Load(this, null);
                    }
                }
            }
            else
            {
                MessageBox.Show("You are tring to delete \n Your own Profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Uc_ViewUser_Load(this, null);
        }
    }
}
