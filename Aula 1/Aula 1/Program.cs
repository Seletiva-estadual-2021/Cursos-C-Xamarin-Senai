using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula_1.model;
using Aula_1.implementacoes;
using Aula_1.interfaces;

namespace Aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa william = new Pessoa();
            william.Nome = "William Chenta";
            Console.WriteLine(william.ToString());

            MeioPagamento debito = new CartaoDebito();
            Console.WriteLine(debito.pagar(150.00));

            MeioPagamento credito = new CartaoCredito();
            Console.WriteLine(credito.pagar(150.00));

            Console.ReadLine();
        }
    }
}
