using System.Drawing;
using System;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class Processos : Form
    {
        private readonly MenuPrincipal formMenuPrincipal;

        public Processos(MenuPrincipal form)
        {
            InitializeComponent();
            formMenuPrincipal = form;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.BtnProcessos.BackColor = Color.FromArgb(25, 25, 112);
            Close();
        }
    }
}