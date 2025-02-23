using System.ComponentModel;
using System.Runtime.CompilerServices;
// using System.Windows.Input;
using News_Radio_app.Models;
using Microsoft.Maui.Controls;

using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace News_Radio_app.ViewModels;

public class MiniPlayerViewModel : INotifyPropertyChanged
{
  private Models.Track _currentTrack;
  private bool _isPlaying = false;

  public event PropertyChangedEventHandler? PropertyChanged;

  public MiniPlayerViewModel()
  {
    _currentTrack = new Track
    {
      Title = "Test Title",
      Artist = "Test Artist",
      AlbumArt = "test_art_.jpg"
    };

    PlayPauseCommand = new Command(TogglePlayPause);
  }

  public string Title
  {
    get => _currentTrack.Title;
    set
    {
      _currentTrack.Title = value;
      OnPropertyChanged();
    }
  }

  public string Artist
  {
    get => _currentTrack.Artist;
    set
    {
      _currentTrack.Artist = value;
      OnPropertyChanged();
    }
  }

  public ICommand PlayPauseCommand { get; }

  public string PlayPauseIcon => _isPlaying ? "stop" : "run";

  private void TogglePlayPause()
  {
    _isPlaying = !_isPlaying;
    OnPropertyChanged(nameof(PlayPauseIcon));
  }

  protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
  {
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }
}
