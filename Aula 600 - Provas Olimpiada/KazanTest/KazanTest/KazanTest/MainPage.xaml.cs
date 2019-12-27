using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using KazanTest.model;
using System.Collections;
using Refit;
using KazanTest.services;

namespace KazanTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<Departments> deptos = loadDepartments();
            List<AssetGroups> assetGroups = loadAssetGroups();
            List<Assets> assets = loadAssets();

            departmentList.ItemsSource = deptos;
            assetsGroupsList.ItemsSource = assetGroups;
            assetsList.ItemsSource = assets;
        }

        private List<Assets> loadAssets()
        {
            var DepsAPI = RestService.For<IRestApi>("http://localhost:51337");
            return DepsAPI.GetAssets().Result;
        }

        private List<AssetGroups> loadAssetGroups()
        {
            var DepsAPI = RestService.For<IRestApi>("http://localhost:51337");
            return DepsAPI.GetAssetGroups().Result;
        }

        private List<Departments> loadDepartments()
        {
            var DepsAPI = RestService.For<IRestApi>("http://localhost:51337");
            return DepsAPI.GetDepartments().Result;
        }

        private void clicou(object sender, EventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            var botao = button.CommandParameter;

            DisplayAlert("Testes", $"o botão clicado foi: {botao}", "Fechar");
        }
    }
}
