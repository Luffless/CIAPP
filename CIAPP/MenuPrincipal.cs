using System;
using System.Drawing;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
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

        private void AbrirFormInPainel(object form)
        {
            if (Painel.Controls.Count > 0)
            {
                if (Painel.Controls[0].Name == form.GetType().Name)
                {
                    return;
                }

                Painel.Controls.RemoveAt(0);
            }

            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            Painel.Controls.Add(fh);
            Painel.Tag = fh;
            fh.Show();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormInPainel(new Usuarios());
        }
    }
}