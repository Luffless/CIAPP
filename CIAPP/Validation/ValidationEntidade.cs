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

        Regex r = new Regex("^[0-9]{2}[\\.]?[0-9]{3}[\\.]?[0-9]{3}/[0-9]{4}[\\.]?-[0-9]{2}$");

        if (!r.IsMatch(cnpj))
        {
            MessageBox.Show("CNPJ inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        string valor = cnpj.Replace(".", "");
        valor = valor.Replace("/", "");
        valor = valor.Replace("-", "");

        int[] digitos, soma, resultado;
        int nrDig;
        string ftmt;
        bool[] CNPJOk;

        ftmt = "6543298765432";
        digitos = new int[14];
        soma = new int[2];
        soma[0] = 0;
        soma[1] = 0;
        resultado = new int[2];
        resultado[0] = 0;
        resultado[1] = 0;

        CNPJOk = new bool[2];
        CNPJOk[0] = false;
        CNPJOk[1] = false;

        for (nrDig = 0; nrDig < 14; nrDig++)
        {
            digitos[nrDig] = int.Parse(valor.Substring(nrDig, 1));

            if (nrDig <= 11)
            {
                soma[0] += digitos[nrDig] * int.Parse(ftmt.Substring(nrDig + 1, 1));
            }

            if (nrDig <= 12)
            {
                soma[1] += digitos[nrDig] * int.Parse(ftmt.Substring(nrDig, 1));
            }
        }

        for (nrDig = 0; nrDig < 2; nrDig++)
        {
            resultado[nrDig] = soma[nrDig] % 11;

            if (resultado[nrDig] == 0 || resultado[nrDig] == 1)
            {
                CNPJOk[nrDig] = digitos[12 + nrDig] == 0;
            }
            else
            {
                CNPJOk[nrDig] = digitos[12 + nrDig] == 11 - resultado[nrDig];
            }   
        }

        if (!CNPJOk[0] || !CNPJOk[1])
        {
            MessageBox.Show("CNPJ inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (entidadeDAO.ExisteCnpjIdDiferente(id, cnpj))
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

        if (entidadeDAO.ExisteEmailIdDiferente(id, email))
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