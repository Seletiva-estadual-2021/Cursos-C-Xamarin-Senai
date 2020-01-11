using PedidoOK.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoOK.Mocks
{
    class ProdutoMock
    {
        static List<Produto> produtos;
        public static List<Produto> gerar()
        {
            produtos = new List<Produto>()
            {
                new Produto()
                {
                    id = 1, estoque = 10, nome = "camisa polo", preco = 100
                },
                new Produto()
                {
                    id = 2, estoque = 50, nome = "camisa simples", preco = 50
                },
                new Produto()
                {
                    id = 3, estoque = 40, nome = "camisa mocassim", preco = 250
                }
            };
            return produtos;
        }
    }
}
