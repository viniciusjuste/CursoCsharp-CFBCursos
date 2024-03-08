using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operações_de_Bitwise___Aula_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

           
            // Bitwise, para esquerda dobra o valor da variável, para direita cai pela metade
            num = num>>1;
            
            Console.WriteLine(num);
        }
    }
}
