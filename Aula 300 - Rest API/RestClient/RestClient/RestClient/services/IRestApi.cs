using Refit;
using RestClient.model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.services
{
    interface IRestApi
    {
        [Get("/api/Pessoa/")]
        Task<List<Pessoa>> GetPessoas();

        [Post("/api/Pessoa")]
        Task Salvar([Body(BodySerializationMethod.UrlEncoded)] Pessoa data);
    }
}
