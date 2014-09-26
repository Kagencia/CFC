using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CFC
{
    public class conexao
    {
          //Conecta no banco
            SqlConnection conn = new SqlConnection(
            @"Data Source=Klaus;
            AttachDbFilename=cfcdb.mdf;
            Integrated Security=True;
            Connect Timeout=30;
            User Instance=True"
            );

        
    }
}
