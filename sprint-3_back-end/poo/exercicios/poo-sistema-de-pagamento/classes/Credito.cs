using System;

namespace abstracao_challenge.classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;

        public void Pagar(float valor) {
            Console.WriteLine($"Pagamento de {valor:C2} efetuado com sucesso!");
            // limite = limite - valor;
            // Console.WriteLine($"Limite atual: {limite:C2}");
        }

        public float CalcularJuros(int parcelas, float valor) {
            float juros = 0;

            if(parcelas < 6) {
                juros = valor * 0.05f;
            } else if(parcelas >= 7) {
                juros = valor * 0.08f;
            }

            return juros;
        }
    }
}