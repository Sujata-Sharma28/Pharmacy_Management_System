using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.PharmancistUC
{
    public partial class Uc_P_ValidityCheck : UserControl
    {
        public Uc_P_ValidityCheck()
        {
            InitializeComponent();
        }

        private void cmbCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCheck.SelectedIndex == 0)
            {
                DataSet ds = Connection.GetData("Select * from mst_medic where eDate >= NOW()");
                dgvValidityCheck.DataSource = ds.Tables[0];
                lblSet.Text = "Valid Medicines";
                lblSet.ForeColor = Color.Black;
            }
            else if (cmbCheck.SelectedIndex == 1)
            {
                DataSet ds = Connection.GetData("Select * from mst_medic where eDate <= NOW()");
                dgvValidityCheck.DataSource = ds.Tables[0];
                lblSet.Text = "Expired Medicines";
                lblSet.ForeColor = Color.Red;
            }
            else if (cmbCheck.SelectedIndex == 2)
            {
                DataSet ds = Connection.GetData("Select * from mst_medic ");
                dgvValidityCheck.DataSource = ds.Tables[0];
                lblSet.Text = "";
                lblSet.ForeColor = Color.Black;
            }
            //private setDataGridView(String query, String labelname, Color col)
            //{

            //}
        }
        private void Uc_P_ValidityCheck_Load(object sender, EventArgs e)
        {
            lblSet.Text = "";
        }
    }
}


