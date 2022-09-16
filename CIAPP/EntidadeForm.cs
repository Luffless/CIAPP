using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class EntidadeForm : Form
    {
        private readonly ValidationEntidade validacaoEntidade = new ValidationEntidade();
        private readonly ValidationEndereco validacaoEndereco = new ValidationEndereco();
        private readonly string manutencao;

        public EntidadeForm(string man)
        {
            InitializeComponent();
            manutencao = man;
        }

        private void EntidadeForm_Load(object sender, EventArgs e)
        {
            switch (manutencao)
            {
                case "Incluir":
                    Id.Text = "1";  //Fazer SQL para verificar o número do próximo Id
                    break;

                case "Editar":
                    //Fazer SQL a partir do Id preenchido, buscando todas as informações e colocando na tela
                    break;

                default:
                    //Fazer SQL a partir do Id preenchido, buscando todas as informações e colocando na tela
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
                    break;
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

            if (!validacaoEntidade.EmailEntrada(Email.Text))
            {
                Email.Focus();
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

            //DataCredenciamento (datetime não permite nulo, ver o que fazer)

            //DataDescredenciamento (datetime não permite nulo, ver o que fazer)

            if (manutencao == "Incluir")
            {
                //Persistência no banco de dados ao realizar inserção
            }
            else
            {
                //Persistência no banco de dados ao realizar edição
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