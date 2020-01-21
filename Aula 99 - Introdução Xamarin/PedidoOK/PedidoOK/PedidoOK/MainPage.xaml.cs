using PedidoOK.Mocks;
using PedidoOK.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PedidoOK
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            produtosList.ItemsSource = ProdutoMock.gerar();
        }

        private void adicionar(object sender, EventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            Produto prod = ProdutoMock.gerar().Where(p => p.id == Int16.Parse(button.CommandParameter.ToString())).FirstOrDefault();

            DisplayAlert("PedidosOK", $"A produto clicado foi: {prod.nome}", "OK");
        }
    }
}
