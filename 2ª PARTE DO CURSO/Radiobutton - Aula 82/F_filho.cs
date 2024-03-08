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
    
    public partial class F_filho : Form
    {
        public F_CheckBox f_CheckBox;
        public F_filho()
        {
            InitializeComponent();
           try
            {
                f_CheckBox = Application.OpenForms["F_CheckBox"] as F_CheckBox;
                cb_carro.Checked = f_CheckBox.cb_carro.Checked;
                cb_aviao.Checked = cb_carro.Checked;
                cb_navio.Checked = f_CheckBox.cb_navio.Checked;
                cb_onibus.Checked = f_CheckBox.cb_onibus.Checked;
            }
            catch 
            {
                MessageBox.Show("Erro ao abrir o formulário");
            }
             
        }

        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            f_CheckBox.cb_carro.Checked = cb_carro.Checked;
        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e)
        {
            cb_carro.Checked = cb_aviao.Checked;
        }

        private void cb_navio_CheckedChanged(object sender, EventArgs e)
        {
            f_CheckBox.cb_navio.Checked = cb_navio.Checked;
        }

        private void cb_onibus_CheckedChanged(object sender, EventArgs e)
        {
            f_CheckBox.cb_onibus.Checked = cb_onibus.Checked;
        }
    }
}
