using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoLinq
{
    class Program
    {

        static void Main(string[] args)
        {
            Random r = new Random();
            List<Pessoa> pessoas = new List<Pessoa>();
            List<string> nomes = new List<string>()
            {
                "João", "Maria", "José", "Jair", "William", "Filomena"
            };

            for (int i = 0; i < 10; i++)
            {
                var p = new Pessoa()
                {
                    idade = r.Next(1, 100),
                    nome = nomes.ElementAt(r.Next(0,5)),
                    nascimento = new DateTime(r.Next(1950, 2019), r.Next(1,12), r.Next(1,30))
                };
                pessoas.Add(p);
            }

            Console.WriteLine("Listando as pessoas:");
            pessoas.ForEach(p => Console.WriteLine(p));

            Console.WriteLine("Jaires maiores de 18:");
            pessoas.Where(p => 
                            p.idade > 18 && p.nome.ToLower().Equals("Jair".ToLower()) &&
                            p.nome.Equals("Jair")).
                            ToList().ForEach(p => Console.WriteLine(p));
        }
    }
}
