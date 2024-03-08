using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componente_Textbo___Aula_62
{
    public partial class F_principal : Form
    {
        public F_principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um veículo");
                tb_veiculo.Focus();
                return; // é para pausar essa execução
            }

            tb_listaVeiculos.Text += tb_veiculo.Text + ", ";
            tb_veiculo.Clear(); // aqui eu limpo o tb_veiculos apos adicionar 
            tb_veiculo.Focus(); // aqui eu posiciono o cursor de volta no tb_veiculos
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaVeiculos.Clear(); // aqui eu limpo a minha lista
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }
    }
}
