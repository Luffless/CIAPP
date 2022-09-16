using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class Entidades : Form
    {
        private readonly List<Entidade> itemList = new List<Entidade>();
        private readonly MenuPrincipal formMenuPrincipal;

        public Entidades(MenuPrincipal form)
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

        private void Entidades_Load(object sender, EventArgs e)
        {
            CarregarRegistros();
        }

        private void CarregarRegistros()
        {
            string dataDescredenciamento;

            dataGridView.Rows.Clear();
            itemList.Clear();

            //SQL de busca de registros aqui
            //For só pra teste
            for (int j = 0; j < 5; j++)
            {
                Entidade entidade = new Entidade
                {
                    Id = j + 1,
                    RazaoSocial = "Nome da Entidade",
                    Telefone = 54999995555,
                    DataCredenciamento = DateTime.Today,
                    DataDescredenciamento = default
                };
                itemList.Add(entidade);
            }

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].DataDescredenciamento != default)
                {
                    dataDescredenciamento = itemList[i].DataDescredenciamento.ToString("dd/MM/yyyy");
                }
                else
                {
                    dataDescredenciamento = null;
                }

                string[] row = { itemList[i].Id.ToString(), itemList[i].RazaoSocial, itemList[i].Telefone.ToString(), itemList[i].DataCredenciamento.ToString("dd/MM/yyyy"), dataDescredenciamento };
                dataGridView.Rows.Add(row);
            }
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            new EntidadeForm("Incluir").ShowDialog();
            CarregarRegistros();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            DataGridViewRow row = dataGridView.SelectedRows[0];
            EntidadeForm form = new EntidadeForm("Editar");
            form.Id.Text = row.Cells["Id"].Value.ToString();
            form.ShowDialog();
            CarregarRegistros();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            //Verificar se a entidade já possui algum Processo Judicial vinculado

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

            DataGridViewRow row = dataGridView.SelectedRows[0];
            EntidadeForm form = new EntidadeForm("Detalhes");
            form.Id.Text = row.Cells["Id"].Value.ToString();
            form.ShowDialog();
        }

        private void DoubleClick_Click(object sender, EventArgs e)
        {
            Detalhes_Click(sender, e);
        }

        private bool VerificaList()
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Não há nenhum registro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}