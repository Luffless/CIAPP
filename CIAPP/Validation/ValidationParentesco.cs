using System.Windows.Forms;

public class ValidationParentesco
{
    public bool NomeGrauParentescoEntrada(ListView listViewParentesco, string nomeParentesco, string grauParentesco)
    {
        int qtdBisavosMulher = 0;
        int qtdBisavosHomem = 0;

        if (string.IsNullOrWhiteSpace(nomeParentesco))
        {
            MessageBox.Show("Informe o nome do parentesco!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (string.IsNullOrWhiteSpace(grauParentesco))
        {
            MessageBox.Show("Informe o grau de parentesco!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        foreach (ListViewItem item in listViewParentesco.Items)
        {
            if (item.SubItems[0].Text == nomeParentesco)
            {
                MessageBox.Show("Este nome de parentesco já foi informado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (item.SubItems[1].Text == grauParentesco && (item.SubItems[1].Text == "Mãe" || item.SubItems[1].Text == "Pai" || item.SubItems[1].Text == "Avó" || item.SubItems[1].Text == "Avô"))
            {
                MessageBox.Show("Este grau de parentesco já foi informado uma vez!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (item.SubItems[1].Text == grauParentesco && item.SubItems[1].Text == "Bisavó")
            {
                qtdBisavosMulher++;

                if (qtdBisavosMulher == 2)
                {
                    MessageBox.Show("Este grau de parentesco já foi informado duas vez!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (item.SubItems[1].Text == grauParentesco && item.SubItems[1].Text == "Bisavô")
            {
                qtdBisavosHomem++;

                if (qtdBisavosHomem == 2)
                {
                    MessageBox.Show("Este grau de parentesco já foi informado duas vez!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }

        return true;
    }

    public bool VerificaMae(ListView listViewParentesco)
    {
        foreach (ListViewItem item in listViewParentesco.Items)
        {
            if (item.SubItems[1].Text == "Mãe")
            {
                return true;
            }
        }

        MessageBox.Show("Informe a mãe do prestador!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
    }
}