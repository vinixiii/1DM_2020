using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.Views
{
    public class ProdutoView
    {
        public void MostrarNoConsole(List<Produto> produtos) {
            foreach (Produto item in produtos)
            {
                Console.WriteLine();
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco}");
            }
        }
    }
}