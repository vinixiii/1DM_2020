using System;

namespace Exercício_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade em anos:");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade * 12;
            int dias = idade * 365;
            int horas = idade * 8760;
            int minutos = idade * 525600;

            Console.WriteLine("Show! Isso é equivalente há " + meses + " meses; " + dias + " dias; " + horas + " horas; " + minutos + " minutos de vida.");
        }
    }
}
