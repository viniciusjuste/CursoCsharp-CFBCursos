using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Componente_Textbo___Aula_62
{
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox1.Text = treeView1.SelectedNode.Text;
            textBox2.Clear();
            if (treeView1.SelectedNode.Tag != null)
            {
                textBox2.Text = treeView1.SelectedNode.Tag.ToString();
            
            }
               
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            TreeNode raizEstados = treeView1.Nodes.Add("Estados");
            raizEstados.Name = "raizEstados";

            TreeNode estado1 = raizEstados.Nodes.Add("Minas Gerais");
            estado1.Name = "Minas Gerais";

            TreeNode estado2 = raizEstados.Nodes.Add("Rio de Janeiro");
            estado2.Name = "Rio de Janeiro";

            TreeNode estado3 = raizEstados.Nodes.Add("São Paulo");
            estado3.Name = "São Paulo";

            
            TreeNode raizCores = treeView1.Nodes.Add("Cores");
            raizCores.Name = "raizCores";

            TreeNode cor1 = raizCores.Nodes.Add("Preto");
            cor1.Name = "Preto";

            TreeNode cor2 = raizCores.Nodes.Add("Branco");
            cor2.Name = "Branco";

            TreeNode cor3 = raizCores.Nodes.Add("Azul");
            cor3.Name = "Azul";

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.Nodes["raizEstados"]);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Erro ao remover" + ex.ToString());
            }
        }

        private void btn_removerSelecionado_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
            catch
            {
                MessageBox.Show("Não tem nada selecionado");
            }
            
            
        }
    }
}
