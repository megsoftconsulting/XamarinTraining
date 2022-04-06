using System;
using System.Net;
using System.Web;
using Newtonsoft.Json;
using WeatherApi.Models;
using Xamarin.Forms;

namespace WeatherApi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            SearchWeather("New York");
        }

        private void Handle_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextCity.Text))
            {
                SearchWeather(TextCity.Text);
            }
        }

        private void SearchWeather(string city)
        {
            try
            {
                var client = new WebClient();
                var encodedParameter = HttpUtility.UrlEncode(city);
                var formattedUrl = string.Format(AppConstants.ApiEndpoint, encodedParameter);
                var url = new Uri(formattedUrl);
                var resultString = client.DownloadString(url);
                var resultObject = JsonConvert.DeserializeObject<WeatherResponse>(resultString);
                client.Dispose();

                BindingContext = resultObject;
            }
            catch(Exception ex)
            {
                DisplayAlert("Error", ex.Message, "ok");
            }
        }
    }
}