using System;

namespace abstracao_challenge.classes
{
    public class Debito : Cartao
    {
        private float saldo = 600;

        public void Pagar(float valor) {
            Console.WriteLine($"Pagamento de {valor:C2} efetuado com sucesso!");
            // saldo = saldo - valor;
            // Console.WriteLine($"Saldo atual: {saldo:C2}");
        }
    }
}