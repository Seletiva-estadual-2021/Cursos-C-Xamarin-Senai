using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula_1.interfaces;

namespace Aula_1.implementacoes
{
    class CartaoCredito : MeioPagamento
    {
        public double pagar(double valor)
        {
            Console.WriteLine("Credito");
            return valor * 1.10;
        }
    }
}
