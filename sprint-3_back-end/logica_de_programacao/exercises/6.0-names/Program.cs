using System;

namespace fixacao_ex_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string [10];
            string message = "NÃO ACHEI";

            for(int i = 0; i < nomes.Length; i++) {
                System.Console.Write($"{i+1}º nome: ");
                nomes[i] = Console.ReadLine();
            }

            System.Console.Write("Digite um nome para pesquisar em nosso sitema: ");
            string nameSearch = Console.ReadLine();

            for(int i = 0; i < nomes.Length; i++) {
               if(nomes[i] == nameSearch){
                   message = "ACHEI";
               }
            }

            System.Console.WriteLine(message);
        }
    }
}
