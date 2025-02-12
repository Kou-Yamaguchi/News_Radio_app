namespace News_Radio_app;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(Views.NotePage), typeof(Views.NotePage));
		// MainPage = new MainPage();
		// MainPage mainPageInstance = new MainPage();
	}
}
