using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componente_Backgroundworker____Aula_97
{
    public partial class F_Timer : Form
    {
        int num;
        int px, py;
        public F_Timer()
        {
            InitializeComponent();
        }

        private void F_Timer_Load(object sender, EventArgs e)
        {
            // num = 0;
            px = img_Carro.Location.X;
            py = img_Carro.Location.Y;
        }

        private void btn_iniciar_t1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_parar_t1_Click(object sender, EventArgs e)
        {
            // timer1.interval = 500;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = num.ToString();
            num++;
        }

        private void btn_reiniciar_t1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            label1.Text = num.ToString();
            timer1.Start();
        }

        private void btn_IniciarCarro_Click(object sender, EventArgs e)
        {
            timer_carro.Start();
        }

        private void btn_pararCarro_Click(object sender, EventArgs e)
        {
            timer_carro.Stop();
        }

        private void timer_carro_Tick(object sender, EventArgs e)
        {
            px += 25; 
            if(px == 475)
            {
                px = 25;
            }
           img_Carro.Location = new Point(px, py);
            px = img_Carro.Location.X;
        }
    }
}
