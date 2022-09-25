using System.Windows.Forms;

public class ValidationLogin
{
    private readonly UsuarioDAO usuarioDAO = new UsuarioDAO();

    public bool LoginEntrada(string login)
    {
        if (string.IsNullOrWhiteSpace(login))
        {
            MessageBox.Show("Informe o login!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

    public bool UsuarioIsValid(string login, string hashmd5)
    {
        if (!usuarioDAO.ExisteUsuarioLogin(login, hashmd5))
        {
            MessageBox.Show("Não foi encontrado o usuário informado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
}