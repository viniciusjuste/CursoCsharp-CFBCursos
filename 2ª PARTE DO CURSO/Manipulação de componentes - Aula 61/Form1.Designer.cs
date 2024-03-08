namespace Formulário__Manipulação_de_componentes__Evento_de_clique___Aula_61
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.lb_1 = new System.Windows.Forms.Label();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_1.ForeColor = System.Drawing.Color.Black;
            this.btn_1.Location = new System.Drawing.Point(296, 524);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(223, 63);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Digite aqui";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_1.Location = new System.Drawing.Point(205, 387);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(433, 32);
            this.lb_1.TabIndex = 1;
            this.lb_1.Text = "Sua mensagem aparecerá aqui...";
            this.lb_1.Click += new System.EventHandler(this.lb_1_Click);
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(257, 254);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(324, 26);
            this.tb_1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(875, 633);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.btn_1);
            this.Name = "Form1";
            this.Text = "CFB Cursos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.TextBox tb_1;
    }
}

