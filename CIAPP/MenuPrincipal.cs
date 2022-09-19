﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace CIAPP
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
            BtnUsuarios.BackColor = Color.FromArgb(45, 45, 48);
            BtnEntidades.BackColor = Color.FromArgb(25, 25, 112);
            BtnPrestadores.BackColor = Color.FromArgb(25, 25, 112);
            AbrirFormInPainel(new Usuarios(this));
        }

        private void BtnEntidades_Click(object sender, EventArgs e)
        {
            BtnUsuarios.BackColor = Color.FromArgb(25, 25, 112);
            BtnEntidades.BackColor = Color.FromArgb(45, 45, 48);
            BtnPrestadores.BackColor = Color.FromArgb(25, 25, 112);
            AbrirFormInPainel(new Entidades(this));
        }
    }
}