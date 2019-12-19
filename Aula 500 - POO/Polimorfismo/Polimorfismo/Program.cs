using Polimorfismo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dinheiro dinheiro = new Dinheiro();
            dinheiro.valor = 100;

            Cheque cheque = new Cheque();
            cheque.valor = 100;

            Credito credito = new Credito();
            credito.valor = 100;

            Debito debito = new Debito();
            debito.valor = 100;

            List<FormaPagamento> pagtos = new List<FormaPagamento>();
            pagtos.Add(dinheiro);
            pagtos.Add(cheque);
            pagtos.Add(credito);
            pagtos.Add(debito);

            pagtos.ForEach(pagto => {
                Console.WriteLine($"Forma de pagamento: {pagto.GetType().Name}\n" +
                    $"Valor: {pagto.calcularValor()}");
            });
        }
    }
}
