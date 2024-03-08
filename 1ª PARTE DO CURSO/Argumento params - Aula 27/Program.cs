using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argumento_params___Aula_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            soma(5,5,5);
        }
        static void soma(params int[] n)
        {
            int res = 0;
            if(n.Length < 1) 
            {
                Console.WriteLine("Não existem valores a serem somados ");
            }else if(n.Length < 2)
            {
                Console.WriteLine("Não existem valores suficientes para a soma: {0}", n[0]);
            }
            else
            {
                for (int i = 0; i < n.Length; i++)
                {
                    res += n[i];
                }
            }
            Console.WriteLine("A soma dos valores é {0}",res);
        }
    }
}
