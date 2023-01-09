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
    public partial class Uc_P_ModifyMedicine : UserControl
    {
        Int64 totalQuantity;
        public Uc_P_ModifyMedicine()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtmedicineID.Text!="")
            {
                DataSet ds = Connection.GetData("Select * from mst_medic where mid = '" + txtmedicineID.Text + "' ");
                if(ds.Tables[0].Rows.Count != 0)
                {
                    txtMedicineName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedicineNumber.Text = ds.Tables[0].Rows[0][3].ToString();
                    dtpManfuDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    dtpExpireDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtAvaiQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPrice.Text = ds.Tables[0].Rows[0][7].ToString();

                }
                else
                {
                    MessageBox.Show("No Medicine with ID : " + txtmedicineID.Text + " exist.", "Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
        }
        private void clearAll()
        {
            txtmedicineID.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            dtpManfuDate.ResetText();
            dtpExpireDate.ResetText();
            txtAvaiQuantity.Clear();
            txtPrice.Clear();
            if(txtAvaiQuantity.Text != "0")
            {
                txtAvaiQuantity.Text = "0";
            }
            else
            {
                txtAvaiQuantity.Text = "0";
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
            String mname = txtMedicineName.Text;
            String mnumber = txtMedicineNumber.Text;
            String mdate = dtpManfuDate.Text;
            String edate = dtpExpireDate.Text;
            Int64 quantity = Int64.Parse(txtAvaiQuantity.Text);
            Int64 Addquantity = Int64.Parse(txtAddQuantity.Text);
            Int64 perunit = Int64.Parse(txtPrice.Text);
            totalQuantity = quantity + Addquantity;
            String error = Connection.SetData("Update mst_medic set mname = '" + mname + "', mnumber ='" + mnumber + "', mDate = '" + mdate + "', eDate ='" + edate + "', quantity = '" + totalQuantity + "' ,perunit = '" + perunit + "' where mid ='" + txtmedicineID.Text + "' ");
            if (error == "")
            {

                MessageBox.Show("Medicine Details Updated Successfull...");

            }
            else
            {
                MessageBox.Show("Error in updating: " + error);
            }

        }

        private void Uc_P_ModifyMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}
