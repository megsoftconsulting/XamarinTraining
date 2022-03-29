using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace EssentialsSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            Connectivity.ConnectivityChanged += OnConnectivityChanged;
            Accelerometer.ShakeDetected += Accelerometer_ShakeDetected;

            if (Xamarin.Essentials.DeviceInfo.DeviceType != DeviceType.Virtual && !Accelerometer.IsMonitoring)
                Accelerometer.Start(SensorSpeed.UI);

        }

        private void Accelerometer_ShakeDetected(object sender, EventArgs e)
        {
            DisplayAlert("Oh no!!", "Detente que me mareo!!!!!", "):");
        }

        public void Handle_Clicked(object sender, EventArgs e) {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet) {
                DisplayAlert("Cool!", "Tienes acceso a internet!", "Ok");
            } else {
                DisplayAlert("Oh no!", "No tienes conexión", "Ok");
            }
        }
        public async void Handle_Clicked2(object sender, EventArgs e)
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Lowest, TimeSpan.FromSeconds(10));
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                   await DisplayAlert("Tus coordeandas son:", $"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}", "Ok");
                }
            }
            catch (FeatureNotEnabledException fneEx)
            {
                await DisplayAlert("Oops!", "Debes encender el GPS", "Ok");
            }
            catch (PermissionException pEx)
            {
                await DisplayAlert("Oops!", "Debes darme permiso para leer el GPS", "Ok");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
            }
        }

        public void OnConnectivityChanged(object sender, ConnectivityChangedEventArgs e) {
            if(e.NetworkAccess == NetworkAccess.Internet) {
                labelAlert.FadeTo(0);
            } else {
                labelAlert.FadeTo(1);
            }
        }
    }
}
