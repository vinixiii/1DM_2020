using System;
using poo_interface.classes;

namespace poo_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();
            
            Produto p1 = new Produto();
            p1.Codigo = 123;
            p1.Nome = "Playstation 5";
            p1.Preco = 10000f;

            Produto p2 = new Produto();
            p2.Codigo = 124;
            p2.Nome = "Xbox Series X";
            p2.Preco = 5000f;

            Produto p3 = new Produto();
            p3.Codigo = 125;
            p3.Nome = "Nintendo Switch";
            p3.Preco = 4000f;

            carrinho.Cadastrar(p1);

            carrinho.Listar();

            carrinho.Alterar(p1.Codigo, p3);

            carrinho.Listar();
        }
    }
}
