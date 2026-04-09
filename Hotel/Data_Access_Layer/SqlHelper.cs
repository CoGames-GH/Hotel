
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Hotel.Data_Access_Layer
{
    public static class SqlHelper
{
        private static readonly string ConnStr = "Server=" + Environment.MachineName + ";Database=Hotel;Integrated Security=SSPI;";

    public static DataTable ExecQuery(string sql, params SqlParameter[] prms)
    {
        var dt = new DataTable();
        using (var con = new SqlConnection(ConnStr))
        using (var cmd = new SqlCommand(sql, con))
        {
            if (prms != null) cmd.Parameters.AddRange(prms);
            con.Open();
            dt.Load(cmd.ExecuteReader());
        }
        return dt;
    }

    public static int ExecNonQuery(string sql, params SqlParameter[] prms)
    {
        using (var con = new SqlConnection(ConnStr))
        using (var cmd = new SqlCommand(sql, con))
        {
            if (prms != null) cmd.Parameters.AddRange(prms);
            con.Open();
            return cmd.ExecuteNonQuery();
        }
    }
}
}