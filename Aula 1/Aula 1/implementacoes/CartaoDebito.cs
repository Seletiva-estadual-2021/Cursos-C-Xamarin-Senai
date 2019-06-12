using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula_1.interfaces;

namespace Aula_1.implementacoes
{
    class CartaoDebito : MeioPagamento
    {
        public double pagar(double valor)
        {
            Console.WriteLine("Débito");
            //10% de desconto
            return valor * 0.9;
        }
    }
}
