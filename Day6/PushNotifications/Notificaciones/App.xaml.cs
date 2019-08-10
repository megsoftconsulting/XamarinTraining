using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Push;

namespace Notificaciones
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            //AppCenter.Start("ee5182e5-2938-4d60-8a76-e08dad19d934", typeof(Push));
            AppCenter.Start("5cca0a4e-ea95-4f0d-900c-4729df4bdf7b", typeof(Push));


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
