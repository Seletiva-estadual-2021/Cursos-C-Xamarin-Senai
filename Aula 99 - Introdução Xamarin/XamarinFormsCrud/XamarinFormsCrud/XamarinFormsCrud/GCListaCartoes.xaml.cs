using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsCrud
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GCListaCartoes : ContentPage
	{
        public int idcli { get; set; }

		public GCListaCartoes ()
		{
			InitializeComponent ();
		}

        public GCListaCartoes(int idCli)
        {
            this.idcli = idCli;
            InitializeComponent();
            print();
        }

        public void print()
        {
            DisplayAlert("Cadastro de pessoas", $"Pessoa: {this.idcli} cadastrada com sucesso!", "OK");
        }

    }
}