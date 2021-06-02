using System;

namespace atributos_e_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem1 = new Personagem();

            personagem1.nome = "Tsukamoto";
            personagem1.idade = 32;
            personagem1.armadura = "Voadora";

            Personagem personagem2 = new Personagem();

            personagem2.nome = "Vinícius";
            personagem2.idade = 21;
            personagem2.armadura = "Voadora";

            Console.WriteLine($"Personagem 1 = {personagem1.nome} - {personagem1.Atacar()}");


            Console.WriteLine($"Personagem 1 = {personagem1.nome} - {personagem1.Atacar()}");
        }
    }
}
