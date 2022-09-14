public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Login { get; set; }
    public string Senha { get; set; }
    public string Email { get; set; }
    public string Tipo { get; set; }

    public Usuario() { }

    public Usuario(int id, string nome, string login, string senha, string email, string tipo)
    {
        Id = id;
        Nome = nome;
        Login = login;
        Senha = senha;
        Email = email;
        Tipo = tipo;
    }
}