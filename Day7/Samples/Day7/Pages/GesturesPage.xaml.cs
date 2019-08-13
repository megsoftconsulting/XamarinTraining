using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Day7.Pages
{
    public partial class GesturesPage : ContentPage
    {
        public GesturesPage()
        {
            InitializeComponent();
        }

        private void TapGestureSample_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TapGesturePage());
        }

        private void PinchGestureSample_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PinchGesturePage());
        }

        private void PanGestureSample_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PanGesturePage());
        }

        private void SwipeGestureSample_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SwipeGesturePage());
        }
    }
}
