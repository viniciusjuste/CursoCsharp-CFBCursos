using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_que_retornam_objetos____Aula_46
{
    internal class Program
    {
        class Galinha
        {
            private String nome;
            private int numOvo;
            static int totalOvos;
            
            public Galinha(String nome) { 
             this.nome = nome;
             numOvo = 0;
            }
            public Ovo botar() // ao chamar o nome da classe ovo , eu retorno a classe ovo
            {
                numOvo++;
                totalOvos++;
                return new Ovo(numOvo, nome, totalOvos);
            }
        }
        class Ovo
        {
            private int numOvo;
            private String nome;
            static int totalOvos;
            public Ovo(int numOvo, string nome,  int totalOvos)
            {
                this.numOvo = 0;
                this.nome = nome;
                
                Console.WriteLine("Ovo criado numero {0}, nome da galinha: {1}, total de ovos criados: {2}", numOvo, nome, totalOvos);
                
            }

         }
        static void Main(string[] args)
        {
           

            Galinha g1 = new Galinha("Popó");
            Galinha g2 = new Galinha("Filomena");
            Galinha g3 = new Galinha("Filó");

           g1.botar();
           g2.botar();
           g2.botar();
           g1.botar();
           g1.botar();

        }
    }
}
