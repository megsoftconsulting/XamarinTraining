using System;
using System.ComponentModel;
using Day8.Pages;
using Xamarin.Forms;

namespace Day8
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

        private void Dependency_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DependencyServicePage());
        }

        private void CustomRenderers_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomRenderersPage());
        }

        private void Behaviors_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BehaviorsPage());
        }
    }
}
