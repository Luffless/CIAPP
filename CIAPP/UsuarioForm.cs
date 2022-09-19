using System;
using System.Collections.Generic;
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
            Usuario usuario;
            List<Entidade> itemList = (List<Entidade>)new EntidadeDAO().RecuperarTodos();

            for (int i = 0; i < itemList.Count; i++)
            {
                Entidade.Items.Add(itemList[i].RazaoSocial);
            }

            switch (manutencao)
            {
                case "Incluir":
                    Id.Text = usuarioDAO.RetornaProximoId().ToString();
                    Tipo.Text = "Entidade";
                    break;

                case "Editar":
                    usuario = usuarioDAO.RecuperarPorId(int.Parse(Id.Text));
                    Nome.Text = usuario.Nome;
                    Login.Text = usuario.Login;
                    Email.Text = usuario.Email;
                    Tipo.Text = usuario.Tipo;
                    Entidade.Text = usuario.Entidade.RazaoSocial;

                    Tipo.Enabled = false;
                    Entidade.Enabled = false;
                    MostraEscondeEntidade();
                    break;

                default:
                    usuario = usuarioDAO.RecuperarPorId(int.Parse(Id.Text));
                    Nome.Text = usuario.Nome;
                    Login.Text = usuario.Login;
                    Email.Text = usuario.Email;
                    Tipo.Text = usuario.Tipo;
                    Entidade.Text = usuario.Entidade.RazaoSocial;

                    Nome.Enabled = false;
                    Login.Enabled = false;
                    Senha.Enabled = false;
                    Email.Enabled = false;
                    Tipo.Enabled = false;
                    Entidade.Enabled = false;
                    MostraEscondeEntidade();
                    SenhaLabel.Visible = false;
                    Senha.Visible = false;
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

            if (!validacaoUsuario.EmailEntrada(int.Parse(Id.Text), Email.Text))
            {
                Email.Focus();
                return;
            }

            if (Tipo.Text == "Entidade")
            {
                if (!validacaoUsuario.EntidadeEntrada(int.Parse(Id.Text), Entidade.SelectedIndex + 1, Entidade.Text))
                {
                    Entidade.Focus();
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

            if (manutencao == "Incluir")
            {
                Usuario usuario = new Usuario
                {
                    Id = int.Parse(Id.Text),
                    Nome = Nome.Text,
                    Login = Login.Text,
                    Senha = hashmd5.ToString(),
                    Email = Email.Text,
                    Tipo = Tipo.Text,
                    Entidade = new Entidade
                    {
                        Id = Entidade.SelectedIndex + 1
                    }
                };

                usuarioDAO.Insert(usuario);
            }
            else
            {
                Usuario usuario = new Usuario
                {
                    Id = int.Parse(Id.Text),
                    Nome = Nome.Text,
                    Login = Login.Text,
                    Senha = hashmd5.ToString(),
                    Email = Email.Text,
                    Tipo = Tipo.Text
                };

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