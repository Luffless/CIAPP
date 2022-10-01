using System.Text.RegularExpressions;
using System.Windows.Forms;

public class ValidationEntidade
{
    private readonly EntidadeDAO entidadeDAO = new EntidadeDAO();

    public bool CnpjEntrada(int id, string cnpj)
    {
        if (string.IsNullOrWhiteSpace(cnpj))
        {
            MessageBox.Show("Informe o CNPJ!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        //XX.XXX.XXX/0001-XX
        //Regex r = new Regex("^[0-9]{3}[\\.]?[0-9]{3}[\\.]?[0-9]{3}-[0-9]{2}$");
        Regex r = new Regex("^[0-9]{2}[\\.]?[0-9]{3}[\\.]?[0-9]{3}/[0-9]{4}[\\.]?-[0-9]{2}$");

        if (!r.IsMatch(cnpj))
        {
            MessageBox.Show("CNPJ inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (entidadeDAO.ExisteCnpj(id, cnpj))
        {
            MessageBox.Show("CNPJ informado já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

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