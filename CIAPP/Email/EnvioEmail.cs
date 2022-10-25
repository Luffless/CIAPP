using System;
using System.IO;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

public class EnvioEmail
{
    public void EnviarEmailEntidade(Processo processo)
    {
        MailMessage message = new MailMessage("dlazzari3@ucs.br", "dlazzari3@ucs.br")
        {
            Subject = "Novo prestador - Central Integrada de Alternativas Penais!",
            Body = "Prezados!\n\nEstamos lhes entregando um novo prestador para que possa cumprir a pena realizando as atividades descritas conforme está no arquivo para ser carregado no sistema.\n\n\nAtenciosamente"
        };

        processo.Prestador.Foto = null;

        //Central -> Entidade
        //processo
        //processo_entidade
        //prestador (sem foto), endereco, parentesco, habilidade, deficiencia, doenca

        //Entidade -> Central
        //frequencia

        //https://www.horadecodar.com.br/2022/05/10/como-transformar-array-em-json-em-javascript/
        //https://www.horadecodar.com.br/2021/05/23/converter-objeto-javascript-para-json/
        //https://www.emailarchitect.net/easendmail/kb/csharp.aspx?cat=7
        //https://www.delftstack.com/howto/csharp/send-email-with-attachment-in-csharp/

        //O equivalente do Stringify pra C# parece ser JsonConvert.SerializeObject(myObject)

        //update frequencia
        //   set observacao = E'Teste\r\nteste' usar \r\n pra quebrar uma linha (se tiver)

        string path = RetornaAnexoJson(processo);

        Attachment anexo = new Attachment(path);
        message.Attachments.Add(anexo);

        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"); //Está ocorrendo erro ao enviar por ser algo externo pelo que parece

        try
        {
            smtpClient.Send(message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exceção ao enviar o e-mail: {0}", e.ToString());
        }
    }

    private string RetornaAnexoJson(Processo processo)
    {
        string path = @"C:\Users\dlazz\Downloads\InformacoesPrestador" + processo.Prestador.Id + ".json";
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

//http://leandrolisura.com.br/classe-para-encriptar-e-decriptar-strings-usando-c/
public class EncryptDecrypt
{
    public byte[] Key { get; set; }
    public byte[] IniVetor { get; set; }
    public Aes Algorithm { get; set; }

    public EncryptDecrypt()
    {
        Key = new byte[] { 12, 2, 56, 117, 12, 67, 33, 23, 12, 2, 56, 117, 12, 67, 33, 23 };
        IniVetor = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        Algorithm = Aes.Create();
    }

    public string Encrypt(string entryText)
    {
        byte[] symEncryptedData;

        byte[] dataToProtectAsArray = Encoding.UTF8.GetBytes(entryText);
        using (ICryptoTransform encryptor = Algorithm.CreateEncryptor(Key, IniVetor))
        using (MemoryStream memoryStream = new MemoryStream())
        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
        {
            cryptoStream.Write(dataToProtectAsArray, 0, dataToProtectAsArray.Length);
            cryptoStream.FlushFinalBlock();
            symEncryptedData = memoryStream.ToArray();
        }
        Algorithm.Dispose();
        return Convert.ToBase64String(symEncryptedData);
    }

    public string Decrypt(string entryText)
    {
        byte[] symEncryptedData = Convert.FromBase64String(entryText);
        byte[] symUnencryptedData;
        using (ICryptoTransform decryptor = Algorithm.CreateDecryptor(Key, IniVetor))
        using (MemoryStream memoryStream = new MemoryStream())
        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Write))
        {
            cryptoStream.Write(symEncryptedData, 0, symEncryptedData.Length);
            cryptoStream.FlushFinalBlock();
            symUnencryptedData = memoryStream.ToArray();
        }
        Algorithm.Dispose();
        return Encoding.Default.GetString(symUnencryptedData);
    }
}

//https://www.hardware.com.br/comunidade/trabalho-criptografia/1495305/
public class RsaEnc
{
    private RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
    private RSAParameters privateKey;
    private RSAParameters publicKey;

    public RsaEnc()
    {
        privateKey = csp.ExportParameters(true);
        publicKey = csp.ExportParameters(false);
    }

    //ver como é a chave pública rs.PublicKeySring()
    public string PublicKeySring()
    {
        StringWriter sw = new StringWriter();
        XmlSerializer xs = new XmlSerializer(typeof(RSAParameters));
        xs.Serialize(sw, publicKey);
        return sw.ToString();
    }

    public string Encrypt(string plainText)
    {
        csp = new RSACryptoServiceProvider();
        csp.ImportParameters(publicKey);

        byte[] data = Encoding.Unicode.GetBytes(plainText);
        byte[] symEncryptedData = csp.Encrypt(data, false);
        return Convert.ToBase64String(symEncryptedData);
    }

    public string Decrypt(string cypherText)
    {
        byte[] dataBytes = Convert.FromBase64String(cypherText);
        csp.ImportParameters(privateKey);
        byte[] symUnencryptedData = csp.Decrypt(dataBytes, false);
        return Encoding.Unicode.GetString(symUnencryptedData);
    }
}