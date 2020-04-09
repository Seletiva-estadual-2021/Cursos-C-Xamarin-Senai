using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudoLinqAvancado.model.config;

namespace EstudoLinqAvancado
{
    class Program
    {
        static void Main(string[] args)
        {
            gravadoraEntities bd = new gravadoraEntities();

            //Lista com todas as Gravadoras que possuem endereço cadastrado;
            Console.WriteLine("Lista com todas as Gravadoras que possuem endereço cadastrado;");
            var gravadoras = from grav in bd.gravadora
                             where grav.endereco.Length > 0
                             select new { grav.nome_gravadora, grav.endereco };

            foreach (var item in gravadoras)
            {
                Console.WriteLine(string.Concat(item.nome_gravadora, " - ", item.endereco));
            }

            //Lista com os CDs que custam entre 10 e 15 reais;
            Console.WriteLine("\nLista com os CDs que custam entre 10 e 15 reais;");
            var cdsBaratos = from cd in bd.cd
                             where cd.preco_venda >= 10 && cd.preco_venda <= 15
                             select new { cd.nome_cd, cd.preco_venda };

            foreach (var item in cdsBaratos)
            {
                Console.WriteLine(string.Concat(item.nome_cd, " - ", item.preco_venda));
            }

            //Lista com os CDs lançados no mês de outubro durante a década de 90 (entre os anos 1990 à 1999);
            Console.WriteLine("\nLista com os CDs lançados no mês de outubro durante a década de 90 (entre os anos 1990 à 1999);");
            var cds90 = from cd in bd.cd
                        where (cd.data_lancamento.Value.Year >= 1990 && cd.data_lancamento.Value.Year <= 1999 && cd.data_lancamento.Value.Month == 10)
                        orderby cd.data_lancamento
                        select new { cd.nome_cd, cd.data_lancamento };
            
            foreach (var item in cds90)
            {
                Console.WriteLine(string.Concat(item.nome_cd, " - ", item.data_lancamento.Value.ToLocalTime()));
            }

            //Lista o nome das músicas que duram mais que cinco minutos ordenando da maior duração para a menor;
            Console.WriteLine("Lista o nome das músicas que duram mais que cinco minutos ordenando da maior duração para a menor;");
            var musicasGrandes = from mus in bd.musica
                                 where mus.duracao.Value.


        }
    }
}
