namespace Practica02;

public partial class UnidadesPage : ContentPage
{
    public UnidadesPage()
    {
        InitializeComponent();
    }

    private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
        CantidadLabel.Text = $"Unidades: {e.NewValue}";
    }

    private async void OnPreviousClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnNextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DireccionPage());
    }
}
