using System;
using System.ComponentModel;
using Day7.iOS.PlatformSpecific;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ResolutionGroupName("MyCompany")]
[assembly:ExportEffect(typeof(FocusEffect), nameof(FocusEffect))]
namespace Day7.iOS.PlatformSpecific
{
    public class FocusEffect : PlatformEffect
    {
        private UIColor _backgroundColor;
        protected override void OnAttached()
        {
            try
            {
                Control.BackgroundColor = _backgroundColor = UIColor.FromRGB(204, 0, 0); //153, 255);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: {0}", ex.Message);
            }
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            try
            {
                if (args.PropertyName != "IsFocused") return;
                Control.BackgroundColor = Control.BackgroundColor != null && Control.BackgroundColor.Equals(_backgroundColor) ? UIColor.White : _backgroundColor;
                    
                if (Control is UITextField field)
                {
                    field.Text = "This is iOS";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: {0}", ex.Message);
            }
        }
    }
}
