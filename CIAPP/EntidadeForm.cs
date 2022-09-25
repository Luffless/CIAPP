using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class EntidadeForm : Form
    {
        private readonly ValidationEntidade validacaoEntidade = new ValidationEntidade();
        private readonly ValidationEndereco validacaoEndereco = new ValidationEndereco();
        private readonly EntidadeDAO entidadeDAO = new EntidadeDAO();
        private readonly string manutencao;

        public EntidadeForm(string man)
        {
            InitializeComponent();
            manutencao = man;
        }

        private void EntidadeForm_Load(object sender, EventArgs e)
        {
            if (manutencao == "Incluir")
            {
                Id.Text = entidadeDAO.RetornaProximoId().ToString();
            }
            else
            {
                Entidade entidade = entidadeDAO.RecuperarPorId(int.Parse(Id.Text));
                RazaoSocial.Text = entidade.RazaoSocial;
                Telefone.Text = entidade.Telefone.ToString();
                Email.Text = entidade.Email;
                DataCredenciamento.Text = entidade.DataCredenciamento.ToString();
                if (entidade.DataDescredenciamento.Date != Convert.ToDateTime("01/01/0001").Date)
                {
                    DataDescredenciamento.Text = entidade.DataDescredenciamento.ToString();
                }
                Observacao.Text = entidade.Observacao;

                Rua.Text = entidade.Endereco.Rua;
                Numero.Text = entidade.Endereco.Numero.ToString();
                Complemento.Text = entidade.Endereco.Complemento;
                Bairro.Text = entidade.Endereco.Bairro;
                Municipio.Text = entidade.Endereco.Municipio;
                Cep.Text = entidade.Endereco.Cep;
                Estado.Text = entidade.Endereco.Estado;
            }

            if (manutencao == "Detalhes")
            {
                RazaoSocial.Enabled = false;
                Telefone.Enabled = false;
                Email.Enabled = false;
                DataCredenciamento.Enabled = false;
                DataDescredenciamento.Enabled = false;
                Observacao.Enabled = false;
                Rua.Enabled = false;
                Numero.Enabled = false;
                Complemento.Enabled = false;
                Bairro.Enabled = false;
                Municipio.Enabled = false;
                Cep.Enabled = false;
                Estado.Enabled = false;

                Salvar.Visible = false;
            }
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

        private void DataCredenciamento_ValueChanged(object sender, EventArgs e)
        {
            DataCredenciamento.CustomFormat = "dd/MM/yyyy";
        }

        private void DataDescredenciamento_ValueChanged(object sender, EventArgs e)
        {
            DataDescredenciamento.CustomFormat = "dd/MM/yyyy";
        }

        private void DataCredenciamento_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                DataCredenciamento.CustomFormat = " ";
            }
        }

        private void DataDescredenciamento_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                DataDescredenciamento.CustomFormat = " ";
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (!validacaoEntidade.RazaoSocialEntrada(RazaoSocial.Text))
            {
                RazaoSocial.Focus();
                return;
            }

            if (!validacaoEntidade.TelefoneEntrada(Telefone.Text))
            {
                Telefone.Focus();
                return;
            }

            if (!validacaoEntidade.EmailEntrada(int.Parse(Id.Text), Email.Text))
            {
                Email.Focus();
                return;
            }

            if (!validacaoEntidade.DataCredenciamentoEntrada(DataCredenciamento))
            {
                DataCredenciamento.Focus();
                return;
            }

            if (!validacaoEntidade.DataDescredenciamentoEntrada(DataCredenciamento, DataDescredenciamento))
            {
                DataDescredenciamento.Focus();
                return;
            }

            if (!validacaoEndereco.RuaEntrada(Rua.Text))
            {
                Rua.Focus();
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

            Entidade entidade;

            if (DataDescredenciamento.CustomFormat == " ")
            {
                entidade = new Entidade
                {
                    Id = int.Parse(Id.Text),
                    RazaoSocial = RazaoSocial.Text,
                    Telefone = long.Parse(Telefone.Text),
                    Email = Email.Text,
                    DataCredenciamento = DataCredenciamento.Value.Date,
                    Observacao = Observacao.Text,
                    Endereco = new Endereco
                    {
                        Rua = Rua.Text,
                        Numero = int.Parse(Numero.Text),
                        Complemento = Complemento.Text,
                        Bairro = Bairro.Text,
                        Municipio = Municipio.Text,
                        Cep = Cep.Text,
                        Estado = Estado.Text
                    }
                };
            }
            else
            {
                entidade = new Entidade
                {
                    Id = int.Parse(Id.Text),
                    RazaoSocial = RazaoSocial.Text,
                    Telefone = long.Parse(Telefone.Text),
                    Email = Email.Text,
                    DataCredenciamento = DataCredenciamento.Value.Date,
                    DataDescredenciamento = DataDescredenciamento.Value.Date,
                    Observacao = Observacao.Text,
                    Endereco = new Endereco
                    {
                        Rua = Rua.Text,
                        Numero = int.Parse(Numero.Text),
                        Complemento = Complemento.Text,
                        Bairro = Bairro.Text,
                        Municipio = Municipio.Text,
                        Cep = Cep.Text,
                        Estado = Estado.Text
                    }
                };
            }

            if (manutencao == "Incluir")
            {
                entidadeDAO.Insert(entidade);
            }
            else
            {
                entidadeDAO.Update(entidade);
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