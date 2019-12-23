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
            departmentList.ItemsSource = loadDepartments();
            departmentList2.ItemsSource = loadDepartments();
        }

        private List<Departments> loadDepartments()
        {
            var DepsAPI = RestService.For<IRestApi>("http://localhost:51337");
            return DepsAPI.GetDepartments().Result;
        }
    }
}
