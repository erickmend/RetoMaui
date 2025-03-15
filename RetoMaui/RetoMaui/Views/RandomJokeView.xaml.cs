using RetoMaui.ViewModels;

namespace RetoMaui.Views;

public partial class RandomJokeView : ContentPage
{
	public RandomJokeView(RandomJokeViewModel vm)
	{
		InitializeComponent();
				BindingContext = vm;
	}
}