using System.Text.RegularExpressions;
using System.Windows.Forms;

public class ValidationEntidade
{
    public bool RazaoSocialEntrada(string razaoSocial)
    {
        if (string.IsNullOrWhiteSpace(razaoSocial))
        {
            MessageBox.Show("Informe a razão social!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool TelefoneEntrada(string telefone)
    {
        if (string.IsNullOrWhiteSpace(telefone))
        {
            MessageBox.Show("Informe o telefone!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (telefone.Length != 11)
        {
            MessageBox.Show("Telefone inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);

        if (!reg.IsMatch(email))
        {
            MessageBox.Show("E-mail inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        //Verificar por SQL se o e-mail informado já existe no banco de dados

        return true;
    }
}