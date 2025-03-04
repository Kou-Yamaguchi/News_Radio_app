using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace News_Radio_app.ViewModels;

public class AboutViewModel
{
  public string Title => AppInfo.Name;
  public string Version => AppInfo.VersionString;
  public string MoreInfoUrl => "https://aka.ms/maui";
  public string Message => "This app is written in XAML and C# with .NET MAUI.";
  public ICommand ShowMoreInfoCommand { get; }

  public ICommand MoveTopCommand { get; }

  public AboutViewModel()
  {
    ShowMoreInfoCommand = new AsyncRelayCommand(ShowMoreInfo);
    MoveTopCommand = new AsyncRelayCommand(MoveTop);
  }

  async Task ShowMoreInfo() =>
      await Launcher.Default.OpenAsync(MoreInfoUrl);

  private async Task MoveTop()
  {
    await Shell.Current.GoToAsync(nameof(Views.TopPage));
  }
}
