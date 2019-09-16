using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, divida;

            Console.Write("Digite seu salario: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de suas dividas: ");
            divida = double.Parse(Console.ReadLine());

            salario = salario - divida;
            Console.WriteLine("Seu salario depois das dividas ficara: " +salario);
        }
    }
}
