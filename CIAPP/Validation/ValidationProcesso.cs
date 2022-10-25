using System.Windows.Forms;

public class ValidationProcesso
{
    private readonly ProcessoDAO processoDAO = new ProcessoDAO();
    private readonly PrestadorDAO prestadorDAO = new PrestadorDAO();
    private readonly EntidadeDAO entidadeDAO = new EntidadeDAO();

    public bool VaraOrigemEntrada(string varaOrigem)
    {
        if (string.IsNullOrWhiteSpace(varaOrigem))
        {
            MessageBox.Show("Informe a vara de origem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool NumeroArtigoPenalEntrada(string numeroArtigoPenal)
    {
        if (string.IsNullOrWhiteSpace(numeroArtigoPenal))
        {
            MessageBox.Show("Informe o número do artigo penal!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool PenaOriginariaEntrada(string penaOriginaria)
    {
        if (string.IsNullOrWhiteSpace(penaOriginaria))
        {
            MessageBox.Show("Informe a pena originária!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool HorasCumprirEntrada(string horasCumprir)
    {
        if (string.IsNullOrWhiteSpace(horasCumprir))
        {
            MessageBox.Show("Informe as horas a cumprir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (int.Parse(horasCumprir) == 0)
        {
            MessageBox.Show("Horas a cumprir inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool CpfEntrada(string cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf))
        {
            MessageBox.Show("Informe o CPF do prestador!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!prestadorDAO.ExisteCpf(cpf))
        {
            MessageBox.Show("O CPF do prestador informado não existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (processoDAO.ExisteCpfProcesso(cpf))
        {
            MessageBox.Show("O CPF do prestador informado já existe em outro processo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public bool CnpjHorasAtividadeEntrada(ListView listViewEntidade, string cnpj, string horasCumprir, string horasCumprirEntidade, string atividade)
    {
        int horasTotalEntidade = 0;

        if (string.IsNullOrWhiteSpace(cnpj))
        {
            MessageBox.Show("Informe o CNPJ da entidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!entidadeDAO.ExisteCnpj(cnpj))
        {
            MessageBox.Show("O CNPJ da entidade informado não existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        foreach (ListViewItem item in listViewEntidade.Items)
        {
            if (item.SubItems[0].Text == cnpj)
            {
                MessageBox.Show("Este CNPJ já foi informado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            horasTotalEntidade += int.Parse(item.SubItems[1].Text);
        }

        if (entidadeDAO.ExisteEntidadeDescredenciada(cnpj))
        {
            MessageBox.Show("O CNPJ da entidade informado possui data de descredenciamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (string.IsNullOrWhiteSpace(horasCumprirEntidade))
        {
            MessageBox.Show("Informe as horas a cumprir da entidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (int.Parse(horasCumprirEntidade) == 0)
        {
            MessageBox.Show("Horas a cumprir da entidade inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (string.IsNullOrWhiteSpace(atividade))
        {
            MessageBox.Show("Informe a atividade a ser realizada na entidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (string.IsNullOrWhiteSpace(horasCumprir))
        {
            MessageBox.Show("Informe antes as horas a cumprir do processo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        } 

        return true;
    }

    public bool HorasCumprirGeralEntidade(ListView listViewEntidade, string horasCumprir)
    {
        int horasTotalEntidade = 0;

        if (listViewEntidade.Items.Count == 0)
        {
            MessageBox.Show("Informe pelo menos uma entidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        foreach (ListViewItem item in listViewEntidade.Items)
        {
            horasTotalEntidade += int.Parse(item.SubItems[1].Text);
        }

        if (int.Parse(horasCumprir) != horasTotalEntidade)
        {
            MessageBox.Show("A soma das horas a cumprir das entidades é diferente das horas a cumprir do processo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
}