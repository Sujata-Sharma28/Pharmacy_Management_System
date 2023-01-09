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
    public partial class UC_P_AddMedicine : UserControl
    {
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_AddMedicine_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtmedicineID.Text!="" && txtMedicineName.Text!="" && txtMedicineNumber.Text!="" && txtQuantity.Text!="" && txtPrice.Text!="" )
            {

                String mid = txtmedicineID.Text;
                String mname = txtMedicineName.Text;
                String mnumber = txtMedicineNumber.Text;
                String mdate = dtpManfuDate.Text;
                String edate = dtpExpireDate.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perunit = Int64.Parse(txtPrice.Text);

                String error = Connection.SetData("insert into mst_medic (mid,mname,mnumber,mDate,eDate,quantity,perunit) Values ('"+mid+"', '"+mname+"','"+mnumber+"', '"+mdate+ "','"+edate+ "', '"+quantity+ "', '"+perunit+"') ");
                if(error == "" )
                {
                    MessageBox.Show("Medicine Added to Database.");
                }
                else
                {
                    MessageBox.Show("Error in Saving : " + error);
                }
            }
            else
            {
                MessageBox.Show("Enter all Data.","Information", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            txtmedicineID.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            dtpManfuDate.ResetText();
            dtpExpireDate.ResetText();
            txtQuantity.Clear();
            txtPrice.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
