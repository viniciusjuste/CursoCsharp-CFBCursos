using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_e_Variáveis_estáticos__static_____Aula_49
{
    internal class Program
    {
        class Mat
        {
            public static double pi = 3.14; // Aqui crio uma variavel static

            public static int dobro(int valor)  // Aqui crio uma metodo static que recebe um valor e o multiplica por 2
            {
                return valor * 2;
            }
        }
        static void Main(string[] args)
        {
            double vpi = Mat.pi; // para chamar a variavel static é so colocar o nome da classe e um ponto e selecionar a variavel
            int num = 10;
            num = Mat.dobro(num); // Aqui chamo o metodo  dobrar e faço ele multiplicar 10 vezes 2
            
            Console.WriteLine(num);
            Console.WriteLine(Mat.pi);
        }
    }
}
