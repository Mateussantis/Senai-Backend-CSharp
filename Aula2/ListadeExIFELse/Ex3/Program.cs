using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2;

            Console.Write("Digite o valor 1: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor 2: ");
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 < valor2) {
                Console.WriteLine(valor2);
            }
            else {
            Console.WriteLine(valor1);
            }
        }
    }
}
