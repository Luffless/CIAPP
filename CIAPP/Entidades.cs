using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class Entidades : Form
    {
        private readonly EntidadeDAO entidadeDAO = new EntidadeDAO();
        private readonly MenuPrincipal formMenuPrincipal;

        public Entidades(MenuPrincipal form)
        {
            InitializeComponent();
            formMenuPrincipal = form;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.BtnEntidades.BackColor = Color.FromArgb(25, 25, 112);
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
            ListView.Columns.Add("CNPJ", 250);
            ListView.Columns.Add("Razão Social", 350);
            ListView.Columns.Add("Data Credenciamento", 200);
        }

        private void CarregarRegistros()
        {
            ListView.Items.Clear();
            List<Entidade> itemList = (List<Entidade>)entidadeDAO.RecuperarTodosFiltrado(CnpjFiltro.Text, RazaoSocialFiltro.Text);

            for (int i = 0; i < itemList.Count; i++)
            {
                ListViewItem listItem = new ListViewItem(itemList[i].Id.ToString())
                {
                    Font = new Font(ListView.Font, FontStyle.Regular)
                };
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Cnpj));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].RazaoSocial));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].DataCredenciamento.ToString("dd/MM/yyyy")));
                ListView.Items.Add(listItem);
            }
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            CarregarRegistros();
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

            ListViewItem item = ListView.SelectedItems[0];

            if (MessageBox.Show("Confirma excluir este registro?", "Selecione a opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                entidadeDAO.Delete(int.Parse(item.SubItems[0].Text));
                CarregarRegistros();
            }
        }

        private void Relatorio_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = ListView.SelectedItems[0];
                Entidade entidade = entidadeDAO.RecuperarPorId(int.Parse(item.SubItems[0].Text));

                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\")) + "\\Report\\ReportEntidade.rpt");

                reportDocument.SetParameterValue("Cnpj", entidade.Cnpj);
                reportDocument.SetParameterValue("RazaoSocial", entidade.RazaoSocial);
                reportDocument.SetParameterValue("Telefone", entidade.Telefone);
                reportDocument.SetParameterValue("Email", entidade.Email);
                reportDocument.SetParameterValue("DataCredenciamento", entidade.DataCredenciamento);
                if (entidade.DataDescredenciamento == Convert.ToDateTime("01/01/0001").Date)
                {
                    reportDocument.SetParameterValue("DataDescredenciamento", " ");
                }
                else
                {
                    reportDocument.SetParameterValue("DataDescredenciamento", entidade.DataDescredenciamento);
                }
                if (string.IsNullOrWhiteSpace(entidade.Observacao))
                {
                    reportDocument.SetParameterValue("Observacao", " ");
                }
                else
                {
                    reportDocument.SetParameterValue("Observacao", entidade.Observacao);
                }
                reportDocument.SetParameterValue("Logradouro", entidade.Endereco.Logradouro);
                reportDocument.SetParameterValue("Numero", entidade.Endereco.Numero);
                if (string.IsNullOrWhiteSpace(entidade.Endereco.Complemento))
                {
                    reportDocument.SetParameterValue("Complemento", " ");
                }
                else
                {
                    reportDocument.SetParameterValue("Complemento", entidade.Endereco.Complemento);
                }
                reportDocument.SetParameterValue("Bairro", entidade.Endereco.Bairro);
                reportDocument.SetParameterValue("Municipio", entidade.Endereco.Municipio);
                reportDocument.SetParameterValue("Cep", entidade.Endereco.Cep);
                reportDocument.SetParameterValue("Estado", entidade.Endereco.Estado);

                reportDocument.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
                reportDocument.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
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