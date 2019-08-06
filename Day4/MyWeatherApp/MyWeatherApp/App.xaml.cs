using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyWeatherApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        private static MiBaseDeDatos _baseDeDatos;
        public static MiBaseDeDatos BaseDeDatos {

            get
            {
                if(_baseDeDatos == null)
                {
                    var dbpath =
                        Path.Combine(
                            Environment.GetFolderPath(
                                Environment.SpecialFolder.LocalApplicationData), "myLocalDatabase.db3");

                    _baseDeDatos = new MiBaseDeDatos(dbpath
                        );
                }

                return _baseDeDatos;
            }

        }

    }
}
