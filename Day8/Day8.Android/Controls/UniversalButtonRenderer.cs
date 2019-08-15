using System;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Day8.Controls;
using Day8.Droid.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(UniversalButton), typeof(UniversalButtonRenderer))]
namespace Day8.Droid.Controls
{
    public class UniversalButtonRenderer : ButtonRenderer
    {
        public UniversalButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Navy);
                Control.SetTextColor(Android.Graphics.Color.White);
            }
        }

    }
}
