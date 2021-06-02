using System;

namespace average_calculation_senai_1dm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            float nota1, nota2, nota3, media;

            //Entrada
            Console.WriteLine("Digite o nome do aluno: ");
            string nomeDoAluno = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            //Processsamento
            media = (nota1 + nota2 + nota3) / 3;

            //Saída
            if(media > 5) {
                Console.WriteLine("O aluno " + nomeDoAluno + " está aprovado");
            } else {
                Console.WriteLine("O aluno " + nomeDoAluno + " está reprovado");
            }
        }
    }
}
