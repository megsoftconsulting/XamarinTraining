using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Day8.Pages
{
    public partial class BehaviorsPage : ContentPage
    {
        public BehaviorsPage()
        {
            InitializeComponent();
        }

        private void Url_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/behaviors/reusable/event-to-command-behavior"));
        }
    }
}
