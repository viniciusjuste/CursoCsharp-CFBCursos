using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_de_estruturas___Aula_45
{
    internal class Program
    {
        struct Carro
        {
            public String modelo, cor;

           
            public void info()
            {
                Console.WriteLine("\nModelo..: {0}", this.modelo);
                Console.WriteLine("Cor.....: {0}\n", this.cor);
            }
        }
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            Carro[] carros = new Carro[5];

            carros[0].modelo = "Golf";
            carros[0].cor = "Azul";

            carros[1].modelo = "Gol";
            carros[1].cor = "Verde";

            carros[2].modelo = "Civic";
            carros[2].cor = "Amarelo";

            carros[3].modelo = "Porsch";
            carros[3].cor = "Cinza";

            carros[4].modelo = "Cruze";
            carros[4].cor = "Prata";

            for(int i = 0; i < carros.Length; i++)
            {
                carros[i].info();
            }
            
        }
    }
}
