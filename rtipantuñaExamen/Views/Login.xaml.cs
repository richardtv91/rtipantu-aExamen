namespace rtipantuñaExamen.Views;

public partial class Login : ContentPage
{
    private string[] user = { "estudiante2025", "uisrael", "sistemas" };
    private string[] password = { "moviles", "2025", "2025_1" };
    public Login()
	{
		InitializeComponent();
	}
    public Login(string usuario, string contraseña)
    {
        InitializeComponent();
    }
    private async void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contraseña = txtContraseña.Text;
        int index = Array.IndexOf(user, usuario);
        if (index >= 0 && password[index] == contraseña)
        {
            _ = DisplayAlert("Bienvenido", $"Hola,{usuario}!", "Cerrar");
            //Navigation.PushModalAsync(new Views.Home());
            await Navigation.PushAsync(new Views.Registro(usuario));



        }
        else
        {
            _ = DisplayAlert("Error", "Usuario o Contraseña incorrectos", "cerrar");
        }

    }
    private async void btnRegistrase_Clicked(object sender, EventArgs e)
    {
        //Navigation.PushModalAsync(new Views.Registro());
        await Navigation.PushAsync(new Views.Registro());
    }
}