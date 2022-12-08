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
            this.Id = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Salvar = new System.Windows.Forms.Button();
            this.SenhaLabel = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail:";
            // 
            // Id
            // 
            this.Id.Enabled = false;
            this.Id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(95, 18);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(63, 26);
            this.Id.TabIndex = 6;
            // 
            // Nome
            // 
            this.Nome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(95, 47);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(299, 26);
            this.Nome.TabIndex = 7;
            this.Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(95, 111);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(299, 26);
            this.Login.TabIndex = 9;
            this.Login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Login.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(95, 79);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(299, 26);
            this.Email.TabIndex = 8;
            this.Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Email.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Salvar.FlatAppearance.BorderSize = 0;
            this.Salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salvar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salvar.ForeColor = System.Drawing.Color.White;
            this.Salvar.Location = new System.Drawing.Point(214, 175);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(180, 40);
            this.Salvar.TabIndex = 12;
            this.Salvar.Text = "SALVAR";
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // SenhaLabel
            // 
            this.SenhaLabel.AutoSize = true;
            this.SenhaLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaLabel.Location = new System.Drawing.Point(31, 144);
            this.SenhaLabel.Name = "SenhaLabel";
            this.SenhaLabel.Size = new System.Drawing.Size(58, 20);
            this.SenhaLabel.TabIndex = 3;
            this.SenhaLabel.Text = "Senha:";
            // 
            // Senha
            // 
            this.Senha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(95, 143);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(299, 26);
            this.Senha.TabIndex = 10;
            this.Senha.UseSystemPasswordChar = true;
            this.Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Senha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(406, 229);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SenhaLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Email;
        public System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label SenhaLabel;
        private System.Windows.Forms.TextBox Senha;
    }
}