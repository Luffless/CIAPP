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
        private readonly ProcessoDAO processoDAO = new ProcessoDAO();
        private readonly PrestadorDAO prestadorDAO = new PrestadorDAO();
        private readonly EntidadeDAO entidadeDAO = new EntidadeDAO();
        //private readonly EnvioEmail envioEmail = new EnvioEmail();
        private readonly string manutencao;

        public ProcessoForm(string man)
        {
            InitializeComponent();
            manutencao = man;
        }

        private void ProcessoForm_Load(object sender, EventArgs e)
        {
            AdicionaColunas();

            if (manutencao == "Incluir")
            {
                Id.Text = processoDAO.RetornaProximoId().ToString();
                FrequenciaGroupBox.Visible = false;
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

                for (int i = 0; i < processo.ProcessoEntidadeList.Count; i++)
                {
                    ListViewItem listItemEntidade = new ListViewItem(processo.ProcessoEntidadeList[i].Entidade.Cnpj)
                    {
                        Font = new Font(ListViewEntidade.Font, FontStyle.Regular)
                    };
                    listItemEntidade.SubItems.Add(new ListViewItem.ListViewSubItem(listItemEntidade, processo.ProcessoEntidadeList[i].HorasCumprir.ToString()));
                    listItemEntidade.SubItems.Add(new ListViewItem.ListViewSubItem(listItemEntidade, processo.ProcessoEntidadeList[i].Atividade));
                    ListViewEntidade.Items.Add(listItemEntidade);

                    for (int j = 0; j < processo.ProcessoEntidadeList[i].FrequenciaList.Count; j++)
                    {
                        ListViewItem listItemFrequencia = new ListViewItem(processo.ProcessoEntidadeList[i].Entidade.Cnpj)
                        {
                            Font = new Font(ListViewFrequencia.Font, FontStyle.Regular)
                        };
                        listItemFrequencia.SubItems.Add(new ListViewItem.ListViewSubItem(listItemFrequencia, processo.ProcessoEntidadeList[i].FrequenciaList[j].DataFrequencia.ToString("dd/MM/yyyy")));
                        listItemFrequencia.SubItems.Add(new ListViewItem.ListViewSubItem(listItemFrequencia, processo.ProcessoEntidadeList[i].FrequenciaList[j].HorasCumpridas.ToString()));
                        listItemFrequencia.SubItems.Add(new ListViewItem.ListViewSubItem(listItemFrequencia, processo.ProcessoEntidadeList[i].FrequenciaList[j].Observacao));
                        ListViewFrequencia.Items.Add(listItemFrequencia);

                        horasCumpridas += processo.ProcessoEntidadeList[i].FrequenciaList[j].HorasCumpridas;
                    }
                }
                HorasCumpridas.Text = horasCumpridas.ToString();

                VaraOrigem.Enabled = false;
                NumeroArtigoPenal.Enabled = false;
                PenaOriginaria.Enabled = false;
                HorasCumprir.Enabled = false;
                AcordoPersecucaoPenal.Enabled = false;
                Cpf.Enabled = false;

                CnpjLabel.Visible = false;
                Cnpj.Visible = false;
                HorasCumprirLabel.Visible = false;
                HorasCumprirEntidade.Visible = false;
                AtividadeLabel.Visible = false;
                Atividade.Visible = false;
                RemoverEntidade.Visible = false;
                IncluirEntidade.Visible = false;
                Salvar.Visible = false;
                ListViewEntidade.Dock = DockStyle.Fill;
            }
        }

        private void AdicionaColunas()
        {
            ListViewEntidade.Font = new Font(ListViewEntidade.Font, FontStyle.Bold);
            ListViewEntidade.Columns.Add("CNPJ", 155);
            ListViewEntidade.Columns.Add("Horas a cumprir", 135);
            ListViewEntidade.Columns.Add("Atividade", 305);

            ListViewFrequencia.Font = new Font(ListViewFrequencia.Font, FontStyle.Bold);
            ListViewFrequencia.Columns.Add("CNPJ", 155);
            ListViewFrequencia.Columns.Add("Data da frequência", 170);
            ListViewFrequencia.Columns.Add("Horas cumpridas", 150);
        }

        private void VisualizarObservacoes_Click(object sender, EventArgs e)
        {
            if (!VerificaList(ListViewFrequencia))
            {
                return;
            }

            ListViewItem item = ListViewFrequencia.SelectedItems[0];
            new Observacao(item.SubItems[3].Text).ShowDialog();
        }

        private void DoubleClick_Click(object sender, EventArgs e)
        {
            VisualizarObservacoes_Click(sender, e);
        }

        private void NumeroArtigoPenal_TextChanged(object sender, EventArgs e)
        {
            NumeroArtigoPenal.Text = EhSomenteNumeros(NumeroArtigoPenal.Text);
        }

        private void HorasCumprir_TextChanged(object sender, EventArgs e)
        {
            HorasCumprir.Text = EhSomenteNumeros(HorasCumprir.Text);
        }

        private void HorasCumprirEntidade_TextChanged(object sender, EventArgs e)
        {
            HorasCumprirEntidade.Text = EhSomenteNumeros(HorasCumprirEntidade.Text);
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
                Prestador prestador = prestadorDAO.RecuperarPorCpf(Cpf.Text);

                if (prestador != null)
                {
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

        private void IncluirEntidade_Click(object sender, EventArgs e)
        {
            if (!validacaoProcesso.CnpjHorasAtividadeEntrada(ListViewEntidade, Cnpj.Text, HorasCumprir.Text, HorasCumprirEntidade.Text, Atividade.Text))
            {
                return;
            }

            ListViewItem listItem = new ListViewItem(Cnpj.Text)
            {
                Font = new Font(ListViewEntidade.Font, FontStyle.Regular)
            };
            listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, HorasCumprirEntidade.Text));
            listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, Atividade.Text));

            ListViewEntidade.Items.Add(listItem);

            Cnpj.Text = null;
            HorasCumprirEntidade.Text = null;
            Atividade.Text = null;
        }

        private void RemoverEntidade_Click(object sender, EventArgs e)
        {
            if (!VerificaList(ListViewEntidade))
            {
                return;
            }

            ListViewEntidade.Items.RemoveAt(ListViewEntidade.SelectedIndices[0]);
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

            if (!validacaoProcesso.HorasCumprirGeralEntidade(ListViewEntidade, HorasCumprir.Text))
            {
                return;
            }

            if (MessageBox.Show("Confirma abrir este processo e enviar o e-mail para as entidades (as informações não poderão ser alteradas)?", "Selecione a opção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Prestador prestador = prestadorDAO.RecuperarPorCpf(Cpf.Text);
            
            List<ProcessoEntidade> processoEntidadeList = new List<ProcessoEntidade>();

            foreach (ListViewItem item in ListViewEntidade.Items)
            {
                Entidade entidade = entidadeDAO.RecuperarPorCnpj(item.SubItems[0].Text);

                ProcessoEntidade processoEntidade = new ProcessoEntidade
                {
                    HorasCumprir = int.Parse(item.SubItems[1].Text),
                    Atividade = item.SubItems[2].Text,
                    Entidade = entidade
                };

                processoEntidadeList.Add(processoEntidade);
            }

            Processo processo = new Processo
            {
                Id = int.Parse(Id.Text),
                VaraOrigem = VaraOrigem.Text,
                NumeroArtigoPenal = int.Parse(NumeroArtigoPenal.Text),
                PenaOriginaria = PenaOriginaria.Text,
                HorasCumprir = int.Parse(HorasCumprir.Text),
                AcordoPersecucaoPenal = AcordoPersecucaoPenal.Checked,
                Prestador = new Prestador
                {
                    Id = prestador.Id
                },
                ProcessoEntidadeList = processoEntidadeList
            };

            processoDAO.Insert(processo);

            //envioEmail.EnviarEmailEntidade();

            Close();
        }
    }
}