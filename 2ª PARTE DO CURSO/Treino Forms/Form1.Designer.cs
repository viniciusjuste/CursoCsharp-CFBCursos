namespace Treino_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_adicionar = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.tb_lista = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_adicionar
            // 
            this.tb_adicionar.Location = new System.Drawing.Point(22, 22);
            this.tb_adicionar.Name = "tb_adicionar";
            this.tb_adicionar.Size = new System.Drawing.Size(407, 26);
            this.tb_adicionar.TabIndex = 0;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(467, 22);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(291, 51);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "Adicionar";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_lista
            // 
            this.tb_lista.Location = new System.Drawing.Point(22, 81);
            this.tb_lista.Multiline = true;
            this.tb_lista.Name = "tb_lista";
            this.tb_lista.Size = new System.Drawing.Size(736, 337);
            this.tb_lista.TabIndex = 2;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(22, 457);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(736, 50);
            this.btn_limpar.TabIndex = 3;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.Location = new System.Drawing.Point(22, 535);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(736, 45);
            this.btn_proximo.TabIndex = 4;
            this.btn_proximo.Text = "Proximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.tb_lista);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.tb_adicionar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_adicionar;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_proximo;
        public System.Windows.Forms.TextBox tb_lista;
    }
}

