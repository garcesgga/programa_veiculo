using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    public abstract class Veiculo
    {
        //Atributos
        private string cor;
        public int velocidade { get; set; }
        private int nivelCombustivel;
        private int numeroRodas;

        //Construtor
        public Veiculo(string corInicial, int velocidadeInicial, int nivelCombustivelInicial, int numeroRodasInicial)
        {
            this.cor = corInicial;
            this.velocidade = velocidadeInicial;
            this.nivelCombustivel = nivelCombustivelInicial;
            this.numeroRodas = numeroRodasInicial;
        }

        //Método abstrato
        public abstract string tipoVeiculo();

        //Métodos para manipulação do veículo
        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");
            this.velocidade += 10;
            nivelCombustivel -= 1;
        }

        public void Frear()
        {
            Console.WriteLine("Freando...");
            this.velocidade -= 10;
        }

        public void Abastecer(int quantidade)
        {
            Console.WriteLine("Abastecendo " + quantidade + " litros de combustível");
            this.nivelCombustivel += quantidade;
        }

        //Método ToString para o texto
        public string ToString()
        {
            string tipo = tipoVeiculo();
            return $"Veiculo : {tipo}\nCor : {cor}\nVelocidade : {velocidade}\nCombustivel : {nivelCombustivel}\n";
        }

        //Método para exibir o estado atual do veículo
        public void exibirEstadoAtual() 
        { 
        Console.WriteLine(this.ToString());
        }
    }
}
