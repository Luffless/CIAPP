using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
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
            AdicionaColunas();
        }

        private void AdicionaColunas()
        {
            ListView.Font = new Font(ListView.Font, FontStyle.Bold);
            ListView.Columns.Add("ID", 30);
            ListView.Columns.Add("CPF", 165);
            ListView.Columns.Add("Nome", 375);
            ListView.Columns.Add("Horas a cumprir", 135);
            ListView.Columns.Add("Horas cumpridas", 135);
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

        private void Importar_Click(object sender, EventArgs e)
        {
            Processo processo;

            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "JSON Files (*.json)|*.json"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (new FileInfo(open.FileName).Length == 0)
                {
                    MessageBox.Show("O arquivo selecionado está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (StreamReader reader = new StreamReader(open.FileName))
                {
                    string json = reader.ReadToEnd();

                    EncryptDecrypt encryptTest = new EncryptDecrypt();
                    string jsonDescrypted = encryptTest.Decrypt(json);

                    try
                    {
                        processo = JsonSerializer.Deserialize<Processo>(jsonDescrypted);
                    }
                    catch
                    {
                        MessageBox.Show("Arquivo JSON inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                //verificar se não existe o registro, se não existir então insere no banco SQLite os registros
            }
        }

        private void Detalhes_Click(object sender, EventArgs e)
        {
            if (!VerificaList())
            {
                return;
            }

            //abrir a tela dos detalhes, sendo que no registro selecionado poderá incluir registros de Frequência
        }

        private void DoubleClick_Click(object sender, EventArgs e)
        {
            Detalhes_Click(sender, e);
        }

        private bool VerificaList()
        {
            if (ListView.Items.Count == 0)
            {
                MessageBox.Show("Não há nenhum registro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro antes!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}