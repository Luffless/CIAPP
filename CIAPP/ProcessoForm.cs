using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class ProcessoForm : Form
    {
        private readonly ValidationProcesso validacaoProcesso = new ValidationProcesso();
        private readonly ValidationAtividade validacaoAtividade = new ValidationAtividade();
        private readonly ValidationFrequencia validacaoFrequencia = new ValidationFrequencia();
        private readonly ProcessoDAO processoDAO = new ProcessoDAO();
        private readonly PrestadorDAO prestadorDAO = new PrestadorDAO();
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

            if (manutencao == "Incluir")
            {
                Id.Text = processoDAO.RetornaProximoId().ToString();
                HorasCumpridas.Text = "0";
            }
            else
            {
                int horasCumpridas = 0;
                Processo processo = processoDAO.RecuperarPorId(int.Parse(Id.Text));
                VaraOrigem.Text = processo.VaraOrigem;
                NumeroArtigoPenal.Text = processo.NumeroArtigoPenal.ToString();
                PenaOriginaria.Text = processo.PenaOriginaria;
                HorasCumprir.Text = processo.HorasCumprir.ToString();
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
            }

            if (manutencao == "Detalhes")
            {
                VaraOrigem.Enabled = false;
                NumeroArtigoPenal.Enabled = false;
                PenaOriginaria.Enabled = false;
                HorasCumprir.Enabled = false;
                AcordoPersecucaoPenal.Enabled = false;
                Cpf.Enabled = false;

                DescricaoAtividadeLabel.Visible = false;
                DescricaoAtividade.Visible = false;
                RemoverAtividade.Visible = false;
                IncluirAtividade.Visible = false;
                DataFrequenciaLabel.Visible = false;
                DataFrequencia.Visible = false;
                HorasCumpridasFrequenciaLabel.Visible = false;
                HorasCumpridasFrequencia.Visible = false;
                IncluirFrequencia.Visible = false;
                RemoverFrequencia.Visible = false;
                Salvar.Visible = false;

                ListViewAtividade.Dock = DockStyle.Fill;
                ListViewFrequencia.Dock = DockStyle.Left;
            }
        }

        private void AdicionaColunas()
        {
            ListViewAtividade.Font = new Font(ListViewAtividade.Font, FontStyle.Bold);
            ListViewAtividade.Columns.Add("Atividade", 500);

            ListViewFrequencia.Font = new Font(ListViewFrequencia.Font, FontStyle.Bold);
            ListViewFrequencia.Columns.Add("Data da frequência", 250);
            ListViewFrequencia.Columns.Add("Horas cumpridas", 250);
        }

        private void Observacao_Click(object sender, EventArgs e)
        {
            if (!VerificaList(ListViewFrequencia))
            {
                return;
            }

            ListViewItem item = ListViewFrequencia.SelectedItems[0];
            new Observacao(this, item.SubItems[2].Text, manutencao).ShowDialog();
            item.SubItems[2].Text = ObservacaoRetorno;
        }

        private void DoubleClick_Click(object sender, EventArgs e)
        {
            Observacao_Click(sender, e);
        }

        private void NumeroArtigoPenal_TextChanged(object sender, EventArgs e)
        {
            NumeroArtigoPenal.Text = EhSomenteNumeros(NumeroArtigoPenal.Text);
        }

        private void HorasCumprir_TextChanged(object sender, EventArgs e)
        {
            HorasCumprir.Text = EhSomenteNumeros(HorasCumprir.Text);
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

        private string EhSomenteNumeros(string text)
        {
            if (Regex.IsMatch(text, "[^0-9]"))
            {
                MessageBox.Show("Digite somente números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text = text.Remove(text.Length - 1);
            }

            return text;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
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

        private void Cpf_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Cpf.Text))
            {
                if (!processoDAO.ExisteCpfProcessoDiferente(int.Parse(Id.Text), Cpf.Text))
                {
                    LimparCamposPrestador();
                    return;
                }

                Prestador prestador = prestadorDAO.RecuperarPorCpf(Cpf.Text);
                Nome.Text = prestador.Nome;
                DataNascimento.Text = prestador.DataNascimento.ToString();
                Idade.Text = CalculaIdade();
                Naturalidade.Text = prestador.Naturalidade;
                EstadoCivil.Text = prestador.EstadoCivil;
                Foto.Image = Image.FromStream(new MemoryStream(prestador.Foto));
                Telefone.Text = prestador.Telefone.ToString();
                Etnia.Text = prestador.Etnia;
                Sexo.Text = prestador.Sexo;
                Profissao.Text = prestador.Profissao;
                RendaFamiliar.Text = prestador.RendaFamiliar.ToString("0.00", CultureInfo.InvariantCulture);
                Religiao.Text = prestador.Religiao;
                GrauInstrucao.Text = prestador.GrauInstrucao;
                RecebeBeneficio.Checked = prestador.RecebeBeneficio;
                UsaAlcool.Checked = prestador.UsaAlcool;
                UsaDrogas.Checked = prestador.UsaDrogas;
            }
            else
            {
                LimparCamposPrestador();
            }
        }

        private void LimparCamposPrestador()
        {
            Nome.Text = null;
            DataNascimento.Text = null;
            Idade.Text = null;
            Naturalidade.Text = null;
            EstadoCivil.Text = null;
            Foto.Image = null;
            Telefone.Text = null;
            Etnia.Text = null;
            Sexo.Text = null;
            Profissao.Text = null;
            RendaFamiliar.Text = null;
            Religiao.Text = null;
            GrauInstrucao.Text = null;
            RecebeBeneficio.Checked = false;
            UsaAlcool.Checked = false;
            UsaDrogas.Checked = false;
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

        private void DataNascimento_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nome.Text))
            {
                DataNascimento.CustomFormat = " ";
            }
            else
            {
                DataNascimento.CustomFormat = "dd/MM/yyyy";
            }
        }

        private bool VerificaList(ListView listView)
        {
            if (listView.Items.Count == 0)
            {
                MessageBox.Show("Não há nenhum registro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro antes!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void IncluirAtividade_Click(object sender, EventArgs e)
        {
            if (!validacaoAtividade.AtividadeEntrada(ListViewAtividade, DescricaoAtividade.Text))
            {
                return;
            }

            ListViewItem listItem = new ListViewItem(DescricaoAtividade.Text)
            {
                Font = new Font(ListViewAtividade.Font, FontStyle.Regular)
            };

            ListViewAtividade.Items.Add(listItem);

            DescricaoAtividade.Text = null;
        }

        private void RemoverAtividade_Click(object sender, EventArgs e)
        {
            if (!VerificaList(ListViewAtividade))
            {
                return;
            }

            ListViewAtividade.Items.RemoveAt(ListViewAtividade.SelectedIndices[0]);
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
            if (!VerificaList(ListViewFrequencia))
            {
                return;
            }

            ListViewFrequencia.Items.RemoveAt(ListViewFrequencia.SelectedIndices[0]);
            HorasCumpridas.Text = AtualizaHorasCumpridas().ToString();
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

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (!validacaoProcesso.VaraOrigemEntrada(VaraOrigem.Text))
            {
                VaraOrigem.Focus();
                return;
            }

            if (!validacaoProcesso.NumeroArtigoPenalEntrada(NumeroArtigoPenal.Text))
            {
                NumeroArtigoPenal.Focus();
                return;
            }

            if (!validacaoProcesso.PenaOriginariaEntrada(PenaOriginaria.Text))
            {
                PenaOriginaria.Focus();
                return;
            }

            if (!validacaoProcesso.HorasCumprirEntrada(HorasCumprir.Text))
            {
                HorasCumprir.Focus();
                return;
            }

            if (!validacaoProcesso.CpfEntrada(Cpf.Text))
            {
                Cpf.Focus();
                return;
            }

            if (!validacaoAtividade.VerificaAtividade(ListViewAtividade))
            {
                return;
            }

            if (!validacaoFrequencia.VerificaFrequencia(ListViewFrequencia, int.Parse(HorasCumprir.Text)))
            {
                return;
            }

            Processo processo = new Processo
            {
                Id = int.Parse(Id.Text),
                VaraOrigem = VaraOrigem.Text,
                NumeroArtigoPenal = int.Parse(NumeroArtigoPenal.Text),
                PenaOriginaria = PenaOriginaria.Text,
                HorasCumprir = int.Parse(HorasCumprir.Text),
                AcordoPersecucaoPenal = AcordoPersecucaoPenal.Checked,
                Prestador = prestadorDAO.RecuperarPorCpf(Cpf.Text),
                AtividadeList = new List<Atividade>(),
                FrequenciaList = new List<Frequencia>()
            };

            foreach (ListViewItem item in ListViewAtividade.Items)
            {
                Atividade atividade = new Atividade
                {
                    Descricao = item.SubItems[0].Text
                };

                processo.AtividadeList.Add(atividade);
            }

            foreach (ListViewItem item in ListViewFrequencia.Items)
            {
                Frequencia frequencia = new Frequencia
                {
                    DataFrequencia = DateTime.Parse(item.SubItems[0].Text).Date,
                    HorasCumpridas = int.Parse(item.SubItems[1].Text),
                    Observacao = item.SubItems[2].Text
                };

                processo.FrequenciaList.Add(frequencia);
            }

            if (manutencao == "Incluir")
            {
                processoDAO.Insert(processo);
            }
            else
            {
                processoDAO.Update(processo);
            }

            Close();
        }
    }
}