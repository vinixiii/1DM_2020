using System;

namespace fixacao_ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do produto: ");
            string name = Console.ReadLine();
            
            Console.Write("Digite o preço unitário: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade adquirida: ");
            double quantity = double.Parse(Console.ReadLine());

            double totalPrice = price * quantity;

            Console.WriteLine("---------");

            if(quantity <= 5){
                double discount = totalPrice * 0.02;
                double totalPayment = totalPrice - discount;

                System.Console.WriteLine($"O valor total a ser pago é de R${totalPayment}");
            } else if(quantity > 5 || quantity <= 10) {
                double discount = totalPrice * 0.03;
                double totalPayment = totalPrice - discount;

                System.Console.WriteLine($"O valor total a ser pago é de R${totalPayment}");
            } else if(quantity > 10) {
                double discount = totalPrice * 0.05;
                double totalPayment = totalPrice - discount;

                System.Console.WriteLine($"O valor total a ser pago é de R${totalPayment}");
            }
        }
    }
}
