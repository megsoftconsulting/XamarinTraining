using System;
using Day8.Dependencies;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Day8.Pages
{
    public partial class DependencyServicePage : ContentPage
    {
        public DependencyServicePage()
        {
            InitializeComponent();

            var deviceType = DependencyService.Get<IDeviceTypeService>();

            LabelDeviceType.Text = deviceType.GetDeviceType();
        }

        private void Device_Clicked(object sender, EventArgs e)
        {
            var deviceOrientation = DependencyService.Get<IDevice>().GetOrientation();
            DisplayAlert("Day 8",
                deviceOrientation == DeviceOrientation.Landscape
                    ? "Your device is in landscape"
                    : "Your device is in portrait", "Ok");
        }

        private async void Picker_Clicked(object sender, EventArgs e)
        {
            var stream = await DependencyService.Get<IDevice>().GetImageStreamAsync();
            if (stream != null)
            {
                Image.Source = ImageSource.FromStream(() => stream);
            }
        }
    }
}
