namespace News_Radio_app.Views;

using System.Diagnostics;

public partial class TopPage : ContentPage
{

        private List<Button> dynamicButtons;
		
        public TopPage()
		{
				InitializeComponent();
                dynamicButtons = new List<Button>(); // ボタンリストの初期化
		}
	
    // 追加ボタンがクリックされた時の処理
    private void OnAddButtonClicked(object sender, EventArgs e)
    {
        // 追加ボタンが押されると、Entryと作成ボタンを表示
        MyEntry.IsVisible = true; // テキストボックスを表示
        MyEntry.Text = ""; // テキストボックスをクリア
        MyEntry.Focus(); // 入力フィールドにフォーカスを当てる
        MyEntry.Placeholder = "ボタンの名前を入力"; // プレースホルダーのテキストを設定

        // ボタン作成ボタンを表示
        MyCreateButton.IsVisible = true;
    }

    // 入力されたテキストを使ってボタンを作成
    private void OnCreateButtonClicked(object sender, EventArgs e)
    {
        string buttonText = MyEntry.Text;

        // テキストが空でなければボタンを作成
        if (!string.IsNullOrEmpty(buttonText))
        {
            CreateDynamicButton(buttonText); // ボタンを作成するメソッドを呼び出し
        }
        else
        {
            Debug.WriteLine("テキストが入力されていません");
        }

        // 作成が完了したら、テキストボックスと作成ボタンを非表示にする
        MyEntry.IsVisible = false;
        MyCreateButton.IsVisible = false;
    }


// ボタンを動的に作成するメソッド
    private void CreateDynamicButton(string buttonText)
    {
        var newButton = new Button
        {
            Text = buttonText,
            WidthRequest = 150,
            HeightRequest = 150,
            Margin = new Thickness(5)
        };

        // ボタンのクリックイベント
        newButton.Clicked += (sender, e) => OnDynamicButtonClicked(sender, e);

        // ボタンをレイアウトに追加
        MyStackLayout.Children.Add(newButton);
    }


    // ボタンを削除
    private void RemoveButton(Button button)
    {
        dynamicButtons.Remove(button);
        MyStackLayout.Children.Remove(button);
    }

    // 動的に追加したボタンのクリックイベント
    private void OnDynamicButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            // ボタンがクリックされた時の処理を記述
            Debug.WriteLine($"{button.Text} ボタンがクリックされました");
        }
    }


    // 削除ボタンを押した時の処理
    private void OnRemoveButtonClicked(object sender, EventArgs e)
    {
        if (dynamicButtons.Count > 0)
        {
            var buttonToRemove = dynamicButtons.Last(); // 最後に追加したボタンを削除
            RemoveButton(buttonToRemove);
        }
    }



    // イベントハンドラーの定義

        private async void On_Cloud_Botten_Clicked(object sender, EventArgs e)
        {
            // ページ遷移
            await Navigation.PushAsync(new Views.CloudPage());
        }

        private async void On_AI_Botten_Clicked(object sender, EventArgs e)
        {
            // ページ遷移
            await Navigation.PushAsync(new Views.AIPage());
        }


}



	