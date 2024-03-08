using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_e_Objetos___Aula_28
{
   
    public class Jogador
    {
        public int energia = 100;
        public bool vivo = true;
        public string nome = "Neymar";
    }
    public class Time
    {
        public string nome_do_time = "Barcelona";

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador();
            Jogador j3 = new Jogador();

            j1.energia = 50; // por conta de ser uma propriedade publica pode ser alterada
            Console.WriteLine("A energia do jogador 1: {0}", j1.energia);

            Time t1 = new Time();
            Console.WriteLine("O jogador {0}, joga no time {1}",j1.nome, t1.nome_do_time);
        }
    }
}
