using System;

namespace lacos_senais_1dm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for(int x = 0; x < 11; x++){
                Console.WriteLine($"{numero}x{x} = {numero * x}");
            }
        }
    }
}
