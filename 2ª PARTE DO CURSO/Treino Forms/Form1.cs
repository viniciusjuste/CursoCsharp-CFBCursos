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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_adicionar.Text == "")
            {
                MessageBox.Show("Não existe nada na lista");
                tb_adicionar.Focus();
                return;
            }
            tb_lista.Text += tb_adicionar.Text + ",";
            tb_adicionar.Clear();
            tb_adicionar.Focus();
            
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_adicionar.Clear();
            tb_adicionar.Focus();
            tb_lista.Clear();

        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(tb_lista.Text, this);
            form2.ShowDialog();
        }
    }
}
