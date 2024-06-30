using System;
using Microsoft.Maui;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SaveUp.ViewModels
{
    public partial class InfoPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string developerUrl = "https://github.com/mahgoe";

        // Open the Link from Developer
        [RelayCommand]
        private async void OpenDeveloperUrl()
        {
            await Launcher.OpenAsync(new Uri(DeveloperUrl));
        }
    }
}
