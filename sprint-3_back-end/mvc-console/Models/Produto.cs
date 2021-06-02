using System.IO;
using System.Collections.Generic;

namespace MVC_Console.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH = "Database/Produto.csv";

        public Produto(){
            string pasta = PATH.Split("/")[0];

            //Verificar se a pasta não existe, caso não exista, criar a pasta!
            if(!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);
            }

            //Verificar se o arquivo "Produto.csv" existe, caso não exista, criar o arquivo!
            if(!File.Exists(PATH)) {
                File.Create(PATH);
            }
        }

        public List<Produto> Ler() {
            List<Produto> produtos = new List<Produto>();
            
            //Pegar as informações do arquivo "Produto.csv"
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                //Separar os atributos de cada linha pelo ponto e vírgula ";"
                string[] atributos = item.Split(";");
                
                //Criar um produto vazio para colocar na lista final de produtos
                Produto produto = new Produto();

                produto.Codigo = int.Parse(atributos[0]);
                produto.Nome = atributos[1];
                produto.Preco = float.Parse(atributos[2]);

                produtos.Add(produto);
            }

            return produtos;
        }
    }
}