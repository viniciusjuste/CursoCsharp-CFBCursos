using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes_e_Vetores_Vidimensionais___Aula_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] n = new int[2, 2];

            n[0,0] = 1;
            n[0,1] = 2;
            n[1,0] = 3;
            n[1,1] = 4;

            Console.WriteLine(n[0,1]);
        }
    }
}
