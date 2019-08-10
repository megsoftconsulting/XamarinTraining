using System;
using Day6.Helpers;
using Day6.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Com.OneSignal;

namespace Day6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.Android)
            {
                var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
                ApplicationResources.Culture = ci; // set the RESX for resource localization
                DependencyService.Get<ILocalize>().SetLocale(ci); // set the Thread for locale-aware methods
            }

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.Gray,
                BarTextColor = Color.White
            };
            // Have fun with this ID on Android
            // iOS configuration can be found here: https://xamarinlatino.com/xamarin-forms-onesignal-series-ios-c994914b5139
            OneSignal.Current.StartInit("23e84f52-7985-485e-992a-8a935e4d910a").EndInit();
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
