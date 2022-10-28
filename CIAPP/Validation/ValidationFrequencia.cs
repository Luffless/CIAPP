using System.Windows.Forms;

public class ValidationFrequencia
{
    public bool DataFrequenciaHorasCumpridasEntrada(ListView listViewFrequencia, DateTimePicker dataFrequencia, string horasCumpridasFrequencia)
    {
        if (dataFrequencia.CustomFormat == " ")
        {
            MessageBox.Show("Informe a data da frequência!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (string.IsNullOrWhiteSpace(horasCumpridasFrequencia))
        {
            MessageBox.Show("Informe as horas cumpridas da frequência!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        foreach (ListViewItem item in listViewFrequencia.Items)
        {
            if (item.SubItems[0].Text == dataFrequencia.Value.Date.ToString("dd/MM/yyyy"))
            {
                MessageBox.Show("Este registro de frequência com esta data já foi informado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        return true;
    }

    public bool VerificaFrequencia(ListView listViewFrequencia, int horasCumprir)
    {
        int horasCumpridas = 0;

        foreach (ListViewItem item in listViewFrequencia.Items)
        {
            horasCumpridas += int.Parse(item.SubItems[1].Text);
        }

        if (horasCumpridas > horasCumprir)
        {
            MessageBox.Show("A soma das horas cumpridas das frequências é maior do que as horas a cumprir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
}