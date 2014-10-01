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

        
        public Structs.conta_a_pagar[] GetContasaPagar()
        {
            List<Structs.conta_a_pagar> ret = new List<Structs.conta_a_pagar>();

            using(SqlDataReader dr = new SqlCommand("SELECT * FROM Contas_a_Pagar", conn).ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Structs.conta_a_pagar item = new Structs.conta_a_pagar();

                        /*
                         * GetColumn<string>(1)
                         * Pega a coluna 1 (que é a segunda), que é do tipo string (varchar = string)
                         */

                        item.Conta = dr.GetColumn<string>(1);
                        item.Valor = dr.GetColumn<decimal>(2);

                        ret.Add(item);
                    }
                }
            }

            return ret.ToArray();
        }



        public Structs.conta_a_receber[] GetContasaReceber()
        {
            List<Structs.conta_a_receber> ret = new List<Structs.conta_a_receber>();

            using(SqlDataReader dr = new SqlCommand("SELECT * FROM Contas_a_Receber", conn).ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Structs.conta_a_receber item = new Structs.conta_a_receber();

                        item.Conta = dr.GetColumn<string>(1);
                        item.Valor = dr.GetColumn<float>(2);

                        ret.Add(item);
                    }
                }
            }
            return ret.ToArray();
        }

        public enum loginReturn
        {
            WRONG_PASS,
            INVALID_USER,
            SUCCESS
        }

        public loginReturn login(string user, string pass)
        {
            using(SqlDataReader r = new SqlCommand("SELECT * FROM Usuarios WHERE Usuario = '" + user + "'", conn).ExecuteReader())
            {
                if(r.HasRows)
                {
                    r.Read();

                    string _password = r.GetColumn<string>(2);

                    if (pass == _password)
                        return loginReturn.SUCCESS;
                    else
                        return loginReturn.WRONG_PASS;
                }
                else
                {
                    return loginReturn.INVALID_USER;
                }
            }
        }
    }
}
