using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage()) {
                BarBackgroundColor = Color.DarkBlue,
                BarTextColor = Color.WhiteSmoke
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
