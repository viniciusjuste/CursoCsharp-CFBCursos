using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treino_Forms
{
    public partial class Form2 : Form
    {
        Form1 fp;
        public Form2(String v, Form1 f)
        {
            InitializeComponent();
            textBox1.Text = v;

            fp = f;
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_lista.Text = textBox1.Text;
        }
    }
}
