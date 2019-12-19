using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Model
{
    class FormaPagamento
    {
        public double valor { get; set; }
        public double taxa { get; set; }
        public double desconto { get; set; }
        public virtual double calcularValor()
        {
            return valor;
        }
    }
}
