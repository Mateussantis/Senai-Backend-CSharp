using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetor3 = new int[10];

            for (int i = 0; i <= 9; i++) {
                Console.Write($"Digite o {i} numero do vetor 1:  ");
                vetor1[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i <= 9; i++) {
                Console.Write($"Digite o {i} numero do vetor 2:  ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= 9; i++) {
                vetor3[i] = vetor1[i] + vetor2[i];
            }

            for (int i = 0; i <= 9; i++) {
                Console.WriteLine(vetor3[i]);
            }          
        }
    }
}
