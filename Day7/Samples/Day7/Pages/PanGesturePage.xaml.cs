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
                    Image.TranslationX =
                      Math.Max(Math.Min(0, x + e.TotalX), -Math.Abs(Image.Width - App.ScreenWidth));
                    Image.TranslationY =
                      Math.Max(Math.Min(0, y + e.TotalY), -Math.Abs(Image.Height - App.ScreenHeight));
                    break;

                case GestureStatus.Completed:
                    // Store the translation applied during the pan
                    x = Image.TranslationX;
                    y = Image.TranslationY;
                    break;
            }
        }
    }
}
