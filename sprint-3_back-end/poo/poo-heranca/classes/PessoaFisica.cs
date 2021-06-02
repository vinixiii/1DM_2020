namespace heranca.classes
{
    public class PessoaFisica : Pessoa
    {
        public string cpf;
        public string rg;

        public bool ValidarCpf(string documento){
            if(documento != ""){
                return true;
            }

            return false;
        }
    }
}