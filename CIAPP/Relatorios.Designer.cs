namespace CIAPP
{
    partial class Relatorios
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Label();
            this.EntidadesRelatorio = new System.Windows.Forms.Button();
            this.PrestadoresRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relatórios";
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
            this.BtnFechar.TabIndex = 18;
            this.BtnFechar.Text = "X";
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // EntidadesRelatorio
            // 
            this.EntidadesRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EntidadesRelatorio.BackColor = System.Drawing.Color.MidnightBlue;
            this.EntidadesRelatorio.FlatAppearance.BorderSize = 0;
            this.EntidadesRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.EntidadesRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntidadesRelatorio.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntidadesRelatorio.ForeColor = System.Drawing.Color.White;
            this.EntidadesRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EntidadesRelatorio.Location = new System.Drawing.Point(309, 157);
            this.EntidadesRelatorio.Name = "EntidadesRelatorio";
            this.EntidadesRelatorio.Size = new System.Drawing.Size(433, 82);
            this.EntidadesRelatorio.TabIndex = 19;
            this.EntidadesRelatorio.Text = "ENTIDADES";
            this.EntidadesRelatorio.UseVisualStyleBackColor = false;
            this.EntidadesRelatorio.Click += new System.EventHandler(this.EntidadesRelatorio_Click);
            // 
            // PrestadoresRelatorio
            // 
            this.PrestadoresRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PrestadoresRelatorio.BackColor = System.Drawing.Color.MidnightBlue;
            this.PrestadoresRelatorio.FlatAppearance.BorderSize = 0;
            this.PrestadoresRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PrestadoresRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrestadoresRelatorio.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrestadoresRelatorio.ForeColor = System.Drawing.Color.White;
            this.PrestadoresRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrestadoresRelatorio.Location = new System.Drawing.Point(309, 348);
            this.PrestadoresRelatorio.Name = "PrestadoresRelatorio";
            this.PrestadoresRelatorio.Size = new System.Drawing.Size(433, 82);
            this.PrestadoresRelatorio.TabIndex = 20;
            this.PrestadoresRelatorio.Text = "PRESTADORES";
            this.PrestadoresRelatorio.UseVisualStyleBackColor = false;
            this.PrestadoresRelatorio.Click += new System.EventHandler(this.PrestadoresRelatorio_Click);
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.PrestadoresRelatorio);
            this.Controls.Add(this.EntidadesRelatorio);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Relatorios";
            this.Text = "Relatorios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BtnFechar;
        private System.Windows.Forms.Button EntidadesRelatorio;
        private System.Windows.Forms.Button PrestadoresRelatorio;
    }
}