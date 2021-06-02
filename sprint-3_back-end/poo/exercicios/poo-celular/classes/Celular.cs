using System;
namespace poo_celular.classes
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;

        public void Ligar() {
            if(this.ligado) {
                Console.WriteLine("O celular já está ligado");
            } else {
                ligado = true;

                Console.Write("Ligando...");

                for(int i = 0; i < 4; i++) {
                    System.Threading.Thread.Sleep(500);
                    Console.Write("...");
                    System.Threading.Thread.Sleep(500);
                }

                Console.WriteLine("\nVocê ligou o aparelho!");
            }
        }

        public void Desligar() {
            if(this.ligado) {
                ligado = false;

                Console.Write("Desligando...");

                for(int i = 0; i < 4; i++) {
                    System.Threading.Thread.Sleep(500);
                    Console.Write("...");
                    System.Threading.Thread.Sleep(500);
                }

                Console.WriteLine("\nVocê desligou o aparelho!");
            } else {
                Console.WriteLine("O aparelho já está desligado.");
            }
        }

        public void FazerLigacao() {
            if(this.ligado) {
                string [] conclusaoDaLigacao = {"Ligação concluída", "Caiu na caixa postal", "Número ocupado"};

                Console.WriteLine("Para qual número deseja ligar? Digite abaixo:");
                string numero = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                for(int i = 0; i < 5; i++) {
                    System.Threading.Thread.Sleep(1000);
                    System.Console.Write("Tuuuuuu...");
                    System.Threading.Thread.Sleep(1000);
                }

                //Cria um objeto aleatório
                Random random = new Random();

                //Gera uma posição (index) aleatória, menor que o tamnho do array
                int index = random.Next(conclusaoDaLigacao.Length);
                
                //Exibe a mensagem aleatória
                Console.WriteLine($"\n{conclusaoDaLigacao[index]}");
            }
        }

        public void EnviarMensagem() {
            if(this.ligado) {
                string [] conclusaoDaLigacao = {"Mensagem enviada com sucesso!", "Erro! Tente novamente."};

                Console.WriteLine("Para qual número deseja enviar a mensagem? Digite abaixo:");
                string numero = Console.ReadLine();

                Console.WriteLine("Digite a mensagem que deseja enviar:");
                string mensagem = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Enviando...");

                for(int i = 0; i < 4; i++) {
                    System.Threading.Thread.Sleep(500);
                    Console.Write("...");
                    System.Threading.Thread.Sleep(500);
                }

                //Cria um objeto aleatório
                Random random = new Random();

                //Gera uma posição (index) aleatória, menor que o tamnho do array
                int index = random.Next(conclusaoDaLigacao.Length);
                
                //Exibe a mensagem aleatória
                Console.WriteLine($"\n{conclusaoDaLigacao[index]}");
            }
        }

    }
}