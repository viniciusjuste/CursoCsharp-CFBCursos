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
using System.Security.Policy;


namespace Criando_um_Editor_de_Texto__P1___Aula_83
{
    public partial class Form1 : Form
    {
        StringReader leitura = null;
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

            bool n, i, s = false;

            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);


            if (n == false)
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);

                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold | FontStyle.Underline);

                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold | FontStyle.Italic);

                }
                else if (i == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold);

                }
            }
            else
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Italic | FontStyle.Underline);

                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Underline);

                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Italic);

                }

            }

           
        }
        private void italico()
        {
            String nomeDaFonte = null;
            float tamanhoDaFonte = 0;

            nomeDaFonte = richTextBox1.Font.Name;
            tamanhoDaFonte = richTextBox1.Font.Size;

            bool n, i, s = false;

            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);


            if (i == false)
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);

                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Italic | FontStyle.Underline);

                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold | FontStyle.Italic);

                }
                else if (n == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Italic);

                }
            }
            else
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold | FontStyle.Underline);

                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Underline);

                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold);

                }

            }

            
        }

        private void sublinhado()
        {
            String nomeDaFonte = null;
            float tamanhoDaFonte = 0;

            nomeDaFonte = richTextBox1.Font.Name;
            tamanhoDaFonte = richTextBox1.Font.Size;

            bool n, i, s = false;

            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);


            if (s == false)
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic);

                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Underline | FontStyle.Italic);

                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Underline | FontStyle.Bold);

                }
                else if (n == false & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Underline);

                }
            }
            else
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold | FontStyle.Italic);

                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Italic);

                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold);

                }

            }

            
        }

        private void alinharEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void alinharDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void alinharCentro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btn_esquerda_Click(object sender, EventArgs e)
        {
            alinharEsquerda();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinharEsquerda();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinharDireita();
        }

        private void btn_direita_Click(object sender, EventArgs e)
        {
            alinharDireita();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinharCentro();
        }

        private void btn_centro_Click(object sender, EventArgs e)
        {
            alinharCentro();
        }

        private void imprimir()
        {
            printDialog1.Document = printDocument1;

            String texto = richTextBox1.Text;
            leitura = new StringReader(texto);

            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPagina = 0;
            float posY = 0;
            int cont = 0;
            float margemEsquerda = e.MarginBounds.Left -50;
            float margemSuperior = e.MarginBounds.Top -50;

            if(margemEsquerda < 5)
            {
                margemEsquerda = 20;
            }

            if (margemSuperior < 5)
            {
                margemSuperior = 20;
            }

            String linha = null;
            Font fonte = richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            linhasPagina = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);
            linha = leitura.ReadLine();

            while(cont < linhasPagina)
            {
                posY = (margemSuperior + (cont * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, fonte, pincel ,margemEsquerda, posY ,new StringFormat());
                cont+=1;
                linha = leitura.ReadLine();
            }

            if (linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
                pincel.Dispose();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void segoeUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fonte = new Font("Arial", 8);
            richTextBox1.Font = fonte;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fonte = new Font("Times New Roman", 8);
            richTextBox1.Font = fonte;
        }

        private void segoeUIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Font fonte = new Font("Segoe UI", 8);
            richTextBox1.Font = fonte;
        }

        private void verdanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fonte = new Font("Verdana", 8);
            richTextBox1.Font = fonte;
        }

        private void tahomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fonte = new Font("Tahoma", 8);
            richTextBox1.Font = fonte;
        }

        private void courierNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fonte = new Font("Courier New", 8);
            richTextBox1.Font = fonte;
        }

        private void comicSansMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fonte = new Font("Comic Sans MS", 8);
            richTextBox1.Font = fonte;
        }
    }
}
