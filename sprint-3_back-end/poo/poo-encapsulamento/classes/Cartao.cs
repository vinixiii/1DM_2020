namespace encapsulamento.classes
{
    public class Cartao
    {
        private string numero;

        public string Numero{
            get{return numero;}
            set{numero = value;}
        }

        private string bandeira = "Mastercard";

        public string Bandeira{
            get{return bandeira;}
        }

        protected string token = "qertyui";

        public string Token{
            get{return token;}
        }

        private string cvv;

        public string Cvv{
            get{return cvv;}
            set{cvv = value;}
        }

        protected float limite = 5000;

        public float Limite{
            get{return limite;}
        }

        //Declaração dos métodos
        public string RegistrarCompra(bool validado){
            return "";
        }

        private bool ValidarCompra(float saldo) {
            return true;
        }

        protected string ValidarToken(string token) {
            return "";
        }
    }
}