using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BounceSquare
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public async void Handle_Tapped(object sender, EventArgs e)
        {
            await myBouncingBox.FadeTo(0, 500, Easing.BounceIn);
            await myBouncingBox.FadeTo(1, 500, Easing.BounceIn);
            await myBouncingBox.ScaleTo(2, 500, Easing.BounceOut);
            await myBouncingBox.ScaleTo(1, 500, Easing.BounceOut);
            myBouncingBox.CornerRadius = 10;
            await myBouncingBox.TranslateTo(-100, 100, 500, Easing.Linear);
            await myBouncingBox.TranslateTo(100, 100, 500, Easing.Linear);
            await myBouncingBox.TranslateTo(0, 0, 500, Easing.Linear);
            await myBouncingBox.FadeTo(0, 500, Easing.BounceIn);
            await myBouncingBox.FadeTo(1, 500, Easing.BounceIn);

        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
