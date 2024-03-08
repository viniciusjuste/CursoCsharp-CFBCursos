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
    }
}
