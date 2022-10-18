using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CIAPP
{
    public partial class Processos : Form
    {
        private readonly ProcessoDAO processoDAO = new ProcessoDAO();
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

        private void Processos_Load(object sender, EventArgs e)
        {
            AdicionaColunas();
            CarregarRegistros();
        }

        private void AdicionaColunas()
        {
            ListView.Font = new Font(ListView.Font, FontStyle.Bold);
            ListView.Columns.Add("ID", 30);
            ListView.Columns.Add("Prestador", 165);
            ListView.Columns.Add("Número Artigo Penal", 140);
            ListView.Columns.Add("Horas a cumprir", 165);
            ListView.Columns.Add("Data de início", 330);
        }

        private void CarregarRegistros()
        {
            ListView.Items.Clear();
            //List<Processo> itemList = (List<Processo>)processoDAO.RecuperarTodosFiltrado(PrestadorFiltro.Text, NumeroArtigoPenalFiltro.Text);

            //for (int i = 0; i < itemList.Count; i++)
            //{
            //    ListViewItem listItem = new ListViewItem(itemList[i].Id.ToString())
            //    {
            //        Font = new Font(ListView.Font, FontStyle.Regular)
            //    };
            //    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].Prestador.Nome));
            //    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].NumeroArtigoPenal.ToString()));
            //    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].HorasCumprir.ToString()));
            //    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, itemList[i].DataInicio.ToString("dd/MM/yyyy")));
            //    ListView.Items.Add(listItem);
            //}
        }
    }
}