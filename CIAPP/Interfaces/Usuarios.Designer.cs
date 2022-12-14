namespace CIAPP
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.Novo = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Label();
            this.Editar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeFiltro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailFiltro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Detalhes = new System.Windows.Forms.Button();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUÁRIOS";
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
            this.Novo.Location = new System.Drawing.Point(858, 107);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(180, 40);
            this.Novo.TabIndex = 3;
            this.Novo.Text = "NOVO";
            this.Novo.UseVisualStyleBackColor = false;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
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
            this.BtnFechar.TabIndex = 4;
            this.BtnFechar.Text = "X";
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
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
            this.Editar.Location = new System.Drawing.Point(858, 153);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(180, 40);
            this.Editar.TabIndex = 6;
            this.Editar.Text = "EDITAR";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
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
            this.Excluir.Location = new System.Drawing.Point(858, 199);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(180, 40);
            this.Excluir.TabIndex = 7;
            this.Excluir.Text = "EXCLUIR";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // ListView
            // 
            this.ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView.FullRowSelect = true;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(7, 107);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(845, 481);
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.DoubleClick += new System.EventHandler(this.DoubleClick_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome:";
            // 
            // NomeFiltro
            // 
            this.NomeFiltro.Location = new System.Drawing.Point(69, 24);
            this.NomeFiltro.Name = "NomeFiltro";
            this.NomeFiltro.Size = new System.Drawing.Size(312, 26);
            this.NomeFiltro.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.Location = new System.Drawing.Point(387, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "E-mail:";
            // 
            // EmailFiltro
            // 
            this.EmailFiltro.Location = new System.Drawing.Point(448, 24);
            this.EmailFiltro.Name = "EmailFiltro";
            this.EmailFiltro.Size = new System.Drawing.Size(391, 26);
            this.EmailFiltro.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EmailFiltro);
            this.groupBox1.Controls.Add(this.NomeFiltro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 64);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
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
            this.Detalhes.Location = new System.Drawing.Point(858, 267);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Size = new System.Drawing.Size(180, 40);
            this.Detalhes.TabIndex = 16;
            this.Detalhes.Text = "DETALHES";
            this.Detalhes.UseVisualStyleBackColor = false;
            this.Detalhes.Click += new System.EventHandler(this.Detalhes_Click);
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
            this.Pesquisar.Location = new System.Drawing.Point(858, 47);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(54, 54);
            this.Pesquisar.TabIndex = 21;
            this.Pesquisar.UseVisualStyleBackColor = false;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.Detalhes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Label BtnFechar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailFiltro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Detalhes;
        private System.Windows.Forms.Button Pesquisar;
    }
}