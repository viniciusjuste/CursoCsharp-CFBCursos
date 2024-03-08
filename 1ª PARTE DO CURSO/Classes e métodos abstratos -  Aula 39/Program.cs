using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_e_métodos_abstratos____Aula_39
{
    abstract class Veiculo // Classe base abstrata
    {
        protected int velMax;
        protected int velAtual;
        protected bool ligado;

        public Veiculo() {
            ligado = false; 
            velAtual = 0;
        }
        public void setLigado(bool ligado)
        {
            this.ligado = ligado;
        }
        public int getVelAtual()
        {
            return velAtual;
        }
        abstract public void aceleracao(int mult);
    }
    class Carro : Veiculo
    {
        public Carro() 
        { 
         velMax = 120;
        }
        override public void aceleracao(int mult)
        {
            velAtual += 10 * mult;
        }
    }
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            c1.aceleracao(1);

            Console.WriteLine(c1.getVelAtual());

        }
    }
}
