public class Endereco
{
    public string Rua { get; set; }
    public int Numero { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    public string Municipio { get; set; }
    public string Cep { get; set; }
    public string Estado { get; set; }

    public Endereco() { }

    public Endereco(string rua, int numero, string complemento, string bairro, string municipio, string cep, string estado)
    {
        Rua = rua;
        Numero = numero;
        Complemento = complemento;
        Bairro = bairro;
        Municipio = municipio;
        Cep = cep;
        Estado = estado;
    }
}