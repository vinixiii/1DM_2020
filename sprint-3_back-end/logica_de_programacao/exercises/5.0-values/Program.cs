using System;

namespace fixacao_ex_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            foreach (int valor in valores)
            {
                for(int x = 1; x < (valores.Length + 1); x++){
                    int resultado = valor * x;
                    System.Console.WriteLine($"{valor}x{x} = {resultado}");
                }

                Console.WriteLine("---------");
            }
        }
    }
}
