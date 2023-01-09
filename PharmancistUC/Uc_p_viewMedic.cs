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
    public partial class Uc_p_viewMedic : UserControl
    {
        
        public Uc_p_viewMedic()
        {
            InitializeComponent();
        }

        private void Uc_p_viewMedic_Load(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select * from mst_medic");
            DGVMedicView.DataSource = ds.Tables[0];


        }

        private void txtMedcName_TextChanged(object sender, EventArgs e)
        {

            DataSet ds = Connection.GetData("Select * from mst_medic where mname like '" + txtMedcName.Text + "%' ");
            DGVMedicView.DataSource = ds.Tables[0];
        }
        String MedicineId;

        private void DGVMedicView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MedicineId = DGVMedicView.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

           
                if (MessageBox.Show("Are you Sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                   
                        DataSet ds = Connection.GetData("delete from mst_medic where mid = '" + MedicineId + "' ");
                        MessageBox.Show("User Record Deleted. ");
                        Uc_p_viewMedic_Load(this, null);
                    
                }
            
            else
            {
                MessageBox.Show("You are tring to delete \n Your own Profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Uc_p_viewMedic_Load(this, null);
        }
    }
}
