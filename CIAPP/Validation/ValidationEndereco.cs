using System.Text.RegularExpressions;
using System.Windows.Forms;

public class ValidationEndereco
{
    public bool LogradouroEntrada(string rua)
    {
        if (string.IsNullOrWhiteSpace(rua))
        {
            MessageBox.Show("Informe o logradouro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool NumeroEntrada(string numero)
    {
        if (string.IsNullOrWhiteSpace(numero))
        {
            MessageBox.Show("Informe o número!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool BairroEntrada(string bairro)
    {
        if (string.IsNullOrWhiteSpace(bairro))
        {
            MessageBox.Show("Informe o bairro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool MunicipioEntrada(string municipio)
    {
        if (string.IsNullOrWhiteSpace(municipio))
        {
            MessageBox.Show("Informe o município!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool CepEntrada(string cep)
    {
        if (string.IsNullOrWhiteSpace(cep))
        {
            MessageBox.Show("Informe o CEP!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        Regex r = new Regex("^[0-9]{5}-[0-9]{3}$");

        if (!r.IsMatch(cep))
        {
            MessageBox.Show("CEP inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool EstadoEntrada(string estado)
    {
        if (string.IsNullOrWhiteSpace(estado))
        {
            MessageBox.Show("Informe o Estado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
}