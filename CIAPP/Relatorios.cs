using System;
using System.Drawing;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class Relatorios : Form
    {
        private readonly MenuPrincipal formMenuPrincipal;

        public Relatorios(MenuPrincipal form)
        {
            InitializeComponent();
            formMenuPrincipal = form;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.BtnRelatorios.BackColor = Color.FromArgb(25, 25, 112);
            Close();
        }

        private void EntidadesRelatorio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidade ainda não está implementada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PrestadoresRelatorio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidade ainda não está implementada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}