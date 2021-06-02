namespace polimorfismo.classes
{
    public class Player
    {
        private float velocidade;
        private float forcaPulo;

        public virtual string Correr() {
            return "Velocidade 1x";
        }

        public virtual string Pular() {
            return "Pular";
        }
    }
}