using System;
using System.Collections.Generic; // esta é a biblioteca para trabalhar com coleções
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleção_List_P1___Aula_57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> carros = new List<String>();

            //  List<String> carros2 = new List<String>();

            String[] carros2 = new string[10]; // aqui crio um array pois CopyTo precisa de array para funcionar


            carros.Add("Golf");
            carros.Add("HRV");
            carros.Add("Focus");
            carros.Add("Argo");
            
            // carros2.AddRange(carros); // Copiei os elementos da lista carros na lista carros2

            // carros.Clear();  // limpa os elementos da lista

            if (carros.Contains("Gol")) // o Constains verifica se algum elemento está na lista 
            {
                Console.WriteLine("Está na lista");
            }
            else
            {
                Console.WriteLine("Não encontrado");
            }

            carros.CopyTo(carros2,4); // Copia os elementos para carros2 a partir da  posição 4


            foreach (String c in carros)
            { 
                Console.WriteLine("Carro: {0}",c);
            }

            String s = "HRV";
            int pos = 0;
            pos = carros.IndexOf(s); // procura o carro através do indice e me fala em qual posição está,
                                     // neste caso procura HRV
            Console.WriteLine("Carro {0} está na posição {1}",s, pos );
        }
    }
}
