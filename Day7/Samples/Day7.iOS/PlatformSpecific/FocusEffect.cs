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
        UIColor backgroundColor;
        protected override void OnAttached()
        {
            try
            {
                Control.BackgroundColor = backgroundColor = UIColor.FromRGB(204, 0, 0); //153, 255);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
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
                if (args.PropertyName == "IsFocused")
                {
                    if (Control.BackgroundColor == backgroundColor)
                    {
                        Control.BackgroundColor = UIColor.White;
                    }
                    else
                    {
                        Control.BackgroundColor = backgroundColor;
                    }
                    
                    if (Control is UITextField)
                    {
                        (Control as UITextField).Text = "Eres un millonario";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }
    }
}
