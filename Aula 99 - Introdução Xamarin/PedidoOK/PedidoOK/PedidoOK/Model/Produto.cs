using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoOK.model
{
    class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }
        public double estoque { get; set; }
    }
}
