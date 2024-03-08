using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp
{
    internal class Program
    {
      
        static void Main()
        {
            int v1,v2,soma;

            Console.WriteLine("Digite o primeiro valor: ");
                v1=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
                v2=int.Parse(Console.ReadLine());

            soma = v1 + v2;

            Console.WriteLine("A soma de {0} mais {1} é igual a: {2}", v1, v2, soma);

            }

    }
}

