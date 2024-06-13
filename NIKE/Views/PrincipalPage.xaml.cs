namespace NIKE.Views;

public partial class PrincipalPage : ContentPage
{
	public PrincipalPage()
	{
		InitializeComponent();
	}

    private void btnLoginVolver_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginPage());
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AcercaPage());
    }
}