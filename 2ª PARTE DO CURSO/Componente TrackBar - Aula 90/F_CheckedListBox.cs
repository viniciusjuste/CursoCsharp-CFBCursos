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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void F_CheckedListBox_Load(object sender, EventArgs e)
        {

        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            String txt = "";
            
            foreach (string s in clb_transportes.CheckedItems) 
            {
                txt += s + ",";
            }
            
            MessageBox.Show(txt);

            
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_resetarLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();

            List<String> tr = new List<string>();

            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Trem");

            clb_transportes.Items.AddRange(tr.ToArray());
        }

        private void btn_addNovoTransporte_Click(object sender, EventArgs e)
        {
            if(tb_novoTransporte.Text != "")
            {
                clb_transportes.Items.Add(tb_novoTransporte.Text);
                tb_novoTransporte.Clear();
                tb_novoTransporte.Focus();
            }
            else
            {
                MessageBox.Show("Lista vazia");
            }
            
        }
    }
}
