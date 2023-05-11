namespace MauiTest2023;

public partial class AnotherPage : ContentPage
{
	public AnotherPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}