using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Model
{
    class Debito:FormaPagamento
    {
        public Debito()
        {
            desconto = 8;
        }

        public override double calcularValor()
        {
            return valor - ((valor * desconto) / 100);
        }
    }
}
