namespace Practica02;

public partial class ResumenPage : ContentPage
{
    public ResumenPage()
    {
        InitializeComponent();
    }
    private async void OnPreviousClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

    }
}