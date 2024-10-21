namespace Practica02;

public partial class ProductoPage : ContentPage
{
    public ProductoPage()
    {
        InitializeComponent();
    }
    private async void OnPreviousClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnNextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UnidadesPage());
    }
}