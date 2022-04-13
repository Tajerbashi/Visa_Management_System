using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StoreMarket_V1
{
    public class SQLCOMMOND
    {
        public void SQL1()
        {
            string connectionString = "Data Source=.;Initial Catalog=StoreMarketDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand()) // <- error is pointing here
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from aLogInformation where ";

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        // int id = dr["id"]();
                        string FirstName = dr["access"].ToString();
                        string LastName = dr["password"].ToString();
                        string email = dr["status"].ToString();
                        // int userlevel = dr["userlevel"].ToString();

                        MessageBox.Show(FirstName + " " + LastName + " " + email);
                    }
                    dr.Close();
                }
            }
        }
    }
}
