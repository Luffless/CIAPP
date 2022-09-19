using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CIAPP
{
    public partial class LoginScreen : Form
    {
        private readonly ValidationLogin validacaoLogin = new ValidationLogin();

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (!validacaoLogin.LoginEntrada(LoginEntrada.Text))
            {
                LoginEntrada.Focus();
                return;
            }

            if (!validacaoLogin.SenhaEntrada(Senha.Text))
            {
                Senha.Focus();
                return;
            }

            byte[] hash;
            using (MD5 md5 = MD5.Create())
            {
                hash = md5.ComputeHash(Encoding.UTF8.GetBytes(LoginEntrada.Text + Senha.Text + "CIAPP"));
            }
            StringBuilder hashmd5 = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                hashmd5.Append(hash[i].ToString("x2"));
            }

            if (!validacaoLogin.UsuarioIsValid(LoginEntrada.Text, hashmd5.ToString()))
            {
                LoginEntrada.Focus();
                return;
            }

            Hide();

            new MenuPrincipal().ShowDialog();
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
