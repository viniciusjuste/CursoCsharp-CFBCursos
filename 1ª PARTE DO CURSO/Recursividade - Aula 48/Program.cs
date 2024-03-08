using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade___Aula_48
{
    internal class Program
    {
        class Calc
        {
            public int soma(params int[] n) // O params serve para eu poder passar o tanto de parametros
                                            // que eu quiser na hora da soma
            {
                int somador = 0;
                for (int i = 0; i < n.Length; i++)
                {
                    somador += n[i];
                }
                return somador;
            }
            public double soma(params double[] n) // aqui é feita a sobrecarga, pois aceita double e o metodo
                                                  // de cima tem o mesmo nome e aceita int
            {
                double somador = 0;
                for (int i = 0; i < n.Length; i++)
                {
                    somador += n[i];
                }
                return somador;
            }

            public int fat(int n)
            {
                int res;
                if(n <= 1)
                {
                    res = 1;
                }
                else
                {
                    res = n * fat(n - 1); // isso é recursividade, quando uma função chama ela mesma
                }
                return res;
            }
        }
        static void Main(string[] args)
        {
            Calc calc = new Calc();

            var res = calc.fat(10); // var serve para quando eu nao sei o tipo da variavel,
                                                       // neste caso ela vai receber int e double
            Console.WriteLine(res);
        }

    }
}
