namespace CIAPP
{
    partial class Processos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Processos));
            this.BtnFechar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumeroArtigoPenalFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NomePrestadorFiltro = new System.Windows.Forms.TextBox();
            this.Detalhes = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Novo = new System.Windows.Forms.Button();
            this.Exportar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.AutoSize = true;
            this.BtnFechar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnFechar.Location = new System.Drawing.Point(1013, 5);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(32, 31);
            this.BtnFechar.TabIndex = 5;
            this.BtnFechar.Text = "X";
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "PROCESSOS";
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
            this.Pesquisar.TabIndex = 29;
            this.Pesquisar.UseVisualStyleBackColor = false;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
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
            this.ListView.TabIndex = 30;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.DoubleClick += new System.EventHandler(this.DoubleClick_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.NumeroArtigoPenalFiltro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NomePrestadorFiltro);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 64);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // NumeroArtigoPenalFiltro
            // 
            this.NumeroArtigoPenalFiltro.Location = new System.Drawing.Point(741, 25);
            this.NumeroArtigoPenalFiltro.MaxLength = 3;
            this.NumeroArtigoPenalFiltro.Name = "NumeroArtigoPenalFiltro";
            this.NumeroArtigoPenalFiltro.Size = new System.Drawing.Size(98, 26);
            this.NumeroArtigoPenalFiltro.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prestador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Número Artigo Penal:";
            // 
            // NomePrestadorFiltro
            // 
            this.NomePrestadorFiltro.Location = new System.Drawing.Point(95, 24);
            this.NomePrestadorFiltro.Name = "NomePrestadorFiltro";
            this.NomePrestadorFiltro.Size = new System.Drawing.Size(470, 26);
            this.NomePrestadorFiltro.TabIndex = 9;
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
            this.Detalhes.Location = new System.Drawing.Point(858, 312);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Size = new System.Drawing.Size(180, 40);
            this.Detalhes.TabIndex = 35;
            this.Detalhes.Text = "DETALHES";
            this.Detalhes.UseVisualStyleBackColor = false;
            this.Detalhes.Click += new System.EventHandler(this.Detalhes_Click);
            // 
            // Excluir
            // 
            this.Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Excluir.BackColor = System.Drawing.Color.MidnightBlue;
            this.Excluir.FlatAppearance.BorderSize = 0;
            this.Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Excluir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.ForeColor = System.Drawing.Color.White;
            this.Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Excluir.Image")));
            this.Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Excluir.Location = new System.Drawing.Point(858, 200);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(180, 40);
            this.Excluir.TabIndex = 34;
            this.Excluir.Text = "EXCLUIR";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Editar
            // 
            this.Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Editar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Editar.FlatAppearance.BorderSize = 0;
            this.Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.ForeColor = System.Drawing.Color.White;
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Editar.Location = new System.Drawing.Point(858, 154);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(180, 40);
            this.Editar.TabIndex = 33;
            this.Editar.Text = "EDITAR";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Novo
            // 
            this.Novo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Novo.BackColor = System.Drawing.Color.MidnightBlue;
            this.Novo.FlatAppearance.BorderSize = 0;
            this.Novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Novo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Novo.ForeColor = System.Drawing.Color.White;
            this.Novo.Image = ((System.Drawing.Image)(resources.GetObject("Novo.Image")));
            this.Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Novo.Location = new System.Drawing.Point(858, 108);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(180, 40);
            this.Novo.TabIndex = 32;
            this.Novo.Text = "NOVO";
            this.Novo.UseVisualStyleBackColor = false;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // Exportar
            // 
            this.Exportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exportar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Exportar.FlatAppearance.BorderSize = 0;
            this.Exportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exportar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exportar.ForeColor = System.Drawing.Color.White;
            this.Exportar.Image = ((System.Drawing.Image)(resources.GetObject("Exportar.Image")));
            this.Exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exportar.Location = new System.Drawing.Point(858, 266);
            this.Exportar.Name = "Exportar";
            this.Exportar.Size = new System.Drawing.Size(180, 40);
            this.Exportar.TabIndex = 36;
            this.Exportar.Text = "EXPORTAR";
            this.Exportar.UseVisualStyleBackColor = false;
            this.Exportar.Click += new System.EventHandler(this.Exportar_Click);
            // 
            // Processos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.Exportar);
            this.Controls.Add(this.Detalhes);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Processos";
            this.Text = "Processos";
            this.Load += new System.EventHandler(this.Processos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BtnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NumeroArtigoPenalFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomePrestadorFiltro;
        private System.Windows.Forms.Button Detalhes;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button Exportar;
    }
}