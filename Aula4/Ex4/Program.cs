using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] vetor1 = new string [3]; 
            string [] vetor2 = new string [3];
            string [] vetor3 = new string [6];

            for (int i = 0; i <= 2; i++) {
                Console.Write("Digite a palavra da sua primeira lista: ");
                vetor1[i] = Console.ReadLine();
            }
            for (int i = 0; i <= 2; i++) {
                Console.Write("Digite a palavra da sua segunda lista: ");
                vetor2[i] = Console.ReadLine();
            }
            for (int i = 0; i <= 4; i++) {
                if (i <= 2) {
                    vetor3[i] = vetor1[i] ;
                }
                if (i >= 3) {
                    vetor3[i] = vetor2[i-2] ;
                }
            }
            for (int i = 0; i <= 4; i++) {
                Console.WriteLine(vetor3[i]);
            }
        }
    }
}
