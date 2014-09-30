using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFC
{
    public static class Structs
    {

        public sealed class conta_a_pagar
        {
            public int ID;
            public string Conta;
            public decimal Valor;
        }

        public sealed class conta_a_receber
        {
            public int ID;
            public string Conta;
            public float Valor;
        }

    }
}
