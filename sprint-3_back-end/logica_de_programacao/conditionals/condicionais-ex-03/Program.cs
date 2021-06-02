using System;

namespace exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício - 03");
            Console.WriteLine("----------");
            Console.WriteLine("");
            
            Console.WriteLine("Digite o salário do funcionário:");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            if(salario >= 500.00) {
                double aumento = salario * 0.3;
                double novoSalario = salario + aumento;

                Console.WriteLine("O salário deste funcionário será reajustado para: " + novoSalario + " reais.");
            } else {
                Console.WriteLine("O salári deste funcionário não será reajustado.");
            }
        }
    }
}
