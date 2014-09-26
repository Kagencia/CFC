using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFC
{
    public static class ExtensionMethods
    {

        /*
         * é um método de extensão,assim eu posso utilizar a partir do '.'
         * em vez de fazer GetColumn(....)
         * eu posso fazer minhaVariael.GetColumn
         * Mas eu só posso fazer com variaveis do tipo SqlDataReader
         * 'this' significa que é um método de extensão
         * 
         * <T> 'T' é um tipo de dado (qualquer) tipo int,float,MeuProprpoTipo,Etcetc...
         * é um método que retorna o tipo de dado T que vai ser casteado
         * 
         * column é a coluna da tabela
         */

        public static T GetColumn<T>(this SqlDataReader r, int column, bool read = false)
        {
            if (read)
                r.Read();

            object _obj = r[column];

            if (typeof(T) == typeof(float))
                _obj = Convert.ToSingle(_obj);

            return (T)_obj;
        }

    }
}
