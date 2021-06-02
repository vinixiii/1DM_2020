using System;

namespace fixacao_ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int [10];
            int menor = 0, maior = 0;

            for(int i = 0; i < valores.Length; i++) {
                Console.Write($"Digite o {i+1}º valor: ");
                valores[i] = int.Parse(Console.ReadLine());

                if(i == 0){
                    menor = valores[0]; //10, 8, 5
                    maior = valores[0];
                }

                if(valores[i] < menor){
                    menor = valores[i];
                } else if(valores[i] > maior) {
                    maior = valores[i];
                }
            }
            
            System.Console.WriteLine("---------");
            
            System.Console.WriteLine($"O maior valor foi: {maior}");
            System.Console.WriteLine($"O menor valor foi: {menor}");
        }
    }
}
