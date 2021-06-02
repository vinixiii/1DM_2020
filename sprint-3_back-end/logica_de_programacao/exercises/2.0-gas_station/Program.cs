using System;

namespace fixacao_ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double litroGasolina = 5.3;
            double litroAlcool = 4.9;

            Console.Write("Digite o tipo de combustível ('A' - Álcool, 'G'- Gasolina): ");
            string tipoCombustivel = Console.ReadLine();

            while(tipoCombustivel.ToUpper() != "A" && tipoCombustivel.ToUpper() != "G"){
                System.Console.WriteLine("Erro! Opção inválida.");
                Console.Write("Digite o tipo de combustível ('A' - Álcool, 'G'- Gasolina): ");
                tipoCombustivel = Console.ReadLine();
            }

            Console.Write("Digite a quantidade de litros: ");
            double litros = double.Parse(Console.ReadLine());

            
            switch(tipoCombustivel.ToUpper()){
                case "A":
                    CalcularPrecoAlcool(litroAlcool, litros);
                    break;
                case "G":
                    CalcularPrecoGasolina(litroGasolina, litros);
                    break;
                default:
                    break;
            }
        }

        static void CalcularPrecoGasolina(double litroGasolina, double litros){
            double valor = 0;

            double desconto1 = (litroGasolina * litros) * 0.04;
            double desconto2 = (litroGasolina * litros) * 0.06;

            switch(litros){
                case double n when n <= 20:
                    valor = (litroGasolina * litros) - desconto1;
                    break;
                case double n when n > 20:
                    valor = (litroGasolina * litros) - desconto2;
                    break;
                default:
                    break;
            }

            System.Console.WriteLine($"O valor a ser pago é de R${valor}");
        }

        static void CalcularPrecoAlcool(double litroAlcool, double litros){
            double valor = 0;
            
            double desconto1 = (litroAlcool * litros) * 0.03;
            double desconto2 = (litroAlcool * litros) * 0.05;

            switch(litros){
                case double n when n <= 20:
                    valor = (litroAlcool * litros) - desconto1;
                    break;
                case double n when n > 20:
                    valor = (litroAlcool * litros) - desconto2;
                    break;
                default:
                    break;
            }

            System.Console.WriteLine($"O valor a ser pago é de R${valor}");
        }
    }
}
