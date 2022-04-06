using System;
using System.IO;
using Database.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Database
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.DodgerBlue,
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
        
        static LocalDatabase _database;

        public static LocalDatabase Database
        {
            get 
            {
                if (_database != null) return _database;
                var dbpath = 
                    Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData), "myLocalDatabase.db3");

                _database = new LocalDatabase(dbpath);
                return _database;
            }
        }
    }
}