using System;

namespace abstracao_challenge.classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;

        public string CodigoDeBarras{
            set{codigoDeBarras = value;}
        }

        public void Registrar() {
            Console.WriteLine("Compra registrada!");
        }

        public float Desconto(int valor) {
            return valor / 100f;
        }
    }
}