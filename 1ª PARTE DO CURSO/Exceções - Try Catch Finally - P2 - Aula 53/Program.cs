﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Exceções___Try_Catch_Finally___P2___Aula_53
{
    internal class Program
    {
        class Area
        {
            public static float Quad(float basequad, float altura)
            {
               if(basequad == 0 || altura == 0)
                {
                    throw new Exception("Base ou altura não podem ser igual a zero"); // aqui eu crio uma exceção
                }
                else
                {
                    return basequad * altura;
                }
            }
        }
        static void Main(string[] args)
        {
            float area = 0; 

            try // esse bloco pega o erro e manda pro bloco catch
            {
                area = Area.Quad(10f, 5f);
                Console.WriteLine("Area do quadrado: {0} ", area);

               // throw new Exception("CFB Cursos"); // O throw gera uma exceção 
            }
            catch (Exception ex)  // esse bloco trata e exceção, esse Exception ex atribui a exceção para a variavel ex,
                                  // caso eu queira printar ela
            {
                Console.WriteLine("Erro: {0}", ex.Message);
            } // isso tudo serve para que mesmo com o erro o codigo nao trave na hora da compilação
            finally
            {
                Console.WriteLine("Fim do processo");
            }

            
            

        }
    }
}
