using System.Windows.Forms;

public class ValidationUsuario
{
    public bool NomeEntrada(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            MessageBox.Show("Informe o nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool LoginEntrada(string login)
    {
        if (string.IsNullOrWhiteSpace(login))
        {
            MessageBox.Show("Informe o login!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        //Verificar por SQL se o login informado já existe no banco de dados

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

    public bool EmailEntrada(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            MessageBox.Show("Informe o e-mail!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        //Verificar por SQL se o e-mail informado já existe no banco de dados

        return true;
    }

    public bool EntidadeEntrada(string tipo, string entidade)
    {
        if (tipo == "Entidade")
        {
            if (string.IsNullOrWhiteSpace(entidade))
            {
                MessageBox.Show("Informe a entidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        return true;
    }
}