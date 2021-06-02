using System;
using poo_celular.classes;

namespace poo_celular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular();

            bool escolheuCelular = true;

            int opcao1 = 0;  

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("-----------------------------");
                Console.WriteLine("---POO - Sitema de Celular---");
                Console.WriteLine("-----------------------------");
                Console.ResetColor();
                Console.WriteLine("Escolha um celular para utilizar:");
                Console.WriteLine("[1] - Celular 1");
                Console.WriteLine("[2] - Celular 2");
                Console.WriteLine("[0] - Sair");

                opcao1 = int.Parse(Console.ReadLine());

                switch(opcao1){
                    case 1:
                        celular.modelo = "iPhone 7 Plus";
                        celular.cor = "Preto";
                        celular.tamanho = "16cm";
                        celular.ligado = false;
                        break;
                    case 2:
                        celular.modelo = "Galaxy S10 Plus";
                        celular.cor = "Branco";
                        celular.tamanho = "16cm";
                        celular.ligado = false;
                        break;
                    case 0:
                        escolheuCelular = false;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Até mais!");
                        break;
                    default:
                        Console.WriteLine("Erro! Opção inválida");
                        break;
                }

                Console.WriteLine("---------");
            } while (!escolheuCelular && opcao1 != 0);
            
            
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if(escolheuCelular){
            Console.WriteLine("Especificações do celular escolhido:");
            Console.ResetColor();
            Console.WriteLine($"Modelo: {celular.modelo}");
            Console.WriteLine($"Cor: {celular.cor}");
            Console.WriteLine($"Tamanho: {celular.tamanho}");

            string opcao2 = "";

            do
            {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("------------------");
                    Console.WriteLine("---Menu inicial---");
                    Console.WriteLine("------------------");
                    Console.ResetColor();
                    Console.WriteLine("Selecione uma opção:");
                    Console.WriteLine("[1] - Ligar aparelho");
                    Console.WriteLine("[2] - Fazer ligação");
                    Console.WriteLine("[3] - Enviar mensagem");
                    Console.WriteLine("[0] - Desligar aparelho");
                    Console.WriteLine("[/] - Sair");

                opcao2 = Console.ReadLine();

                switch(opcao2){
                    case "1":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        celular.Ligar();
                        // Console.ResetColor();
                        break;
                    case "2":
                        celular.FazerLigacao();
                        break;
                    case "3":
                        celular.EnviarMensagem();
                        break;
                    case "0":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        celular.Desligar();
                        break;
                    case "/":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Até mais!");
                        break;
                    default:
                        Console.WriteLine("Erro! Opção inválida");
                        break;
                }
            } while (opcao2 != "/");
            }
        }
    }
}
