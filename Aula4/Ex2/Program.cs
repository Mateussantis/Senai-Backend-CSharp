using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vetor1 = new int [10];
            int [] vetor2 = new int [10];
            int [] vetor3 = new int [20];

            for (int i = 0; i <= 9; i++) {
                Console.Write("Digite sua primeira lista: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= 9; i++) {
                Console.Write("Digite sua segunda lista: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= 19; i++) {
                if (i <= 9) {
                    vetor3[i] = vetor1[i] ;
                }
                if (i >= 10) {
                    vetor3[i] = vetor2[i-10] ;
                }
            }
            for (int i = 0; i <= 19; i++) {
                Console.WriteLine(vetor3[i]);
            }
        }
    }
}
