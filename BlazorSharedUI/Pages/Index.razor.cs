using System;
using BlazorSharedUI.SharedServices;
using Microsoft.AspNetCore.Components;

namespace BlazorSharedUI.Pages
{
    public partial class Index
    {
        [Inject]
        private IPlatformInfo? PlatformInfo { get; set; }

        private string? _windowDimensions;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                _windowDimensions = await PlatformInfo?.GetWindowSize();
                StateHasChanged();
            }
        }
    }
}

