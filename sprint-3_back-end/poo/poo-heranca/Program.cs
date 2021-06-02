using System;
using heranca.classes;

namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instância da subclasse
            PessoaFisica pf = new PessoaFisica();

            // Atribuição de um valor para a propriedade disponível na superclasse
            pf.nome = "Vini";
            pf.cpf = "999.999.999-99";

            // Mostrar no console o método da saudação
            Console.WriteLine(pf.DarBoasVindas(pf.nome));

            Console.WriteLine(pf.ValidarCpf(pf.cpf));
        }
    }
}