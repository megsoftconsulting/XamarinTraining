using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace WebViewSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private void Handle_Clicked(object sender, EventArgs e)
        {
            var url = AddressEntry.Text;
            if (!Regex.IsMatch(url, @"^https?:\/\/", RegexOptions.IgnoreCase))
                url = "https://" + url;

            var isUrlValid = Uri.TryCreate(url, UriKind.Absolute, out var resultUri);

            if (isUrlValid)
            {
                MyWebBrowser.Source = resultUri.ToString();
            }
            else
            {
                DisplayAlert("Oh no!", "The address is invalid", "Ok");
            }
        }
    }
}
