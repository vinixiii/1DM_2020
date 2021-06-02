using System;

namespace program_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma nota entre 0 e 10: ");
            int nota = int.Parse(Console.ReadLine());
            bool validacao = false;

            while(validacao == false){
                if(nota < 0 || nota > 10){
                    Console.WriteLine("Valor inválido.");
                    Console.Write("Digite uma nota entre 0 e 10: ");
                    nota = int.Parse(Console.ReadLine());
                } else {
                    validacao = true;
                    Console.WriteLine("Nota válida.");
                }
            }
        }
    }
}
