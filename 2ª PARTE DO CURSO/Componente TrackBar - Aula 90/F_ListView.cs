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
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void limpar()
        {
            tb_id.Clear();
            tb_preco.Clear(); 
            tb_produto.Clear(); 
            tb_qtde.Clear();
            tb_id.Focus();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            String[] pr = new string[4];

            pr[0] = tb_id.Text;
            pr[1] = tb_produto.Text;
            pr[2] = tb_qtde.Text;
            pr[3] = tb_preco.Text;

            ListViewItem listView = new ListViewItem(pr);
            lv_produtos.Items.Add(listView);
            limpar();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_qtde.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }

        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_produtos.SelectedIndices.Count > 0)
            {
                tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
                tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
                tb_qtde.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
                tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
