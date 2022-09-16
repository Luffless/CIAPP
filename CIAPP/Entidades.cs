﻿using System;
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
            AdicionaColunas();
            CarregarRegistros();
        }

        private void AdicionaColunas()
        {
            ListView.Font = new Font(ListView.Font, FontStyle.Bold);
            ListView.Columns.Add("ID", 30);
            ListView.Columns.Add("Razão Social", 290);
            ListView.Columns.Add("Telefone", 100);
            ListView.Columns.Add("Data Credenciamento", 200);
            ListView.Columns.Add("Data Descredenciamento", 210);
        }

        private void CarregarRegistros()
        {
            ListView.Items.Clear();
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
                ListViewItem listItem = new ListViewItem(itemList[i].Id.ToString())
                {
                    Font = new Font(ListView.Font, FontStyle.Regular)
                };
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].RazaoSocial));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Telefone.ToString()));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].DataCredenciamento.ToString("dd/MM/yyyy")));
                if (itemList[i].DataDescredenciamento != default)
                {
                    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].DataDescredenciamento.ToString("dd/MM/yyyy")));
                }
                ListView.Items.Add(listItem);
            }
        }

        private void DataCredenciamentoFiltro_ValueChanged(object sender, EventArgs e)
        {
            DataCredenciamentoFiltro.CustomFormat = "dd/MM/yyyy";
        }

        private void DataCredenciamentoFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                DataCredenciamentoFiltro.CustomFormat = " ";
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

            ListViewItem item = ListView.SelectedItems[0];
            EntidadeForm form = new EntidadeForm("Editar");
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

            ListViewItem item = ListView.SelectedItems[0];
            EntidadeForm form = new EntidadeForm("Detalhes");
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