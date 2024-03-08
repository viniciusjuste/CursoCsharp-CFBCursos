using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleção_Dictionary___Aula_55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <int, String> Veiculos = new Dictionary <int, String> ();
            Veiculos.Add(10, "Carro");
            Veiculos.Add(5, "Avião");
            Veiculos.Add(0, "Navio");
            Veiculos.Add(20, "Moto");
            Veiculos.Add(15, "Patinete");

            // Veiculos.Clear (); Aqui  eu limpo a coleção

            // Veiculos.Remove(10); Aqui eu estou removendo a chave 10 da coleção

            Console.WriteLine("Tamanho do dictionary: {0}", Veiculos.Count ());

            int chave = 21; 
                if(Veiculos.ContainsKey (chave)) // Aqui eu verifico se a chave 21 está na coleção
            {
                Console.WriteLine("A chave {0} está na colecão", chave);
            }
            else
            {
                Console.WriteLine("A chave {0} não está na colecão", chave);
            }

            Veiculos[15] = "Bicicleta";

            String valor = "Bicicleta";
            if (Veiculos.ContainsValue(valor)) // Aqui eu verifco se o valor navio está na coleção
            {
                Console.WriteLine("O valor {0} está na colecão", valor);
            }
            else
            {
                Console.WriteLine("O valor {0} não está na colecão", valor);
            }

            foreach(KeyValuePair<int, String> v in Veiculos)
            {
                Console.WriteLine(v);
            }

        }
    }
}
