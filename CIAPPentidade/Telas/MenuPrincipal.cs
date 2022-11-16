using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace CIAPPentidade
{
    public partial class MenuPrincipal : Form
    {
        private readonly string loginUsuarioLogado;
        private readonly ProcessoDAO processoDAO = new ProcessoDAO();
        private readonly UsuarioDAO usuarioDAO = new UsuarioDAO();

        public MenuPrincipal(string usuarioLogado)
        {
            InitializeComponent();
            loginUsuarioLogado = usuarioLogado;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Usuario usuario = usuarioDAO.RecuperarPorLogin(loginUsuarioLogado);
            UsuarioLogado.Text = usuario.Nome;
            AdicionaColunas();
            CarregarRegistros();
        }

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 60;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdicionaColunas()
        {
            ListView.Font = new Font(ListView.Font, FontStyle.Bold);
            ListView.Columns.Add("ID", 30);
            ListView.Columns.Add("CPF", 165);
            ListView.Columns.Add("Nome", 375);
            ListView.Columns.Add("Horas a cumprir", 135);
            ListView.Columns.Add("Horas cumpridas", 135);
        }

        private void CarregarRegistros()
        {
            int horasCumpridas;
            ListView.Items.Clear();
            List<Processo> itemList = (List<Processo>)processoDAO.RecuperarTodosFiltrado(CpfFiltro.Text, NomeFiltro.Text);

            for (int i = 0; i < itemList.Count; i++)
            {
                horasCumpridas = 0;

                for (int j = 0; j < itemList[i].FrequenciaList.Count; j++)
                {
                    horasCumpridas += itemList[i].FrequenciaList[j].HorasCumpridas;
                }

                ListViewItem listItem = new ListViewItem(itemList[i].Id.ToString())
                {
                    Font = new Font(ListView.Font, FontStyle.Regular)
                };
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Prestador.Cpf));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Prestador.Nome));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].HorasCumprir.ToString()));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, horasCumpridas.ToString()));
                ListView.Items.Add(listItem);
            }
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            CarregarRegistros();
        }

        private void Frequencia_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = ListView.SelectedItems[0];
            ProcessoForm form = new ProcessoForm("Editar");
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
                Processo processo = processoDAO.RecuperarPorId(int.Parse(item.SubItems[0].Text));
                processoDAO.Delete(processo);
                CarregarRegistros();
            }
        }

        private void Importar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "JSON Files (*.json)|*.json"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (new FileInfo(open.FileName).Length == 0)
                {
                    MessageBox.Show("O arquivo selecionado está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Processo processo;

                using (StreamReader reader = new StreamReader(open.FileName))
                {
                    string json = reader.ReadToEnd();

                    EncryptDecrypt encryptTest = new EncryptDecrypt();
                    string jsonDescrypted = encryptTest.Decrypt(json);

                    try
                    {
                        processo = JsonSerializer.Deserialize<Processo>(jsonDescrypted);
                    }
                    catch
                    {
                        MessageBox.Show("Arquivo JSON inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                processoDAO.Delete(processo);
                processoDAO.Insert(processo);
                CarregarRegistros();

                MessageBox.Show("Arquivo JSON carregado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                int horasCumpridas = 0;

                ListViewItem item = ListView.SelectedItems[0];
                Processo processo = processoDAO.RecuperarPorId(int.Parse(item.SubItems[0].Text));

                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\")) + "\\Report\\ReportProcesso.rpt");

                reportDocument.SetParameterValue("VaraOrigem", processo.VaraOrigem);
                reportDocument.SetParameterValue("NumeroArtigoPenal", processo.NumeroArtigoPenal);
                reportDocument.SetParameterValue("PenaOriginaria", processo.PenaOriginaria);
                reportDocument.SetParameterValue("HorasCumprir", processo.HorasCumprir);
                for (int i = 0; i < processo.FrequenciaList.Count; i++)
                {
                    horasCumpridas += processo.FrequenciaList[i].HorasCumpridas;
                }
                reportDocument.SetParameterValue("HorasCumpridas", horasCumpridas);
                if (processo.AcordoPersecucaoPenal)
                {
                    reportDocument.SetParameterValue("AcordoPersecucaoPenal", "Sim");
                }
                else
                {
                    reportDocument.SetParameterValue("AcordoPersecucaoPenal", "Não");
                }
                reportDocument.SetParameterValue("Cpf", processo.Prestador.Cpf);
                reportDocument.SetParameterValue("Nome", processo.Prestador.Nome);
                reportDocument.SetParameterValue("DataNascimento", processo.Prestador.DataNascimento);
                reportDocument.SetParameterValue("Idade", CalculaIdade(processo.Prestador.DataNascimento));
                reportDocument.SetParameterValue("Naturalidade", processo.Prestador.Naturalidade);
                reportDocument.SetParameterValue("EstadoCivil", processo.Prestador.EstadoCivil);
                reportDocument.SetParameterValue("Telefone", processo.Prestador.Telefone);
                reportDocument.SetParameterValue("Etnia", processo.Prestador.Etnia);
                reportDocument.SetParameterValue("Sexo", processo.Prestador.Sexo);
                reportDocument.SetParameterValue("Profissao", processo.Prestador.Profissao);
                reportDocument.SetParameterValue("RendaFamiliar", processo.Prestador.RendaFamiliar.ToString("0.00", CultureInfo.InvariantCulture));
                reportDocument.SetParameterValue("Religiao", processo.Prestador.Religiao);
                reportDocument.SetParameterValue("GrauInstrucao", processo.Prestador.GrauInstrucao);
                if (processo.Prestador.RecebeBeneficio)
                {
                    reportDocument.SetParameterValue("RecebeBeneficio", "Sim");
                }
                else
                {
                    reportDocument.SetParameterValue("RecebeBeneficio", "Não");
                }
                if (processo.Prestador.UsaAlcool)
                {
                    reportDocument.SetParameterValue("UsaAlcool", "Sim");
                }
                else
                {
                    reportDocument.SetParameterValue("UsaAlcool", "Não");
                }
                if (processo.Prestador.UsaDrogas)
                {
                    reportDocument.SetParameterValue("UsaDrogas", "Sim");
                }
                else
                {
                    reportDocument.SetParameterValue("UsaDrogas", "Não");
                }
                if (string.IsNullOrWhiteSpace(processo.Prestador.Observacao))
                {
                    reportDocument.SetParameterValue("Observacao", " ");
                }
                else
                {
                    reportDocument.SetParameterValue("Observacao", processo.Prestador.Observacao);
                }
                reportDocument.SetParameterValue("Logradouro", processo.Prestador.Endereco.Logradouro);
                reportDocument.SetParameterValue("Numero", processo.Prestador.Endereco.Numero);
                if (string.IsNullOrWhiteSpace(processo.Prestador.Endereco.Complemento))
                {
                    reportDocument.SetParameterValue("Complemento", " ");
                }
                else
                {
                    reportDocument.SetParameterValue("Complemento", processo.Prestador.Endereco.Complemento);
                }
                reportDocument.SetParameterValue("Bairro", processo.Prestador.Endereco.Bairro);
                reportDocument.SetParameterValue("Municipio", processo.Prestador.Endereco.Municipio);
                reportDocument.SetParameterValue("Cep", processo.Prestador.Endereco.Cep);
                reportDocument.SetParameterValue("Estado", processo.Prestador.Endereco.Estado);

                reportDocument.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
                reportDocument.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
            }
        }

        private int CalculaIdade(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;

            if (DateTime.Now.Month < dataNascimento.Month || (DateTime.Now.Month == dataNascimento.Month && DateTime.Now.Day < dataNascimento.Day))
            {
                idade--;
            }

            return idade;
        }

        private void Detalhes_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = ListView.SelectedItems[0];
            ProcessoForm form = new ProcessoForm("Detalhes");
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