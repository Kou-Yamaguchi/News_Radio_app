namespace News_Radio_app.Views;

public partial class AllNotesPage : ContentPage
{
	public AllNotesPage()
	{
		InitializeComponent();

		Content = new VerticalStackLayout

        // PageにLabelを追加して"Welcome"を表示
        {
            Children = {
                new Label
                {
                    HorizontalOptions = LayoutOptions.Center,  // テキストを中央に配置
                    VerticalOptions = LayoutOptions.Center,  // 中央に配置
                    Text = "Welcome to Note Page",  // 表示するテキスト
                    FontSize = 30  // フォントサイズを設定
                },
				
				new Label
                {
                    HorizontalOptions = LayoutOptions.Center, 
                    VerticalOptions = LayoutOptions.Center, 
                    Text = "You can write ,record and deleat some messeage",
                    FontSize = 20  // 文字サイズを12に設定
                },

                new BoxView
                {
                    Color = Colors.Black,  // 線の色を黒に設定
                    HeightRequest = 2,     // 線の太さ（高さ）
                    HorizontalOptions = LayoutOptions.Fill // 横幅を画面いっぱいに広げる
                },    
			
            }
        };
	}

	private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
	{
		notesCollection.SelectedItem = null;
	}
}
