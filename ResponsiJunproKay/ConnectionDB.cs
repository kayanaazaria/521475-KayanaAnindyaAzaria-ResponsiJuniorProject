using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace ResponsiJunproKay
{
    public abstract class ConnectionDB
    {
        private string connString = "Host=localhost;Username=postgres;Password=usti;Database=ResponsiJunpro";
        protected NpgsqlConnection conn;
        public ConnectionDB()
        {
            conn = new NpgsqlConnection(connString);
        }
        protected void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        protected void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
