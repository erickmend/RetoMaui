using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace RetoMaui.ViewModels;

public partial class HomeViewModel : ObservableObject
{
[ObservableProperty]
private string title = "HomeView title";
}
