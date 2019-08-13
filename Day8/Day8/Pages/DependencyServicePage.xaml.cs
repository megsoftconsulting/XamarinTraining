using System;
using System.Collections.Generic;
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
        }

        private void Device_Clicked(object sender, EventArgs e)
        {
            var deviceOrientation = DependencyService.Get<IDevice>().GetOrientation();
            if(deviceOrientation == DeviceOrientation.Landscape)
            {
                DisplayAlert("Day 8", "Tu dispositivo esta landscape", "Ok");
            }
            else
            {
                DisplayAlert("Day 8", "Tu dispositivo esta portrait", "Ok");
            }
        }

        private async void Picker_Clicked(object sender, EventArgs e)
        {
            var stream = await DependencyService.Get<IDevice>().GetImageStreamAsync();
            if(stream != null)
            {
                image.Source = ImageSource.FromStream(() => stream);
            }
        }
    }
}
