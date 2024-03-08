using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos____Aula_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1, v2;

            Console.WriteLine(" Digite os numeros:");
            
            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());
          
            soma(v1, v2);
        }
        static void soma(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("A soma de {0} e {1} é: {2}", n1, n2, res);
        }
    }
}
