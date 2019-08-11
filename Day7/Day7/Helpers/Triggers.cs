using System;
using Xamarin.Forms;

namespace Day7.Helpers
{
    public class ExpandButtonTriggerAction : TriggerAction<Button>
    {
        protected override async void Invoke(Button sender)
        {
            await sender.ScaleTo(0.95, 50, Easing.CubicOut);
            await sender.ScaleTo(1.0, 50, Easing.CubicIn);
        }
    }
}
