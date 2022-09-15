using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class Entidades : Form
    {
        private readonly List<Entidade> itemList = new List<Entidade>();
        private readonly MenuPrincipal formMenuPrincipal;

        public Entidades(MenuPrincipal form)
        {
            InitializeComponent();
            formMenuPrincipal = form;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.BtnUsuarios.BackColor = Color.FromArgb(25, 25, 112);
            formMenuPrincipal.BtnEntidades.BackColor = Color.FromArgb(25, 25, 112);
            formMenuPrincipal.BtnPrestadores.BackColor = Color.FromArgb(25, 25, 112);
            Close();
        }

        private void Entidades_Load(object sender, EventArgs e)
        {
            AdicionaColunas();
            CarregarRegistros();
        }

        private void AdicionaColunas()
        {
            listView.Font = new Font(listView.Font, FontStyle.Bold);
            listView.Columns.Add("Razão Social", 310);
            listView.Columns.Add("Telefone", 120);
            listView.Columns.Add("Data Credenciamento", 180);
            listView.Columns.Add("Data Descredenciamento", 210);
        }

        private void CarregarRegistros()
        {
            listView.Items.Clear();
            itemList.Clear();

            //SQL de busca de registros aqui, não buscar o usuário de código zero, pois é o usuário admin (primeiro usuário)
            //For só pra teste
            for (int j = 0; j < 5; j++)
            {
                Entidade entidade = new Entidade
                {
                    RazaoSocial = "Nome da Entidade",
                    Telefone = 054999995555,
                    DataCredenciamento = DateTime.Today,
                    DataDescredenciamento = default
                };
                itemList.Add(entidade);
            }

            for (int i = 0; i < itemList.Count; i++)
            {
                ListViewItem listItem = new ListViewItem(itemList[i].RazaoSocial)
                {
                    Font = new Font(listView.Font, FontStyle.Regular)
                };
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Telefone.ToString()));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].DataCredenciamento.ToString("dd/MM/yyyy")));
                if (itemList[i].DataDescredenciamento != default)
                {
                    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].DataDescredenciamento.ToString("dd/MM/yyyy")));
                }
                listView.Items.Add(listItem);
            }
        }
    }
}