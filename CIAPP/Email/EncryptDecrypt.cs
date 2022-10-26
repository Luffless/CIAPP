//http://leandrolisura.com.br/classe-para-encriptar-e-decriptar-strings-usando-c/
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

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