using Microsoft.Maui.Controls;
using News_Radio_app.ViewModels; // ViewModel を参照

namespace News_Radio_app.Controls;

public partial class MiniPlayerView : ContentView
{
	public MiniPlayerView()
	{
		InitializeComponent();
		// BindingContext = new MiniPlayerViewModel();
	}
}