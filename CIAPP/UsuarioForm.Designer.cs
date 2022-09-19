namespace CIAPP
{
    partial class UsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Tipo = new System.Windows.Forms.ComboBox();
            this.Salvar = new System.Windows.Forms.Button();
            this.LabelEntidade = new System.Windows.Forms.Label();
            this.Entidade = new System.Windows.Forms.ComboBox();
            this.SenhaLabel = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo:";
            // 
            // Id
            // 
            this.Id.Enabled = false;
            this.Id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(127, 22);
            this.Id.Margin = new System.Windows.Forms.Padding(4);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(83, 30);
            this.Id.TabIndex = 6;
            // 
            // Nome
            // 
            this.Nome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(127, 58);
            this.Nome.Margin = new System.Windows.Forms.Padding(4);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(397, 30);
            this.Nome.TabIndex = 7;
            this.Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(127, 95);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(397, 30);
            this.Login.TabIndex = 8;
            this.Login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Login.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(127, 172);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(397, 30);
            this.Email.TabIndex = 10;
            this.Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Email.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Tipo
            // 
            this.Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.FormattingEnabled = true;
            this.Tipo.Items.AddRange(new object[] {
            "Fórum",
            "Entidade"});
            this.Tipo.Location = new System.Drawing.Point(127, 213);
            this.Tipo.Margin = new System.Windows.Forms.Padding(4);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(160, 30);
            this.Tipo.TabIndex = 11;
            this.Tipo.SelectedIndexChanged += new System.EventHandler(this.Tipo_SelectedIndexChanged);
            this.Tipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Tipo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Salvar.FlatAppearance.BorderSize = 0;
            this.Salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salvar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salvar.ForeColor = System.Drawing.Color.White;
            this.Salvar.Location = new System.Drawing.Point(285, 325);
            this.Salvar.Margin = new System.Windows.Forms.Padding(4);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(240, 49);
            this.Salvar.TabIndex = 12;
            this.Salvar.Text = "SALVAR";
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // LabelEntidade
            // 
            this.LabelEntidade.AutoSize = true;
            this.LabelEntidade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEntidade.Location = new System.Drawing.Point(15, 258);
            this.LabelEntidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEntidade.Name = "LabelEntidade";
            this.LabelEntidade.Size = new System.Drawing.Size(98, 22);
            this.LabelEntidade.TabIndex = 13;
            this.LabelEntidade.Text = "Entidade:";
            // 
            // Entidade
            // 
            this.Entidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Entidade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entidade.FormattingEnabled = true;
            this.Entidade.Location = new System.Drawing.Point(127, 255);
            this.Entidade.Margin = new System.Windows.Forms.Padding(4);
            this.Entidade.Name = "Entidade";
            this.Entidade.Size = new System.Drawing.Size(397, 30);
            this.Entidade.TabIndex = 14;
            this.Entidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // SenhaLabel
            // 
            this.SenhaLabel.AutoSize = true;
            this.SenhaLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaLabel.Location = new System.Drawing.Point(41, 134);
            this.SenhaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SenhaLabel.Name = "SenhaLabel";
            this.SenhaLabel.Size = new System.Drawing.Size(73, 22);
            this.SenhaLabel.TabIndex = 3;
            this.SenhaLabel.Text = "Senha:";
            // 
            // Senha
            // 
            this.Senha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(127, 133);
            this.Senha.Margin = new System.Windows.Forms.Padding(4);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(397, 30);
            this.Senha.TabIndex = 9;
            this.Senha.UseSystemPasswordChar = true;
            this.Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Senha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(541, 389);
            this.Controls.Add(this.Entidade);
            this.Controls.Add(this.LabelEntidade);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SenhaLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsuarioForm";
            this.Text = "Usuário";
            this.Load += new System.EventHandler(this.UsuarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.ComboBox Tipo;
        public System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label LabelEntidade;
        private System.Windows.Forms.ComboBox Entidade;
        private System.Windows.Forms.Label SenhaLabel;
        private System.Windows.Forms.TextBox Senha;
    }
}