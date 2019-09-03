using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFormsCrud.model;

namespace XamarinFormsCrud
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Pessoa> pessoas = new ObservableCollection<Pessoa>();
        //List<Pessoa> pessoas = new List<Pessoa>();

        public string Image { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Image = "plus.png";
        }

        private void digaOi(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text
            };

            pessoas.Add(p);
            updateList();
            DisplayAlert("Cadastro de pessoas", $"Pessoa: {txtNome.Text} cadastrada com sucesso!", "OK");
        }

        private void updateList()
        {
            lstPessoas.ItemsSource = pessoas;
        }
    }
}
