namespace Practica02;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnStartShoppingClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProductoPage());
    }
}
