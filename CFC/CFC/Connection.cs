using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFC
{
    public sealed class Connection
    {

        private SqlConnection conn;

        public Connection(string connectionString)
        {
            Connection conn = new Connection(connectionString);
        }

        private bool isConnected()
        {
            return conn.State == System.Data.ConnectionState.Open;
        }

        public bool Connect()
        {
            try
            {
                if (isConnected())
                    return true;

                conn.Open();
                return true;
            }catch(Exception)
            {
                return false;
            }
        }

        

    }
}
