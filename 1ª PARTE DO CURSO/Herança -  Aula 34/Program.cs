using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Herança____Aula_34
{
    public class Veiculo // Classe base
    {
        public int velmax;
        private bool ligado;
        public int rodas;
        public void ligar()
        {
            ligado = true;
        }
        public void desligar()
        {
            ligado = false;
        }
        public String getLigado()
        {
            if (ligado) 
            {
                return "Sim";
            }else
            {
                return "Não";
            }
        }
    }
    class Carro : Veiculo // Os dois pontos segnifica que a classe derivada herda a classe base,
                          // ou seja, indica que a classe Carro herda a classe Veiculo
    {
        public String nome;
        public String cor;
        public Carro(String nome, String cor) 
        {
            desligar();
            rodas = 4;
            velmax = 120;
            this.nome = nome;
            this.cor = cor;

        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
     
            Carro c1 = new Carro("Nivus", "Preto");
           
            Console.WriteLine("O nome do carro: {0} e a cor é: {1}",c1.nome, c1.cor);
            Console.WriteLine("Está ligado? {0}", c1.getLigado());
        }
    }
}
