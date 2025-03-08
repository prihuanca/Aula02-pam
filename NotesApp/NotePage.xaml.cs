namespace NotesApp;

public partial class NotePage : ContentPage
{
    string fileName = Path.Combine(FileSystem.AppDataDirectory, "config.DAT");

    public NotePage()
	{
		InitializeComponent();
		if (File.Exists(fileName))
	}

	private void SalvarButton_Clicked(object sender, EventArgs e)
	{

		File.WriteAllText(fileName, TextoEditor.Text);
        DisplayAlert("Sucesso", "O texto foi salvo com sucesso.", "Certo");
    }

	private void DeletarButton_Clicked(Object sender, EventArgs e)
	{
		File.Delete(fileName);
        DisplayAlert("Sucesso", "O arquivo foi deletado com sucesso.", "Certo");
    }
}
