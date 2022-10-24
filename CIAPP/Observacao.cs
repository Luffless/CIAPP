using System.Windows.Forms;

namespace CIAPP
{
    public partial class Observacao : Form
    {
        public Observacao(string observacao)
        {
            InitializeComponent();
            ObservacaoTexto.Text = observacao;
        }
    }
}