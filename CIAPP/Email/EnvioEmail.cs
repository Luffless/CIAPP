using System;
using System.IO;
using System.Net.Mail;

public class EnvioEmail
{
    public void EnviarEmailEntidade()
    {
        MailMessage message = new MailMessage("dlazzari3@ucs.br", "dlazzari3@ucs.br")
        {
            Subject = "Novo prestador - Central Integrada de Alternativas Penais!",
            Body = @"Prezados!
                     Estamos lhes entregando um novo prestador para que possa cumprir a pena realizando as atividades descritas conforme está no arquivo para ser carregado no sistema.
                   
                     Atenciosamente"
        };

        //Central -> Entidade
        //processo
        //processo_entidade (com endereco)
        //prestador (sem foto), parentesco, habilidade, deficiencia, doenca

        //Entidade -> Central
        //frequencia

        //https://www.horadecodar.com.br/2022/05/10/como-transformar-array-em-json-em-javascript/
        //https://www.horadecodar.com.br/2021/05/23/converter-objeto-javascript-para-json/
        //https://www.emailarchitect.net/easendmail/kb/csharp.aspx?cat=7
        //https://www.delftstack.com/howto/csharp/send-email-with-attachment-in-csharp/

        //O equivalente do Stringify pra C# parece ser JsonConvert.SerializeObject(myObject)

        //update frequencia
        //   set observacao = E'Teste\r\nteste'  usar \r\n pra quebrar uma linha (se tiver)

        string path = RetornaAnexoJson();

        Attachment anexo = new Attachment(path);
        message.Attachments.Add(anexo);

        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"); //Ver qual é da UCS

        try
        {
            smtpClient.Send(message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exceção ao enviar o e-mail: {0}", e.ToString());
        }
    }

    private string RetornaAnexoJson()
    {
        string path = @"C:\Users\dlazz\Downloads\InformacoesPrestador.json";

        using (FileStream fs = File.Create(path))

        return path;
    }
}