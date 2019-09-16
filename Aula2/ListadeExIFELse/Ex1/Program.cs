using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, divida;

            Console.Write("Digite seu salario: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Digite sua divida: ");
            divida = double.Parse(Console.ReadLine());

            if (salario > divida) {
                Console.WriteLine("Seu saldo ainda é positivo!");
            }
            else if (salario < divida) {
                Console.WriteLine("Voce esta negativo!");
            }
            else {
                Console.WriteLine("Voce esta zerado!");
            }
        }
    }
}
