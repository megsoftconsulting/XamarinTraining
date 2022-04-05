using System;
using Day8.Dependencies;
using Day8.Droid.Dependencies;
using Xamarin.Forms;

[assembly:Dependency(typeof(AndroidDeviceTypeService))]

namespace Day8.Droid.Dependencies
{
    public class AndroidDeviceTypeService : IDeviceTypeService
    {

        public string GetDeviceType()
        {
            return "Hi! This device is Android";
        }
    }
}
