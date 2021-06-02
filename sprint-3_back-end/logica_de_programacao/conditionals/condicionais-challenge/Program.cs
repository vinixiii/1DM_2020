using System;

namespace challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio");
            Console.WriteLine("----------");
            Console.WriteLine("");

            Console.WriteLine("Digite a idade do nadador:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if(idade >= 5 && idade <= 7) {
                Console.WriteLine("Este nadador está na categoria: Infantil A.");         
            } else if(idade >= 8 && idade <= 10) {
                Console.WriteLine("Este nadador está na categoria: Infantil B.");          
            } else if(idade >= 11 && idade <= 13) {
                Console.WriteLine("Este nadador está na categoria: Juvenil A.");          
            } else if(idade >= 14 && idade <= 17) {
                Console.WriteLine("Este nadador está na categoria: Juvenil B.");       
            } else if(idade >= 18) {
                Console.WriteLine("Este nadador está na categoria: Sênior.");
            } else {
                Console.WriteLine("Este nadador não se enquadra em nenhuma categoria.");
            }
        }
    }
}
