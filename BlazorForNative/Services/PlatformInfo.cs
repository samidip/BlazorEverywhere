using System;
using BlazorSharedUI.SharedServices;

namespace BlazorForNative.Services
{
    public class PlatformInfo : IPlatformInfo
    {
        public string GetPlatformName()
        {
            return DeviceInfo.Current.Platform.ToString();
        }

        public Task<string> GetWindowSize()
        {
            double Width = DeviceDisplay.MainDisplayInfo.Width;
            double Height = DeviceDisplay.MainDisplayInfo.Height;

            string WindowSize = Width + "x" + Height;
            return Task.FromResult(WindowSize);
        }
    }
}

