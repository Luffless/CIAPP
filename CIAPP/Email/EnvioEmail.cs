using System.IO;
using System.Text.Json;
using Windows.Storage;

public class EnvioEmail
{
    //Escolher diretório de salvar o json
    //https://learn.microsoft.com/pt-br/dotnet/desktop/winforms/controls/how-to-choose-folders-with-the-windows-forms-folderbrowserdialog-component?view=netframeworkdesktop-4.8

    private string RetornaAnexoJson(Processo processo)
    {
        string localfolder = ApplicationData.Current.LocalFolder.Path;
        string[] array = localfolder.Split('\\');
        string username = array[2];
        string path = @"C:\Users\" + username + @"\Downloads\InformacoesPrestador" + processo.Prestador.Id + ".json";
        string json = JsonSerializer.Serialize(processo);

        EncryptDecrypt encryptTest = new EncryptDecrypt();
        string base64EncryptStringAes = encryptTest.Encrypt(json);

        if (File.Exists(path))
        {
            File.Delete(path);
        }

        File.WriteAllText(path, base64EncryptStringAes);

        return path;
    }
}