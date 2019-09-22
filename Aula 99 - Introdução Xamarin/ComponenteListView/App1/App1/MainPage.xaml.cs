using App1.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        public MainPage()
        {
            InitializeComponent();
            carregaList();
        }

        private void carregaList()
        {
            populaPessoas();
            listaPessoas.ItemsSource = pessoas;
        }

        private void populaPessoas()
        {
            pessoas.Add(new Pessoa()
            {
                nome = "William",
                idade = 43
            });

            pessoas.Add(new Pessoa()
            {
                nome = "Jair",
                idade = 99
            });
        }

        private void pessoaSel(object sender, SelectedItemChangedEventArgs e)
        {
            var pessoaSel = (Pessoa)e.SelectedItem;
            DisplayAlert("Listagem de pessoas", $"A pessoa clicada foi: {pessoaSel.nome}", "OK");
        }

        private void clicou(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Pessoa pes = pessoas.Where(p => p.nome.Equals(button.CommandParameter))
                .Select(p=> p).FirstOrDefault();

            DisplayAlert("Listagem de pessoas", $"A pessoa clicada foi: {pes.nome}", "OK");


        }
    }
}
