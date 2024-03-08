using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecão_List_P2___Aula_58
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
            carros.Add("HRV");

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

            carros.CopyTo(carros2, 4); // Copia os elementos para carros2 a partir da  posição 4

            carros.Insert(1, "Cruze"); // insere atraves de indice

            int posicao = carros.LastIndexOf("HRV"); // vai achar o ultimo HRV da lista, pois tem mais de um
           
           // carros.Remove("Argo");  // remove o elemento da lista que eu digitar, neste caso a argo
           
           // carros.RemoveAt(0); // remove o carro da posição desejada 

           // carros.Reverse();

            carros.Sort(); // Ordena a lista em ordem alfabetica

            int tamanho = carros.Count(); // Aqui eu verifico o tamanho da minha lista
            Console.WriteLine("O tamanho da lista: {0}", tamanho);


            carros.Capacity = 15; // Aqui eu defino a capacidade da lista com 15 elementos


            int capacidade = carros.Capacity;
            Console.WriteLine("Capacidade da lista: {0}", capacidade); // Aqui eu verifico a capacidade da minha lista

            foreach (String c in carros)
            {
                Console.WriteLine("Carro: {0}", c);
            }

            

            String s = "HRV";
            int pos = 0;
            pos = carros.IndexOf(s); // procura o carro através do indice e me fala em qual posição está,
                                     // neste caso procura HRV
            Console.WriteLine("Carro {0} está na posição {1}", s, pos); 
            Console.WriteLine("O ultimo HRV está na posição {0}", posicao);


        }
    }
}
