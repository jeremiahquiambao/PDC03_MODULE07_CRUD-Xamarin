using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE07
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Create a new NavigationPage with ShowAnimalsPage as the root page
            var navigationPage = new NavigationPage(new View.LandingPage());

            // Set the BarBackgroundColor for the NavigationPage
            navigationPage.BarBackgroundColor = Color.Black;

            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
