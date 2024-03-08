using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_de_métodos____Aula_47
{
    internal class Program
    {
         class Calc
        {
            public int soma(params int[]n) // O params serve para eu poder passar o tanto de parametros
                                           // que eu quiser na hora da soma
            {
                int somador = 0;
                for(int i = 0; i < n.Length; i++)
                {
                    somador += n[i];
                }
                return somador;
            }
            public double soma(params double[]n) // aqui é feita a sobrecarga, pois aceita double e o metodo
                                                 // de cima tem o mesmo nome e aceita int
            {
                double somador = 0;
                for(int i = 0;i < n.Length;i++)
                {
                    somador += n[i];
                }
                return somador;
            }
        }
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            
            var res = calc.soma(10.5, 10.5, 20, 30.5); // var serve para quando eu nao sei o tipo da variavel,
                                         // neste caso ela vai receber int e double
            Console.WriteLine(res);
        }
    }
}
