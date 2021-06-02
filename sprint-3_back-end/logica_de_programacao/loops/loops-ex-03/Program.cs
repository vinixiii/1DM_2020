using System;

namespace program_03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool usernameValidation = false;
            bool ageValidation = false;
            bool salaryValidation = false;
            bool maritalStatusValidation = false;

            Console.Write("Nome: ");
            string username = Console.ReadLine();
            
            while(usernameValidation == false){
                if(username == string.Empty){
                    Console.WriteLine("Erro! Este campo deve ser preenchido. Tente novamente!");
                    Console.Write("Nome: ");
                    username = Console.ReadLine();
                } else {
                    usernameValidation = true;
                }
            }

            Console.Write("Idade: ");
            int age = int.Parse(Console.ReadLine());

            while(ageValidation == false){
                if(age < 0 || age > 150){
                    Console.WriteLine("Erro! A idade deve estar entre 0 e 150. Tente novamente!");
                    Console.Write("Idade: ");
                    age = int.Parse(Console.ReadLine());
                } else {
                    ageValidation = true;
                }
            }

            Console.Write("Salário: ");
            int salary = int.Parse(Console.ReadLine());

            while(salaryValidation == false){
                if(salary < 0){
                    Console.WriteLine("Erro! O salário não pode ser menor que 0. Tente novamente!");
                    Console.Write("Saláro: ");
                    salary = int.Parse(Console.ReadLine());
                } else {
                    salaryValidation = true;
                }
            }

            Console.Write("Estado civil |'s'-Solteiro(a)|'c'-Casado(a)|'v'-Viúvo(a)|'d'-Divorciado(a)|: ");
            string maritalStatus = Console.ReadLine();

            while(maritalStatusValidation == false){
                switch(maritalStatus){
                    case "s":
                        maritalStatusValidation = true;
                        maritalStatus = "Solteiro(a)";
                        break;
                    case "c":
                        maritalStatusValidation = true;
                        maritalStatus = "Casado(a)";
                        break;
                    case "v":
                        maritalStatusValidation = true;
                        maritalStatus = "Viúvo(a)";
                        break;
                    case "d":
                        maritalStatusValidation = true;
                        maritalStatus = "Divorciado(a)";
                        break;
                    default:
                        Console.WriteLine("Erro! A idade deve estar entre 0 e 150. Tente novamente!");
                        Console.Write("Estado civil |'s'-Solteiro(a)|'c'-Casado(a)|'v'-Viúvo(a)|'d'-Divorciado(a)|: ");
                        maritalStatus = Console.ReadLine();
                        break;
                }
            }

            Console.WriteLine("\nOs dados foram registrados com sucesso!");
            Console.WriteLine($"Nome: {username}");
            Console.WriteLine($"Idade: {age}");
            Console.WriteLine($"Salário: {salary}");
            Console.WriteLine($"Estado civil: {maritalStatus}");
        }
    }
}
