using System;

namespace program_02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validation = false;

            Console.Write("Insita o nome de usuário: ");
            string username = Console.ReadLine();

            Console.Write("Insira a senha: ");
            string password = Console.ReadLine();

            while(validation == false){
                if(username == password){
                    Console.WriteLine("Erro! O nome de usuário e senha não podem ser iguais. Tente novamente.");
                    Console.WriteLine("");

                    Console.Write("Insita o nome de usuário: ");
                    username = Console.ReadLine();

                    Console.Write("Insira a senha: ");
                    password = Console.ReadLine();

                } else {
                    validation = true;
                }
            }
        }
    }
}
