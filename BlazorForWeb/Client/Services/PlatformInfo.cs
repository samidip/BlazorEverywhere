using System;
using BlazorSharedUI.SharedServices;
using System.Threading.Tasks;

namespace BlazorForWeb.Client.Services
{
    public class PlatformInfo : IPlatformInfo
    {
        BrowserService myService;

        public PlatformInfo(BrowserService service)
        {
            myService = service;
        }

        public string GetPlatformName()
        {
            return "Browser";
        }

        public async Task<string> GetWindowSize()
        {
            var dimension = await myService.GetDimensions();
            int Height = dimension.Height;
            int Width = dimension.Width;
            string WindowDimension = Width + "x" + Height;

            return WindowDimension;
        }
    }
}

