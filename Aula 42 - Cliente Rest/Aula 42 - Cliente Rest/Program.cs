using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace Aula_42___Cliente_Rest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("http://viacep.com.br");
            var request = new RestRequest("ws/89042000/json", DataFormat.Json);

            var response = client.Get(request);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(response.Content);

            Console.WriteLine(end.logradouro);
        }
    }

    class Endereco
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string unidade { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
    }
}
