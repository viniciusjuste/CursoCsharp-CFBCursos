using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct____Aula_44
{
    internal class Program
    {
        struct Carro
        {
            public String marca, modelo, cor;

            public Carro(String marca, String modelo, String cor)
            {
                this.marca = marca;
                this.modelo = modelo;
                this.cor = cor;
            }
            public void info()
            {
                Console.WriteLine("\nMarca...: {0}", this.marca);
                Console.WriteLine("Modelo..: {0}", this.modelo);
                Console.WriteLine("Cor.....: {0}", this.cor);
            }
        }
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Vw", "golf", "Azul");
            Carro c2 = new Carro("Vw", "gol", "Preto");

            c1.info();
            c2.info();







        }
    }
}
