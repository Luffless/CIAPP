namespace CIAPP
{
    partial class Observacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Observacao));
            this.ObservacaoTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ObservacaoTexto
            // 
            this.ObservacaoTexto.Enabled = false;
            this.ObservacaoTexto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObservacaoTexto.Location = new System.Drawing.Point(12, 12);
            this.ObservacaoTexto.Multiline = true;
            this.ObservacaoTexto.Name = "ObservacaoTexto";
            this.ObservacaoTexto.Size = new System.Drawing.Size(441, 280);
            this.ObservacaoTexto.TabIndex = 0;
            // 
            // Observacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 305);
            this.Controls.Add(this.ObservacaoTexto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Observacao";
            this.Text = "Observação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ObservacaoTexto;
    }
}