using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numero;

            Console.Write("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            int triplo = numero * 3;

            Console.WriteLine();

            Console.WriteLine(triplo);

        }
    }
}
