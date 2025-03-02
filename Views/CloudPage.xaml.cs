namespace News_Radio_app.Views;

public partial class CloudPage : ContentPage
{
	public CloudPage()
	{
		InitializeComponent();
	}
	    
	private async void On_article_Clicked(object sender, EventArgs e)
    {
        // ページ遷移
        await Navigation.PushAsync(new Views.Articles_detail_Page());
    }

}