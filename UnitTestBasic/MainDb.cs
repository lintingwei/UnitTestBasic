using System.Data;
using System.Data.SqlClient;

namespace UnitTestBasic
{
    public class MainDb
    {
        public static DataTable GetPasswordBy(string username)
        {
            using var conn = new SqlConnection("Data Source=.;Initial Catalog=LogDb;Persist Security Info=True;User ID=N_Logger;Password=log123;Pooling=true;min pool size=4;max pool size=32;");
            conn.Open();

            using var cmd = new SqlCommand("dbo.GetPasswordByUsername", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters["@username"].Value = username;
            using SqlDataReader dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
    }
}