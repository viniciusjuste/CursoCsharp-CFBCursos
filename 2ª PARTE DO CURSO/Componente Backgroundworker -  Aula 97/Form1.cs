using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componente_Backgroundworker____Aula_97
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundworkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Backgroundworker f_Backgroundworker = new F_Backgroundworker();
            f_Backgroundworker.ShowDialog();
        }
    }
}
