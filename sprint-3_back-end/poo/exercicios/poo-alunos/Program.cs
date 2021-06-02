using System;
using sistema_alunos.classes;

namespace sistema_alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Digite o curso do aluno: ");
            aluno.curso = Console.ReadLine();

            Console.WriteLine("Digite o RG do aluno: ");
            aluno.rg = Console.ReadLine();

            Console.WriteLine("Digite a idade do aluno: ");
            aluno.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a média final do aluno: ");
            aluno.mediaFinal = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da mensalidade do aluno: ");
            aluno.valorMensalidade = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite se o aluno é bolsista: 'S' ou 'N'");
            string resposta = Console.ReadLine();
            
            if(resposta == "s"){
                aluno.bolsista = true;
            } else {
                aluno.bolsista = false;
            }

            int opcao = 0;

            do
            {
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("[1] - Ver média do aluno");
                Console.WriteLine("[2] - Ver mensalidade do aluno");
                Console.WriteLine("[0] - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    case 1:
                        Console.WriteLine($"A média final do aluno {aluno.nome} = {aluno.VerMediaAluno()}");
                        break;
                    case 2:
                        Console.WriteLine($"O valor da mensalidade do aluno {aluno.nome} é de R${aluno.VerMensalidade()}");
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por acessar!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 0);
            
        }
    }
}
