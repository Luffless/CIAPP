using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class Usuarios : Form
    {
        private readonly List<Usuario> itemList = new List<Usuario>();
        private readonly MenuPrincipal formMenuPrincipal;

        public Usuarios(MenuPrincipal form)
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

        private void Usuarios_Load(object sender, EventArgs e)
        {
            TipoFiltro.SelectedItem = TipoFiltro.Items[0];
            AdicionaColunas();
            CarregarRegistros();
        }

        private void AdicionaColunas()
        {
            ListView.Font = new Font(ListView.Font, FontStyle.Bold);
            ListView.Columns.Add("ID", 30);
            ListView.Columns.Add("Nome", 210);
            ListView.Columns.Add("Login", 200);
            ListView.Columns.Add("Tipo", 80);
            ListView.Columns.Add("E-mail", 300);
        }

        private void CarregarRegistros()
        {
            ListView.Items.Clear();
            itemList.Clear();

            //SQL de busca de registros aqui, não buscar o usuário de código zero, pois é o usuário admin (primeiro usuário)
            //For só pra teste
            for (int j = 0; j < 50; j++)
            {
                Usuario usuario = new Usuario
                {
                    Id = j + 1,
                    Nome = "Daniel",
                    Login = "daniel",
                    Tipo = "Fórum",
                    Email = "daniel"
                };
                itemList.Add(usuario);
            }

            for (int i = 0; i < itemList.Count; i++)
            {
                ListViewItem listItem = new ListViewItem(itemList[i].Id.ToString())
                {
                    Font = new Font(ListView.Font, FontStyle.Regular)
                };
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Nome));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Login));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Tipo));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Email));
                ListView.Items.Add(listItem);
            }
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            new UsuarioForm("Incluir").ShowDialog();
            CarregarRegistros();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = ListView.SelectedItems[0];
            UsuarioForm form = new UsuarioForm("Editar");
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
            if (item.SubItems[3].Text == "Entidade")
            {
                //Verificar se o usuário com o tipo 'Entidade' já possui algum Processo Judicial vinculado em sua entidade
            }

            if (MessageBox.Show("Confirma excluir este registro?", "Selecione a opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //SQL de exclusão de registro
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
            UsuarioForm form = new UsuarioForm("Detalhes");
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