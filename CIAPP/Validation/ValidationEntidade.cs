using System.Text.RegularExpressions;
using System.Windows.Forms;

public class ValidationEntidade
{
    private readonly EntidadeDAO entidadeDAO = new EntidadeDAO();

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

        if (entidadeDAO.ExisteEmail(id, email))
        {
            MessageBox.Show("E-mail informado já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool DataCredenciamentoEntrada(DateTimePicker dataCredenciamento)
    {
        if (dataCredenciamento.CustomFormat == " ")
        {
            MessageBox.Show("Informe a data de credenciamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool DataDescredenciamentoEntrada(DateTimePicker dataCredenciamento, DateTimePicker dataDescredenciamento)
    {
        if (dataDescredenciamento.CustomFormat == "dd/MM/yyyy" && dataDescredenciamento.Value < dataCredenciamento.Value)
        {
            MessageBox.Show("Data de descredenciamento não pode ser menor que a data de credenciamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
}