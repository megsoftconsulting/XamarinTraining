using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Day7.Pages
{
    public partial class PinchGesturePage : ContentPage
    {
        double xOffset, yOffset, startScale, currentScale;
        public PinchGesturePage()
        {
            InitializeComponent();
        }

        private void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            if (e.Status == GestureStatus.Started)
            {
                // Store the current scale factor applied to the wrapped user interface element,
                // and zero the components for the center point of the translate transform.
                startScale = Image.Scale;
                Image.AnchorX = 0;
                Image.AnchorY = 0;
            }
            if (e.Status == GestureStatus.Running)
            {
                // Calculate the scale factor to be applied.
                currentScale += (e.Scale - 1) * startScale;
                currentScale = Math.Max(1, currentScale);

                // The ScaleOrigin is in relative coordinates to the wrapped user interface element,
                // so get the X pixel coordinate.
                double renderedX = Image.X + xOffset;
                double deltaX = renderedX / Width;
                double deltaWidth = Width / (Image.Width * startScale);
                double originX = (e.ScaleOrigin.X - deltaX) * deltaWidth;

                // The ScaleOrigin is in relative coordinates to the wrapped user interface element,
                // so get the Y pixel coordinate.
                double renderedY = Image.Y + yOffset;
                double deltaY = renderedY / Height;
                double deltaHeight = Height / (Image.Height * startScale);
                double originY = (e.ScaleOrigin.Y - deltaY) * deltaHeight;

                // Calculate the transformed element pixel coordinates.
                double targetX = xOffset - (originX * Image.Width) * (currentScale - startScale);
                double targetY = yOffset - (originY * Image.Height) * (currentScale - startScale);

                // Apply translation based on the change in origin.
                Image.TranslationX = targetX.Clamp(-Image.Width * (currentScale - 1), 0);
                Image.TranslationY = targetY.Clamp(-Image.Height * (currentScale - 1), 0);

                // Apply scale factor.
                Image.Scale = currentScale;
            }
            if (e.Status == GestureStatus.Completed)
            {
                // Store the translation delta's of the wrapped user interface element.
                xOffset = Image.TranslationX;
                yOffset = Image.TranslationY;
            }
        }
    }
}
