using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace CIAPPentidade
{
    public partial class ProcessoForm : Form
    {
        private readonly ValidationFrequencia validacaoFrequencia = new ValidationFrequencia();
        private readonly ProcessoDAO processoDAO = new ProcessoDAO();
        private readonly string manutencao;
        public string ObservacaoRetorno;

        public ProcessoForm(string man)
        {
            InitializeComponent();
            manutencao = man;
        }

        private void ProcessoForm_Load(object sender, EventArgs e)
        {
            int i;

            AdicionaColunas();

            int horasCumpridas = 0;
            Processo processo = processoDAO.RecuperarPorId(int.Parse(Id.Text));
            VaraOrigem.Text = processo.VaraOrigem;
            NumeroArtigoPenal.Text = processo.NumeroArtigoPenal.ToString();
            PenaOriginaria.Text = processo.PenaOriginaria;
            HorasCumprir.Text = processo.HorasCumprir.ToString();
            AcordoPersecucaoPenal.Checked = processo.AcordoPersecucaoPenal;
            Cpf.Text = processo.Prestador.Cpf;
            Nome.Text = processo.Prestador.Nome;
            DataNascimento.Text = processo.Prestador.DataNascimento.ToString();
            Idade.Text = CalculaIdade();
            Naturalidade.Text = processo.Prestador.Naturalidade;
            EstadoCivil.Text = processo.Prestador.EstadoCivil;
            Foto.Image = Image.FromStream(new MemoryStream(processo.Prestador.Foto));
            Telefone.Text = processo.Prestador.Telefone.ToString();
            Etnia.Text = processo.Prestador.Etnia;
            Sexo.Text = processo.Prestador.Sexo;
            Profissao.Text = processo.Prestador.Profissao;
            RendaFamiliar.Text = processo.Prestador.RendaFamiliar.ToString("0.00", CultureInfo.InvariantCulture);
            Religiao.Text = processo.Prestador.Religiao;
            GrauInstrucao.Text = processo.Prestador.GrauInstrucao;
            RecebeBeneficio.Checked = processo.Prestador.RecebeBeneficio;
            UsaAlcool.Checked = processo.Prestador.UsaAlcool;
            UsaDrogas.Checked = processo.Prestador.UsaDrogas;
            Observacao.Text = processo.Prestador.Observacao;

            Logradouro.Text = processo.Prestador.Endereco.Logradouro;
            Numero.Text = processo.Prestador.Endereco.Numero.ToString();
            Complemento.Text = processo.Prestador.Endereco.Complemento;
            Bairro.Text = processo.Prestador.Endereco.Bairro;
            Municipio.Text = processo.Prestador.Endereco.Municipio;
            Cep.Text = processo.Prestador.Endereco.Cep;
            Estado.Text = processo.Prestador.Endereco.Estado;

            for (i = 0; i < processo.Prestador.ParentescoList.Count; i++)
            {
                ListViewItem listItem = new ListViewItem(processo.Prestador.ParentescoList[i].Nome)
                {
                    Font = new Font(ListViewParentesco.Font, FontStyle.Regular)
                };
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, processo.Prestador.ParentescoList[i].GrauParentesco));
                ListViewParentesco.Items.Add(listItem);
            }

            for (i = 0; i < processo.Prestador.HabilidadeList.Count; i++)
            {
                ListViewItem listItem = new ListViewItem(processo.Prestador.HabilidadeList[i].Descricao)
                {
                    Font = new Font(ListViewHabilidade.Font, FontStyle.Regular)
                };
                ListViewHabilidade.Items.Add(listItem);
            }

            for (i = 0; i < processo.Prestador.DeficienciaList.Count; i++)
            {
                ListViewItem listItem = new ListViewItem(processo.Prestador.DeficienciaList[i].Descricao)
                {
                    Font = new Font(ListViewDeficiencia.Font, FontStyle.Regular)
                };
                ListViewDeficiencia.Items.Add(listItem);
            }

            for (i = 0; i < processo.Prestador.DoencaList.Count; i++)
            {
                ListViewItem listItem = new ListViewItem(processo.Prestador.DoencaList[i].Descricao)
                {
                    Font = new Font(ListViewDoenca.Font, FontStyle.Regular)
                };
                ListViewDoenca.Items.Add(listItem);
            }

            for (i = 0; i < processo.AtividadeList.Count; i++)
            {
                ListViewItem listItemAtividade = new ListViewItem(processo.AtividadeList[i].Descricao)
                {
                    Font = new Font(ListViewAtividade.Font, FontStyle.Regular)
                };
                ListViewAtividade.Items.Add(listItemAtividade);
            }

            for (i = 0; i < processo.FrequenciaList.Count; i++)
            {
                ListViewItem listItemFrequencia = new ListViewItem(processo.FrequenciaList[i].DataFrequencia.ToString("dd/MM/yyyy"))
                {
                    Font = new Font(ListViewFrequencia.Font, FontStyle.Regular)
                };
                listItemFrequencia.SubItems.Add(new ListViewItem.ListViewSubItem(listItemFrequencia, processo.FrequenciaList[i].HorasCumpridas.ToString()));
                listItemFrequencia.SubItems.Add(new ListViewItem.ListViewSubItem(listItemFrequencia, processo.FrequenciaList[i].Observacao));
                ListViewFrequencia.Items.Add(listItemFrequencia);

                horasCumpridas += processo.FrequenciaList[i].HorasCumpridas;
            }

            HorasCumpridas.Text = horasCumpridas.ToString();

            if (manutencao == "Detalhes")
            {
                VaraOrigem.Enabled = false;
                NumeroArtigoPenal.Enabled = false;
                PenaOriginaria.Enabled = false;
                HorasCumprir.Enabled = false;
                AcordoPersecucaoPenal.Enabled = false;
                Cpf.Enabled = false;

                DataFrequenciaLabel.Visible = false;
                DataFrequencia.Visible = false;
                HorasCumpridasFrequenciaLabel.Visible = false;
                HorasCumpridasFrequencia.Visible = false;
                IncluirFrequencia.Visible = false;
                RemoverFrequencia.Visible = false;
                Salvar.Visible = false;

                ListViewFrequencia.Dock = DockStyle.Left;
            }
            else
            {
                ExportarFrequencia.Visible = false;
            }
        }

        private void AdicionaColunas()
        {
            ListViewParentesco.Font = new Font(ListViewParentesco.Font, FontStyle.Bold);
            ListViewParentesco.Columns.Add("Nome", 520);
            ListViewParentesco.Columns.Add("Grau Parentesco", 150);

            ListViewHabilidade.Font = new Font(ListViewHabilidade.Font, FontStyle.Bold);
            ListViewHabilidade.Columns.Add("Descrição", 670);

            ListViewDeficiencia.Font = new Font(ListViewDeficiencia.Font, FontStyle.Bold);
            ListViewDeficiencia.Columns.Add("Descrição", 670);

            ListViewDoenca.Font = new Font(ListViewDoenca.Font, FontStyle.Bold);
            ListViewDoenca.Columns.Add("Descrição", 670);

            ListViewAtividade.Font = new Font(ListViewAtividade.Font, FontStyle.Bold);
            ListViewAtividade.Columns.Add("Atividade", 680);

            ListViewFrequencia.Font = new Font(ListViewFrequencia.Font, FontStyle.Bold);
            ListViewFrequencia.Columns.Add("Data da frequência", 250);
            ListViewFrequencia.Columns.Add("Horas cumpridas", 250);
        }

        private string CalculaIdade()
        {
            int idade = DateTime.Now.Year - DataNascimento.Value.Year;

            if (DateTime.Now.Month < DataNascimento.Value.Month || (DateTime.Now.Month == DataNascimento.Value.Month && DateTime.Now.Day < DataNascimento.Value.Day))
            {
                idade--;
            }

            return idade.ToString();
        }

        private void DataFrequencia_ValueChanged(object sender, EventArgs e)
        {
            DataFrequencia.CustomFormat = "dd/MM/yyyy";
        }

        private void DataFrequencia_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                DataFrequencia.CustomFormat = " ";
            }
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                SelectNextControl(ActiveControl, false, true, true, true);
                e.Handled = true;
            }
        }

        private void IncluirFrequencia_Click(object sender, EventArgs e)
        {
            if (!validacaoFrequencia.DataFrequenciaHorasCumpridasEntrada(ListViewFrequencia, DataFrequencia, HorasCumpridasFrequencia.Text))
            {
                return;
            }

            ListViewItem listItem = new ListViewItem(DataFrequencia.Value.Date.ToString("dd/MM/yyyy"))
            {
                Font = new Font(ListViewFrequencia.Font, FontStyle.Regular)
            };
            listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, HorasCumpridasFrequencia.Text));
            listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, null)); //Observação

            ListViewFrequencia.Items.Add(listItem);
            HorasCumpridas.Text = AtualizaHorasCumpridas().ToString();

            DataFrequencia.CustomFormat = " ";
            HorasCumpridasFrequencia.Text = null;
        }

        private void RemoverFrequencia_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewFrequencia.Items.RemoveAt(ListViewFrequencia.SelectedIndices[0]);
            HorasCumpridas.Text = AtualizaHorasCumpridas().ToString();
        }

        private bool VerificaList()
        {
            if (ListViewFrequencia.Items.Count == 0)
            {
                MessageBox.Show("Não há nenhum registro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ListViewFrequencia.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro antes!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private int AtualizaHorasCumpridas()
        {
            int horasCumpridas = 0;

            foreach (ListViewItem item in ListViewFrequencia.Items)
            {
                horasCumpridas += int.Parse(item.SubItems[1].Text);
            }

            return horasCumpridas;
        }

        private void ExportarFrequencia_Click(object sender, EventArgs e)
        {
            if (ListViewFrequencia.Items.Count == 0)
            {
                MessageBox.Show("Não há nenhum registro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = false,
                Description = "Selecione o diretório que você deseja usar para salvar o arquivo."
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                List<Frequencia> frequenciaList = new List<Frequencia>();

                foreach (ListViewItem item in ListViewFrequencia.Items)
                {
                    Frequencia frequencia = new Frequencia
                    {
                        DataFrequencia = DateTime.Parse(item.SubItems[0].Text),
                        HorasCumpridas = int.Parse(item.SubItems[1].Text),
                        Observacao = item.SubItems[2].Text
                    };

                    frequenciaList.Add(frequencia);
                }

                string json = JsonSerializer.Serialize(frequenciaList);
                EncryptDecrypt encryptTest = new EncryptDecrypt();
                string base64EncryptStringAes = encryptTest.Encrypt(json);

                folderBrowserDialog.SelectedPath += @"\InformacoesFrequencias" + Id.Text + ".json";

                if (File.Exists(folderBrowserDialog.SelectedPath))
                {
                    File.Delete(folderBrowserDialog.SelectedPath);
                }

                File.WriteAllText(folderBrowserDialog.SelectedPath, base64EncryptStringAes);

                MessageBox.Show(string.Format("Arquivo salvo no diretório {0}", folderBrowserDialog.SelectedPath), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ObservacaoFrequencia_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            ListViewItem item = ListViewFrequencia.SelectedItems[0];
            new Observacao(this, item.SubItems[2].Text, manutencao).ShowDialog();
            item.SubItems[2].Text = ObservacaoRetorno;
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (!validacaoFrequencia.VerificaFrequencia(ListViewFrequencia, int.Parse(HorasCumprir.Text)))
            {
                return;
            }

            List<Frequencia> frequenciaList = new List<Frequencia>();

            foreach (ListViewItem item in ListViewFrequencia.Items)
            {
                Frequencia frequencia = new Frequencia
                {
                    DataFrequencia = DateTime.Parse(item.SubItems[0].Text),
                    HorasCumpridas = int.Parse(item.SubItems[1].Text),
                    Observacao = item.SubItems[2].Text
                };

                frequenciaList.Add(frequencia);
            }

            processoDAO.DeletaInsereFrequencia(int.Parse(Id.Text), frequenciaList);

            Close();
        }
    }
}