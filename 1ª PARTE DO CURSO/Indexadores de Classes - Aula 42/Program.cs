using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores_de_Classes___Aula_42
{
    internal class Program
    {
        class Carro
        {
            private int[] velMax = new int[5] {80, 120, 160, 240, 300}; // criei um vetor de 5 posicoes
            public Carro()
            {
            }
            public int this[int i] //se cria como se fosse uma variavel para fazer o set e o get, e adicionei um indice
            {
                get
                {
                    return velMax[i];
                }
                set
                {
                    if (value < 0) // o value é o valor que a pessoa digitar
                    {
                        velMax[i] = 0;
                    }
                    if (value > 300)
                    {
                        velMax[i] = 300;
                    }
                    else
                    {
                        velMax[i] = value;
                    }
                }



            }
        }
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            carro[4] = 200; // mudei o indice 4 para o valor 200
            Console.WriteLine("Velocidade maxima: {0}", carro[4]);
        }
    }
}

