using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores_e_Destrutores___Aula_29
{
    public class Jogador
    {
        public int energia;
        public bool vivo;
        public string nome;
        
        public Jogador(string n) { // Este é o construtor 
            energia = 100;
            vivo = true;
            nome = n;
        }
        ~Jogador() { // Este é o destrutor
            Console.WriteLine("Jogador {0} foi destruido", nome);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;

            Console.WriteLine("Digite o nome do jogador 1: ");
            nome1 = Console.ReadLine();

            Console.WriteLine("Digite o nome do jogador 2: ");
            nome2 = Console.ReadLine();

            Jogador j1 = new Jogador(nome1);
            Jogador j2 = new Jogador(nome2);
            

            j1.energia = 50; // por conta de ser uma propriedade publica pode ser alterada
            Console.WriteLine("Nome do jogador 1: {0}", j1.nome);
            Console.WriteLine("Nome do jogador 2: {0}", j2.nome);

        }
    }
}
