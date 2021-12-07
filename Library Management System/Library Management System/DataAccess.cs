using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public static class DataAccess
    {
        private static string conString = "Data Source=DESKTOP-D7E5QRU\\BILASH;Initial Catalog=Library_Management_System;User ID=sa;Password=1234";

        public static DataTable LoadData(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                return dt;
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }

        public static int ExecuteQuery(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                int row = cmd.ExecuteNonQuery();
                return row;
            }
            catch (Exception)
            {
                return -1;
            }
        }

       public static int InsertDataImage(string query, byte[] images)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int N = cmd.ExecuteNonQuery();
                con.Close();

                return N;
            }
            catch (Exception)
            {

                return -1;
            }
        }

    }
}
