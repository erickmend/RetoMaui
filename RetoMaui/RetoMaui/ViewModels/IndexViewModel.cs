using System;
using System.Globalization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RetoMaui.Helpers;
using RetoMaui.Views;

namespace RetoMaui.ViewModels;

public partial class IndexViewModel : ObservableObject
{
    public IndexViewModel(LanguageResourceManager lng)
    {
        languageResourceManager = lng;
    }

    [ObservableProperty]
private string title = "hello world! This is a message from a ViewModel";

    [ObservableProperty]
    private LanguageResourceManager languageResourceManager;

    [RelayCommand]
public async Task GoToHome(){
    
await Shell.Current.GoToAsync(nameof(HomeView));
    
}

    [RelayCommand]
    public async Task Spanish()
    {
        var culture = new CultureInfo("es-US");
        languageResourceManager.SetCulture(culture);
    }

    [RelayCommand]
    public async Task English()
    {
        var culture = new CultureInfo("en-US");
        languageResourceManager.SetCulture(culture);

    }
}
