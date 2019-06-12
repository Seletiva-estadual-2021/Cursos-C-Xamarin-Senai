using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1.model
{
    class Pessoa
    {
        private string nome;

        public string Nome {
            get {
                return nome;
            }
            set {
                if(value.Length < 3)
                {
                    Console.WriteLine("tamanho inválido");
                } else
                {
                    nome = value;
                }
            }
        }

        public override string ToString()
        {
            return String.Concat("Nome: ", this.nome);
        }
    }
}
