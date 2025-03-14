using RetoMaui.ViewModels;

namespace RetoMaui.Views;

public partial class HomeView : ContentPage
{
	public HomeView(HomeViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}