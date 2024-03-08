using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This____Aula_32
{
    class Calculos
    {
        public int v1;
        public int v2;
        
        public Calculos(int v1, int v2)
        {
            this.v1 = v1; // O this faz referência ao objeto pai, que no caso é o Calculos,
                          // caso contrario ele confundiria com o parâmetro do construtor
            this.v2 = v2;
        }
        public int Somar()
        { 
        return v1 + v2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculos c1 = new Calculos(10, 5);
            Console.WriteLine("O resultado da soma é: {0}", c1.Somar());
        }
    }
}
