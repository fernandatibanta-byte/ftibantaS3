namespace ftibantaS3.Views;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private async void btnGuardarUsuario_Clicked(object sender, EventArgs e)
    {
        string usuarioNuevo = txtUsuarioNuevo.Text;
        string contraseniaNueva = txtContrasenia.Text;

        await Navigation.PushAsync(new vLogin(usuarioNuevo, contraseniaNueva));
        await DisplayAlertAsync("BIENVENIDO", "Usuario Guardado","Cerrar");
    }

    private async void btnCancelar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new vLogin());
    }
}