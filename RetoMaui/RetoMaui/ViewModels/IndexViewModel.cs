using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RetoMaui.Views;

namespace RetoMaui.ViewModels;

public partial class IndexViewModel : ObservableObject
{

[ObservableProperty]
private string title = "hello world! This is a message from a ViewModel";



[RelayCommand]
public async Task GoToHome(){
    
await Shell.Current.GoToAsync(nameof(HomeView));
    
}
}
