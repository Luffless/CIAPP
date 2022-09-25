using System.Windows.Forms;

public class ValidationDeficiencia
{
    public bool DeficienciaEntrada(ListView listViewDeficiencia, string descricao)
    {
        if (string.IsNullOrWhiteSpace(descricao))
        {
            MessageBox.Show("Informe a descrição da deficiência!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        foreach (ListViewItem item in listViewDeficiencia.Items)
        {
            if (item.SubItems[0].Text == descricao)
            {
                MessageBox.Show("Esta deficiência já foi informada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        return true;
    }
}