using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class Processos : Form
    {
        private readonly ProcessoDAO processoDAO = new ProcessoDAO();
        private readonly MenuPrincipal formMenuPrincipal;
        private readonly string loginUsuarioLogado;

        public Processos(MenuPrincipal form, string usuarioLogado)
        {
            InitializeComponent();
            formMenuPrincipal = form;
            loginUsuarioLogado = usuarioLogado;
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
            ListView.Columns.Add("Prestador", 375);
            ListView.Columns.Add("Número Artigo Penal", 165);
            ListView.Columns.Add("Horas a cumprir", 135);
            ListView.Columns.Add("Horas cumpridas", 135);
        }

        private void CarregarRegistros()
        {
            int horasCumpridas;
            ListView.Items.Clear();
            List<Processo> itemList = (List<Processo>)processoDAO.RecuperarTodosFiltrado(NomePrestadorFiltro.Text, NumeroArtigoPenalFiltro.Text);

            for (int i = 0; i < itemList.Count; i++)
            {
                horasCumpridas = 0;

                for (int j = 0; j < itemList[i].ProcessoEntidadeList.Count; j++)
                {
                    for (int k = 0; k < itemList[i].ProcessoEntidadeList[j].FrequenciaList.Count; k++)
                    {
                        horasCumpridas += itemList[i].ProcessoEntidadeList[j].FrequenciaList[k].HorasCumpridas;
                    }
                }

                ListViewItem listItem = new ListViewItem(itemList[i].Id.ToString())
                {
                    Font = new Font(ListView.Font, FontStyle.Regular)
                };
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Prestador.Nome));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].NumeroArtigoPenal.ToString()));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].HorasCumprir.ToString()));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, horasCumpridas.ToString()));
                ListView.Items.Add(listItem);
            }
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            CarregarRegistros();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            new ProcessoForm("Incluir", loginUsuarioLogado).ShowDialog();
            CarregarRegistros();
        }

        private void Importar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "JSON Files(*.json)|*.json"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (new FileInfo(open.FileName).Length == 0)
                {
                    MessageBox.Show("O arquivo selecionado está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (StreamReader reader = new StreamReader(open.FileName))
                {
                    string json = reader.ReadToEnd();
                    //Frequencia frequencia = JsonSerializer.Deserialize<Frequencia>(json); //try catch
                }
            }
        }

        private void Detalhes_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = ListView.SelectedItems[0];
            ProcessoForm form = new ProcessoForm("Detalhes", loginUsuarioLogado);
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