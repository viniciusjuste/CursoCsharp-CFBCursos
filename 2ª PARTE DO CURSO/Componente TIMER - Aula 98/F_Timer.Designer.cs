namespace Componente_Backgroundworker____Aula_97
{
    partial class F_Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Timer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_iniciar_t1 = new System.Windows.Forms.Button();
            this.btn_parar_t1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reiniciar_t1 = new System.Windows.Forms.Button();
            this.timer_carro = new System.Windows.Forms.Timer(this.components);
            this.btn_IniciarCarro = new System.Windows.Forms.Button();
            this.btn_pararCarro = new System.Windows.Forms.Button();
            this.img_Carro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_Carro)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_iniciar_t1
            // 
            this.btn_iniciar_t1.Location = new System.Drawing.Point(12, 32);
            this.btn_iniciar_t1.Name = "btn_iniciar_t1";
            this.btn_iniciar_t1.Size = new System.Drawing.Size(179, 50);
            this.btn_iniciar_t1.TabIndex = 0;
            this.btn_iniciar_t1.Text = "Iniciar";
            this.btn_iniciar_t1.UseVisualStyleBackColor = true;
            this.btn_iniciar_t1.Click += new System.EventHandler(this.btn_iniciar_t1_Click);
            // 
            // btn_parar_t1
            // 
            this.btn_parar_t1.Location = new System.Drawing.Point(235, 32);
            this.btn_parar_t1.Name = "btn_parar_t1";
            this.btn_parar_t1.Size = new System.Drawing.Size(179, 50);
            this.btn_parar_t1.TabIndex = 1;
            this.btn_parar_t1.Text = "Parar";
            this.btn_parar_t1.UseVisualStyleBackColor = true;
            this.btn_parar_t1.Click += new System.EventHandler(this.btn_parar_t1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // btn_reiniciar_t1
            // 
            this.btn_reiniciar_t1.Location = new System.Drawing.Point(463, 32);
            this.btn_reiniciar_t1.Name = "btn_reiniciar_t1";
            this.btn_reiniciar_t1.Size = new System.Drawing.Size(179, 50);
            this.btn_reiniciar_t1.TabIndex = 3;
            this.btn_reiniciar_t1.Text = "Reiniciar";
            this.btn_reiniciar_t1.UseVisualStyleBackColor = true;
            this.btn_reiniciar_t1.Click += new System.EventHandler(this.btn_reiniciar_t1_Click);
            // 
            // timer_carro
            // 
            this.timer_carro.Interval = 1;
            this.timer_carro.Tick += new System.EventHandler(this.timer_carro_Tick);
            // 
            // btn_IniciarCarro
            // 
            this.btn_IniciarCarro.Location = new System.Drawing.Point(12, 446);
            this.btn_IniciarCarro.Name = "btn_IniciarCarro";
            this.btn_IniciarCarro.Size = new System.Drawing.Size(179, 50);
            this.btn_IniciarCarro.TabIndex = 5;
            this.btn_IniciarCarro.Text = "Iniciar";
            this.btn_IniciarCarro.UseVisualStyleBackColor = true;
            this.btn_IniciarCarro.Click += new System.EventHandler(this.btn_IniciarCarro_Click);
            // 
            // btn_pararCarro
            // 
            this.btn_pararCarro.Location = new System.Drawing.Point(274, 446);
            this.btn_pararCarro.Name = "btn_pararCarro";
            this.btn_pararCarro.Size = new System.Drawing.Size(179, 50);
            this.btn_pararCarro.TabIndex = 6;
            this.btn_pararCarro.Text = "Parar";
            this.btn_pararCarro.UseVisualStyleBackColor = true;
            this.btn_pararCarro.Click += new System.EventHandler(this.btn_pararCarro_Click);
            // 
            // img_Carro
            // 
            this.img_Carro.Image = ((System.Drawing.Image)(resources.GetObject("img_Carro.Image")));
            this.img_Carro.Location = new System.Drawing.Point(25, 179);
            this.img_Carro.Name = "img_Carro";
            this.img_Carro.Size = new System.Drawing.Size(313, 236);
            this.img_Carro.TabIndex = 7;
            this.img_Carro.TabStop = false;
            // 
            // F_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.img_Carro);
            this.Controls.Add(this.btn_pararCarro);
            this.Controls.Add(this.btn_IniciarCarro);
            this.Controls.Add(this.btn_reiniciar_t1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_parar_t1);
            this.Controls.Add(this.btn_iniciar_t1);
            this.Name = "F_Timer";
            this.Text = "F_Timer";
            this.Load += new System.EventHandler(this.F_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Carro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_iniciar_t1;
        private System.Windows.Forms.Button btn_parar_t1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reiniciar_t1;
        private System.Windows.Forms.Timer timer_carro;
        private System.Windows.Forms.Button btn_IniciarCarro;
        private System.Windows.Forms.Button btn_pararCarro;
        private System.Windows.Forms.PictureBox img_Carro;
    }
}