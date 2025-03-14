using RetoMaui.ViewModels;

namespace RetoMaui.Views;

public partial class BiometricsFunctionView : ContentPage
{
	public BiometricsFunctionView(BiometricsFunctionViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}