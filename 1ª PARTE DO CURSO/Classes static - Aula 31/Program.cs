using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_static___Aula_31
{
    static public class Jogador // Quando uma classe é static não existe construtor
    {
        static public int energia;
        static public bool vivo;
        static public string nome;

        static public void iniciar(string n)
        { 
            energia = 100;
            vivo = false;
            nome = n;
        }
       
        static public void informacao()
        {
            Console.WriteLine("Nome do jogador: {0} ", nome);
            Console.WriteLine("energia do jogador: {0} ", energia);
            Console.WriteLine("Estado do jogador: {0}\n ", vivo);
        }
    
    }

    class Inimigo
    {
        static public bool alerta; // o alerta foi definido como static para que todos os inimigos fiquem alerta ao mesmo tempo
        public string nome; 

        public Inimigo(string n) // Construtor da classe inimigo
        {
            alerta = true;
            nome = n;
        }
        public void informacao() // método que vai exibir as informações do inimigo
        {
            Console.WriteLine("Nome do inimigo: {0}", nome);
            Console.WriteLine("Estado de alerta do inimigo: {0}\n", alerta);

        }
    }
  
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador.iniciar("Bruno");
            Jogador.informacao();

            Inimigo i1 = new Inimigo("Warwick");
            Inimigo i2 = new Inimigo("Rick");
            Inimigo i3 = new Inimigo("Morty");

            Inimigo.alerta = true; // aqui mudei o alerta dos inimigos de false para true, pois é static, se muda aqui serve para todos

           i1.informacao();
           i2.informacao();
           i3.informacao();
        }
    }
}
