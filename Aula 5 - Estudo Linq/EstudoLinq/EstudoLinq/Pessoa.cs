using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoLinq
{
    class Pessoa
    {
        public int idade { get; set; }
        public string nome { get; set; }
        public DateTime nascimento { get; set; }

        public override string ToString()
        {
            return $"Nome:{nome}\nIdade:{idade}\nNascimento:{nascimento}\n";
        }
    }
}
