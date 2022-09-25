using System.Windows.Forms;

public class ValidationHabilidade
{
    public bool HabilidadeEntrada(ListView listViewHabilidade, string descricao)
    {
        if (string.IsNullOrWhiteSpace(descricao))
        {
            MessageBox.Show("Informe a descrição da habilidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        foreach (ListViewItem item in listViewHabilidade.Items)
        {
            if (item.SubItems[0].Text == descricao)
            {
                MessageBox.Show("Esta habilidade já foi informada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        return true;
    }

    public bool VerificaHabilidade(ListView listViewHabilidade)
    {
        if (listViewHabilidade.Items.Count == 0)
        {
            MessageBox.Show("Informe pelo menos uma habilidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
}