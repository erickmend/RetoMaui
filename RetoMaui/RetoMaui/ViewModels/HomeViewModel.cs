using System;
using CommunityToolkit.Mvvm.ComponentModel;
using RetoMaui.Helpers;

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
}
