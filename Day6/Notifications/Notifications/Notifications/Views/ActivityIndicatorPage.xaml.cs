using System;
using Xamarin.Forms.Xaml;

namespace Notifications.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityIndicatorPage
    {
        public ActivityIndicatorPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            ActivityIndicator.IsRunning = !ActivityIndicator.IsRunning;
        }
    }
}