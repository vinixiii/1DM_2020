namespace poo_interface.classes
{
    public interface ICarrinho
    {
         //CRUD -> Create Read Update Delete

        //Create
         void Cadastrar(Produto produto);

        //Read
         void Listar();

         //Update
         void Alterar(int codigo, Produto produto);

         //Delete
         void Deletar(Produto produto);
    }
}