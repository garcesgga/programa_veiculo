using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    internal class Carro : Veiculo
    {
        //Construtor
        public Carro(string corInicial, int velocidadeInicial, int nivelCombustivelInicial, int numeroRodasInicial) : base(corInicial, velocidadeInicial, nivelCombustivelInicial, numeroRodasInicial) 
        { }

        //Método para retornar o tipo de veículo
        public override string tipoVeiculo()
        {
            return "Carro";
        }
    }
}
