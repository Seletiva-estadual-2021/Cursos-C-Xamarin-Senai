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
	public partial class GCLogin : ContentPage
	{
		public GCLogin ()
		{
			InitializeComponent ();
		}

        private void irListaCartoes(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GCListaCartoes(581));
        }
    }
}