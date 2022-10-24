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

        string valor = cpf.Replace(".", "");
        valor = valor.Replace("-", "");

        bool igual = true;

        for (int i = 1; i < 11 && igual; i++)
        {
            if (valor[i] != valor[0])
            {
                igual = false;
            } 
        }

        if (igual || valor == "12345678909")
        {
            MessageBox.Show("CPF inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        int[] numeros = new int[11];

        for (int i = 0; i < 11; i++)
        {
            numeros[i] = int.Parse(valor[i].ToString());
        }

        int soma = 0;

        for (int i = 0; i < 9; i++)
        {
            soma += (10 - i) * numeros[i];
        }

        int resultado = soma % 11;

        if (resultado == 1 || resultado == 0)
        {
            if (numeros[9] != 0)
            {
                MessageBox.Show("CPF inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        if (numeros[9] != 11 - resultado)
        {
            MessageBox.Show("CPF inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        soma = 0;

        for (int i = 0; i < 10; i++)
        {
            soma += (11 - i) * numeros[i];
        }

        resultado = soma % 11;

        if (resultado == 1 || resultado == 0)
        {
            if (numeros[10] != 0)
            {
                MessageBox.Show("CPF inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        if (numeros[10] != 11 - resultado)
        {
            MessageBox.Show("CPF inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (prestadorDAO.ExisteCpfIdDiferente(id, cpf))
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