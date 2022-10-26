using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text.Json;
using Windows.Storage;

public class EnvioEmail
{
    public void EnviarEmailEntidade(Processo processo, List<ProcessoEntidade> processoEntidadeList, string usuarioLogado)
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        Usuario usuario = usuarioDAO.RecuperarPorLogin(usuarioLogado);

        processo.Prestador.Foto = null;
        processo.EmailCentral = usuario.Email;

        for (int i = 0; i < processoEntidadeList.Count; i++)
        {
            processo.ProcessoEntidadeList = new List<ProcessoEntidade>
            {
                processoEntidadeList[i]
            };

            MailMessage message = new MailMessage("dlazzari3@ucs.br", "dlazzari3@ucs.br") //processo.EmailCentral, processoEntidadeList[i].Entidade.Email
            {
                Subject = "Novo prestador - Central Integrada de Alternativas Penais!",
                Body = "Prezados!\n\nEstamos lhes entregando um novo prestador para que possa cumprir a pena realizando as atividades descritas conforme está no arquivo para ser carregado no sistema.\n\n\nAtenciosamente"
            };

            string path = RetornaAnexoJson(processo);

            Attachment anexo = new Attachment(path);
            message.Attachments.Add(anexo);

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587) //Tem uma forma de não ser sempre o Gmail?
            {
                Credentials = new NetworkCredential("email", "senha"), //Tem uma forma de não fazer isso?
                EnableSsl = true
            };

            smtpClient.Send(message);
        }
    }

    private string RetornaAnexoJson(Processo processo)
    {
        string localfolder = ApplicationData.Current.LocalFolder.Path;
        string[] array = localfolder.Split('\\');
        string username = array[2];
        string path = @"C:\Users\" + username + @"\Downloads\InformacoesPrestador" + processo.Prestador.Id + processo.ProcessoEntidadeList[0].Entidade.Id + ".json";
        string json = JsonSerializer.Serialize(processo);

        //Aes (síncrona - uma só chave)
        EncryptDecrypt encryptTest = new EncryptDecrypt();
        string base64EncryptStringAes = encryptTest.Encrypt(json);
        File.WriteAllText(path, base64EncryptStringAes);

        //RSA (assíncrona - uma chave pública e uma chave privada)
        //RsaEnc rs = new RsaEnc();
        //string base64EncryptStringRSA = rs.Encrypt(json);
        //File.WriteAllText(path, base64EncryptStringRSA);

        return path;
    }
}