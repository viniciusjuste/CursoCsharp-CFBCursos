using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_DO_WHILE__Estruturas_de_iteração___Aula_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";
            string senhauser;
            int tentativas = 0;

            do
            {
               
                Console.Clear();
                Console.WriteLine("Digite a senha"); 
                senhauser = Console.ReadLine();
                tentativas++;
            
            } while (senhauser != senha);

            Console.WriteLine("Senha correta !!");
            Console.WriteLine(" Numero de tentativas: {0}",tentativas);
        }
    }
}
