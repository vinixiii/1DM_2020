using System;
using metodos_construtores_2.classes;

namespace metodos_construtores_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizando o construtor vazio
            Produto produto1 = new Produto();
            produto1.Codigo = 1;
            produto1.Nome = "Coca-Cola";
            produto1.Descricao = "Refrigerante de cola";
            produto1.Estoque = 30;

            Console.WriteLine($"Produto 1\nCódigo: {produto1.Codigo}\nNome: {produto1.Nome}\nDescrição: {produto1.Descricao}\nEstoque: {produto1.Estoque}");

            //Utilizando o construtor inserindo apenas o codigo
            Produto produto2 = new Produto(10);
            Console.WriteLine($"\nProduto 2\nCódigo: {produto2.Codigo}\nNome: {produto2.Nome ?? "null"}\nDescrição: {produto2.Descricao ?? "null"}\nEstoque: {produto2.Estoque}");

            //Construtor inserindo todos os argumentos
            Produto produto3 = new Produto(1, "Trakinas", "Bolacha de chocolate", 1000);
            Console.WriteLine($"\nProduto 3\nCódigo: {produto3.Codigo}\nNome: {produto3.Nome}\nDescrição: {produto3.Descricao}\nEstoque: {produto3.Estoque}");
        }
    }
}
