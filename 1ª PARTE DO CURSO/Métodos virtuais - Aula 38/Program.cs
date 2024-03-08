using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_virtuais___Aula_38
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("Construtor da classe base");
        }
        virtual public void info() // A palavra VIRTUAl serve para dizer que é um método virtual,
                                   // pode ser usado com o mesmo nome em outra classe
        {
            Console.WriteLine("Base");
        }
    }
    class Derivada1 : Base
    {
        public Derivada1()
        {
            Console.WriteLine("Construtor da classe derivada1");
        }
        override public void info() // OVERRIDE sere para poder usar o método virtual em outra classe,
                                    // ou seja, basicamente sobrescrever ele em outra classe
        {
            Console.WriteLine("derivada1");
        }
    }
    class Derivada2 : Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Construtor da classe derivada2");
        }
        override public void info()
        {
            Console.WriteLine("derivada2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Base Ref; // REF serve para passar a referência da classe que eu quero pegar o método virtual
            Derivada1 derivada1 = new Derivada1();
            Derivada2 derivada2 = new Derivada2();
            
            derivada1.info();
            derivada2.info();
            Ref = derivada1; // Aqui eu falo que quero pegar o método info da classe derivada1
            Ref.info();
        }
    }
}
