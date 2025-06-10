using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ApartmanOtomasyon
{
    internal class SqlHelper
    {
        public string ConnectionString { get; set; }
        public SqlConnection Connection { get; set; }

        public SqlHelper()
        {
            ConnectionString = @"Data Source=DESKTOP-K1AL95H\SQLEXPRESS;Initial Catalog=apartman;TrustServerCertificate=True;Integrated Security=True;";
            Connection = new SqlConnection(ConnectionString);
        }

        public void ExecuteProc(string procName, params SqlParameter[] ps)
        {
            using (SqlCommand command = new SqlCommand(procName, Connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(ps);

                try
                {
                    Connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (Connection.State == ConnectionState.Open)
                        Connection.Close();
                }
            }
        }

        public DataTable GetTable(string query)
        {
            using (SqlDataAdapter sda = new SqlDataAdapter(query, ConnectionString))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        }
    }
}
