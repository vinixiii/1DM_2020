namespace encapsulamento.classes
{
    public class Mastercard : Cartao
    {
        private int parcelas;

        public int Parcelas {
            get{return parcelas;}
            set{parcelas = value;}
        }

        public string CompraComDesconto() {
            return "";
        }
    }
}