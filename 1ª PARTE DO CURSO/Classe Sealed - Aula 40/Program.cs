using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Sealed___Aula_40
{
    internal class Program
    {
        sealed class Veiculo // uma classe sealed não pode ser herdada,
                             // e nem ser declarada como abstrata
        {

        }
        class Carro : Veiculo // Este erro é por que a classe veiculo é selada,
                              // ou seja, ninguem pode herdar ela
        {

        }
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
        }
    }
}
