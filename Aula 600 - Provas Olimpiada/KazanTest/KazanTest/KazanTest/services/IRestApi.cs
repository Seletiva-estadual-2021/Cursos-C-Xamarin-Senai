using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KazanTest.model;
using Refit;

namespace KazanTest.services
{
    interface IRestApi
    {
        [Get("/api/Assets/")]
        Task<List<Assets>> GetAssets();

        [Get("/api/Departmento/")]
        Task<List<Departments>> GetDepartments();

        [Post("/api/Assets")]
        Task Salvar([Body(BodySerializationMethod.UrlEncoded)] Assets data);
    }
}
