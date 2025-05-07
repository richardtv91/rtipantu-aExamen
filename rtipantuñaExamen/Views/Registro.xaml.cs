namespace rtipantuñaExamen.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
        PikerVa.SelectedIndex = 0;
        PikerCiudad.SelectedIndex = 0;
	}
    public Registro(string usuario)
    {
        InitializeComponent();
        
    }
    private void PickerVa_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        var selected= PikerVa.SelectedItem?.ToString();
        
        
    }
    private void PickerCiudad_SelectedIndexChanged(Object sender, EventArgs e)
    {
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {

    }
}