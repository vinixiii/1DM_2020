using System;
using System.Text;
using poo_static.classes;

namespace poo_static
{
    class Program
    {
        static void Main(string[] args)
        {   
            float valor = 1f;

            //Chamando classe estática sem precisar instânciar
            Console.WriteLine($"{valor} Dólar = {Conversor.DolarParaReal(valor)} Reais");
            Console.WriteLine($"{valor} Real = {Conversor.RealParaDolar(valor):0.00} Dólar");
            Console.WriteLine($"{valor} Euro = {Conversor.EuroParaReal(valor)} Reais");
            Console.WriteLine($"{valor} Real = {Conversor.RealParaEuro(valor):0.00} Euro");

            //Exeplo: Math
            Console.WriteLine($"2^4 = {Math.Pow(2, 4)}");
        }
    }
}
