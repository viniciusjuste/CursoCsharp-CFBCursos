 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membros_Protected____Aula_36
{
    class Veiculo // Classe base
    {
        public int velAtual;
        private int velMax;
        protected bool ligado;

        public Veiculo(int velMax) 
        {
            velAtual = 0;
            this.velMax = velMax;
            ligado = false;
        }
        public bool getLigado()
        {
            return ligado;
        }
        public int getVelMax()
        {
            return velMax;
        }
    }

    class Carro : Veiculo
    {
        public String nome;

        public Carro(String nome, int vm) : base(vm) 
        {
            this.nome = nome;
            ligado = true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Nivus", 100);
            Console.WriteLine("Nome do carro:.. {0}", c1.nome);
            Console.WriteLine("Vel.Maxima:..... {0}", c1.getVelMax());
            Console.WriteLine("Está ligado?:... {0}", c1.getLigado());
        }
    }
}
