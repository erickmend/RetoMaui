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
public void ChangeLanguage(string cultureCode)
{
    if (!string.IsNullOrWhiteSpace(cultureCode))
    {
        var culture = new CultureInfo(cultureCode);
        languageResourceManager?.SetCulture(culture);
    }
}
     
}
