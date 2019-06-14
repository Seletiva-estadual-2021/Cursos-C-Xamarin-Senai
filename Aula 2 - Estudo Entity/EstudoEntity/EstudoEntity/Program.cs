using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudoEntity.view;

namespace EstudoEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            EstudoEntity estudoEntity = new EstudoEntity();

            //salvando
            /*
            pessoa william = new pessoa("william", 55);
            estudoEntity.pessoa.Add(william);
            estudoEntity.SaveChanges();
            */

            //listando
            /*
            estudoEntity.pessoa.ToList().ForEach(p => {
                Console.WriteLine(p.nome);
            });
            */

            //pegando pelo id
            /*
            Console.WriteLine(estudoEntity.pessoa.Find(2).nome);

            var teste = estudoEntity.pessoa.Where(p => p.idade == 25).Select(p => new { p.nome, p.idade }).ToList();
            teste.ForEach(p => {
                Console.WriteLine(p.nome);
            });

            //filtrando no foreach
            List<pessoa> pessoas25 = estudoEntity.pessoa.ToList().FindAll(p => p.idade > 25 && p.idade < 60);
            Console.WriteLine(pessoas25.Count);

            Console.ReadKey();
            */
            new PessoasForm().Show();
        }
    }
}
