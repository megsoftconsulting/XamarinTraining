using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Day7.Pages
{
    public partial class PanGesturePage : ContentPage
    {
        double x, y;
        public PanGesturePage()
        {
            InitializeComponent();
        }

        private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Running:
                    // Translate and ensure we don't pan beyond the wrapped user interface element bounds.
                    image.TranslationX =
                      Math.Max(Math.Min(0, x + e.TotalX), -Math.Abs(image.Width - App.ScreenWidth));
                    image.TranslationY =
                      Math.Max(Math.Min(0, y + e.TotalY), -Math.Abs(image.Height - App.ScreenHeight));
                    break;

                case GestureStatus.Completed:
                    // Store the translation applied during the pan
                    x = image.TranslationX;
                    y = image.TranslationY;
                    break;
            }
        }
    }
}
