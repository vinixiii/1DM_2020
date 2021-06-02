using System;
using System.Collections.Generic;

namespace objetos_argumentos.classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        //Criando lista de produtos
        List<Produto> carrinho = new List<Produto>();

        //Craindo método para adicionar produtos à lista
        public void AdicionarProduto(Produto produto) {
            carrinho.Add(produto);
        }

        public void RemoverProduto(Produto produto) {
            carrinho.Remove(produto);
        }

        public void MostrarProdutos() {
            if(carrinho.Count > 0) {
                foreach (var item in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"R${item.Preco.ToString("n2")} Nome: {item.Nome}");
                    Console.ResetColor();
                }
            } else {
                Console.WriteLine("Não há itens no carrinho");
            }
        }

        public void AlterarItem(int codigo, Produto produto) {
            if(produto.Nome != null) {
                carrinho.Find(x => x.Codigo == codigo).Nome = produto.Nome;
            }
            carrinho.Find(x => x.Codigo == codigo).Preco = produto.Preco;
        }
        
        
        
        
        
    }
}