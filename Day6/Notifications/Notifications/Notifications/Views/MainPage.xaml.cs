using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notifications.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ActivityIndicator_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ActivityIndicatorPage());
        }
        
        private void Alerts_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AlertsPage());
        }
        
        private void LocalNotifications_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LocalNotificationsPage());
        }
        
        private void Toast_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ToastPage());
        }
    }
}