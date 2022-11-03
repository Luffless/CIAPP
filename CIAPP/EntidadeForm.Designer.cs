namespace CIAPP
{
    partial class EntidadeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntidadeForm));
            this.Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Salvar = new System.Windows.Forms.Button();
            this.RazaoSocial = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Observacao = new System.Windows.Forms.TextBox();
            this.DataCredenciamento = new System.Windows.Forms.DateTimePicker();
            this.DataDescredenciamento = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.Cnpj = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.Enabled = false;
            this.Id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(120, 30);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(63, 26);
            this.Id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Razão Social:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Estado);
            this.groupBox1.Controls.Add(this.Cep);
            this.groupBox1.Controls.Add(this.Municipio);
            this.groupBox1.Controls.Add(this.Bairro);
            this.groupBox1.Controls.Add(this.Complemento);
            this.groupBox1.Controls.Add(this.Numero);
            this.groupBox1.Controls.Add(this.Logradouro);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 280);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
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
            this.Estado.Location = new System.Drawing.Point(131, 233);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(161, 28);
            this.Estado.TabIndex = 15;
            // 
            // Cep
            // 
            this.Cep.Location = new System.Drawing.Point(131, 198);
            this.Cep.MaxLength = 9;
            this.Cep.Name = "Cep";
            this.Cep.Size = new System.Drawing.Size(100, 26);
            this.Cep.TabIndex = 14;
            this.Cep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Cep.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Municipio
            // 
            this.Municipio.Location = new System.Drawing.Point(131, 164);
            this.Municipio.Name = "Municipio";
            this.Municipio.Size = new System.Drawing.Size(309, 26);
            this.Municipio.TabIndex = 13;
            this.Municipio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Municipio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Bairro
            // 
            this.Bairro.Location = new System.Drawing.Point(131, 129);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(309, 26);
            this.Bairro.TabIndex = 12;
            this.Bairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Bairro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Complemento
            // 
            this.Complemento.Location = new System.Drawing.Point(131, 94);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(309, 26);
            this.Complemento.TabIndex = 11;
            this.Complemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Complemento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(131, 58);
            this.Numero.MaxLength = 5;
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(100, 26);
            this.Numero.TabIndex = 10;
            this.Numero.TextChanged += new System.EventHandler(this.Numero_TextChanged);
            this.Numero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Numero.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Logradouro
            // 
            this.Logradouro.Location = new System.Drawing.Point(131, 26);
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Size = new System.Drawing.Size(498, 26);
            this.Logradouro.TabIndex = 9;
            this.Logradouro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(62, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Estado:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(82, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "CEP:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Município:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Bairro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Complemento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Número:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Logradouro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data Credenciamento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(321, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data Descredenciamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Observação:";
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Salvar.FlatAppearance.BorderSize = 0;
            this.Salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salvar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salvar.ForeColor = System.Drawing.Color.White;
            this.Salvar.Location = new System.Drawing.Point(481, 560);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(180, 40);
            this.Salvar.TabIndex = 13;
            this.Salvar.Text = "SALVAR";
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // RazaoSocial
            // 
            this.RazaoSocial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RazaoSocial.Location = new System.Drawing.Point(120, 64);
            this.RazaoSocial.Name = "RazaoSocial";
            this.RazaoSocial.Size = new System.Drawing.Size(389, 26);
            this.RazaoSocial.TabIndex = 3;
            this.RazaoSocial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.RazaoSocial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Telefone
            // 
            this.Telefone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(120, 96);
            this.Telefone.MaxLength = 9;
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(100, 26);
            this.Telefone.TabIndex = 4;
            this.Telefone.TextChanged += new System.EventHandler(this.Telefone_TextChanged);
            this.Telefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Telefone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(120, 128);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(389, 26);
            this.Email.TabIndex = 5;
            this.Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Email.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Observacao
            // 
            this.Observacao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Observacao.Location = new System.Drawing.Point(120, 202);
            this.Observacao.Multiline = true;
            this.Observacao.Name = "Observacao";
            this.Observacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Observacao.Size = new System.Drawing.Size(531, 66);
            this.Observacao.TabIndex = 8;
            // 
            // DataCredenciamento
            // 
            this.DataCredenciamento.CustomFormat = " ";
            this.DataCredenciamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataCredenciamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataCredenciamento.Location = new System.Drawing.Point(193, 163);
            this.DataCredenciamento.Name = "DataCredenciamento";
            this.DataCredenciamento.Size = new System.Drawing.Size(122, 26);
            this.DataCredenciamento.TabIndex = 6;
            this.DataCredenciamento.ValueChanged += new System.EventHandler(this.DataCredenciamento_ValueChanged);
            this.DataCredenciamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataCredenciamento_KeyDown);
            this.DataCredenciamento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // DataDescredenciamento
            // 
            this.DataDescredenciamento.CustomFormat = " ";
            this.DataDescredenciamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataDescredenciamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataDescredenciamento.Location = new System.Drawing.Point(529, 166);
            this.DataDescredenciamento.Name = "DataDescredenciamento";
            this.DataDescredenciamento.Size = new System.Drawing.Size(122, 26);
            this.DataDescredenciamento.TabIndex = 7;
            this.DataDescredenciamento.ValueChanged += new System.EventHandler(this.DataDescredenciamento_ValueChanged);
            this.DataDescredenciamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataDescredenciamento_KeyDown);
            this.DataDescredenciamento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(252, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "CNPJ:";
            // 
            // Cnpj
            // 
            this.Cnpj.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cnpj.Location = new System.Drawing.Point(310, 30);
            this.Cnpj.MaxLength = 18;
            this.Cnpj.Name = "Cnpj";
            this.Cnpj.Size = new System.Drawing.Size(199, 26);
            this.Cnpj.TabIndex = 2;
            this.Cnpj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // EntidadeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(673, 611);
            this.Controls.Add(this.Cnpj);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DataDescredenciamento);
            this.Controls.Add(this.DataCredenciamento);
            this.Controls.Add(this.Observacao);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.RazaoSocial);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntidadeForm";
            this.Text = "Entidade";
            this.Load += new System.EventHandler(this.EntidadeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Estado;
        private System.Windows.Forms.TextBox Cep;
        private System.Windows.Forms.TextBox Municipio;
        private System.Windows.Forms.TextBox Bairro;
        private System.Windows.Forms.TextBox Complemento;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.TextBox Logradouro;
        private System.Windows.Forms.TextBox RazaoSocial;
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Observacao;
        private System.Windows.Forms.DateTimePicker DataCredenciamento;
        private System.Windows.Forms.DateTimePicker DataDescredenciamento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Cnpj;
    }
}