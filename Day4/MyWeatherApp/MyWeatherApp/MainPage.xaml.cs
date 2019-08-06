using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MyWeatherApp.Entities;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace MyWeatherApp
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var result =
                App.BaseDeDatos.BuscarTodos<MiHistoricoDeBusquedas>().OrderByDescending(x => x.FechaDeBusqueda);

            listHistorico.ItemsSource = result;
        }

        public void Handle_Clicked(object sender, EventArgs args)
        {
            try
            {
                var url = $"http://api.apixu.com/v1/current.json?key=f4a33bfe56d84a7b895210819181510&q="+ CityNameEntry.Text;

                var client = new WebClient();

                var result = client.DownloadString(url);

                var resultObject = JsonConvert.DeserializeObject<Weather>(result);

                App.BaseDeDatos.Insertar(
                    new MiHistoricoDeBusquedas
                    {
                        FechaDeBusqueda = DateTime.UtcNow,
                        TextoBusqueda = CityNameEntry.Text
                    });
                BindingContext = resultObject;
            }
            catch(Exception ex)
            {
                DisplayAlert("Ooops!", ex.Message, "Ok");
            }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var result =
                App.BaseDeDatos.BuscarTodos<MiHistoricoDeBusquedas>().OrderByDescending(x=>x.FechaDeBusqueda);

            listHistorico.ItemsSource = result;
        }
    }
}
