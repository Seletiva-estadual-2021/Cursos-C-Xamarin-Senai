using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Model
{
    class Credito: FormaPagamento
    {
        public Credito()
        {
            taxa = 8;
        }

        public override double calcularValor()
        {
            return valor + ((valor * taxa) / 100);
        }
    }
}
