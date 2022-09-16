using System;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class UsuarioForm : Form
    {
        private readonly ValidationUsuario validacaoUsuario = new ValidationUsuario();
        private readonly string manutencao;

        public UsuarioForm(string man)
        {
            InitializeComponent();
            manutencao = man;
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            //Fazer SQL para carregar as entidades no combobox Entidade (que não possuem nenhum usuário atribuído) na tela

            switch (manutencao)
            {
                case "Incluir":
                    Id.Text = "1";  //Fazer SQL para verificar o número do próximo Id
                    Tipo.Text = "Entidade";
                    break;

                case "Editar":
                    //Fazer SQL a partir do Id preenchido, buscando todas as informações e colocando na tela
                    Login.Enabled = false;
                    Tipo.Enabled = false;
                    Entidade.Enabled = false;
                    MostraEscondeEntidade();
                    break;

                default:
                    //Fazer SQL a partir do Id preenchido, buscando todas as informações e colocando na tela
                    Nome.Enabled = false;
                    Login.Enabled = false;
                    Senha.Enabled = false;
                    Email.Enabled = false;
                    Tipo.Enabled = false;
                    Entidade.Enabled = false;
                    MostraEscondeEntidade();
                    Salvar.Visible = false;
                    break;
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (!validacaoUsuario.NomeEntrada(Nome.Text))
            {
                Nome.Focus();
                return;
            }

            if (!validacaoUsuario.LoginEntrada(Login.Text))
            {
                Login.Focus();
                return;
            }

            if (!validacaoUsuario.SenhaEntrada(Senha.Text))
            {
                Senha.Focus();
                return;
            }

            if (!validacaoUsuario.EmailEntrada(Email.Text))
            {
                Email.Focus();
                return;
            }

            if (!validacaoUsuario.EntidadeEntrada(Tipo.Text, Entidade.Text))
            {
                Entidade.Focus();
                return;
            }

            if (manutencao == "Incluir")
            {
                //Persistência no banco de dados ao realizar inserção
                //Se o tipo de usuário for 'Entidade' fazer persistência no banco SQLite da entidade do usuário também
            }
            else
            {
                //Persistência no banco de dados ao realizar edição
                //Se o tipo de usuário for 'Entidade' fazer persistência no banco SQLite da entidade do usuário também
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

        private void Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostraEscondeEntidade();
        }

        private void MostraEscondeEntidade()
        {
            if (Tipo.Text == "Entidade")
            {
                LabelEntidade.Visible = true;
                Entidade.Visible = true;
            }
            else
            {
                LabelEntidade.Visible = false;
                Entidade.Visible = false;
            }
        }
    }
}