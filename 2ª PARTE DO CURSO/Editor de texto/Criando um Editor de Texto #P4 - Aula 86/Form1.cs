using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Criando_um_Editor_de_Texto__P1___Aula_83
{
    public partial class Form1 : Form
    {
        StreamReader leitura = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void salvar()
        {
            try
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter cfb_arquivo = new StreamWriter(arquivo);
                    cfb_arquivo.Flush();
                    cfb_arquivo.BaseStream.Seek(0, SeekOrigin.Begin);
                    cfb_arquivo.Write(richTextBox1.Text);
                    cfb_arquivo.Flush();
                    cfb_arquivo.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação do arquivo" + ex.Message,"Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void abrir()
        {
           openFileDialog1.InitialDirectory = @"C:\Users\vinic_jmhc68q\OneDrive\Documentos\CSharp\Editor de texto\"; // O "@" é por conta dos caracteres especiais
            openFileDialog1.Filter = "(*.txt) | *.txt";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader cfb_reader = new StreamReader(arquivo);
                    cfb_reader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    String linha = cfb_reader.ReadLine();

                    while(linha != null)
                    {
                        richTextBox1.Text += linha + "\n";
                        linha = cfb_reader.ReadLine();
                        
                    }
                    cfb_reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na abertura do arquivo" + ex.Message, "Erro ao abrir", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void copiar()
        {
            if(richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void colar()
        {
            richTextBox1.Paste();
        }

        private void btn_colar_Click(object sender, EventArgs e)
        {
            colar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colar();
        }

        private void negrito()
        {
            String nomeDaFonte = null;
            float tamanhoDaFonte = 0;

            nomeDaFonte = richTextBox1.Font.Name;
            tamanhoDaFonte = richTextBox1.Font.Size;

            bool negr = false;

            negr = richTextBox1.Font.Bold;

            if(negr == false)
            {
                richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);
            }
        }

        private void italico()
        {
            String nomeDafonte = null;
            float tamanhoDaFonte = 0;
            bool itali = false;

            nomeDafonte = richTextBox1.Font.Name;
            tamanhoDaFonte = richTextBox1.Font.Size;
            itali = richTextBox1.Font.Italic;

            if(itali == false)
            {
                richTextBox1.SelectionFont = new Font(nomeDafonte, tamanhoDaFonte, FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nomeDafonte, tamanhoDaFonte, FontStyle.Regular);
            }
        }

        private void sublinhado()
        {
            String nomeDafonte = null;
            float tamanhoDaFonte = 0;
            bool subl = false;

            nomeDafonte = richTextBox1.Font.Name;
            tamanhoDaFonte = richTextBox1.Font.Size;
            subl = richTextBox1.Font.Underline;

            if(subl == false)
            {
                richTextBox1.SelectionFont = new Font(nomeDafonte, tamanhoDaFonte, FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nomeDafonte, tamanhoDaFonte, FontStyle.Regular);
            }
        }

        private void btn_negrito_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void btn_italico_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            sublinhado();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sublinhado();
        }
    }
}
