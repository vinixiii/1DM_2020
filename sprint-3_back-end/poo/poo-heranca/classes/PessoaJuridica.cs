namespace heranca.classes
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj;
        public string inscricaoEstadual;

        public bool ValidarCnpj(string documento){
            if(documento != "") {
                return true;
            }

            return false;
        }
    }
}