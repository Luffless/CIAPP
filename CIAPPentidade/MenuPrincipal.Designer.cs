namespace CIAPPentidade
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSlide = new System.Windows.Forms.PictureBox();
            this.Painel = new System.Windows.Forms.Panel();
            this.Detalhes = new System.Windows.Forms.Button();
            this.Importar = new System.Windows.Forms.Button();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CpfFiltro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListView = new System.Windows.Forms.ListView();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.UsuarioLogado = new System.Windows.Forms.Label();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).BeginInit();
            this.Painel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.MidnightBlue;
            this.MenuVertical.Controls.Add(this.pictureBox2);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(66, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSlide
            // 
            this.BtnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSlide.Image = ((System.Drawing.Image)(resources.GetObject("BtnSlide.Image")));
            this.BtnSlide.Location = new System.Drawing.Point(6, 7);
            this.BtnSlide.Name = "BtnSlide";
            this.BtnSlide.Size = new System.Drawing.Size(35, 35);
            this.BtnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSlide.TabIndex = 0;
            this.BtnSlide.TabStop = false;
            this.BtnSlide.Click += new System.EventHandler(this.BtnSlide_Click);
            // 
            // Painel
            // 
            this.Painel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Painel.Controls.Add(this.Detalhes);
            this.Painel.Controls.Add(this.Importar);
            this.Painel.Controls.Add(this.Pesquisar);
            this.Painel.Controls.Add(this.groupBox1);
            this.Painel.Controls.Add(this.label1);
            this.Painel.Controls.Add(this.ListView);
            this.Painel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel.Location = new System.Drawing.Point(250, 50);
            this.Painel.Name = "Painel";
            this.Painel.Size = new System.Drawing.Size(1050, 600);
            this.Painel.TabIndex = 2;
            // 
            // Detalhes
            // 
            this.Detalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Detalhes.BackColor = System.Drawing.Color.MidnightBlue;
            this.Detalhes.FlatAppearance.BorderSize = 0;
            this.Detalhes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Detalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detalhes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detalhes.ForeColor = System.Drawing.Color.White;
            this.Detalhes.Image = ((System.Drawing.Image)(resources.GetObject("Detalhes.Image")));
            this.Detalhes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Detalhes.Location = new System.Drawing.Point(858, 176);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Size = new System.Drawing.Size(180, 40);
            this.Detalhes.TabIndex = 32;
            this.Detalhes.Text = "DETALHES";
            this.Detalhes.UseVisualStyleBackColor = false;
            this.Detalhes.Click += new System.EventHandler(this.Detalhes_Click);
            // 
            // Importar
            // 
            this.Importar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Importar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Importar.FlatAppearance.BorderSize = 0;
            this.Importar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Importar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Importar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Importar.ForeColor = System.Drawing.Color.White;
            this.Importar.Image = ((System.Drawing.Image)(resources.GetObject("Importar.Image")));
            this.Importar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Importar.Location = new System.Drawing.Point(858, 108);
            this.Importar.Name = "Importar";
            this.Importar.Size = new System.Drawing.Size(180, 40);
            this.Importar.TabIndex = 31;
            this.Importar.Text = "IMPORTAR";
            this.Importar.UseVisualStyleBackColor = false;
            this.Importar.Click += new System.EventHandler(this.Importar_Click);
            // 
            // Pesquisar
            // 
            this.Pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pesquisar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Pesquisar.FlatAppearance.BorderSize = 0;
            this.Pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pesquisar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisar.ForeColor = System.Drawing.Color.White;
            this.Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("Pesquisar.Image")));
            this.Pesquisar.Location = new System.Drawing.Point(858, 46);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(54, 54);
            this.Pesquisar.TabIndex = 30;
            this.Pesquisar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CpfFiltro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NomeFiltro);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 64);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // CpfFiltro
            // 
            this.CpfFiltro.Location = new System.Drawing.Point(54, 25);
            this.CpfFiltro.MaxLength = 14;
            this.CpfFiltro.Name = "CpfFiltro";
            this.CpfFiltro.Size = new System.Drawing.Size(220, 26);
            this.CpfFiltro.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(280, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome:";
            // 
            // NomeFiltro
            // 
            this.NomeFiltro.Location = new System.Drawing.Point(343, 25);
            this.NomeFiltro.Name = "NomeFiltro";
            this.NomeFiltro.Size = new System.Drawing.Size(496, 26);
            this.NomeFiltro.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Prestadores";
            // 
            // ListView
            // 
            this.ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView.FullRowSelect = true;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(7, 108);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(845, 480);
            this.ListView.TabIndex = 27;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.DoubleClick += new System.EventHandler(this.DoubleClick_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTitulo.Controls.Add(this.UsuarioLogado);
            this.BarraTitulo.Controls.Add(this.BtnSlide);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.BarraTitulo.TabIndex = 1;
            // 
            // UsuarioLogado
            // 
            this.UsuarioLogado.AutoSize = true;
            this.UsuarioLogado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLogado.Location = new System.Drawing.Point(47, 15);
            this.UsuarioLogado.Name = "UsuarioLogado";
            this.UsuarioLogado.Size = new System.Drawing.Size(125, 19);
            this.UsuarioLogado.TabIndex = 1;
            this.UsuarioLogado.Text = "UsuarioLogado";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.Painel);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1316, 689);
            this.Name = "MenuPrincipal";
            this.Text = "CIAPP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Close);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).EndInit();
            this.Painel.ResumeLayout(false);
            this.Painel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel Painel;
        private System.Windows.Forms.PictureBox BtnSlide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label UsuarioLogado;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CpfFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeFiltro;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.Button Detalhes;
        private System.Windows.Forms.Button Importar;
    }
}