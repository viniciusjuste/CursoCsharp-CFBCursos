using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadeia_de_herança_e_Construtor_de_classe_base___Aula_35
{
    public class Veiculo // Classe base
    {
        public int velmax;
        private bool ligado;
        private int rodas;

        public Veiculo(int rodas)
        {
            this.rodas = rodas;
        }
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
            return (ligado ? "Sim" : "Não"); // Operador ternário, primeiro se for TRUE e depois se for FALSE
        }
        public int getRodas()
        {
            return rodas;
        }
        public void setRodas(int rodas) // Aqui o setter foi criado para me permitir colocar a quantidade
                                        // de rodas necessarias, ja que rodas é privado,
                                        // e dentro do setter foi feita uma filtragem
        {
            if (rodas < 0)
            {
                this.rodas = 0;
            } else if (rodas > 40) 
            {
                this.rodas = 0;
            } else 
            { 
                this.rodas = rodas;
            }
        }
    }
    class Carro : Veiculo // Os dois pontos segnifica que a classe derivada herda a classe base,
                          // ou seja, indica que a classe Carro herda a classe Veiculo
    {
        public String nome;
        public String cor;
        public Carro(String nome, String cor) : base (4) // A palavra BASE faz referência ao construtor
                                                         // da classe base, esse quatro entre
                                                         // parenteses atribui valor a variavel rodas
        {
            desligar();
            velmax = 120;
            this.nome = nome;
            this.cor = cor;

        }
    }

    class CarroCombate : Carro
    {
        public int municao;

        public CarroCombate() : base("Carro de combate", "Verde")
        {
           municao = 100;
           setRodas(7); // Aqui eu uso o setter para mexer na quantidade de rodas
           desligar();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Carro c1 = new Carro("Nivus", "Preto");

            Console.WriteLine("O nome do carro: {0} e a cor é: {1}", c1.nome, c1.cor);
            Console.WriteLine("Está ligado? {0}", c1.getLigado());
            Console.WriteLine("Rodas: {0}\n", c1.getRodas());

            CarroCombate c2 = new CarroCombate();
           
            Console.WriteLine("Nome do carro: {0}, Cor do carro: {1}", c2.nome, c2.cor);
            Console.WriteLine("Está ligado? {0}", c2.getLigado());
            Console.WriteLine("Rodas: {0}", c2.getRodas());
            Console.WriteLine("quantidade de munição: {0}", c2.municao);
        }
    }

}
