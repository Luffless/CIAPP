using System.Windows.Forms;

public class ValidationAtividade
{
    public bool AtividadeEntrada(ListView listViewAtividade, string descricao)
    {
        if (string.IsNullOrWhiteSpace(descricao))
        {
            MessageBox.Show("Informe a descrição da atividade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        foreach (ListViewItem item in listViewAtividade.Items)
        {
            if (item.SubItems[0].Text == descricao)
            {
                MessageBox.Show("Esta atividade já foi informada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        return true;
    }

    public bool VerificaAtividade(ListView listViewAtividade)
    {
        if (listViewAtividade.Items.Count == 0)
        {
            MessageBox.Show("Informe pelo menos uma atividade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
}