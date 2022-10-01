using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class ValidationPrestador
{
    private readonly PrestadorDAO prestadorDAO = new PrestadorDAO();

    public bool CpfEntrada(int id, string cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf))
        {
            MessageBox.Show("Informe o CPF!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        Regex r = new Regex("^[0-9]{3}[\\.]?[0-9]{3}[\\.]?[0-9]{3}-[0-9]{2}$");

        if (!r.IsMatch(cpf))
        {
            MessageBox.Show("CPF inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (prestadorDAO.ExisteCpf(id, cpf))
        {
            MessageBox.Show("CPF informado já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

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

        if (dataNascimento.Value > DateTime.Today.Date)
        {
            MessageBox.Show("Data de nascimento inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            MessageBox.Show("Selecione uma foto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

    public bool EtniaEntrada(string etnia)
    {
        if (string.IsNullOrWhiteSpace(etnia))
        {
            MessageBox.Show("Informe a etnia!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool SexoEntrada(string sexo)
    {
        if (string.IsNullOrWhiteSpace(sexo))
        {
            MessageBox.Show("Informe o sexo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

    public bool RendaFamiliarEntrada(string rendaFamiliar)
    {
        if (string.IsNullOrWhiteSpace(rendaFamiliar))
        {
            MessageBox.Show("Informe a renda familiar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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