using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Pharmacy_Management_System
{
    internal static class Connection
    {
        static MySqlConnection con = null;
        private static bool OpenConnection()
        {
            string conn_string = "server=localhost;port=3306;Database=pharmacydb;uid=root;password=mysql;";
            con = new MySqlConnection(conn_string);
            try
            {
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                System.Windows.Forms.MessageBox.Show("Unable to connect with database: " + ex.Message);
            }
        }
        internal static DataSet GetData(String query)
        {
            if (OpenConnection() == false)
            {
                return null;
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in query: " + ex.Message);
                return null;
            }
        }
        internal static string SetData(string query)
        {
            if (OpenConnection() == false)
            {
                return "Unable to connect with database";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                return "";
            }
            catch (Exception ex)
            {
                return "Exception in Query " + ex.Message;
            }
        }
    }
}
 