using RetoMaui.ViewModels;

namespace RetoMaui.Views;

public partial class IndexView : ContentPage
{
	public IndexView(IndexViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}