using RetoMaui.ViewModels;

namespace RetoMaui.Views;

public partial class MapsView : ContentPage
{
	public MapsView(MapsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}