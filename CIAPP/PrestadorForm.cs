using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class PrestadorForm : Form
    {
        private readonly ValidationPrestador validacaoPrestador = new ValidationPrestador();
        private readonly ValidationEndereco validacaoEndereco = new ValidationEndereco();
        private readonly ValidationParentesco validacaoParentesco = new ValidationParentesco();
        private readonly ValidationHabilidade validacaoHabilidade = new ValidationHabilidade();
        private readonly ValidationDeficiencia validacaoDeficiencia = new ValidationDeficiencia();
        private readonly ValidationDoenca validacaoDoenca = new ValidationDoenca();
        private readonly PrestadorDAO prestadorDAO = new PrestadorDAO();
        private readonly string manutencao;
        private byte[] bytes;

        public PrestadorForm(string man)
        {
            InitializeComponent();
            manutencao = man;
        }

        private void PrestadorForm_Load(object sender, EventArgs e)
        {
            int i;

            AdicionaColunas();

            if (manutencao == "Incluir")
            {
                Id.Text = prestadorDAO.RetornaProximoId().ToString();
            }
            else
            {
                Prestador prestador = prestadorDAO.RecuperarPorId(int.Parse(Id.Text));
                Cpf.Text = prestador.Cpf;
                Nome.Text = prestador.Nome;
                DataNascimento.Text = prestador.DataNascimento.ToString();
                Idade.Text = CalculaIdade();
                Naturalidade.Text = prestador.Naturalidade;
                EstadoCivil.Text = prestador.EstadoCivil;
                Foto.Image = Image.FromStream(new MemoryStream(prestador.Foto));
                bytes = prestador.Foto;
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
                Observacao.Text = prestador.Observacao;

                Logradouro.Text = prestador.Endereco.Logradouro;
                Numero.Text = prestador.Endereco.Numero.ToString();
                Complemento.Text = prestador.Endereco.Complemento;
                Bairro.Text = prestador.Endereco.Bairro;
                Municipio.Text = prestador.Endereco.Municipio;
                Cep.Text = prestador.Endereco.Cep;
                Estado.Text = prestador.Endereco.Estado;

                for (i = 0; i < prestador.ParentescoList.Count; i++)
                {
                    ListViewItem listItem = new ListViewItem(prestador.ParentescoList[i].Nome)
                    {
                        Font = new Font(ListViewParentesco.Font, FontStyle.Regular)
                    };
                    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, prestador.ParentescoList[i].GrauParentesco));
                    ListViewParentesco.Items.Add(listItem);
                }

                for (i = 0; i < prestador.HabilidadeList.Count; i++)
                {
                    ListViewItem listItem = new ListViewItem(prestador.HabilidadeList[i].Descricao)
                    {
                        Font = new Font(ListViewHabilidade.Font, FontStyle.Regular)
                    };
                    ListViewHabilidade.Items.Add(listItem);
                }

                for (i = 0; i < prestador.DeficienciaList.Count; i++)
                {
                    ListViewItem listItem = new ListViewItem(prestador.DeficienciaList[i].Descricao)
                    {
                        Font = new Font(ListViewDeficiencia.Font, FontStyle.Regular)
                    };
                    ListViewDeficiencia.Items.Add(listItem);
                }

                for (i = 0; i < prestador.DoencaList.Count; i++)
                {
                    ListViewItem listItem = new ListViewItem(prestador.DoencaList[i].Descricao)
                    {
                        Font = new Font(ListViewDoenca.Font, FontStyle.Regular)
                    };
                    ListViewDoenca.Items.Add(listItem);
                }
            }

            if (manutencao == "Detalhes")
            {
                Nome.Enabled = false;
                Cpf.Enabled = false;
                DataNascimento.Enabled = false;
                Naturalidade.Enabled = false;
                EstadoCivil.Enabled = false;
                Telefone.Enabled = false;
                Etnia.Enabled = false;
                Sexo.Enabled = false;
                Profissao.Enabled = false;
                RendaFamiliar.Enabled = false;
                Religiao.Enabled = false;
                GrauInstrucao.Enabled = false;
                RecebeBeneficio.Enabled = false;
                UsaAlcool.Enabled = false;
                UsaDrogas.Enabled = false;
                Observacao.Enabled = false;
                Logradouro.Enabled = false;
                Numero.Enabled = false;
                Complemento.Enabled = false;
                Bairro.Enabled = false;
                Municipio.Enabled = false;
                Cep.Enabled = false;
                Estado.Enabled = false;

                NomeParentescoLabel.Visible = false;
                NomeParentesco.Visible = false;
                GrauParentescoLabel.Visible = false;
                GrauParentesco.Visible = false;
                DescricaoHabilidadeLabel.Visible = false;
                DescricaoHabilidade.Visible = false;
                DescricaoDeficienciaLabel.Visible = false;
                DescricaoDeficiencia.Visible = false;
                DescricaoDoencaLabel.Visible = false;
                DescricaoDoenca.Visible = false;
                Selecionar.Visible = false;
                IncluirParentesco.Visible = false;
                RemoverParentesco.Visible = false;
                IncluirHabilidade.Visible = false;
                RemoverHabilidade.Visible = false;
                IncluirDeficiencia.Visible = false;
                RemoverDeficiencia.Visible = false;
                IncluirDoenca.Visible = false;
                RemoverDoenca.Visible = false;
                Salvar.Visible = false;

                Foto.Dock = DockStyle.Fill;
                ListViewParentesco.Dock = DockStyle.Fill;
                ListViewHabilidade.Dock = DockStyle.Fill;
                ListViewDeficiencia.Dock = DockStyle.Fill;
                ListViewDoenca.Dock = DockStyle.Fill;
            }
        }

        private void AdicionaColunas()
        {
            ListViewParentesco.Font = new Font(ListViewParentesco.Font, FontStyle.Bold);
            ListViewParentesco.Columns.Add("Nome", 350);
            ListViewParentesco.Columns.Add("Grau Parentesco", 150);

            ListViewHabilidade.Font = new Font(ListViewHabilidade.Font, FontStyle.Bold);
            ListViewHabilidade.Columns.Add("Descrição", 500);

            ListViewDeficiencia.Font = new Font(ListViewDeficiencia.Font, FontStyle.Bold);
            ListViewDeficiencia.Columns.Add("Descrição", 500);

            ListViewDoenca.Font = new Font(ListViewDoenca.Font, FontStyle.Bold);
            ListViewDoenca.Columns.Add("Descrição", 500);
        }

        private void Telefone_TextChanged(object sender, EventArgs e)
        {
            Telefone.Text = EhSomenteNumeros(Telefone.Text);
        }

        private void Numero_TextChanged(object sender, EventArgs e)
        {
            Numero.Text = EhSomenteNumeros(Numero.Text);
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

        private void DataNascimento_ValueChanged(object sender, EventArgs e)
        {
            DataNascimento.CustomFormat = "dd/MM/yyyy";
            Idade.Text = CalculaIdade();
        }

        private void DataNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                DataNascimento.CustomFormat = " ";
                Idade.Text = null;
            }
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

        private void RendaFamiliar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }        
            }
        }

        private void Selecionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Images Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (new FileInfo(open.FileName).Length == 0)
                {
                    MessageBox.Show("O arquivo selecionado está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (new FileInfo(open.FileName).Length > 1048576000) // 1GB
                {
                    MessageBox.Show("A foto selecionada é muito grande!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Foto.Image = new Bitmap(open.FileName);
                bytes = File.ReadAllBytes(open.FileName);
            }
        }

        private void IncluirParentesco_Click(object sender, EventArgs e)
        {
            if (!validacaoParentesco.NomeGrauParentescoEntrada(ListViewParentesco, NomeParentesco.Text, GrauParentesco.Text))
            {
                return;
            }

            ListViewItem listItem = new ListViewItem(NomeParentesco.Text)
            {
                Font = new Font(ListViewParentesco.Font, FontStyle.Regular)
            };
            listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, GrauParentesco.Text));

            ListViewParentesco.Items.Add(listItem);

            NomeParentesco.Text = null;
            GrauParentesco.Text = null;
        }

        private void RemoverParentesco_Click(object sender, EventArgs e)
        {
            if (!VerificaList(ListViewParentesco))
            {
                return;
            }

            ListViewParentesco.Items.RemoveAt(ListViewParentesco.SelectedIndices[0]);
        }

        private void IncluirHabilidade_Click(object sender, EventArgs e)
        {
            if (!validacaoHabilidade.HabilidadeEntrada(ListViewHabilidade, DescricaoHabilidade.Text))
            {
                return;
            }

            ListViewItem listItem = new ListViewItem(DescricaoHabilidade.Text)
            {
                Font = new Font(ListViewHabilidade.Font, FontStyle.Regular)
            };

            ListViewHabilidade.Items.Add(listItem);

            DescricaoHabilidade.Text = null;
        }

        private void RemoverHabilidade_Click(object sender, EventArgs e)
        {
            if (!VerificaList(ListViewHabilidade))
            {
                return;
            }

            ListViewHabilidade.Items.RemoveAt(ListViewHabilidade.SelectedIndices[0]);
        }

        private void IncluirDeficiencia_Click(object sender, EventArgs e)
        {
            if (!validacaoDeficiencia.DeficienciaEntrada(ListViewDeficiencia, DescricaoDeficiencia.Text))
            {
                return;
            }

            ListViewItem listItem = new ListViewItem(DescricaoDeficiencia.Text)
            {
                Font = new Font(ListViewDeficiencia.Font, FontStyle.Regular)
            };

            ListViewDeficiencia.Items.Add(listItem);

            DescricaoDeficiencia.Text = null;
        }

        private void RemoverDeficiencia_Click(object sender, EventArgs e)
        {
            if (!VerificaList(ListViewDeficiencia))
            {
                return;
            }

            ListViewDeficiencia.Items.RemoveAt(ListViewDeficiencia.SelectedIndices[0]);
        }

        private void IncluirDoenca_Click(object sender, EventArgs e)
        {
            if (!validacaoDoenca.DoencaEntrada(ListViewDoenca, DescricaoDoenca.Text))
            {
                return;
            }

            ListViewItem listItem = new ListViewItem(DescricaoDoenca.Text)
            {
                Font = new Font(ListViewDoenca.Font, FontStyle.Regular)
            };

            ListViewDoenca.Items.Add(listItem);

            DescricaoDoenca.Text = null;
        }

        private void RemoverDoenca_Click(object sender, EventArgs e)
        {
            if (!VerificaList(ListViewDoenca))
            {
                return;
            }

            ListViewDoenca.Items.RemoveAt(ListViewDoenca.SelectedIndices[0]);
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

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (!validacaoPrestador.CpfEntrada(int.Parse(Id.Text), Cpf.Text))
            {
                Cpf.Focus();
                return;
            }

            if (!validacaoPrestador.NomeEntrada(Nome.Text))
            {
                Nome.Focus();
                return;
            }

            if (!validacaoPrestador.DataNascimentoEntrada(DataNascimento))
            {
                DataNascimento.Focus();
                return;
            }

            if (!validacaoPrestador.NaturalidadeEntrada(Naturalidade.Text))
            {
                Naturalidade.Focus();
                return;
            }

            if (!validacaoPrestador.EstadoCivilEntrada(EstadoCivil.Text))
            {
                EstadoCivil.Focus();
                return;
            }

            if (!validacaoPrestador.FotoEntrada(Foto.Image))
            {
                return;
            }

            if (!validacaoPrestador.TelefoneEntrada(Telefone.Text))
            {
                Telefone.Focus();
                return;
            }

            if (!validacaoPrestador.EtniaEntrada(Etnia.Text))
            {
                Etnia.Focus();
                return;
            }

            if (!validacaoPrestador.SexoEntrada(Sexo.Text))
            {
                Sexo.Focus();
                return;
            }

            if (!validacaoPrestador.ProfissaoEntrada(Profissao.Text))
            {
                Profissao.Focus();
                return;
            }

            if (!validacaoPrestador.RendaFamiliarEntrada(RendaFamiliar.Text))
            {
                RendaFamiliar.Focus();
                return;
            }

            if (!validacaoPrestador.ReligiaoEntrada(Religiao.Text))
            {
                Religiao.Focus();
                return;
            }

            if (!validacaoPrestador.GrauInstrucaoEntrada(GrauInstrucao.Text))
            {
                GrauInstrucao.Focus();
                return;
            }

            if (!validacaoEndereco.LogradouroEntrada(Logradouro.Text))
            {
                Logradouro.Focus();
                return;
            }

            if (!validacaoEndereco.NumeroEntrada(Numero.Text))
            {
                Numero.Focus();
                return;
            }

            if (!validacaoEndereco.BairroEntrada(Bairro.Text))
            {
                Bairro.Focus();
                return;
            }

            if (!validacaoEndereco.MunicipioEntrada(Municipio.Text))
            {
                Municipio.Focus();
                return;
            }

            if (!validacaoEndereco.CepEntrada(Cep.Text))
            {
                Cep.Focus();
                return;
            }

            if (!validacaoEndereco.EstadoEntrada(Estado.Text))
            {
                Estado.Focus();
                return;
            }

            if (!validacaoParentesco.VerificaMae(ListViewParentesco))
            {
                return;
            }

            if (!validacaoHabilidade.VerificaHabilidade(ListViewHabilidade))
            {
                return;
            }

            Prestador prestador = new Prestador
            {
                Id = int.Parse(Id.Text),
                Cpf = Cpf.Text,
                Nome = Nome.Text,
                DataNascimento = DataNascimento.Value.Date,
                Naturalidade = Naturalidade.Text,
                EstadoCivil = EstadoCivil.Text,
                Foto = bytes,
                Telefone = long.Parse(Telefone.Text),
                Etnia = Etnia.Text,
                Sexo = Sexo.Text,
                Profissao = Profissao.Text,
                RendaFamiliar = Convert.ToDecimal(RendaFamiliar.Text, new CultureInfo("en-US")),
                Religiao = Religiao.Text,
                GrauInstrucao = GrauInstrucao.Text,
                RecebeBeneficio = RecebeBeneficio.Checked,
                UsaAlcool = UsaAlcool.Checked,
                UsaDrogas = UsaDrogas.Checked,
                Observacao = Observacao.Text,
                Endereco = new Endereco
                {
                    Logradouro = Logradouro.Text,
                    Numero = int.Parse(Numero.Text),
                    Complemento = Complemento.Text,
                    Bairro = Bairro.Text,
                    Municipio = Municipio.Text,
                    Cep = Cep.Text,
                    Estado = Estado.Text
                },
                ParentescoList = new List<Parentesco>(),
                HabilidadeList = new List<Habilidade>(),
                DeficienciaList = new List<Deficiencia>(),
                DoencaList = new List<Doenca>()
            };

            foreach (ListViewItem item in ListViewParentesco.Items)
            {
                Parentesco parentesco = new Parentesco
                {
                    Nome = item.SubItems[0].Text,
                    GrauParentesco = item.SubItems[1].Text
                };

                prestador.ParentescoList.Add(parentesco);
            }

            foreach (ListViewItem item in ListViewHabilidade.Items)
            {
                Habilidade habilidade = new Habilidade
                {
                    Descricao = item.SubItems[0].Text
                };

                prestador.HabilidadeList.Add(habilidade);
            }

            foreach (ListViewItem item in ListViewDeficiencia.Items)
            {
                Deficiencia deficiencia = new Deficiencia
                {
                    Descricao = item.SubItems[0].Text
                };

                prestador.DeficienciaList.Add(deficiencia);
            }

            foreach (ListViewItem item in ListViewDoenca.Items)
            {
                Doenca doenca = new Doenca
                {
                    Descricao = item.SubItems[0].Text
                };

                prestador.DoencaList.Add(doenca);
            }

            if (manutencao == "Incluir")
            {
                prestadorDAO.Insert(prestador);
            }
            else
            {
                prestadorDAO.Update(prestador);
            }

            Close();
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
    }
}