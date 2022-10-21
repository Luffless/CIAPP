using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class Processos : Form
    {
        private readonly ProcessoDAO processoDAO = new ProcessoDAO();
        private readonly MenuPrincipal formMenuPrincipal;

        public Processos(MenuPrincipal form)
        {
            InitializeComponent();
            formMenuPrincipal = form;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.BtnProcessos.BackColor = Color.FromArgb(25, 25, 112);
            Close();
        }

        private void Processos_Load(object sender, EventArgs e)
        {
            AdicionaColunas();
            CarregarRegistros();
        }

        private void AdicionaColunas()
        {
            ListView.Font = new Font(ListView.Font, FontStyle.Bold);
            ListView.Columns.Add("ID", 30);
            ListView.Columns.Add("Prestador", 395);
            ListView.Columns.Add("Número Artigo Penal", 165);
            ListView.Columns.Add("Horas a cumprir", 130);
            ListView.Columns.Add("Data de início", 120);
        }

        private void CarregarRegistros()
        {
            ListView.Items.Clear();
            List<Processo> itemList = (List<Processo>)processoDAO.RecuperarTodosFiltrado(NomePrestadorFiltro.Text, NumeroArtigoPenalFiltro.Text);

            for (int i = 0; i < itemList.Count; i++)
            {
                ListViewItem listItem = new ListViewItem(itemList[i].Id.ToString())
                {
                    Font = new Font(ListView.Font, FontStyle.Regular)
                };
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Prestador.Nome));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].NumeroArtigoPenal.ToString()));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].HorasCumprir.ToString()));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].DataInicio.ToString("dd/MM/yyyy")));
                ListView.Items.Add(listItem);
            }
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            CarregarRegistros();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            //new ProcessoForm("Incluir").ShowDialog();
            CarregarRegistros();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            //ListViewItem item = ListView.SelectedItems[0];
            //ProcessoForm form = new ProcessoForm("Editar");
            //form.Id.Text = item.SubItems[0].Text;
            //form.ShowDialog();
            CarregarRegistros();
        }

        private void Detalhes_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            //ListViewItem item = ListView.SelectedItems[0];
            //ProcessoForm form = new ProcessoForm("Detalhes");
            //form.Id.Text = item.SubItems[0].Text;
            //form.ShowDialog();
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