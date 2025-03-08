namespace NotesApp;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}
	private void PerfilButton_Clicked(object sender, EventArgs e)
	{
		Uri link = new Uri("https://github.com/prihuanca");
		Launcher.OpenAsync(link);

	}
}