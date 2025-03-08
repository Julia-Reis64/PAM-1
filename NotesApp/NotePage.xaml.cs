namespace NotesApp;

public partial class NotePage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "arquivo");
    public NotePage()
	{
		InitializeComponent();
        if (File.Exists(_fileName))
        {
            TextoEditor.Text = File.ReadAllText(_fileName);
        }
	}

    private void SalvarButton_Clicked(object sender, EventArgs e)
    {
        //Salvar os arquivos
        File.WriteAllText(_fileName, TextoEditor.Text);
        DisplayAlert("Sucesso", "O arquivo está salvo!", "OK!");
    }

    private void DeletarButton_Clicked(object sender, EventArgs e)
    {
        //Deletar os arquivos
        File.Delete(_fileName);
        TextoEditor.Text = string.Empty;
        DisplayAlert("Sucesso!", "Você obliterou o arquivo!", "Beleza");


    }

}