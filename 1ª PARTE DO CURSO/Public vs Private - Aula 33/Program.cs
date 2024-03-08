using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_vs_Private___Aula_33
{
    class Jogador
{
        private int energia;
        private String nome; 

        public Jogador(String nome) 
        { 
                 this.nome = nome;
                 energia = 100;
        }
        public int getEnergia()
        {
            return energia;
        }
        public String getNome()
        {
            return nome;
        }
        public void setEnergia(int e)
        {
            if (e < 0)
            {
                if (energia + e < 0)
                {
                    energia = 0;
                }else
                {
                    energia += e; // aqui ficou += por que MAIS com MENOS é MENOS,
                                  // caso contrário somaria ao invés de subtrair
                }
            }
           
            if(e > 0)
            {
                 if(energia + e > 100)
                 {
                        energia = 100;
                 } else
                    {
                        energia += e;
                    }
            }
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador("Vinícius");
           
            j1.setEnergia(-150);
          Console.WriteLine("Nome: {0}, energia: {1}", j1.getNome(), j1.getEnergia());
        }
    }
}
