using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace EssentialsSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage
    {

        public MainPage()
        {
            InitializeComponent();

            Connectivity.ConnectivityChanged += OnConnectivityChanged;
            Accelerometer.ShakeDetected += Accelerometer_ShakeDetected;

            if (DeviceInfo.DeviceType != DeviceType.Virtual && !Accelerometer.IsMonitoring)
                Accelerometer.Start(SensorSpeed.UI);

        }

        private void Accelerometer_ShakeDetected(object sender, EventArgs e)
        {
            DisplayAlert("Oh no !!", "Please stop, I'm getting dizzy!!!", "):");
        }

        private void Handle_Clicked(object sender, EventArgs e) 
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet) 
            {
                DisplayAlert("Cool!", "You have access to the Internet", "Ok");
            } 
            else 
            {
                DisplayAlert("Oh no!", "You don't have Internet", "Ok");
            }
        }

        private async void Handle_Clicked2(object sender, EventArgs e)
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Lowest, TimeSpan.FromSeconds(10));
                var location = await Geolocation.GetLocationAsync(request);

                if (location == null) return;
                Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                await DisplayAlert("Your coordinates are:", $"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}", "Ok");
            }
            catch (FeatureNotEnabledException)
            {
                await DisplayAlert("Oops!", "You have to turn on your GPS", "Ok");
            }
            catch (PermissionException)
            {
                await DisplayAlert("Oops!", "You have to give me the permission to read your GPS", "Ok");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
            }
        }

        private void OnConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            LabelAlert.FadeTo(e.NetworkAccess == NetworkAccess.Internet ? 0 : 1);
        }
    }
}
