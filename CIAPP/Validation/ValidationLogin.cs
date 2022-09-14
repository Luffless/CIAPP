using System.Windows.Forms;

public class ValidationLogin
{
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

    public bool UsuarioIsValid(string hashmd5)
    {
        // Validação de que se o usuário existe no banco de dados
        /*
        if (hashmd5 != "QldDWlxEL6fWALFXL1uUvA==")
        {
            MessageBox.Show("Não foi encontrado o usuário informado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        */

        return true;
    }
}