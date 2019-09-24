using Refit;
using RestClient.model;
using RestClient.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestClient
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void salvar(object sender, EventArgs e)
        {
            var pessoaAPI = RestService.For<IRestApi>("http://localhost:51459");

            Pessoa p = new Pessoa()
            {
                nome = nome.Text,
                idade = Convert.ToInt16(idade.Text),
                foto = foto.Text
            };
            
            pessoaAPI.Salvar(p);
            DisplayAlert("Cadastro", "Salvo com sucesso", "OK");
        }
    }
}