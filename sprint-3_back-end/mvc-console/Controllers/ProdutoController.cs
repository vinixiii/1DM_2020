using MVC_Console.Models;
using MVC_Console.Views;

namespace MVC_Console.Controllers
{
    public class ProdutoController
    {
        //Instanciar as classes do Model e do View
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();
        
        public void MostrarProdutos() {
            //O método MostrarNoConsole recebe uma lista de produtos
            produtoView.MostrarNoConsole(produto.Ler());
        }
    }
}