using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeradores__enum_____Aula_10
{
    internal class Program
    {
        enum DiasSemana {Domingo, Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
        static void Main()
        {
            DiasSemana ds = (DiasSemana)3;

            Console.WriteLine(ds);

        }
    }
}
