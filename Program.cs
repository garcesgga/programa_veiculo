using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciando objetos
            Veiculo veiculo = null;
            Garagem garagem = new Garagem();

            //Menu Principal
            while (true) {

                Console.WriteLine("Escolha uma opção:\n1 - Criar véiculo\n2 - Dirigir\n3 - Ver garagem\n4 - Sair\nobs:ainda não resolvi o erro de travar o código quando acessa a opção 2 sem ter carro na garagem ou se digita um valor inválido");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    //Menu de criação de veículos
                    while (true)
                    {
                        Console.WriteLine("Escolha uma opção:\n1 - Carro\n2 - Caminhão\n3 - Voltar\n");
                        int opcaov = int.Parse(Console.ReadLine());

                        //Criando veículo
                        if (opcaov == 1 || opcaov == 2)
                        {
                            //Recebendo informações do veículo
                            Console.WriteLine("Escolha a cor do veículo: ");
                            string cor = Console.ReadLine();
                            Console.WriteLine("Escolha o numero de rodas do veiculo: ");
                            int numeroRodas = int.Parse(Console.ReadLine());

                            //Criando carro ou caminhão
                            if (opcaov == 1)
                            {
                                veiculo = new Carro(cor, 0, 0, numeroRodas);
                            }
                            else if (opcaov == 2)
                            {
                                veiculo = new Caminhao(cor, 0, 0, numeroRodas);
                            }

                            //Exibindo estado atual do veículo
                            veiculo.exibirEstadoAtual();
                            bool salvo = garagem.adicionarVeiculo(veiculo);
                            if (salvo)
                            {
                                Console.WriteLine("Veículo criado e salvo com sucesso na garagem!\n");
                            }

                            else
                            {
                                Console.WriteLine("Falha ao salvar o veículo na garagem.\n");
                            }

                            /*veiculo.exibirEstadoAtual();
                            garagem.adicionarVeiculo(veiculo);
                            Console.WriteLine("Veículo criado e salvo na garagem com sucesso!");*/
                        }

                        //Voltando
                        else if (opcaov == 3)
                        {
                            Console.WriteLine("Voltando...");
                            break;
                        }
                    }
                }


                else if (opcao == 2)
                {  //Menu de direção
                    if (garagem != null)
                    {
                       Console.WriteLine("Escolha o veículo para dirigir: ");
                       garagem.ListarVeiculos();
                       int indice = int.Parse(Console.ReadLine()) - 1;
                       veiculo = garagem.SelecionarVeiculo(indice);

                        if (veiculo == null)
                        {
                            Console.WriteLine("Garagem vazia ou veículo inválido, Teste novamente!");
                        }
                        else
                        {
                            while (true)
                            {


                                Console.WriteLine("Escolha uma opção: 1 - Acelerar\n2 - Freiar\n3 - Abastecer\n4 - Estacionar\n");
                                int opcaod = int.Parse(Console.ReadLine());

                                //Direção do veículo
                                if (opcaod == 1)
                                {
                                    veiculo.Acelerar();
                                }

                                if (opcaod == 2)
                                {
                                    veiculo.Frear();
                                }

                                if (opcaod == 3)
                                {
                                    Console.WriteLine("Selecione a quantidade de combustível:");
                                    int quantidade = int.Parse(Console.ReadLine());
                                    veiculo.Abastecer(quantidade);
                                }

                                //Estacionando e saindo
                                if (opcaod == 4)
                                {
                                    Console.WriteLine("Estacionando e saindo...");
                                    break;
                                }
                            }
                        }
                    }
                }

                else if (opcao == 3)
                {
                    //Menu da garagem
                    while (true)
                    {
                        if (garagem == null)
                        {
                            Console.WriteLine("Não há veículos na garagem!");
                        }
                        Console.WriteLine("1 - Listar Veiculos\n2 - Voltar\n");
                        int opcaog = int.Parse(Console.ReadLine());

                        //Listando veículos
                        if (opcaog == 1)
                        {
                            garagem.ListarVeiculos();
                        }

                        //Voltando
                        else if (opcaog == 2)
                        {
                            Console.WriteLine("Voltando...");
                            break;
                        }
                    }
                }

                //Saindo
                else if (opcao == 4)
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
                //Opção inválida
                else
                {
                    Console.WriteLine(opcao + "Não é uma opção válida!");
                }
            }
        }
    }
}
