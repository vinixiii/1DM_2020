using System;

namespace abstracao_challenge.classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        protected float valor;

        public string Cancelar() {
            return "";
        }
    }
}