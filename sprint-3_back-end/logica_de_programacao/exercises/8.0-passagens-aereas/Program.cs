using System;

namespace passagens
{
    class Program
    {
        static void Main(string[] args)
        {   
            string[] names = new string[2];
            string[] origin = new string[2];
            string[] destiny = new string[2];
            string[] date = new string[2];

            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("---Sistema de passagens aéreas---");
            Console.WriteLine("---------------------------------");

            //Validação da senha
            bool passwordValidation;
            do{
                Console.Write("Digite a senha: ");
                string password = Console.ReadLine();
                passwordValidation = EfetuarLogin(password);
            } while(!passwordValidation);

            //Criação do menu
            int choice;
            int contador = 0;

            do{
               Console.WriteLine("---Menu inicial---");
               Console.WriteLine("Selecione uma opção:");
               Console.WriteLine("[1] - Cadastrar passagem");
               Console.WriteLine("[2] - Listar passagens");
               Console.WriteLine("[0] - Cadastrar passagem");
               choice = int.Parse(Console.ReadLine());

               switch(choice){
                   case 1:
                        //Cadastrar passagem
                        string answer;

                        do{
                            if(contador < names.Length){
                                Console.Write($"Digite o nome do {contador+1}º passageiro: ");
                                names[contador] = Console.ReadLine();
                                
                                Console.Write($"Digite a origem do {contador+1}º passageiro: ");
                                origin[contador] = Console.ReadLine();

                                Console.Write($"Digite o destino do {contador+1}º passageiro: ");
                                destiny[contador] = Console.ReadLine();

                                Console.Write($"Digite a data do vôo do {contador+1}º passageiro: ");
                                date[contador] = Console.ReadLine();

                                contador++;
                            } else {
                                Console.WriteLine("Limite excedido.");
                            }

                            System.Console.WriteLine("Gostaria de adicionar mais um passageior?");
                            System.Console.WriteLine("[S] - Sim");
                            System.Console.WriteLine("[N] - Não");
                            answer = Console.ReadLine();
                        } while (answer.ToUpper() == "S");
                        break;
                    case 2:
                        //Listar as passagens
                        for(int i = 0; i < names.Length; i++){
                            Console.WriteLine($"Nome do {i+1}º passageiro: {names[i]}");

                            Console.WriteLine($"Origem do {i+1}º passageiro: {names[i]}");

                            Console.WriteLine($"Destino do {i+1}º passageiro: {names[i]}");

                            Console.WriteLine($"Data do vôo do {i+1}º passageiro: {names[i]}");
                        }
                        break;
                    case 0:
                        //Sair
                        break;
                    default:
                        //Opção inválida
                        break;
               }
            } while (choice != 0);
            
            //Funções
            bool EfetuarLogin(string password){
                if(password == "123456"){
                    return true;
                } else {
                    Console.WriteLine("Senha incorreta");
                    return false;
                }
            }

        }
    }
}
