namespace News_Radio_app.Views;

public partial class Home : Window
{
    public Home()
    {
        InitializeComponent();
        Page = new ContentPage()
        {
            Content = new VerticalStackLayout
            {
                Children = {
                    new Label
                    {
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Start,
                        Text = "Welcome News Radio App!!",
                        FontSize = 30  // 文字サイズを30に設定
                    },
                    new BoxView
                    {
                        Color = Colors.Black,  // 線の色を黒に設定
                        HeightRequest = 2,     // 線の太さ（高さ）
                        HorizontalOptions = LayoutOptions.Fill // 横幅を画面いっぱいに広げる
                    },
                    new Label
                    {
                        HorizontalOptions = LayoutOptions.End, // 右詰めに配置
                        VerticalOptions = LayoutOptions.Start, // 上部に配置
                        Text = "Yamaguti, Naoya",
                        FontSize = 12  // 文字サイズを12に設定
                    }
                }
            }
        };
    }
}
