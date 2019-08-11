using System;
using Day7.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Day7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TriggersPage())
            {
                BarBackgroundColor = Color.Gray,
                BarTextColor = Color.White
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
