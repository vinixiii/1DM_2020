using System;
using abstracao_challenge.classes;

namespace abstracao_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boleto = new Boleto();
            Credito credito = new Credito();
            Debito debito = new Debito();

            string opcao;
            string confirmacaoDePagamento = "";


            do
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("---------------------------------");
                Console.WriteLine("---POO - Sistema de Pagamentos---");
                Console.WriteLine("---------------------------------");
                Console.ResetColor();

                Console.WriteLine("[1] - Efetuar pagamento");
                Console.WriteLine("[/] - Sair");
                opcao = Console.ReadLine();

                if(opcao == "1") {
                    Console.WriteLine("Digite o valor da compra:");
                    Console.Write("R$: ");
                    float valor = int.Parse(Console.ReadLine());

                    Console.WriteLine("Escolha a melhor forma de pagamento:");
                    Console.WriteLine("[1] - Boleto");
                    Console.WriteLine("[2] - Cartão de Crédito");
                    Console.WriteLine("[3] - Cartão de Débito");
                    opcao = Console.ReadLine();

                    Console.WriteLine("------------------------");
                    
                    switch(opcao) {
                        case "1":
                            float desconto = boleto.Desconto(12);
                            float valorComDesconto = valor - (valor * desconto);
                            Console.WriteLine($"{Math.Round(desconto * 100)}% de desconto aplicado!");
                            Console.WriteLine($"Valor total: {valorComDesconto:C2}");

                            Console.WriteLine("------------------------");
                            Console.WriteLine($"Digite o código de barras: ");
                            boleto.CodigoDeBarras = Console.ReadLine();

                            Console.WriteLine("------------------------");
                            Console.WriteLine("Confirmar pagamento?");
                            Console.WriteLine("[S] - Sim / [N] - Não");
                            confirmacaoDePagamento = Console.ReadLine();

                            if(confirmacaoDePagamento.ToUpper() == "S") {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                boleto.Registrar();
                            } else {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Operação cancelada!");
                            }
                            
                            break;

                        case "2":
                            int parcelas = 0;

                            Console.Write("Bandeira: ");
                            credito.bandeira = Console.ReadLine();
                            
                            Console.Write("Número do cartão: ");
                            credito.numero = Console.ReadLine();
                            
                            Console.Write("Nome do titular: ");
                            credito.titular = Console.ReadLine();
                                                
                            Console.Write("Cvv: ");
                            credito.cvv = Console.ReadLine();

                            Console.WriteLine("------------------------");
                            Console.WriteLine("Digite o número de parcelas:");
                            parcelas = int.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------");

                            while(parcelas <= 0 || parcelas >= 13) {
                                Console.WriteLine("Erro! Opção inválida.");

                                Console.WriteLine("Digite o número de parcelas:");
                                parcelas = int.Parse(Console.ReadLine());

                                Console.WriteLine("------------------------");
                            }
                            
                            float juros = credito.CalcularJuros(parcelas, valor);

                            float valorComJuros = valor + juros;
                            float valorParcelas = valorComJuros / parcelas;
                            
                            Console.WriteLine($"Juros de {Math.Round(juros * 10)}% aplicado");
                            Console.WriteLine($"Valor total: {valorComJuros:C2}");
                            Console.WriteLine($"Valor das parcelas: {parcelas}x de {valorParcelas:C2}");

                            Console.WriteLine("------------------------");
                            Console.WriteLine("Confirmar pagamento?");
                            Console.WriteLine("[S] - Sim / [N] - Não");
                            confirmacaoDePagamento = Console.ReadLine();

                            if(confirmacaoDePagamento.ToUpper() == "S") {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                credito.Pagar(valorComJuros);
                            } else {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Operação cancelada!");
                            }

                            break;
                        case "3":
                            Console.Write("Bandeira: ");
                            debito.bandeira = Console.ReadLine();
                            
                            Console.Write("Número do cartão: ");
                            debito.numero = Console.ReadLine();
                            
                            Console.Write("Nome do titular: ");
                            debito.titular = Console.ReadLine();
                                                
                            Console.Write("Cvv: ");
                            debito.cvv = Console.ReadLine();

                            Console.WriteLine("------------------------");
                            Console.WriteLine($"Valor total: {valor:C2}");
                            
                            Console.WriteLine("------------------------");
                            Console.WriteLine("Confirmar pagamento?");
                            Console.WriteLine("[S] - Sim / [N] - Não");
                            confirmacaoDePagamento = Console.ReadLine();

                            if(confirmacaoDePagamento.ToUpper() == "S") {
                                Console.WriteLine("------------------------");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                debito.Pagar(valor);
                            } else {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Operação cancelada!");
                            }
                            
                            break;
                        default:
                            Console.WriteLine("Até mais!");
                            break;
                    }
                }
            } while (opcao != "/" && confirmacaoDePagamento.ToUpper() != "S");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Até mais!");
        }
    }
}

