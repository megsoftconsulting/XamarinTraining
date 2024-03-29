﻿using Day7.Pages;
using Xamarin.Forms;

namespace Day7
{
    public partial class App : Application
    {
        public static double ScreenWidth = Xamarin.Essentials.DeviceDisplay.MainDisplayInfo.Width;
        public static double ScreenHeight = Xamarin.Essentials.DeviceDisplay.MainDisplayInfo.Height;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
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
