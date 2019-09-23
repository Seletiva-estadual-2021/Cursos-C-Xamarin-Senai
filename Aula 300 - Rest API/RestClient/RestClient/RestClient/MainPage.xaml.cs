using RestClient.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using RestClient.services;
using Refit;

namespace RestClient
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var pessoaAPI = RestService.For<IRestApi>("http://localhost:51459");
            List<Pessoa> listaPessoas = pessoaAPI.GetPessoas().Result;

            listaPessoas.ForEach(p => {
                DisplayAlert("teste", p.nome, "OK");
            });
        }
    }
}
