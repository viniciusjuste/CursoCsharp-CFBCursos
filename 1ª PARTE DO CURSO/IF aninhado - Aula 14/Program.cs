using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_aninhado___Aula_14
{
    internal class Program
    {
        static void Main()
        {
            int n1, n2, n3, n4;
            int nota;
            string  resultado;
           

            Console.WriteLine(" Digite a primeira nota");
            n1=int.Parse (Console.ReadLine());

            Console.WriteLine(" Digite a segunda nota");
            n2=int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite a terceira nota");
            n3=int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite a quarta nota");
            n4=int.Parse(Console.ReadLine());

             nota = n1 + n2 + n3 + n4;

            if (nota > 60)
            { if(nota >= 90)
                {
                    resultado = "Aprovado com louvor";
                }  else
                {
                    resultado = " Aprovado";
                }

            }
            else
            {
                if(nota >= 40)
                {
                    resultado = "Recuperação";
                }
                else
                {
                    resultado="Reprovado";
                }
            }
          
            Console.WriteLine("Nota : {0} Resultado: {1}", nota, resultado);
        }   
    }
}
