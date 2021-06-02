using System;
using ex_01.classes;

namespace ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();

            int totalDeAndares = elevador.TotalDeAndares;

            string opcao = "";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-------------------------");
            Console.WriteLine("---Sistema de Elevador---");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            Console.ResetColor();

            while (opcao != "/")
            {
                bool inicializar = elevador.Inicializar(elevador.Capacidade, elevador.TotalDeAndares);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                if(elevador.AndarAtual == 0) {
                    Console.WriteLine($"O elevador está no térreo!");
                } else if(elevador.AndarAtual == elevador.TotalDeAndares) {
                    Console.WriteLine($"O elevador está no último andar!");
                } else {
                    Console.WriteLine($"O elevador está no {elevador.AndarAtual}º andar");
                }
                Console.ResetColor();

                Console.WriteLine("");

                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("[1] - Subir");
                Console.WriteLine("[2] - Descer");
                Console.WriteLine("[3] - Adicionar pessoa ao elevador");
                Console.WriteLine("[4] - Remover pessoa ao elevador");
                Console.WriteLine("[/] - Sair");

                opcao = Console.ReadLine();

                switch(opcao) {
                    case "1":
                        Console.Clear();

                        if(inicializar && elevador.Subir()){
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Subindo...");
                            elevador.AndarAtual = elevador.AndarAtual + 1;
                            Console.ResetColor();
                        } else {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Impossível subir!");
                            Console.ResetColor();
                        }

                        break;
                    case "2":
                        Console.Clear();

                        if(inicializar && elevador.Descer()){
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Descendo...");
                            elevador.AndarAtual = elevador.AndarAtual - 1;
                            Console.ResetColor();
                        } else {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Impossível descer!");
                            Console.ResetColor();
                        }

                        break;
                    case "3":
                        Console.Clear();

                        bool entrar = elevador.Entrar();

                        if(entrar){
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("1 pessoa entrou no elevador!");
                            elevador.PessoasPresentes = elevador.PessoasPresentes + 1;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"Total de pessoas no elevador: {elevador.PessoasPresentes}");
                        } else {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Não é possível entrar mais pessoas. Limite máximo atingido!");
                            Console.ResetColor();
                        }
                        break;
                    case "4":
                        Console.Clear();

                        bool sair = elevador.Sair();

                        if(sair){
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("1 pessoa saiu do elevador!");
                            elevador.PessoasPresentes = elevador.PessoasPresentes - 1;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"Total de pessoas no elevador: {elevador.PessoasPresentes}");
                            Console.ResetColor();
                        } else {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Não há mais pessoas para sair do elevador!");
                            Console.ResetColor();
                        }
                        break;
                }
            }
        }
    }
}
