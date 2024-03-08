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
    public partial class F_ListBox : Form
    {
        List<String> carros = new List<String>();
        public F_ListBox()
        {
            InitializeComponent();
            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");
            
            lb_carros.DataSource = carros;
        }

        private void F_ListBox_Load(object sender, EventArgs e)
        {

        }

        public void atualizar()
        {
            lb_carros.DataSource = null;
            lb_carros.DataSource = carros;

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_carros.Text == "")
            {
                MessageBox.Show("Digite um carro");  
                tb_carros.Focus();
            }
            else
            {
                carros.Add(tb_carros.Text);
                
                atualizar();
                tb_carros.Clear();
                tb_carros.Focus();
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lb_carros.SelectedIndex);
            atualizar();

        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_carros.Text = carros[lb_carros.SelectedIndex];
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            tb_carros.Clear();
            atualizar();

        }
    }
}
