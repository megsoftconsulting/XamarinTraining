using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using WeatherApp.Models;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await GetHistory();
        }

        protected override async void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            await GetHistory();
        }
        
        private async Task GetHistory()
        {
            var result = await App.Database.Lookup<History>();
            ListHistory.ItemsSource = result.OrderByDescending(x => x.DateTime);
        }

        private async void Handle_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextCity.Text)) return;
            var response = await SearchWeather(TextCity.Text);
            if (response == null) return;
            App.Database.Insert(new History
            {
                Text = TextCity.Text,
                DateTime = DateTime.UtcNow
            });
            BindingContext = response;
        }

        private async Task<WeatherResponse> SearchWeather(string city)
        {
            WeatherResponse response = null;
            try
            {
                var client = new WebClient();
                var encodedParameter = HttpUtility.UrlEncode(city);
                var formattedUrl = string.Format(AppConstants.ApiEndpoint, encodedParameter);
                var url = new Uri(formattedUrl);
                var resultString = await client.DownloadStringTaskAsync(url);
                response = JsonConvert.DeserializeObject<WeatherResponse>(resultString);
                client.Dispose();
            }
            catch(Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "ok");
            }

            return response;
        }
    }
}