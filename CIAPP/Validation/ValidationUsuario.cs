using System.Text.RegularExpressions;
using System.Windows.Forms;

public class ValidationUsuario
{
    private readonly UsuarioDAO usuarioDAO = new UsuarioDAO();

    public bool NomeEntrada(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            MessageBox.Show("Informe o nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool EmailEntrada(int id, string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            MessageBox.Show("Informe o e-mail!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);

        if (!reg.IsMatch(email))
        {
            MessageBox.Show("E-mail inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (usuarioDAO.ExisteEmail(id, email))
        {
            MessageBox.Show("E-mail informado já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool LoginEntrada(int id, string login)
    {
        if (string.IsNullOrWhiteSpace(login))
        {
            MessageBox.Show("Informe o login!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (usuarioDAO.ExisteLogin(id, login))
        {
            MessageBox.Show("Login informado já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool SenhaEntrada(string senha)
    {
        if (string.IsNullOrWhiteSpace(senha))
        {
            MessageBox.Show("Informe a senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
}