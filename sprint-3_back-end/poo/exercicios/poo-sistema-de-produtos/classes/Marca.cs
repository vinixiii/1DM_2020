using System;
using System.Collections.Generic;

namespace projeto_de_produtos.classes
{
    public class Marca
    {
        //Se não houver nenhum modificador de acesso é igual a privado
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        public List<Marca> Marcas = new List<Marca>();

        public void AdicionarNaLista(Marca marca) {
            Marcas.Add(marca);
        }
        
        public Marca CadastrarMarca() {

            Marca novaMarca = new Marca();

            Console.WriteLine("Digite o código da marca:");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca:");
            novaMarca.NomeMarca = Console.ReadLine();
            
            novaMarca.DataCadastro = DateTime.UtcNow;

            Marcas.Add(novaMarca);

            return novaMarca;
        }

        public void Listar() {
            Console.WriteLine("Marcas cadastradas:");
            foreach (Marca item in Marcas)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Marca: {item.NomeMarca}");
                Console.WriteLine($"Data de cadastro: {item.DataCadastro}");
            }
        }

        public void Deletar(int codigo) {
            Marca marcaDelete = Marcas.Find(x => x.Codigo == codigo);
            Marcas.Remove(marcaDelete);
        }
        
        
        
        
        
        
    }
}