using RetoMaui.Views;

namespace RetoMaui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		// Routing.RegisterRoute(nameof(IndexView), typeof(IndexView));
		Routing.RegisterRoute(nameof(HomeView), typeof(HomeView));
		Routing.RegisterRoute(nameof(BiometricsFunctionView), typeof(BiometricsFunctionView)); 
		Routing.RegisterRoute(nameof(MapsView), typeof(MapsView)); 
		Routing.RegisterRoute(nameof(RandomJokeView), typeof(RandomJokeView)); 
	}
}
