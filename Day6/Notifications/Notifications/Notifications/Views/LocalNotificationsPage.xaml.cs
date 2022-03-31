using System;
using Plugin.LocalNotifications;
using Xamarin.Forms.Xaml;

namespace Notifications.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocalNotificationsPage
    {
        public LocalNotificationsPage()
        {
            InitializeComponent();
        }
        
        private void ShowNotification_Clicked(object sender, EventArgs e)
        {
            CrossLocalNotifications.Current.Show("Hey!", "Listen!");
        }

        private void AfterSeconds_Clicked(object sender, EventArgs e)
        {
            CrossLocalNotifications.Current.Show("Hey!", "Watch out!", 101, DateTime.Now.AddSeconds(5));
        }

        private void CancelNotification_Clicked(object sender, EventArgs e)
        {
            CrossLocalNotifications.Current.Cancel(101);
        }
    }
}