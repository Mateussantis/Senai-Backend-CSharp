using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] v1 = {1,2,3,4,9,6,7,8};
            System.Console.WriteLine(Maior(v1));
        }

        static double Maior(double[] v1) {
            double cont = 0;
            for (int i = 0; i < v1.Length; i++) {
                if (v1[i] > cont) {
                    cont = v1[i];
                }
            }
            return cont;
        }
    }
}
