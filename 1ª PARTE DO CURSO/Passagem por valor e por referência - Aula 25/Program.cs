﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagem_por_valor_e_por_referência___Aula_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            dobrar(ref num);

            Console.WriteLine(num);
        }
        static void dobrar(ref int valor)
        {
            valor *= 2;
        }
    }
}
