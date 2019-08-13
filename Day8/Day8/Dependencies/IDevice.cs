using System;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace Day8.Dependencies
{
    public interface IDevice
    {
        DeviceOrientation GetOrientation();
        Task<Stream> GetImageStreamAsync();
    }
}
