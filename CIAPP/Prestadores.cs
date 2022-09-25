using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class Prestadores : Form
    {
        private readonly PrestadorDAO prestadorDAO = new PrestadorDAO();
        private readonly MenuPrincipal formMenuPrincipal;

        public Prestadores(MenuPrincipal form)
        {
            InitializeComponent();
            formMenuPrincipal = form;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.BtnUsuarios.BackColor = Color.FromArgb(25, 25, 112);
            formMenuPrincipal.BtnEntidades.BackColor = Color.FromArgb(25, 25, 112);
            formMenuPrincipal.BtnPrestadores.BackColor = Color.FromArgb(25, 25, 112);
            Close();
        }

        private void Prestadores_Load(object sender, EventArgs e)
        {
            AdicionaColunas();
            CarregarRegistros();
        }

        private void AdicionaColunas()
        {
            ListView.Font = new Font(ListView.Font, FontStyle.Bold);
            ListView.Columns.Add("ID", 30);
            ListView.Columns.Add("Nome", 330);
            ListView.Columns.Add("Data Nascimento", 140);
            ListView.Columns.Add("Naturalidade", 165);
            ListView.Columns.Add("Profissão", 165);
        }

        private void CarregarRegistros()
        {
            string dataNascimento;

            ListView.Items.Clear();

            if (DataNascimentoFiltro.CustomFormat == " ")
            {
                dataNascimento = null;
            }
            else
            {
                dataNascimento = DataNascimentoFiltro.Value.Date.ToString();
            }

            List<Prestador> itemList = (List<Prestador>)prestadorDAO.RecuperarTodosFiltrado(NomeFiltro.Text, dataNascimento);

            for (int i = 0; i < itemList.Count; i++)
            {
                ListViewItem listItem = new ListViewItem(itemList[i].Id.ToString())
                {
                    Font = new Font(ListView.Font, FontStyle.Regular)
                };
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Nome));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].DataNascimento.ToString("dd/MM/yyyy")));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Naturalidade));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Profissao));
                ListView.Items.Add(listItem);
            }
        }

        private void DataNascimentoFiltro_ValueChanged(object sender, EventArgs e)
        {
            DataNascimentoFiltro.CustomFormat = "dd/MM/yyyy";
        }

        private void DataNascimentoFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                DataNascimentoFiltro.CustomFormat = " ";
            }
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            CarregarRegistros();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            new PrestadorForm("Incluir").ShowDialog();
            CarregarRegistros();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = ListView.SelectedItems[0];
            PrestadorForm form = new PrestadorForm("Editar");
            form.Id.Text = item.SubItems[0].Text;
            form.ShowDialog();
            CarregarRegistros();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = ListView.SelectedItems[0];

            //Verificar se o prestador já possui algum Processo Judicial vinculado
            //(será implementado futuramente)

            if (MessageBox.Show("Confirma excluir este registro?", "Selecione a opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                prestadorDAO.Delete(int.Parse(item.SubItems[0].Text));
                CarregarRegistros();
            }
        }

        private void Detalhes_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = ListView.SelectedItems[0];
            PrestadorForm form = new PrestadorForm("Detalhes");
            form.Id.Text = item.SubItems[0].Text;
            form.ShowDialog();
        }

        private void DoubleClick_Click(object sender, EventArgs e)
        {
            Detalhes_Click(sender, e);
        }

        private bool VerificaList()
        {
            if (ListView.Items.Count == 0)
            {
                MessageBox.Show("Não há nenhum registro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro antes!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
