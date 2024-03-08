using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_e_Ordem_de_execução_dos_construtores___Aula_37
{
    class Base
    {
        public Base() 
        {
            Console.WriteLine("Construtor da classe base");
        }
    }
    class Derivada1 : Base
    {
        public Derivada1()
        {
            Console.WriteLine("Construtor da classe derivada1");
        }
    }
    class Derivada2 : Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Construtor da classe derivada2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Derivada2 derivada2 = new Derivada2();
            // A ordem de execução dos construtores sempre é da base para as derivadas
        }
    }
}
