namespace MauiTest2023;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

	void Button_Clicked(System.Object sender, System.EventArgs e)
	{
		Navigation.PushAsync(new AnotherPage());
	}
}