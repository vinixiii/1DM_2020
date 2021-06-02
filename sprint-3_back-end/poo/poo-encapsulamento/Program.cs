using System;
using encapsulamento.classes;

namespace encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Mastercard m = new Mastercard();

            m.Parcelas = 12;

            System.Console.WriteLine(m.Bandeira);
        }
    }
}
