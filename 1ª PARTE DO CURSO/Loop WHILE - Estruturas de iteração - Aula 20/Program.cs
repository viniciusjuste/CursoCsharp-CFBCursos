using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_WHILE___Estruturas_de_iteração___Aula_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            int i = 0;

            while (i < num.Length)
            {
                
                num[i] = 0;

                Console.WriteLine(num[i]);
                i++;
            }
            
            Console.WriteLine("Fim do loop");
        }
    }
}
