using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acessors_GET_e_SET____Aula_41
{
    internal class Program
    {
        class Carro
        {
            private int velMax;
            public Carro()
            {
                this.velMax = 120;
            }
            public int Vm //se cria como se fosse uma variavel para fazer o set e o get
            {
                get
                {
                    return velMax; 
                }
                set
                {
                    if(value < 0) // o value é o valor que a pessoa digitar
                    {
                        velMax = 0;
                    } 
                    if(value > 300)
                    {
                        velMax = 300;
                    }
                    else
                    {
                        velMax = value;
                    }
              }

            
           
            }
        }
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            carro.Vm = 310;
            Console.WriteLine("Velocidade maxima: {0}", carro.Vm);
        }
    }
}
