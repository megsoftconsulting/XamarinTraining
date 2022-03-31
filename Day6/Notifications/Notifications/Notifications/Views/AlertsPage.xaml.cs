using System;
using System.Diagnostics;
using Xamarin.Forms.Xaml;

namespace Notifications.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertsPage
    {
        public AlertsPage()
        {
            InitializeComponent();
        }

        private async void SimpleAlert_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "You have been alerted", "OK");
        }
        
        private async void AlertOptions_OnClicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Question?", "Would you like to play a game?", "Yes", "No");
            Debug.WriteLine("The answer selected is: " + answer);
        }
    }
}