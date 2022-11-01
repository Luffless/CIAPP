﻿using System;
using System.Drawing;
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
            Usuario usuario = usuarioDAO.RecuperarPorLogin(loginUsuarioLogado);
            UsuarioLogado.Text = usuario.Nome;
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

        private void BtnProcessos_Click(object sender, EventArgs e)
        {
            BtnProcessos.BackColor = Color.FromArgb(45, 45, 48);
            BtnRelatorios.BackColor = Color.FromArgb(25, 25, 112);
            AbrirFormInPainel(new Processos(this));
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            //BtnProcessos.BackColor = Color.FromArgb(25, 25, 112);
            //BtnRelatorios.BackColor = Color.FromArgb(45, 45, 48);
            //AbrirFormInPainel(new Relatorios(this));
            MessageBox.Show("Esta funcionalidade ainda não está implementada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}