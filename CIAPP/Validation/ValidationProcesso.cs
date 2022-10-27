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
}