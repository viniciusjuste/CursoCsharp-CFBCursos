using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceções___Try_Catch_Finally___P1____Aula_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, res;
            res = n1 = n2 = 0;

            n1 = 10;
            n2 = 0; // aqui eu gerei um erro, pois não existe divisao por 0
           
            try // esse bloco pega o erro e manda pro bloco catch
            {
            res = n1 / n2; // aqui dentro eu coloco qual a parte critica do erro, que no caso é a divisao
            Console.WriteLine("{0}/{1} = {2}", n1, n2, res);
            }
            catch(Exception ex)  // esse bloco trata e exceção, esse Exception ex atribui a exceção para a variavel ex,
                                 // caso eu queira printar ela
            {
                Console.WriteLine("Erro: {0}", ex.Message);            
            } // isso tudo serve para que mesmo com o erro o codigo nao trave na hora da compilação

           
        }
    }
}
