using System;
using System.Collections.Generic;

namespace poo_interface.classes
{
    public class Carrinho : ICarrinho
    {
        List<Produto> carrinho = new List<Produto>();
        
        public void Alterar(int codigo, Produto produto)
        {
            carrinho.Find(x => x.Codigo == codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == codigo).Preco = produto.Preco;
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Listar()
        {
            foreach (Produto item in carrinho)
            {
                Console.WriteLine($"Produto: {item.Nome}\nPreço: R${item.Preco}\nCódigo: {item.Codigo}");
            }
        }
    }
}