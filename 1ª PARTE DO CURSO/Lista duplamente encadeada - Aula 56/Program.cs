using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleção_LinkedList___Lista_duplamente_encadeada___Aula_56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> transp = new LinkedList<String>();
            transp.AddFirst("Carro");
            transp.AddFirst("Avião");
            transp.AddFirst("Navio"); 
            transp.AddFirst("Motocicleta"); // Adiciona no inicio

            transp.AddLast("Bicicleta");
          
            LinkedListNode<String> node;
            node = transp.FindLast("Navio"); // fim
            transp.AddAfter(node,"Trem"); // Adiciona Após

            node = transp.FindLast("Carro"); // Adiciona antes
            transp.AddBefore(node, "Jet-ski"); 

           // transp.Clear();  Limpa todos os elementos da lista 

            transp.Find("Carro"); // procura um elemento na lista

            transp.Remove("Carro"); // Remove um valor da lista

            transp.RemoveLast(); // remove o ultimo elemento

            transp.RemoveFirst(); // Remove o primeiro elemento

            foreach (String s in transp)
            {
                Console.WriteLine("Transporte: {0}", s);
            }


        }
    }
}
