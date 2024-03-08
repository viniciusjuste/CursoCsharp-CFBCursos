using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componente_Backgroundworker____Aula_97
{
    public partial class F_Backgroundworker : Form
    {
        int count = 0;
        int  max = 1000;
        public F_Backgroundworker()
        {
            InitializeComponent();
        }

        private void F_Backgroundworker_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < max; i++)
            {
                count ++;
                Thread.Sleep(10);
                backgroundWorker1.ReportProgress(0);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Trabalho terminado");
            label1.Text = "Terminado";
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label1.Text = "w1 trabalhando";
            label2.Text = count.ToString();

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();

            }
        }
    }
}
