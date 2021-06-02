using System;

namespace fixacao_ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoAtual = 2020;

            Console.WriteLine("Digite a data de nascimento: ");
            int nascimento = int.Parse(Console.ReadLine());
            int validation = anoAtual - nascimento;

            if(validation < 18){
                Console.WriteLine("Você não pode votar esse ano.");
            } else {
                Console.WriteLine("Você pode votar esse ano.");
            }
        }
    }
}
