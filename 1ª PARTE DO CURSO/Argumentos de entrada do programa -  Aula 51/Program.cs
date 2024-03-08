using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argumentos_de_entrada_do_programa____Aula_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
           if(args.Length > 0) 
            {
                Console.WriteLine("Qtde de argumentos {0}", args.Length);

                for(int i = 0; i < args.Length; i++)
                {
                    res += Int32.Parse(args[i]); // isso é um cast
                    Console.WriteLine("Argumento {0}:{1}", i, args[i]);
                }
                Console.WriteLine("Soma: {0}" , res);
            } else
            {
                Console.WriteLine("Não foram passados argumentos");
            }
        }
    }
}
