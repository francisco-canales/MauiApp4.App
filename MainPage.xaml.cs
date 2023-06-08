namespace MauiApp4;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private void btnCambio_Clicked(object sender, EventArgs e)
    {
        double Pago = Convert.ToDouble(pago.Text);
        double Costo = Convert.ToDouble(costo.Text);
        if (Pago>Costo)
        {

            double calculo = Pago - Costo;

            DisplayAlert("Cambio Calculado", Convert.ToString(calculo).PadLeft(2, '0'), "Aceptar");
        }
        else
        {
            DisplayAlert("Error", "NO se pude calcular", "ok");
        }


    }
}

