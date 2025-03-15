using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RetoMaui.Helpers;
using RetoMaui.Views;

namespace RetoMaui.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    public HomeViewModel(LanguageResourceManager lng)
    {
        languageResourceManager = lng;
    }
    [ObservableProperty]
    private LanguageResourceManager languageResourceManager;

    [ObservableProperty]
private string title = "HomeView title";

    [RelayCommand]
public async Task GoToBiometricView(){
    
await Shell.Current.GoToAsync(nameof(BiometricsFunctionView));
    
}

    [RelayCommand]
public async Task GoToMapsView(){
    
await Shell.Current.GoToAsync(nameof(MapsView));
    
}


    [RelayCommand]
public async Task GoToRandomJokeView(){
    
await Shell.Current.GoToAsync(nameof(RandomJokeView));
    
}

}
