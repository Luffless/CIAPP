using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Text.Json;

public class EnvioEmail
{
    public void EnviarEmailEntidade(Processo processo, List<ProcessoEntidade> processoEntidadeList, string usuarioLogado)
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        Usuario usuario = usuarioDAO.RecuperarPorLogin(usuarioLogado);

        processo.Prestador.Foto = null;

        for (int i = 0; i < processoEntidadeList.Count; i++)
        {
            processo.ProcessoEntidadeList = new List<ProcessoEntidade>
            {
                processoEntidadeList[i]
            };

            MailMessage message = new MailMessage("dlazzari3@ucs.br", "dlazzari3@ucs.br") //usuario.Email, processoEntidadeList[i].Entidade.Email
            {
                Subject = "Novo prestador - Central Integrada de Alternativas Penais!",
                Body = "Prezados!\n\nEstamos lhes entregando um novo prestador para que possa cumprir a pena realizando as atividades descritas conforme está no arquivo para ser carregado no sistema.\n\n\nAtenciosamente"
            };

            //Central -> Entidade
            //entidade
            //processo
            //processo_entidade
            //prestador (sem foto), endereco, parentesco, habilidade, deficiencia, doenca

            //Entidade -> Central
            //frequencia

            //https://www.horadecodar.com.br/2022/05/10/como-transformar-array-em-json-em-javascript/
            //https://www.horadecodar.com.br/2021/05/23/converter-objeto-javascript-para-json/
            //https://www.emailarchitect.net/easendmail/kb/csharp.aspx?cat=7
            //https://www.delftstack.com/howto/csharp/send-email-with-attachment-in-csharp/

            //update frequencia
            //   set observacao = E'Teste\r\nteste' usar \r\n pra quebrar uma linha (se tiver)

            string path = RetornaAnexoJson(processo);

            Attachment anexo = new Attachment(path);
            message.Attachments.Add(anexo);

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"); //Está ocorrendo erro ao enviar por ser algo externo pelo que parece

            smtpClient.Send(message);
        }
    }

    private string RetornaAnexoJson(Processo processo)
    {
        //Verificar a string de path, pois não podemos deixar fixo desse jeito
        string path = @"C:\Users\dlazz\Downloads\InformacoesPrestador" + processo.Prestador.Id + processo.ProcessoEntidadeList[0].Entidade.Id + ".json";
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