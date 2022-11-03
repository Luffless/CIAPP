namespace CIAPP
{
    partial class PrestadorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrestadorForm));
            this.Estado = new System.Windows.Forms.ComboBox();
            this.Cep = new System.Windows.Forms.TextBox();
            this.Municipio = new System.Windows.Forms.TextBox();
            this.Bairro = new System.Windows.Forms.TextBox();
            this.Complemento = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.TextBox();
            this.Logradouro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Salvar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GrauParentesco = new System.Windows.Forms.ComboBox();
            this.NomeParentesco = new System.Windows.Forms.TextBox();
            this.GrauParentescoLabel = new System.Windows.Forms.Label();
            this.NomeParentescoLabel = new System.Windows.Forms.Label();
            this.RemoverParentesco = new System.Windows.Forms.Button();
            this.IncluirParentesco = new System.Windows.Forms.Button();
            this.ListViewParentesco = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DescricaoHabilidade = new System.Windows.Forms.TextBox();
            this.DescricaoHabilidadeLabel = new System.Windows.Forms.Label();
            this.RemoverHabilidade = new System.Windows.Forms.Button();
            this.IncluirHabilidade = new System.Windows.Forms.Button();
            this.ListViewHabilidade = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DescricaoDeficiencia = new System.Windows.Forms.ComboBox();
            this.DescricaoDeficienciaLabel = new System.Windows.Forms.Label();
            this.RemoverDeficiencia = new System.Windows.Forms.Button();
            this.IncluirDeficiencia = new System.Windows.Forms.Button();
            this.ListViewDeficiencia = new System.Windows.Forms.ListView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.DescricaoDoenca = new System.Windows.Forms.TextBox();
            this.DescricaoDoencaLabel = new System.Windows.Forms.Label();
            this.RemoverDoenca = new System.Windows.Forms.Button();
            this.IncluirDoenca = new System.Windows.Forms.Button();
            this.ListViewDoenca = new System.Windows.Forms.ListView();
            this.Foto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Selecionar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Profissao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.GrauInstrucao = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Religiao = new System.Windows.Forms.TextBox();
            this.RecebeBeneficio = new System.Windows.Forms.CheckBox();
            this.UsaAlcool = new System.Windows.Forms.CheckBox();
            this.UsaDrogas = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Observacao = new System.Windows.Forms.TextBox();
            this.EstadoCivil = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.TextBox();
            this.Naturalidade = new System.Windows.Forms.ComboBox();
            this.Etnia = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Idade = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.RendaFamiliar = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Cpf = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Estado
            // 
            this.Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Estado.FormattingEnabled = true;
            this.Estado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.Estado.Location = new System.Drawing.Point(133, 226);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(161, 28);
            this.Estado.TabIndex = 25;
            this.Estado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Cep
            // 
            this.Cep.Location = new System.Drawing.Point(133, 191);
            this.Cep.MaxLength = 9;
            this.Cep.Name = "Cep";
            this.Cep.Size = new System.Drawing.Size(100, 26);
            this.Cep.TabIndex = 24;
            this.Cep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Cep.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Municipio
            // 
            this.Municipio.Location = new System.Drawing.Point(133, 157);
            this.Municipio.Name = "Municipio";
            this.Municipio.Size = new System.Drawing.Size(309, 26);
            this.Municipio.TabIndex = 23;
            this.Municipio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Municipio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Bairro
            // 
            this.Bairro.Location = new System.Drawing.Point(133, 120);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(309, 26);
            this.Bairro.TabIndex = 22;
            this.Bairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Bairro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Complemento
            // 
            this.Complemento.Location = new System.Drawing.Point(133, 85);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(309, 26);
            this.Complemento.TabIndex = 21;
            this.Complemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Complemento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(133, 49);
            this.Numero.MaxLength = 5;
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(100, 26);
            this.Numero.TabIndex = 20;
            this.Numero.TextChanged += new System.EventHandler(this.Numero_TextChanged);
            this.Numero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Numero.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Logradouro
            // 
            this.Logradouro.Location = new System.Drawing.Point(133, 16);
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Size = new System.Drawing.Size(544, 26);
            this.Logradouro.TabIndex = 19;
            this.Logradouro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(64, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Estado:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(84, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "CEP:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Município:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Bairro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Complemento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Número:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Logradouro:";
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Salvar.FlatAppearance.BorderSize = 0;
            this.Salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salvar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salvar.ForeColor = System.Drawing.Color.White;
            this.Salvar.Location = new System.Drawing.Point(523, 693);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(180, 40);
            this.Salvar.TabIndex = 14;
            this.Salvar.Text = "SALVAR";
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 383);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(691, 304);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Estado);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.Complemento);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.Cep);
            this.tabPage1.Controls.Add(this.Bairro);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.Numero);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.Logradouro);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.Municipio);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(683, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Endereço";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GrauParentesco);
            this.tabPage2.Controls.Add(this.NomeParentesco);
            this.tabPage2.Controls.Add(this.GrauParentescoLabel);
            this.tabPage2.Controls.Add(this.NomeParentescoLabel);
            this.tabPage2.Controls.Add(this.RemoverParentesco);
            this.tabPage2.Controls.Add(this.IncluirParentesco);
            this.tabPage2.Controls.Add(this.ListViewParentesco);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(683, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parentesco";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GrauParentesco
            // 
            this.GrauParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GrauParentesco.FormattingEnabled = true;
            this.GrauParentesco.Items.AddRange(new object[] {
            "Mãe",
            "Pai",
            "Irmão",
            "Irmã",
            "Avó",
            "Avô",
            "Bisavó",
            "Bisavô",
            "Tia",
            "Tio",
            "Prima",
            "Primo",
            "Filha",
            "Filho",
            "Sobrinha",
            "Sobrinho",
            "Neta",
            "Neto",
            "Bisneta",
            "Bisneto"});
            this.GrauParentesco.Location = new System.Drawing.Point(150, 46);
            this.GrauParentesco.Name = "GrauParentesco";
            this.GrauParentesco.Size = new System.Drawing.Size(361, 28);
            this.GrauParentesco.TabIndex = 27;
            this.GrauParentesco.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // NomeParentesco
            // 
            this.NomeParentesco.Location = new System.Drawing.Point(150, 16);
            this.NomeParentesco.Name = "NomeParentesco";
            this.NomeParentesco.Size = new System.Drawing.Size(361, 26);
            this.NomeParentesco.TabIndex = 26;
            this.NomeParentesco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // GrauParentescoLabel
            // 
            this.GrauParentescoLabel.AutoSize = true;
            this.GrauParentescoLabel.Location = new System.Drawing.Point(6, 48);
            this.GrauParentescoLabel.Name = "GrauParentescoLabel";
            this.GrauParentescoLabel.Size = new System.Drawing.Size(138, 20);
            this.GrauParentescoLabel.TabIndex = 24;
            this.GrauParentescoLabel.Text = "Grau Parentesco:";
            // 
            // NomeParentescoLabel
            // 
            this.NomeParentescoLabel.AutoSize = true;
            this.NomeParentescoLabel.Location = new System.Drawing.Point(87, 17);
            this.NomeParentescoLabel.Name = "NomeParentescoLabel";
            this.NomeParentescoLabel.Size = new System.Drawing.Size(57, 20);
            this.NomeParentescoLabel.TabIndex = 23;
            this.NomeParentescoLabel.Text = "Nome:";
            // 
            // RemoverParentesco
            // 
            this.RemoverParentesco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoverParentesco.BackColor = System.Drawing.Color.MidnightBlue;
            this.RemoverParentesco.FlatAppearance.BorderSize = 0;
            this.RemoverParentesco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RemoverParentesco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoverParentesco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverParentesco.ForeColor = System.Drawing.Color.White;
            this.RemoverParentesco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverParentesco.Location = new System.Drawing.Point(517, 55);
            this.RemoverParentesco.Name = "RemoverParentesco";
            this.RemoverParentesco.Size = new System.Drawing.Size(160, 40);
            this.RemoverParentesco.TabIndex = 22;
            this.RemoverParentesco.Text = "Remover";
            this.RemoverParentesco.UseVisualStyleBackColor = false;
            this.RemoverParentesco.Click += new System.EventHandler(this.RemoverParentesco_Click);
            // 
            // IncluirParentesco
            // 
            this.IncluirParentesco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IncluirParentesco.BackColor = System.Drawing.Color.MidnightBlue;
            this.IncluirParentesco.FlatAppearance.BorderSize = 0;
            this.IncluirParentesco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.IncluirParentesco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncluirParentesco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncluirParentesco.ForeColor = System.Drawing.Color.White;
            this.IncluirParentesco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IncluirParentesco.Location = new System.Drawing.Point(517, 8);
            this.IncluirParentesco.Name = "IncluirParentesco";
            this.IncluirParentesco.Size = new System.Drawing.Size(160, 40);
            this.IncluirParentesco.TabIndex = 21;
            this.IncluirParentesco.Text = "Incluir";
            this.IncluirParentesco.UseVisualStyleBackColor = false;
            this.IncluirParentesco.Click += new System.EventHandler(this.IncluirParentesco_Click);
            // 
            // ListViewParentesco
            // 
            this.ListViewParentesco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewParentesco.FullRowSelect = true;
            this.ListViewParentesco.HideSelection = false;
            this.ListViewParentesco.Location = new System.Drawing.Point(6, 80);
            this.ListViewParentesco.Name = "ListViewParentesco";
            this.ListViewParentesco.Size = new System.Drawing.Size(505, 185);
            this.ListViewParentesco.TabIndex = 28;
            this.ListViewParentesco.UseCompatibleStateImageBehavior = false;
            this.ListViewParentesco.View = System.Windows.Forms.View.Details;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DescricaoHabilidade);
            this.tabPage3.Controls.Add(this.DescricaoHabilidadeLabel);
            this.tabPage3.Controls.Add(this.RemoverHabilidade);
            this.tabPage3.Controls.Add(this.IncluirHabilidade);
            this.tabPage3.Controls.Add(this.ListViewHabilidade);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(683, 271);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Habilidade";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DescricaoHabilidade
            // 
            this.DescricaoHabilidade.Location = new System.Drawing.Point(100, 16);
            this.DescricaoHabilidade.Name = "DescricaoHabilidade";
            this.DescricaoHabilidade.Size = new System.Drawing.Size(411, 26);
            this.DescricaoHabilidade.TabIndex = 29;
            // 
            // DescricaoHabilidadeLabel
            // 
            this.DescricaoHabilidadeLabel.AutoSize = true;
            this.DescricaoHabilidadeLabel.Location = new System.Drawing.Point(6, 19);
            this.DescricaoHabilidadeLabel.Name = "DescricaoHabilidadeLabel";
            this.DescricaoHabilidadeLabel.Size = new System.Drawing.Size(88, 20);
            this.DescricaoHabilidadeLabel.TabIndex = 36;
            this.DescricaoHabilidadeLabel.Text = "Descrição:";
            // 
            // RemoverHabilidade
            // 
            this.RemoverHabilidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoverHabilidade.BackColor = System.Drawing.Color.MidnightBlue;
            this.RemoverHabilidade.FlatAppearance.BorderSize = 0;
            this.RemoverHabilidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RemoverHabilidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoverHabilidade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverHabilidade.ForeColor = System.Drawing.Color.White;
            this.RemoverHabilidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverHabilidade.Location = new System.Drawing.Point(517, 55);
            this.RemoverHabilidade.Name = "RemoverHabilidade";
            this.RemoverHabilidade.Size = new System.Drawing.Size(160, 40);
            this.RemoverHabilidade.TabIndex = 35;
            this.RemoverHabilidade.Text = "Remover";
            this.RemoverHabilidade.UseVisualStyleBackColor = false;
            this.RemoverHabilidade.Click += new System.EventHandler(this.RemoverHabilidade_Click);
            // 
            // IncluirHabilidade
            // 
            this.IncluirHabilidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IncluirHabilidade.BackColor = System.Drawing.Color.MidnightBlue;
            this.IncluirHabilidade.FlatAppearance.BorderSize = 0;
            this.IncluirHabilidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.IncluirHabilidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncluirHabilidade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncluirHabilidade.ForeColor = System.Drawing.Color.White;
            this.IncluirHabilidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IncluirHabilidade.Location = new System.Drawing.Point(517, 8);
            this.IncluirHabilidade.Name = "IncluirHabilidade";
            this.IncluirHabilidade.Size = new System.Drawing.Size(160, 40);
            this.IncluirHabilidade.TabIndex = 34;
            this.IncluirHabilidade.Text = "Incluir";
            this.IncluirHabilidade.UseVisualStyleBackColor = false;
            this.IncluirHabilidade.Click += new System.EventHandler(this.IncluirHabilidade_Click);
            // 
            // ListViewHabilidade
            // 
            this.ListViewHabilidade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewHabilidade.FullRowSelect = true;
            this.ListViewHabilidade.HideSelection = false;
            this.ListViewHabilidade.Location = new System.Drawing.Point(6, 55);
            this.ListViewHabilidade.Name = "ListViewHabilidade";
            this.ListViewHabilidade.Size = new System.Drawing.Size(505, 208);
            this.ListViewHabilidade.TabIndex = 30;
            this.ListViewHabilidade.UseCompatibleStateImageBehavior = false;
            this.ListViewHabilidade.View = System.Windows.Forms.View.Details;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DescricaoDeficiencia);
            this.tabPage4.Controls.Add(this.DescricaoDeficienciaLabel);
            this.tabPage4.Controls.Add(this.RemoverDeficiencia);
            this.tabPage4.Controls.Add(this.IncluirDeficiencia);
            this.tabPage4.Controls.Add(this.ListViewDeficiencia);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(683, 271);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Deficiência";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DescricaoDeficiencia
            // 
            this.DescricaoDeficiencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DescricaoDeficiencia.FormattingEnabled = true;
            this.DescricaoDeficiencia.Items.AddRange(new object[] {
            "Física",
            "Visual",
            "Auditiva",
            "Mental",
            "Intelectual"});
            this.DescricaoDeficiencia.Location = new System.Drawing.Point(101, 17);
            this.DescricaoDeficiencia.Name = "DescricaoDeficiencia";
            this.DescricaoDeficiencia.Size = new System.Drawing.Size(410, 28);
            this.DescricaoDeficiencia.TabIndex = 31;
            // 
            // DescricaoDeficienciaLabel
            // 
            this.DescricaoDeficienciaLabel.AutoSize = true;
            this.DescricaoDeficienciaLabel.Location = new System.Drawing.Point(6, 19);
            this.DescricaoDeficienciaLabel.Name = "DescricaoDeficienciaLabel";
            this.DescricaoDeficienciaLabel.Size = new System.Drawing.Size(88, 20);
            this.DescricaoDeficienciaLabel.TabIndex = 36;
            this.DescricaoDeficienciaLabel.Text = "Descrição:";
            // 
            // RemoverDeficiencia
            // 
            this.RemoverDeficiencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoverDeficiencia.BackColor = System.Drawing.Color.MidnightBlue;
            this.RemoverDeficiencia.FlatAppearance.BorderSize = 0;
            this.RemoverDeficiencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RemoverDeficiencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoverDeficiencia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverDeficiencia.ForeColor = System.Drawing.Color.White;
            this.RemoverDeficiencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverDeficiencia.Location = new System.Drawing.Point(517, 55);
            this.RemoverDeficiencia.Name = "RemoverDeficiencia";
            this.RemoverDeficiencia.Size = new System.Drawing.Size(160, 40);
            this.RemoverDeficiencia.TabIndex = 35;
            this.RemoverDeficiencia.Text = "Remover";
            this.RemoverDeficiencia.UseVisualStyleBackColor = false;
            this.RemoverDeficiencia.Click += new System.EventHandler(this.RemoverDeficiencia_Click);
            // 
            // IncluirDeficiencia
            // 
            this.IncluirDeficiencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IncluirDeficiencia.BackColor = System.Drawing.Color.MidnightBlue;
            this.IncluirDeficiencia.FlatAppearance.BorderSize = 0;
            this.IncluirDeficiencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.IncluirDeficiencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncluirDeficiencia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncluirDeficiencia.ForeColor = System.Drawing.Color.White;
            this.IncluirDeficiencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IncluirDeficiencia.Location = new System.Drawing.Point(517, 8);
            this.IncluirDeficiencia.Name = "IncluirDeficiencia";
            this.IncluirDeficiencia.Size = new System.Drawing.Size(160, 40);
            this.IncluirDeficiencia.TabIndex = 34;
            this.IncluirDeficiencia.Text = "Incluir";
            this.IncluirDeficiencia.UseVisualStyleBackColor = false;
            this.IncluirDeficiencia.Click += new System.EventHandler(this.IncluirDeficiencia_Click);
            // 
            // ListViewDeficiencia
            // 
            this.ListViewDeficiencia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewDeficiencia.FullRowSelect = true;
            this.ListViewDeficiencia.HideSelection = false;
            this.ListViewDeficiencia.Location = new System.Drawing.Point(6, 55);
            this.ListViewDeficiencia.Name = "ListViewDeficiencia";
            this.ListViewDeficiencia.Size = new System.Drawing.Size(505, 208);
            this.ListViewDeficiencia.TabIndex = 32;
            this.ListViewDeficiencia.UseCompatibleStateImageBehavior = false;
            this.ListViewDeficiencia.View = System.Windows.Forms.View.Details;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.DescricaoDoenca);
            this.tabPage5.Controls.Add(this.DescricaoDoencaLabel);
            this.tabPage5.Controls.Add(this.RemoverDoenca);
            this.tabPage5.Controls.Add(this.IncluirDoenca);
            this.tabPage5.Controls.Add(this.ListViewDoenca);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(683, 271);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Doença";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // DescricaoDoenca
            // 
            this.DescricaoDoenca.Location = new System.Drawing.Point(100, 16);
            this.DescricaoDoenca.Name = "DescricaoDoenca";
            this.DescricaoDoenca.Size = new System.Drawing.Size(411, 26);
            this.DescricaoDoenca.TabIndex = 33;
            // 
            // DescricaoDoencaLabel
            // 
            this.DescricaoDoencaLabel.AutoSize = true;
            this.DescricaoDoencaLabel.Location = new System.Drawing.Point(6, 19);
            this.DescricaoDoencaLabel.Name = "DescricaoDoencaLabel";
            this.DescricaoDoencaLabel.Size = new System.Drawing.Size(88, 20);
            this.DescricaoDoencaLabel.TabIndex = 36;
            this.DescricaoDoencaLabel.Text = "Descrição:";
            // 
            // RemoverDoenca
            // 
            this.RemoverDoenca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoverDoenca.BackColor = System.Drawing.Color.MidnightBlue;
            this.RemoverDoenca.FlatAppearance.BorderSize = 0;
            this.RemoverDoenca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RemoverDoenca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoverDoenca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverDoenca.ForeColor = System.Drawing.Color.White;
            this.RemoverDoenca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverDoenca.Location = new System.Drawing.Point(517, 55);
            this.RemoverDoenca.Name = "RemoverDoenca";
            this.RemoverDoenca.Size = new System.Drawing.Size(160, 40);
            this.RemoverDoenca.TabIndex = 35;
            this.RemoverDoenca.Text = "Remover";
            this.RemoverDoenca.UseVisualStyleBackColor = false;
            this.RemoverDoenca.Click += new System.EventHandler(this.RemoverDoenca_Click);
            // 
            // IncluirDoenca
            // 
            this.IncluirDoenca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IncluirDoenca.BackColor = System.Drawing.Color.MidnightBlue;
            this.IncluirDoenca.FlatAppearance.BorderSize = 0;
            this.IncluirDoenca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.IncluirDoenca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncluirDoenca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncluirDoenca.ForeColor = System.Drawing.Color.White;
            this.IncluirDoenca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IncluirDoenca.Location = new System.Drawing.Point(517, 8);
            this.IncluirDoenca.Name = "IncluirDoenca";
            this.IncluirDoenca.Size = new System.Drawing.Size(160, 40);
            this.IncluirDoenca.TabIndex = 34;
            this.IncluirDoenca.Text = "Incluir";
            this.IncluirDoenca.UseVisualStyleBackColor = false;
            this.IncluirDoenca.Click += new System.EventHandler(this.IncluirDoenca_Click);
            // 
            // ListViewDoenca
            // 
            this.ListViewDoenca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewDoenca.FullRowSelect = true;
            this.ListViewDoenca.HideSelection = false;
            this.ListViewDoenca.Location = new System.Drawing.Point(6, 55);
            this.ListViewDoenca.Name = "ListViewDoenca";
            this.ListViewDoenca.Size = new System.Drawing.Size(505, 208);
            this.ListViewDoenca.TabIndex = 34;
            this.ListViewDoenca.UseCompatibleStateImageBehavior = false;
            this.ListViewDoenca.View = System.Windows.Forms.View.Details;
            // 
            // Foto
            // 
            this.Foto.Location = new System.Drawing.Point(6, 25);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(160, 250);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Foto.TabIndex = 16;
            this.Foto.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Selecionar);
            this.groupBox1.Controls.Add(this.Foto);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 327);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto";
            // 
            // Selecionar
            // 
            this.Selecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Selecionar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Selecionar.FlatAppearance.BorderSize = 0;
            this.Selecionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Selecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selecionar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selecionar.ForeColor = System.Drawing.Color.White;
            this.Selecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Selecionar.Location = new System.Drawing.Point(6, 281);
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Size = new System.Drawing.Size(160, 40);
            this.Selecionar.TabIndex = 18;
            this.Selecionar.Text = "Selecionar";
            this.Selecionar.UseVisualStyleBackColor = false;
            this.Selecionar.Click += new System.EventHandler(this.Selecionar_Click);
            // 
            // Id
            // 
            this.Id.Enabled = false;
            this.Id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(255, 22);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(63, 26);
            this.Id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID:";
            // 
            // Nome
            // 
            this.Nome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(255, 54);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(448, 26);
            this.Nome.TabIndex = 3;
            this.Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Nome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data Nascimento:";
            // 
            // DataNascimento
            // 
            this.DataNascimento.CustomFormat = " ";
            this.DataNascimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataNascimento.Location = new System.Drawing.Point(341, 87);
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.Size = new System.Drawing.Size(122, 26);
            this.DataNascimento.TabIndex = 4;
            this.DataNascimento.ValueChanged += new System.EventHandler(this.DataNascimento_ValueChanged);
            this.DataNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataNascimento_KeyDown);
            this.DataNascimento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Naturalidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Estado Civil:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Profissão:";
            // 
            // Profissao
            // 
            this.Profissao.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Profissao.Location = new System.Drawing.Point(272, 189);
            this.Profissao.Name = "Profissao";
            this.Profissao.Size = new System.Drawing.Size(431, 26);
            this.Profissao.TabIndex = 11;
            this.Profissao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Profissao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Etnia:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(195, 257);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Grau Instrução:";
            // 
            // GrauInstrucao
            // 
            this.GrauInstrucao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GrauInstrucao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrauInstrucao.FormattingEnabled = true;
            this.GrauInstrucao.Items.AddRange(new object[] {
            "Analfabeto",
            "Ensino Fundamental Incompleto",
            "Ensino Fundamental Completo",
            "Ensino Médio Incompleto",
            "Ensino Médio Completo",
            "Ensino Superior Incompleto",
            "Ensino Superior Completo"});
            this.GrauInstrucao.Location = new System.Drawing.Point(324, 254);
            this.GrauInstrucao.Name = "GrauInstrucao";
            this.GrauInstrucao.Size = new System.Drawing.Size(379, 28);
            this.GrauInstrucao.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(469, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "Religião:";
            // 
            // Religiao
            // 
            this.Religiao.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Religiao.Location = new System.Drawing.Point(543, 223);
            this.Religiao.Name = "Religiao";
            this.Religiao.Size = new System.Drawing.Size(160, 26);
            this.Religiao.TabIndex = 13;
            this.Religiao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Religiao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // RecebeBeneficio
            // 
            this.RecebeBeneficio.AutoSize = true;
            this.RecebeBeneficio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecebeBeneficio.Location = new System.Drawing.Point(199, 291);
            this.RecebeBeneficio.Name = "RecebeBeneficio";
            this.RecebeBeneficio.Size = new System.Drawing.Size(160, 24);
            this.RecebeBeneficio.TabIndex = 15;
            this.RecebeBeneficio.Text = "Recebe Benefício";
            this.RecebeBeneficio.UseVisualStyleBackColor = true;
            this.RecebeBeneficio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.RecebeBeneficio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // UsaAlcool
            // 
            this.UsaAlcool.AutoSize = true;
            this.UsaAlcool.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsaAlcool.Location = new System.Drawing.Point(420, 291);
            this.UsaAlcool.Name = "UsaAlcool";
            this.UsaAlcool.Size = new System.Drawing.Size(106, 24);
            this.UsaAlcool.TabIndex = 16;
            this.UsaAlcool.Text = "Usa Álcool";
            this.UsaAlcool.UseVisualStyleBackColor = true;
            this.UsaAlcool.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.UsaAlcool.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // UsaDrogas
            // 
            this.UsaDrogas.AutoSize = true;
            this.UsaDrogas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsaDrogas.Location = new System.Drawing.Point(592, 291);
            this.UsaDrogas.Name = "UsaDrogas";
            this.UsaDrogas.Size = new System.Drawing.Size(111, 24);
            this.UsaDrogas.TabIndex = 17;
            this.UsaDrogas.Text = "Usa Drogas";
            this.UsaDrogas.UseVisualStyleBackColor = true;
            this.UsaDrogas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.UsaDrogas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(195, 319);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 20);
            this.label17.TabIndex = 39;
            this.label17.Text = "Observação:";
            // 
            // Observacao
            // 
            this.Observacao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Observacao.Location = new System.Drawing.Point(308, 321);
            this.Observacao.Multiline = true;
            this.Observacao.Name = "Observacao";
            this.Observacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Observacao.Size = new System.Drawing.Size(395, 56);
            this.Observacao.TabIndex = 18;
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadoCivil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoCivil.FormattingEnabled = true;
            this.EstadoCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Separado",
            "Divorciado",
            "Viúvo"});
            this.EstadoCivil.Location = new System.Drawing.Point(570, 121);
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.Size = new System.Drawing.Size(133, 28);
            this.EstadoCivil.TabIndex = 7;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(195, 159);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 20);
            this.label23.TabIndex = 40;
            this.label23.Text = "Telefone:";
            // 
            // Telefone
            // 
            this.Telefone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(272, 156);
            this.Telefone.MaxLength = 9;
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(100, 26);
            this.Telefone.TabIndex = 8;
            this.Telefone.TextChanged += new System.EventHandler(this.Telefone_TextChanged);
            this.Telefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Telefone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Naturalidade
            // 
            this.Naturalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Naturalidade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naturalidade.FormattingEnabled = true;
            this.Naturalidade.Items.AddRange(new object[] {
            "Brasileiro",
            "Argentino",
            "Boliviano",
            "Chileno",
            "Paraguaio",
            "Uruguaio",
            "Alemão",
            "Belga",
            "Britânico",
            "Canadense",
            "Espanhol",
            "Norte-americano",
            "Francês",
            "Suíço",
            "Italiano",
            "Japonês",
            "Chinês",
            "Coreano",
            "Português"});
            this.Naturalidade.Location = new System.Drawing.Point(308, 121);
            this.Naturalidade.Name = "Naturalidade";
            this.Naturalidade.Size = new System.Drawing.Size(155, 28);
            this.Naturalidade.TabIndex = 6;
            // 
            // Etnia
            // 
            this.Etnia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Etnia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etnia.FormattingEnabled = true;
            this.Etnia.Items.AddRange(new object[] {
            "Branca",
            "Negra",
            "Amarela",
            "Parda",
            "Indígena"});
            this.Etnia.Location = new System.Drawing.Point(430, 155);
            this.Etnia.Name = "Etnia";
            this.Etnia.Size = new System.Drawing.Size(106, 28);
            this.Etnia.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(539, 159);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 20);
            this.label18.TabIndex = 41;
            this.label18.Text = "Sexo:";
            // 
            // Sexo
            // 
            this.Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sexo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sexo.FormattingEnabled = true;
            this.Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.Sexo.Location = new System.Drawing.Point(592, 156);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(111, 28);
            this.Sexo.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(506, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 20);
            this.label19.TabIndex = 42;
            this.label19.Text = "Idade:";
            // 
            // Idade
            // 
            this.Idade.Enabled = false;
            this.Idade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idade.Location = new System.Drawing.Point(570, 88);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(43, 26);
            this.Idade.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(195, 226);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 20);
            this.label20.TabIndex = 44;
            this.label20.Text = "Renda Familiar:";
            // 
            // RendaFamiliar
            // 
            this.RendaFamiliar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RendaFamiliar.Location = new System.Drawing.Point(324, 223);
            this.RendaFamiliar.Name = "RendaFamiliar";
            this.RendaFamiliar.Size = new System.Drawing.Size(139, 26);
            this.RendaFamiliar.TabIndex = 12;
            this.RendaFamiliar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.RendaFamiliar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RendaFamiliar_KeyPress);
            this.RendaFamiliar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(469, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 20);
            this.label21.TabIndex = 45;
            this.label21.Text = "CPF:";
            // 
            // Cpf
            // 
            this.Cpf.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpf.Location = new System.Drawing.Point(516, 22);
            this.Cpf.MaxLength = 14;
            this.Cpf.Name = "Cpf";
            this.Cpf.Size = new System.Drawing.Size(186, 26);
            this.Cpf.TabIndex = 2;
            this.Cpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // PrestadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 745);
            this.Controls.Add(this.Cpf);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.RendaFamiliar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Idade);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Etnia);
            this.Controls.Add(this.Naturalidade);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.EstadoCivil);
            this.Controls.Add(this.Observacao);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.UsaDrogas);
            this.Controls.Add(this.UsaAlcool);
            this.Controls.Add(this.RecebeBeneficio);
            this.Controls.Add(this.Religiao);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.GrauInstrucao);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Profissao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrestadorForm";
            this.Text = "Prestador";
            this.Load += new System.EventHandler(this.PrestadorForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Estado;
        private System.Windows.Forms.TextBox Cep;
        private System.Windows.Forms.TextBox Municipio;
        private System.Windows.Forms.TextBox Bairro;
        private System.Windows.Forms.TextBox Complemento;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.TextBox Logradouro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox Foto;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DataNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Profissao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox GrauInstrucao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Religiao;
        private System.Windows.Forms.CheckBox RecebeBeneficio;
        private System.Windows.Forms.CheckBox UsaAlcool;
        private System.Windows.Forms.CheckBox UsaDrogas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Observacao;
        private System.Windows.Forms.Button RemoverParentesco;
        private System.Windows.Forms.Button IncluirParentesco;
        private System.Windows.Forms.ListView ListViewParentesco;
        private System.Windows.Forms.Label NomeParentescoLabel;
        private System.Windows.Forms.Label GrauParentescoLabel;
        private System.Windows.Forms.ComboBox GrauParentesco;
        private System.Windows.Forms.TextBox NomeParentesco;
        private System.Windows.Forms.Label DescricaoDeficienciaLabel;
        private System.Windows.Forms.Button RemoverDeficiencia;
        private System.Windows.Forms.Button IncluirDeficiencia;
        private System.Windows.Forms.ListView ListViewDeficiencia;
        private System.Windows.Forms.TextBox DescricaoDoenca;
        private System.Windows.Forms.Label DescricaoDoencaLabel;
        private System.Windows.Forms.Button RemoverDoenca;
        private System.Windows.Forms.Button IncluirDoenca;
        private System.Windows.Forms.ListView ListViewDoenca;
        private System.Windows.Forms.TextBox DescricaoHabilidade;
        private System.Windows.Forms.Label DescricaoHabilidadeLabel;
        private System.Windows.Forms.Button RemoverHabilidade;
        private System.Windows.Forms.Button IncluirHabilidade;
        private System.Windows.Forms.ListView ListViewHabilidade;
        private System.Windows.Forms.ComboBox EstadoCivil;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.ComboBox Naturalidade;
        private System.Windows.Forms.ComboBox Etnia;
        private System.Windows.Forms.ComboBox DescricaoDeficiencia;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox Sexo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Idade;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox RendaFamiliar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox Cpf;
        private System.Windows.Forms.Button Selecionar;
    }
}