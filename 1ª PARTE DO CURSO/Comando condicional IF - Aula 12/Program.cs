using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando_condicional_IF___Aula_12
{
    internal class Program
    {
        static void Main()
        {
            int num;

            Console.WriteLine("Digite um numero: ");
            
            num=int.Parse(Console.ReadLine());

            if(num == 0)
            {
                Console.WriteLine("Numero igual a 0");
            }
            else
            {
                Console.WriteLine("Numero diferente de 0");
            }

        }
    }
}
