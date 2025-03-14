using RetoMaui.Views;

namespace RetoMaui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		// Routing.RegisterRoute(nameof(IndexView), typeof(IndexView));
		Routing.RegisterRoute(nameof(HomeView), typeof(HomeView));
	}
}
