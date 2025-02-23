// using News_Radio_app.ViewModels;

namespace News_Radio_app;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		// MiniPlayerVM = new MiniPlayerViewModel();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}