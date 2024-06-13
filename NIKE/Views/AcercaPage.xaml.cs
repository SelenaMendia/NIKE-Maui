namespace NIKE.Views;

public partial class AcercaPage : ContentPage
{
	public AcercaPage()
	{
		InitializeComponent();
	}

    private void btnPrincipalVolver_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PrincipalPage());
    }

    private void MarcarNumero(object sender, EventArgs e)
    {
        var numero = "2954222653";
        Launcher.OpenAsync($"tel:{numero}");
    }

    private void EnviarCorreoConGmail(object sender, EventArgs e)
    {
        var destinatario = "selenamendia1@gmail.com";
        Launcher.OpenAsync($"mailto:{destinatario}");
    }
}