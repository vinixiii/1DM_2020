using System;
using System.Collections.Generic;
using listas2.classes;

namespace listas2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando lista
            List<Produto> produtos = new List<Produto>();

            //Adicionando produtos à lista
            produtos.Add(new Produto(1, "Apple Watch", 3522.56f));
            produtos.Add(new Produto(2, "Xiamoni Watch", 1522.45f));
            produtos.Add(new Produto(3, "Zenfone Asus", 2522.87f));
            produtos.Add(new Produto(4, "Samsung Galaxy S10", 2522.87f));
            produtos.Add(new Produto(5, "Motorola G8", 2522.87f));

            //Ou através de instâncias básicas e suas atribuições
            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome =  "iPhone 7 Plus";
            iphone.Preco = 3522.56f;

            produtos.Add(iphone);

            //Podemos mostrar os produtos com foreach
            foreach (Produto item in produtos) {
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }
            
            //Podemos remover itens através de seu índice de array
            //Linha removida na posição 3 do array: Produto(4, "Samsung Galaxy S10", 2522.87f);
            produtos.RemoveAt(3);

            //Também podemos remover um produto da lista usando expressão lambda e o método RemoveAll
            //Linha removida: Produto(1, "Apple Watch", 3522.56f);
            produtos.RemoveAll(x => x.Nome == "Apple Watch");

            Console.WriteLine("\nLista alterada: ");

            //Checando se foi realmente removido
            foreach (Produto item in produtos) {
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }
        }
    }
}

