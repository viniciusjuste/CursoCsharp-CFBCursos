using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_FOREACH_Estruturas_de_iteração___Aula_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3] { 11, 22, 33, };

            for(int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
