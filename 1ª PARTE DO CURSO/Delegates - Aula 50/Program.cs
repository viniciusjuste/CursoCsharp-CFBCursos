using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates___Aula_50
{
    internal class Program
    {
        delegate int Op(int n1, int n2); // aqui eu crio um delegate
        class Mat
        {
            public static int soma(int n1, int n2)
            {
                return n1 + n2;
            }
          
            public static int mult(int n1, int n2)
            {
                return n1 * n2;
            }
        } 
        static void Main(string[] args)
        {
            int res;

            Op d1 = new Op(Mat.soma); // aqui eu atribuo o delegate ao metodo soma

            res = d1(10, 10); 

            Console.WriteLine(res);

            d1 = new Op(Mat.mult); // aqui eu atribuo o delegate ao metodo de multiplicacao
            res =d1(10, 10);
            Console.WriteLine(res);
        }
    }
}
