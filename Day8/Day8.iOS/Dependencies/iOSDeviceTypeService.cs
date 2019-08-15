using System;
using Day8.Dependencies;
using Day8.iOS.Dependencies;
using Xamarin.Forms;

[assembly:Dependency(typeof(iOSDeviceTypeService))]
namespace Day8.iOS.Dependencies
{
    public class iOSDeviceTypeService : IDeviceTypeService
    {
        public string GetDeviceType()
        {
            return "Yo soy Apple";
        }
    }
}
