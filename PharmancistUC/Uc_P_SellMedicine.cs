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
    public partial class Uc_P_SellMedicine : UserControl
    {
        public Uc_P_SellMedicine()
        {
            InitializeComponent();
        }

        private void Uc_P_SellMedicine_Load(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            DataSet ds = Connection.GetData("Select mname from mst_medic where eDate >= NOW() and quantity > '0' ");
            for(int i=0; i<ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Uc_P_SellMedicine_Load(this, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            DataSet ds = Connection.GetData("select mname from mst_medic where mname like '" + txtSearch.Text + "%' and eDate >= NOW() and quantity >'0' ");
            for(int i=0; i<ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoOfUnits.Clear();
            String name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);
            txtMedicineName.Text = name;
            DataSet ds = Connection.GetData("Select mid, edate, perunit from mst_medic where mname = '" + name + "' ");
            txtMedicineId.Text = ds.Tables[0].Rows[0][0].ToString();
            dtpExpire.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtNoOfUnits_TextChanged(object sender, EventArgs e)
        {
            if(txtNoOfUnits.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtPricePerUnit.Text);
                Int64 noOfUnit = Int64.Parse(txtNoOfUnits.Text);
                Int64 totalAmount = unitPrice * noOfUnit;
                txtTotalPrice.Text = totalAmount.ToString();
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(txtMedicineId.Text != "")
            {
                DataSet ds = Connection.GetData("Select quantity from mst_medic where mid = '" + txtMedicineId.Text + "' ");
                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtNoOfUnits.Text);

                if(newQuantity >= 0)
                {
                    n = dgvSellMedicine.Rows.Add();
                    dgvSellMedicine.Rows[n].Cells[0].Value = txtMedicineId.Text;
                    dgvSellMedicine.Rows[n].Cells[1].Value = txtMedicineName.Text;
                    dgvSellMedicine.Rows[n].Cells[2].Value = dtpExpire.Text;
                    dgvSellMedicine.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                    dgvSellMedicine.Rows[n].Cells[4].Value = txtNoOfUnits.Text;
                    dgvSellMedicine.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                    totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                    lblTotal.Text = "Rs. " + totalAmount.ToString();

                    DataSet ds1 = Connection.GetData("Update mst_medic set quantity = '" + newQuantity + "' where mid = '" + txtMedicineId.Text + "' ");
                    MessageBox.Show("Medicine Added..");
                }

                else
                {
                    MessageBox.Show("Medicine is out of stock.\n Only " +quantity+ " Left", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                Uc_P_SellMedicine_Load(this, null);

            }
            else
            {
                MessageBox.Show("Select Medicine First", "Information!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        int valueAmount;
        String valueId;
        protected Int64 noOfUnit;
        private void dgvSellMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                valueAmount = int.Parse(dgvSellMedicine.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = dgvSellMedicine.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnit = Int64.Parse(dgvSellMedicine.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch(Exception)
            {

            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(valueId != null)
            {
                try
                {
                    dgvSellMedicine.Rows.RemoveAt(this.dgvSellMedicine.SelectedRows[0].Index);
                }
                catch(Exception)
                {

                }
                finally
                {
                    DataSet ds = Connection.GetData("Select quantity from mst_medic where mid = '" + valueId + "' ");
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfUnit;

                    DataSet ds1 = Connection.GetData("Update mst_medic set quantity = '" + newQuantity + "' where mid = '" + valueId + "' ");
                    MessageBox.Show("Medicine Removed From Cart..");
                    totalAmount = totalAmount - valueAmount;
                    lblTotal.Text = "Rs. " + totalAmount.ToString();
                }
                Uc_P_SellMedicine_Load(this, null);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           // DGVPrinter print = new DGVPrinter();
        }
        private void clearAll()
        {
            txtMedicineId.Clear();
            txtMedicineName.Clear();
            dtpExpire.ResetText();
            txtPricePerUnit.Clear();
            txtNoOfUnits.Clear();
        }
    }
}
