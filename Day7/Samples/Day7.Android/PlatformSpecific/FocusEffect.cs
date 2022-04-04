using System;
using Day7.Droid.PlatformSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("MyCompany")]
[assembly: ExportEffect(typeof(FocusEffect), nameof(FocusEffect))]
namespace Day7.Droid.PlatformSpecific
{
    public class FocusEffect : PlatformEffect
    {
        private readonly Android.Graphics.Color _originalBackgroundColor = new Android.Graphics.Color(0, 0, 0, 0);
        private Android.Graphics.Color _backgroundColor;

        protected override void OnAttached()
        {
            try
            {
                _backgroundColor = Android.Graphics.Color.LightGreen;
                Control.SetBackgroundColor(_backgroundColor);
                Control.TooltipText = "This is android";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: {0}", ex.Message);
            }
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            try
            {
                if (args.PropertyName != "IsFocused") return;
                Control.SetBackgroundColor(
                    (((Android.Graphics.Drawables.ColorDrawable) Control.Background)!).Color == _backgroundColor
                        ? _originalBackgroundColor
                        : _backgroundColor);
                if(Control is FormsEditText entry)
                {
                    entry.Text = "This is android";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: {0}", ex.Message);
            }
        }
    }
}
