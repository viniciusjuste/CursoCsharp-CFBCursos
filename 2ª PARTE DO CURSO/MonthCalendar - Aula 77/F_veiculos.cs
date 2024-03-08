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
    public partial class F_veiculos : Form
    {
        F_principal fp; // o fp é do tipo form pai, e é global, para ter acesso ao conteudo do form pai
        public F_veiculos(String v, F_principal f)
        {
            InitializeComponent();
            tb_listaVeiculos.Text = v;

            fp = f;
            f.num = 10;
        }

        private void tb_listaVeiculos_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_principal f_Principal = new F_principal();
            f_Principal.Show();
        }

        private void F_veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_listaVeiculos.Text = tb_listaVeiculos.Text;
        }
    }
}
