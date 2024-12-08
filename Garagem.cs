using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    public class Garagem
    {
        //Atributos
        private List<Veiculo> veiculos;
         public Garagem()
           {
            veiculos = new List<Veiculo>();
           }

        //Método para adicionar veículos na garagem
        public bool adicionarVeiculo(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
            return true;
        }

        //Método para listar os veículos na garagem
        public void ListarVeiculos()
        {
            //Verificando se há veículos na garagem
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Não há veículos na garagem!");
            }
            //Listando os veículos
            foreach (Veiculo veiculo in veiculos)
            {
                Console.WriteLine(veiculo.ToString());
            }
        }

        public Veiculo SelecionarVeiculo(int index) 
        {
            if (index >= 0 && index < veiculos.Count)
            {
                return veiculos[index];
            }
            return null;
        }
    }
}
