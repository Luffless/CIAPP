using System;
using System.Windows.Forms;

namespace CIAPPentidade
{
    public partial class Observacao : Form
    {
        private readonly ProcessoForm formProcessoForm;
        private readonly string manutencao;

        public Observacao(ProcessoForm form, string observacao, string man)
        {
            InitializeComponent();
            formProcessoForm = form;
            ObservacaoTexto.Text = observacao;
            manutencao = man;
        }

        private void Observacao_Load(object sender, EventArgs e)
        {
            if (manutencao == "Detalhes")
            {
                ObservacaoTexto.Enabled = false;
            }
        }

        private void Close(object sender, FormClosedEventArgs e)
        {
            formProcessoForm.ObservacaoRetorno = ObservacaoTexto.Text;
            Close();
        }
    }
}