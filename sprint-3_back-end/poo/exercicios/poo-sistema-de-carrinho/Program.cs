using System;
using objetos_argumentos.classes;

namespace objetos_argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando os produtos
            Produto p1 = new Produto(1, "Red Dead Redemption 2", 499f);
            Produto p2 = new Produto(2, "GTA V", 56.90f);
            Produto p3 = new Produto(3, "Detroit Become Human", 120.50f);
            Produto p4 = new Produto(4, "Celeste", 22.99f);
            Produto p5 = new Produto(5, "Borderlands 3", 59.90f);

            Carrinho carrinho = new Carrinho();
            string opcao = "";

            while (opcao != "/") {
                // Console.Clear();

                Console.WriteLine("GAME STORE");
                Console.WriteLine("Carrinho de compras:");
                Console.WriteLine("[1] - Visualizar carrinho");
                Console.WriteLine("[2] - Adicionar item ao carrinho");
                Console.WriteLine("[3] - Alterar item do carrinho");
                Console.WriteLine("[4] - Remover item do carrinho");
                Console.WriteLine("[/] - Sair");
                opcao = Console.ReadLine();

                switch(opcao) {
                    case "1":
                        carrinho.MostrarProdutos();
                        break;
                    case "2":
                        string selecao = "";
                        do
                        {
                            Console.WriteLine("Produtos:");
                            Console.WriteLine($"[{p1.Codigo}] - {p1.Nome} - R${p1.Preco.ToString("n2")}");
                            Console.WriteLine($"[{p2.Codigo}] - {p2.Nome} - R${p2.Preco.ToString("n2")}");
                            Console.WriteLine($"[{p3.Codigo}] - {p3.Nome} - R${p3.Preco.ToString("n2")}");
                            Console.WriteLine($"[{p4.Codigo}] - {p4.Nome} - R${p4.Preco.ToString("n2")}");
                            Console.WriteLine("[/] - Sair");
                            selecao = Console.ReadLine();
                            
                            string add = "";

                            if(selecao != "/") {
                                do
                                {
                                    Console.WriteLine("Adicionar ao carrinho?");
                                    Console.WriteLine("[S] - Sim");
                                    Console.WriteLine("[N] - Não");
                                    add = Console.ReadLine();
                                    
                                    switch(selecao) {
                                        case "1":
                                            carrinho.AdicionarProduto(p1);
                                            Console.WriteLine("Produto adicionado ao carrinho!");
                                            break;
                                        case "2":
                                            carrinho.AdicionarProduto(p2);
                                            Console.WriteLine("Produto adicionado ao carrinho!");
                                            break;
                                        case "3":
                                            carrinho.AdicionarProduto(p3);
                                            Console.WriteLine("Produto adicionado ao carrinho!");
                                            break;
                                        case "4":
                                            carrinho.AdicionarProduto(p4);
                                            Console.WriteLine("Produto adicionado ao carrinho!");
                                            break;
                                        default:
                                            break;
                                    }
                                } while (add.ToUpper() != "S" && add.ToUpper() != "N");
                            }
                        } while (selecao != "/");
                        
                        break;
                    case "3":
                        Console.WriteLine("Qual item deseja alterar?");
                        carrinho.MostrarProdutos();
                        int escolha = int.Parse(Console.ReadLine());

                        Console.WriteLine("Escolha um item para colocar no lugar:");
                        Console.WriteLine($"[{p1.Codigo}] - {p1.Nome} - R${p1.Preco.ToString("n2")}");
                        Console.WriteLine($"[{p2.Codigo}] - {p2.Nome} - R${p2.Preco.ToString("n2")}");
                        Console.WriteLine($"[{p3.Codigo}] - {p3.Nome} - R${p3.Preco.ToString("n2")}");
                        Console.WriteLine($"[{p4.Codigo}] - {p4.Nome} - R${p4.Preco.ToString("n2")}");
                        string escolhaProduto = Console.ReadLine();

                        Produto produtoNovo = new Produto();

                        switch(escolhaProduto) {
                            case "1":
                                produtoNovo = p1;
                                break;
                            case "2":
                                produtoNovo = p2;
                                break;
                            case "3":
                                produtoNovo = p3;
                                break;
                            case "4":
                                produtoNovo = p4;
                                break;
                        }

                        carrinho.AlterarItem(escolha, produtoNovo);
                        Console.WriteLine("Item alterado!");
                        break;
                    case "4":
                        Console.WriteLine("Qual item deseja remover?");
                        carrinho.MostrarProdutos();
                        string escolha2 = Console.ReadLine();

                        switch(escolha2) {
                            case "1":
                                carrinho.RemoverProduto(p1);
                                break;
                            case "2":
                                carrinho.RemoverProduto(p2);
                                break;
                            case "3":
                                carrinho.RemoverProduto(p3);
                                break;
                            case "4":
                                carrinho.RemoverProduto(p4);
                                break;
                        }
                        
                        break;
                    case "/":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
