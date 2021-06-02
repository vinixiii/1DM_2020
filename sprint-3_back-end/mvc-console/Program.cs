using System;
using MVC_Console.Controllers;
using MVC_Console.Models;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar o ProdutoController
            ProdutoController produtoController = new ProdutoController();

            //Chamar o método que exibe os produtos
            produtoController.MostrarProdutos();
        }
    }
}
