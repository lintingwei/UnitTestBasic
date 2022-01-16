using System;
using System.Data;
using System.Data.SqlClient;

namespace UnitTestBasic
{
    public class Logger : ILogger
    {
        public void LogToDb(string message)
        {
            using var conn = new SqlConnection("Data Source=.;Initial Catalog=LogDb;Persist Security Info=True;User ID=N_Logger;Password=log123;Pooling=true;min pool size=4;max pool size=32;");
            conn.Open();

            using var cmd = new SqlCommand("dbo.LogMessage", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters["@message"].Value = message;
            cmd.ExecuteNonQuery();
        }
    }
}