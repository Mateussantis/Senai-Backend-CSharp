using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] v1 = {1,2,3,4,5};
            Console.WriteLine(Soma(v1));
        }
        static double Soma(double[] v1) {
            double soma = 0;
            for (int i = 0; i < v1.Length; i++) {
                soma += v1[i];
            }
            return soma;
        }


    }
}
