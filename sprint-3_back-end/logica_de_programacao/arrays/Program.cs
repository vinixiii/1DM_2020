using System;

namespace arrays_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays || Vetores");
            Console.WriteLine("----------");

            string[]nomes = new string[3];
            int[]idades = new int[3];

            for(int i = 0; i < nomes.Length; i++){
                Console.Write($"Digite o {i+1}º nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Digite a idade: ");
                idades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("----------");

            Console.WriteLine("Nomes e idades cadastrados:");
            for(int i = 0; i < nomes.Length; i++){
                Console.WriteLine($"Nome: {nomes[i]}");
                Console.WriteLine($"Idade: {idades[i]}");
            }
        }
    }
}
