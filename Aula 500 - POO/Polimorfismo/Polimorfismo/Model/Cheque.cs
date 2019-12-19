using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Model
{
    class Cheque: FormaPagamento
    {
        public Cheque()
        {
            taxa = 10;
        }

        public override double calcularValor()
        {
            return valor + ((valor * taxa) / 100);
        }
    }
}
