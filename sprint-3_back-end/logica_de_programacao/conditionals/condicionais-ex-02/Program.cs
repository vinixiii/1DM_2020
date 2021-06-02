using System;

namespace exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício - 02");
            Console.WriteLine("----------");
            Console.WriteLine("");

            int anoAtual = 2020;

            Console.WriteLine("Digite o ano de seu nascimento:");
            int anoDeNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int idadeEmAnos = anoAtual - anoDeNascimento;
            int idadeEmSemanas = idadeEmAnos * 52;

            Console.WriteLine("Você tem " + idadeEmAnos + " anos. Isso é equivalente há " + idadeEmSemanas + " semanas.");
        }
    }
}
