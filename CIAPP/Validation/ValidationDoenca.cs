using System.Windows.Forms;

public class ValidationDoenca
{
    public bool DoencaEntrada(ListView listViewDoenca, string descricao)
    {
        if (string.IsNullOrWhiteSpace(descricao))
        {
            MessageBox.Show("Informe a descrição da doença!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        foreach (ListViewItem item in listViewDoenca.Items)
        {
            if (item.SubItems[0].Text == descricao)
            {
                MessageBox.Show("Esta doença já foi informada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        return true;
    }
}