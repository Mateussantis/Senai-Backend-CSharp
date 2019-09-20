using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] lista = new int [10];
            int soma = 0;


            for (int i = 0; i <= 9; i++) {
                if (i == 0) {
                    Console.WriteLine(i);
                }
                if (i >= 1 && i <= 9) {
                    soma = i * 2;
                    lista[i] = soma;
                }                
            }
            for (int i = 0; i <= 9; i++) {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
