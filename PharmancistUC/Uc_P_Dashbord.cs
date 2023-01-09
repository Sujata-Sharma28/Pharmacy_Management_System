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
    public partial class Uc_P_Dashbord : UserControl
    {
        Int64 count;
        public Uc_P_Dashbord()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Uc_P_Dashbord_Load(object sender, EventArgs e)
        {
            loadChart();
        }
        public void loadChart()
        {
            DataSet ds = Connection.GetData("select count(mname) from mst_medic Where eDate >= NOW()");
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Valid Medicines"].Points.AddXY("Medicine Validity Chart", count);
            DataSet ds1 = Connection.GetData("Select count(mname) from mst_medic where eDate <= NOW()");
            count = Int64.Parse(ds1.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Expired Medicines"].Points.AddXY("Medicine Validity Chart", count);
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            chart1.Series["Valid Medicines"].Points.Clear();
            chart1.Series["Expired Medicines"].Points.Clear();
            loadChart();
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
