using System;

namespace BlazorSharedUI.SharedServices
{
    public interface IPlatformInfo
    {
        public string GetPlatformName();
        public Task<string> GetWindowSize();
    }
}

