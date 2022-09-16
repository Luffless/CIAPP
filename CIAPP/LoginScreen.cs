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

            var bytes = new UTF8Encoding().GetBytes(LoginEntrada.Text + Senha.Text);
            var hashbytes = MD5.Create().ComputeHash(bytes);
            var convert = Convert.ToBase64String(hashbytes);

            if (!validacaoLogin.UsuarioIsValid(convert))
            {
                LoginEntrada.Focus();
                return;
            }

            Hide();

            new MenuPrincipal(LoginEntrada.Text).ShowDialog();
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
