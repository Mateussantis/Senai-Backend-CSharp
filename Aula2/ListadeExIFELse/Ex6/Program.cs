using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Digite Sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade <= 3) {
                Console.WriteLine("Voce pode jogar jogos Early Childhood..");
            }
            else if (idade >= 6) {
                Console.WriteLine("Voce pode jogar jogos Everyone..");
            }
            else if (idade >= 10) {
                Console.WriteLine("Voce pode jogar jogos Everyone 10+..");
            }
            else if (idade >= 13) {
                Console.WriteLine("Voce pode jogar jogos Teen..");
            }
            else if (idade >= 17) {
                Console.WriteLine("Voce pode jogar jogos Mature 17+..");
            }
            else if (idade >= 18) {
                Console.WriteLine("Voce pode jogar jogos Adults only 18+ ..");
            }
            else if (idade >= 10) {
                Console.WriteLine("Voce pode jogar jogos de Everyone 10+ ..");
            }
        }
    }
}
