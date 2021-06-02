using System;

namespace Calculadora_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            float resultado = 0;

            Console.WriteLine("Digite a operação desejada: (adicao, subtracao, multiplicacao, ou divisao)");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o 1º número:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número:");
            float num2 = float.Parse(Console.ReadLine());

            switch(operacao){
                case "adicao":
                    resultado = num1 + num2;
                    break;
                case "subtracao":
                    resultado = num1 - num2;
                    break;
                case "multiplicacao":
                    resultado = num1 * num2;
                    break;
                case "divisao":
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }

            Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
        }
    }
}
