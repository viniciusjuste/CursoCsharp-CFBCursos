using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Coleção_Queue__Fila____Aula_59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue <String> veiculos = new Queue <String>();

            veiculos.Enqueue("Carro"); // Adiciona no final da fila
            veiculos.Enqueue("Moto");
            veiculos.Enqueue("Navio");
            veiculos.Enqueue("Avião");

            // veiculos.Clear(); // limpa a fila 

           

            String v = "Avião";

            if(veiculos.Contains(v))
            {
                Console.WriteLine(v + " Esta na fila");
            }
            else
            {
                Console.WriteLine(v + " Não esta na fila");
            }

            //  Console.WriteLine("Primeiro veiculo: " + veiculos.Dequeue()); // o dequeue retorna o primeiro elemento da fila e depois o remove

            Console.WriteLine("Primeiro veiculo: " + veiculos.Peek()); // o peek retorna o primeiro elemento mas não o remove

            Console.WriteLine("Tamanho da fila: " + veiculos.Count);

           while(veiculos.Count > 0)
            {
                Console.WriteLine("Veiculo: " + veiculos.Dequeue());

            }
            Console.WriteLine("Tamanho da fila: " + veiculos.Count);
        }
    }
}
