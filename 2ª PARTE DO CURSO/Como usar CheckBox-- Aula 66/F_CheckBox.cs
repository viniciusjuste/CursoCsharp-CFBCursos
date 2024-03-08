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
    public partial class F_CheckBox : Form
    {
        List<CheckBox> transp = new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            transp.Add(cb_carro);
            transp.Add(cb_aviao);
            transp.Add(cb_navio);
            transp.Add(cb_onibus);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_TransporteMarcados_Click(object sender, EventArgs e)
        {
            String txt = "";
            
            foreach (CheckBox cb in transp)
            {
                if (cb.Checked)
                {
                    txt += cb.Text + ", ";
                }
            }

            MessageBox.Show(txt);
        }
    }
}
