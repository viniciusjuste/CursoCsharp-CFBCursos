using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces____Aula_43
{
    internal class Program
    {
        public interface Veiculo
        {
            void ligar();
            void desligar();
            void info();


        }

        public interface Combate
        {
            void disparar();
        }

        class Carro : Veiculo, Combate
        {
            public bool ligado;
            private int municao;
            public Carro() {
                setMunicao(100);
            }
            public void ligar()
            {
                this.ligado = true;
            }
            public void desligar()
            {
                this.ligado = false;
            }
            public void info()
            {

            }
            public void disparar()
            {
            }
            public void setMunicao(int qtde)
            {
                this.municao = qtde;
            }
        }
        static void Main(string[] args)
        {
            Carro carro = new Carro();
        }
    }
}
