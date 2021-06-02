using System;

namespace fibonacci_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite 'Fibonacci' para iniciar: ");
            string start = Console.ReadLine();
            bool startValidation = false;

            while(startValidation == false){
                if(start != "Fibonacci"){
                    Console.WriteLine("Erro! Tente novamente.");
                    Console.Write("Digite 'Fibonacci' para iniciar: ");
                    start = Console.ReadLine();
                } else {
                    startValidation = true;
                    int valor1 = -1;
                    int valor2 = 1;
                    int valor3 = 0;
                    
                    Console.WriteLine("----------");
                    while(valor3 < 500){
                        valor3 = valor1 + valor2;
                        valor1 = valor2;
                        valor2 = valor3;
                        Console.WriteLine(valor3);
                    }
                    Console.WriteLine("----------");
                }
            }
        }
    }
}
