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
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        { 
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
           
            DataSet ds = Connection.GetData("Select count(userRole) from mst_adduser where userRole = 'Administrator' ");
            setLabel(ds, lblAdmin);

            DataSet ds1 = Connection.GetData("Select count(userRole) from mst_adduser where userRole = 'Pharmicist' ");
            setLabel(ds1, lblPharm);

            DataSet ds2 = Connection.GetData("Select count(userRole) from mst_adduser where userRole = 'Customer' ");
            setLabel(ds2, lblCustomer);
        }

        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Dashboard_Load(this, null);
        }
    }
}
