using System;

namespace projeto_de_produtos.classes
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login() {
            // Usuario user = new Usuario();

            // Logar(user);

            // if(Logado) {
                GerarMenu();
            // }
        }

        public void GerarMenu() {

            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao = "";

            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("[1] - Cadastrar produto");
                Console.WriteLine("[2] - Listar produtos");
                Console.WriteLine("[3] - Deletar produto");
                Console.WriteLine("[4] - Cadastrar marca");
                Console.WriteLine("[5] - Listar marcas");
                Console.WriteLine("[6] - Deletar marca");
                Console.WriteLine("[0] - Sair");
                opcao = Console.ReadLine();
                
                switch (opcao)
                {
                    case "1":
                        produto.Cadastrar(marca);
                        break;
                    case "2":
                        produto.Listar();
                        break;
                    case "3":
                        Console.WriteLine("Digite um código para excluir:");
                        int codigoProduto = int.Parse(Console.ReadLine());
                        produto.Deletar(codigoProduto);
                        break;
                    case "4":
                        marca.CadastrarMarca();
                        break;
                    case "5":
                        marca.Listar();
                        break;
                    case "6":
                        Console.WriteLine("Digite um código para excluir:");
                        int codigoMarca = int.Parse(Console.ReadLine());
                        marca.Deletar(codigoMarca);
                        break;
                    default:
                        break;
                }
                
            } while (opcao != "0");
        }

        public void Logar(Usuario usuario) {

            Console.WriteLine("Digite seu e-mail:");
            string emailLogin = Console.ReadLine();
            
            Console.WriteLine("Digite sua senha:");
            string senhaLogin = Console.ReadLine();
            
            if(emailLogin == usuario.Email && senhaLogin == usuario.Senha) {
                Logado = true;
                Console.WriteLine("Login efetuado com sucesso!");
            } else {
                Console.WriteLine("Falha ao logar na aplicação.");
            }
        }

        public void Deslogar() {
            Logado = false;
        }
        
        
    }
}