using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class BackUpDAL
    {
        public void BackUp(String Path)
        {
            String Cstr = "Data Source=.;Initial Catalog = StoreMarketDB;Integrated Security = true";
            SqlConnection connection = new SqlConnection(Cstr);
            connection.Open();
            SqlCommand commond = new SqlCommand();
            commond.Connection = connection;
            commond.CommandText = @"backup database StoreMarketDB to disk ='" + Path + @"\BackUpDB.bak'";
            commond.ExecuteNonQuery();
            connection.Close();
        }

        public void Restore(String Path)
        {
            String Cstr = "Data Source=.;Initial Catalog = model;Integrated Security = true";
            SqlConnection connection = new SqlConnection(Cstr);
            connection.Open();
            SqlCommand commond = new SqlCommand();
            commond.Connection = connection;
            commond.CommandText = "ALTER DATABASE StoreMarketDB SET OFFLINE WITH ROLLBACK IMMEDIATE";
            commond.ExecuteNonQuery();
            commond.CommandText = @"RESTORE DATABASE StoreMarketDB FROM DISK='" + Path + "' WITH REPLACE";
            commond.ExecuteNonQuery();
            commond.CommandText = "ALTER DATABASE StoreMarketDB SET ONLINE";
            commond.ExecuteNonQuery();
            connection.Close();
        }

    }
}
