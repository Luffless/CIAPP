using System.Drawing;
using System.Windows.Forms;

public class ValidationPrestador
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

    public bool DataNascimentoEntrada(DateTimePicker dataNascimento)
    {
        if (dataNascimento.CustomFormat == " ")
        {
            MessageBox.Show("Informe a data de nascimento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool NaturalidadeEntrada(string naturalidade)
    {
        if (string.IsNullOrWhiteSpace(naturalidade))
        {
            MessageBox.Show("Informe a naturalidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool EstadoCivilEntrada(string estadoCivil)
    {
        if (string.IsNullOrWhiteSpace(estadoCivil))
        {
            MessageBox.Show("Informe o estado civil!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool FotoEntrada(Image foto)
    {
        if (foto == null)
        {
            MessageBox.Show("Informe uma foto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool EtniaEntrada(string etnia)
    {
        if (string.IsNullOrWhiteSpace(etnia))
        {
            MessageBox.Show("Informe a etnia!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool ProfissaoEntrada(string profissao)
    {
        if (string.IsNullOrWhiteSpace(profissao))
        {
            MessageBox.Show("Informe a profissão!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

    public bool ReligiaoEntrada(string religiao)
    {
        if (string.IsNullOrWhiteSpace(religiao))
        {
            MessageBox.Show("Informe a religião!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool GrauInstrucaoEntrada(string grauInstrucao)
    {
        if (string.IsNullOrWhiteSpace(grauInstrucao))
        {
            MessageBox.Show("Informe o grau de instrução!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
}