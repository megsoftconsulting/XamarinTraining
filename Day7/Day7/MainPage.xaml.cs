using System;
using System.ComponentModel;
using Day7.Pages;
using Xamarin.Forms;

namespace Day7
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

        private void Triggers_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TriggersPage());
        }

        private void Gestures_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GesturesPage());
        }

        private void Effects_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EffectsPage());
        }
    }
}
