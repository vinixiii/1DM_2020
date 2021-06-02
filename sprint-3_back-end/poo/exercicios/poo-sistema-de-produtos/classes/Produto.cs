using System;
using System.Collections.Generic;

namespace projeto_de_produtos.classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor { get; set; }
        public List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar(Marca marca) {
            Produto novoProduto = new Produto();

            Console.WriteLine("Digite o código do produto:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto:");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            novoProduto.Preco = float.Parse(Console.ReadLine());
            
            novoProduto.DataCadastro = DateTime.UtcNow;

            //Atribuimos nossa marca através de um método criado para cadastro
            novoProduto.Marca = Marca.CadastrarMarca();

            //Adicionamos a marca à lista de marcas
            marca.AdicionarNaLista(novoProduto.Marca);

            //Atribuimos o usuário através do método construtor
            novoProduto.CadastradoPor = new Usuario();

            ListaDeProdutos.Add(novoProduto);
        }

        public void Listar() {
            foreach (Produto item in ListaDeProdutos)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preco: {item.Preco}");
                Console.WriteLine($"Data de cadastro: {item.DataCadastro}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado por: {item.CadastradoPor.Nome}");
            }
        }

        public void Deletar(int codigo) {
            Produto produtoDelete = ListaDeProdutos.Find(x => x.Codigo == codigo);
            ListaDeProdutos.Remove(produtoDelete);
        }
    }
}