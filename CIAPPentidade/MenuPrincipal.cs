using System;
using System.Windows.Forms;

namespace CIAPPentidade
{
    public partial class MenuPrincipal : Form
    {
        private readonly string loginUsuarioLogado;
        private readonly UsuarioDAO usuarioDAO = new UsuarioDAO();

        public MenuPrincipal(string usuarioLogado)
        {
            InitializeComponent();
            loginUsuarioLogado = usuarioLogado;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            UsuarioLogado.Text = usuarioDAO.RecuperarPorLogin(loginUsuarioLogado);
        }

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 60;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}