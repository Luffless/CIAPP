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
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.UsuarioLogado = new System.Windows.Forms.Label();
            this.BtnRelatorios = new System.Windows.Forms.Button();
            this.BtnProcessos = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.MidnightBlue;
            this.MenuVertical.Controls.Add(this.BtnRelatorios);
            this.MenuVertical.Controls.Add(this.BtnProcessos);
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
            this.Painel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel.Location = new System.Drawing.Point(250, 50);
            this.Painel.Name = "Painel";
            this.Painel.Size = new System.Drawing.Size(1050, 600);
            this.Painel.TabIndex = 2;
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
            // BtnRelatorios
            // 
            this.BtnRelatorios.FlatAppearance.BorderSize = 0;
            this.BtnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelatorios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelatorios.ForeColor = System.Drawing.Color.White;
            this.BtnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("BtnRelatorios.Image")));
            this.BtnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelatorios.Location = new System.Drawing.Point(0, 148);
            this.BtnRelatorios.Name = "BtnRelatorios";
            this.BtnRelatorios.Size = new System.Drawing.Size(250, 40);
            this.BtnRelatorios.TabIndex = 8;
            this.BtnRelatorios.Text = "Relatórios";
            this.BtnRelatorios.UseVisualStyleBackColor = true;
            this.BtnRelatorios.Click += new System.EventHandler(this.BtnRelatorios_Click);
            // 
            // BtnProcessos
            // 
            this.BtnProcessos.FlatAppearance.BorderSize = 0;
            this.BtnProcessos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnProcessos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcessos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcessos.ForeColor = System.Drawing.Color.White;
            this.BtnProcessos.Image = ((System.Drawing.Image)(resources.GetObject("BtnProcessos.Image")));
            this.BtnProcessos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProcessos.Location = new System.Drawing.Point(0, 102);
            this.BtnProcessos.Name = "BtnProcessos";
            this.BtnProcessos.Size = new System.Drawing.Size(250, 40);
            this.BtnProcessos.TabIndex = 7;
            this.BtnProcessos.Text = "Processos";
            this.BtnProcessos.UseVisualStyleBackColor = true;
            this.BtnProcessos.Click += new System.EventHandler(this.BtnProcessos_Click);
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
        public System.Windows.Forms.Button BtnRelatorios;
        public System.Windows.Forms.Button BtnProcessos;
    }
}