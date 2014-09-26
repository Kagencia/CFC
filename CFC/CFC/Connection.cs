using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFC;

namespace CFC
{
    public sealed class Connection
    {

        private SqlConnection conn;

        public Connection(string connectionString)
        {
            conn = new SqlConnection(connectionString);
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

        
        public Structs.Item[] GetItems()
        {
            List<Structs.Item> ret = new List<Structs.Item>();

            using(SqlDataReader dr = new SqlCommand("SELECT * FROM tabela", conn).ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Structs.Item item = new Structs.Item();

                        /*
                         * GetColumn<string>(1)
                         * Pega a coluna 1 (que é a segunda), que é do tipo string (varchar = string)
                         */

                        item.Conta = dr.GetColumn<string>(1);
                        item.Valor = dr.GetColumn<float>(2);

                        ret.Add(item);
                    }
                }
            }

            return ret.ToArray();
        }

       /* public string outrometodo()
        {
            using(SqlDataReader r = new SqlCommand("SELECT * .......", conn).ExecuteReader())
            {
                
            }
        }*/
    }
}
