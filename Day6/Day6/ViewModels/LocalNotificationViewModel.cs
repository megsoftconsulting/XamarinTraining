using System;
using System.Windows.Input;
using Plugin.LocalNotifications;
using Xamarin.Forms;

namespace Day6.ViewModels
{
    public class LocalNotificationViewModel : BindableObject
    {
        public ICommand SimpleAlertCommand => new Command(OnSimpleAlertTapped);
        public ICommand TwoOptionsAlertCommand => new Command(OnTwoOptionsAlertTapped);
        public ICommand ActionSheetCommand => new Command(OnActionSheetAlertTapped);
        public ICommand ActionSheetWithDestructionCommand => new Command(OnActionSheetAlertWithDestructionTapped);
        public ICommand LocalNotificationCommand => new Command(ScheduleNotification);

        public LocalNotificationViewModel() { }

        private void OnSimpleAlertTapped()
        {
            // A simple way to call the DisplayAlert from any place in a XF App. Remember, this is a sample. Depending on what framework you are using, this may change.
            Application.Current.MainPage.DisplayAlert("Tu titulo aqui", "Ejemplo de una alerta simple", "Ok");
        }
        private void OnTwoOptionsAlertTapped()
        {
            // A simple way to call the DisplayAlert from any place in a XF App. Remember, this is a sample. Depending on what framework you are using, this may change.
            // NOTE: You can also make this method as async and await for the alert to get the result (true/false)
            Application.Current.MainPage.DisplayAlert("Tu titulo aqui", "Ejemplo de una alerta simple", "Si", "No")
                .ContinueWith(task =>
                {
                    // This code is on background, We need to call the Main Thread to display the results
                    if(task.Result)
                    {
                        // Si presionas la opcion "Si"
                        Device.BeginInvokeOnMainThread(() =>
                        Application.Current.MainPage.DisplayAlert("Tu titulo aqui", "Presionaste Si", "Ok"));
                    }
                    else
                    {
                        // Si presionas la opcion "No"
                        Device.BeginInvokeOnMainThread(() =>
                        Application.Current.MainPage.DisplayAlert("Tu titulo aqui", "Presionaste No", "Ok"));
                    }
                });
        }
        private void OnActionSheetAlertTapped()
        {
            // A simple way to call the DisplayActionSheet from any place in a XF App. Remember, this is a sample. Depending on what framework you are using, this may change.
            // NOTE: You can also make this method as async and await for the alert to get the result (true/false)
            var options = new[] { "Opcion 1", "Opcion 2", "Opcion 3" };
            Application.Current.MainPage.DisplayActionSheet("Escoge una opcion", "Cancelar", null, options)
                .ContinueWith(task =>
                {
                    Device.BeginInvokeOnMainThread(() =>
                    Application.Current.MainPage.DisplayAlert("Tu titulo aqui", $"Seleccionaste {task.Result}", "Ok"));
                });
        }

        private void OnActionSheetAlertWithDestructionTapped()
        {
            // A simple way to call the DisplayActionSheet from any place in a XF App. Remember, this is a sample. Depending on what framework you are using, this may change.
            // This shows the destructive options enabled which means a text with red text color will appear as an extra option to let the user know is a delete or destructive action.
            // NOTE: You can also make this method as async and await for the alert to get the result (true/false)
            var options = new[] { "Opcion 1", "Opcion 2", "Opcion 3" };
            Application.Current.MainPage.DisplayActionSheet("Escoge una opcion", "Cancelar", "Eliminar", options)
                .ContinueWith(task =>
                {
                    Device.BeginInvokeOnMainThread(() =>
                    Application.Current.MainPage.DisplayAlert("Tu titulo aqui", $"Seleccionaste {task.Result}", "Ok"));
                });
        }

        private void ScheduleNotification()
        {
            CrossLocalNotifications.Current.Show("Your notification", "This is a test, you should see this as a notification", 101, DateTime.Now.AddSeconds(7));
        }
    }
}
