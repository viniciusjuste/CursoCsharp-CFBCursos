using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argumento_out___Aula_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divid, divis, quoc, rest;
            divid = 0;
            divis = 0;
             
            divid = int.Parse(Console.ReadLine());
            divis = int.Parse(Console.ReadLine());
            
            quoc = divisao(divid, divis, out rest);

           
            
            Console.WriteLine("{0}/{1}: quociente = {2} e resto {3}",divid, divis, quoc, rest);
        }
       
        static int divisao(int dividendo, int divisor, out int resto)
        {
            int quociente = dividendo/divisor;
            resto = dividendo % divisor;
            return quociente;
        }
    }
}

