using System;
using polimorfismo.classes;

namespace polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Megaman megaman = new Megaman();
            Zero zero = new Zero();

            Console.WriteLine($"Megaman (corrida): {megaman.Correr()}");
            Console.WriteLine($"Zero (corrida): {zero.Correr()}");
            Console.WriteLine("---------");
            Console.WriteLine($"Megaman (pulo): {megaman.Pular()}");
            Console.WriteLine($"Zero (pulo): {zero.Pular()}");   
        }
    }
}
