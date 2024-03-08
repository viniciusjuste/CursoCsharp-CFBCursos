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
        public F_veiculos(String v)
        {
            InitializeComponent();
            tb_listaVeiculos.Text = v;
        }

        private void tb_listaVeiculos_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_principal f_Principal = new F_principal();
            f_Principal.Show();
        }
    }
}
