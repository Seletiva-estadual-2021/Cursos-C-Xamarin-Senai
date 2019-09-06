using CadastroJson.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroJson.util
{
    class ManipulaArquivos
    {
        private string path = @"C:\Users\william.chenta\documents\pessoas.json";
        private List<Pessoa> pessoas = new List<Pessoa>();

        public List<Pessoa> ler()
        {
            string conteudo = File.ReadAllText(path);
            pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(conteudo);
            return pessoas != null ? pessoas : new List<Pessoa>();
        }

        public void escrever(Pessoa p)
        {
            pessoas = ler();
            pessoas.Add(p);
            string pessoa = JsonConvert.SerializeObject(pessoas);
            File.WriteAllText(path, pessoa);
        }
    }
}
