using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class Usuarios : Form
    {
        private readonly List<Usuario> itemList = new List<Usuario>();

        public Usuarios()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Tipo.SelectedItem = Tipo.Items[0];
            AdicionaColunas();
            CarregarRegistros();
        }

        private void AdicionaColunas()
        {
            listView.Font = new Font(listView.Font, FontStyle.Bold);
            listView.Columns.Add("Nome", 220);
            listView.Columns.Add("Login", 220);
            listView.Columns.Add("Tipo", 80);
            listView.Columns.Add("E-mail", 300);
        }

        private void CarregarRegistros()
        {
            listView.Items.Clear();

            //SQL de busca de registros aqui
            //For só pra teste
            for (int j = 0; j < 50; j++)
            {
                Usuario usuario1 = new Usuario();
                usuario1.Nome = "Daniel";
                usuario1.Login = "daniel";
                usuario1.Tipo = "Fórum";
                usuario1.Email = "daniel";
                itemList.Add(usuario1);
            }

            for (int i = 0; i < itemList.Count; i++)
            {
                ListViewItem listItem = new ListViewItem(itemList[i].Nome)
                {
                    Font = new Font(listView.Font, FontStyle.Regular)
                };
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Login));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Tipo));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Email));
                listView.Items.Add(listItem);
            }
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            //Abrir tela de inserir novo registro
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count == 0)
            {
                MessageBox.Show("Não há nenhum registro para editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro antes para editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Abrir tela de editar registro
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count == 0)
            {
                MessageBox.Show("Não há nenhum registro para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro antes para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //SQL de exclusão de registro
        }
    }
}