using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_de_Construtores___Aula_30
{
    public class Jogador
    {
        public int energia;
        public bool vivo;
        public string nome;

        public Jogador()
        { // Este é o construtor 
            energia = 100;
            vivo = true;
            nome = "Player";
        }
            public Jogador(string n)
        { // Este é o construtor 
            energia = 100;
            vivo = true;
            nome = n;
        }
        public Jogador(string n, int e)
        { // Este é o construtor 
            energia = e;
            vivo = true;
            nome = n;
        }
        public Jogador(string n, int e, bool v)
        { // Este é o construtor 
            energia = e;
            vivo = v;
            nome = n;
        }
        public void informacao()
        {
            Console.WriteLine("Nome do jogador: {0} ", nome);
            Console.WriteLine("energia do jogador: {0} ", energia);
            Console.WriteLine("Estado do jogador: {0}\n ", vivo);
        }
    }
   

    internal class Program
    {
        static void Main(string[] args)
        {

            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador("Cristiano Ronaldo");
            Jogador j3 = new Jogador("neymar",100);
            Jogador j4 = new Jogador("Firmino", 0, false);

            j1.informacao();
            j2.informacao();
            j3.informacao();
            j4.informacao();
        }
    }
}
