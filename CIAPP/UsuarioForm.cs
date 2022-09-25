using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class UsuarioForm : Form
    {
        private readonly ValidationUsuario validacaoUsuario = new ValidationUsuario();
        private readonly UsuarioDAO usuarioDAO = new UsuarioDAO();
        private readonly string manutencao;

        public UsuarioForm(string man)
        {
            InitializeComponent();
            manutencao = man;
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            if (manutencao == "Incluir")
            {
                Id.Text = usuarioDAO.RetornaProximoId().ToString();
            }
            else
            {
                Usuario usuario = usuarioDAO.RecuperarPorId(int.Parse(Id.Text));
                Nome.Text = usuario.Nome;
                Email.Text = usuario.Email;
                Login.Text = usuario.Login;
            }

            if (manutencao == "Detalhes")
            {
                Nome.Enabled = false;
                Email.Enabled = false;
                Login.Enabled = false;
                Senha.Enabled = false;

                SenhaLabel.Visible = false;
                Senha.Visible = false;
                Salvar.Visible = false;
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (!validacaoUsuario.NomeEntrada(Nome.Text))
            {
                Nome.Focus();
                return;
            }

            if (!validacaoUsuario.EmailEntrada(int.Parse(Id.Text), Email.Text))
            {
                Email.Focus();
                return;
            }

            if (!validacaoUsuario.LoginEntrada(int.Parse(Id.Text), Login.Text))
            {
                Login.Focus();
                return;
            }

            if (manutencao == "Incluir")
            {
                if (!validacaoUsuario.SenhaEntrada(Senha.Text))
                {
                    Senha.Focus();
                    return;
                }
            }

            byte[] hash;
            StringBuilder hashmd5 = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(Senha.Text))
            {
                using (MD5 md5 = MD5.Create())
                {
                    hash = md5.ComputeHash(Encoding.UTF8.GetBytes(Login.Text + Senha.Text + "CIAPP"));
                }
                for (int i = 0; i < hash.Length; i++)
                {
                    hashmd5.Append(hash[i].ToString("x2"));
                }
            }

            Usuario usuario = new Usuario
            {
                Id = int.Parse(Id.Text),
                Nome = Nome.Text,
                Email = Email.Text,
                Login = Login.Text,
                Senha = hashmd5.ToString()
            };

            if (manutencao == "Incluir")
            {
                usuarioDAO.Insert(usuario);
            }
            else
            {
                usuarioDAO.Update(usuario);
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