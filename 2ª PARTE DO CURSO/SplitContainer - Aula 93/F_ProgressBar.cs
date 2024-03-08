using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componente_Textbo___Aula_62
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            if((int.Parse(textBox1.Text) >= progressBar1.Minimum) & (int.Parse(textBox1.Text) <= progressBar1.Maximum))
            {
                progressBar1.Value = int.Parse(textBox1.Text);
                
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Esse valor não é válido");
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = int.Parse(textBox2.Text);
            
            for (int i = 0; i <= int.Parse(textBox2.Text); i++)
            {
                progressBar1.Value = i;
                // Thread.Sleep(200); // define um tempo de 2 milisegundos
                label1.Text = i.ToString();

            }
        }
    }
}
