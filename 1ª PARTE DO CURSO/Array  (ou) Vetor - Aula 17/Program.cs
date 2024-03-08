using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array___ou__Vetor___Aula_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            //int[] num = new int[3] { 55, 77, 99 };
            int[] num = { 55, 77, 99 };

            n[0] = 111;
            n[1] = 222;
            n[2] = 333;
            n[3] = 444;
            n[4] = 555;

            Console.WriteLine(num[2]);
          
        }
    }
}
