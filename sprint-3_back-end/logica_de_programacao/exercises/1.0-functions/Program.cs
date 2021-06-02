using System;

namespace ex_20_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string [2];

            int[] notas1 = new int [2];
            int[] notas2 = new int [2];
            int[] notas3 = new int [2];
            int[] notas4 = new int [2];

            float[] media = new float [2];           

            for(int i = 0; i < nomes.Length; i++){
                Console.Write($"{i+1}º aluno: ");
                nomes[i] = Console.ReadLine();

                Console.Write($"Digite a 1ª nota do {i+1}º aluno: ");
                notas1[i] = int.Parse(Console.ReadLine());

                Console.Write($"Digite a 2ª nota do {i+1}º aluno: ");
                notas2[i] = int.Parse(Console.ReadLine());

                Console.Write($"Digite a 3ª nota do {i+1}º aluno: ");
                notas3[i] = int.Parse(Console.ReadLine());

                Console.Write($"Digite a 4ª nota do {i+1}º aluno: ");
                notas4[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("---------");

            for (int i = 0; i < nomes.Length; i++)
            {
                media[i] = (notas1[i] + notas2[i] + notas3[i] + notas4[i]) / 4;
                Console.WriteLine($"A média de {nomes[i]}: {media[i]}");
            }

            Console.WriteLine("---------");

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"O aluno(a) {nomes[i]} está: ");
                if(media[i] >= 7){
                    Console.WriteLine("Aprovado");
                } else {
                    Console.WriteLine("Reprovado");
                }
            }

            Console.WriteLine("---------");
            
            float soma = 0;

            for (int i = 0; i < nomes.Length; i++)
            {
                soma = soma + media[i];
            }
            
            float mediaGeral = soma / nomes.Length;
            Console.WriteLine($"A média geral é: {mediaGeral}");
        }
    }
}
