using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double reais, dolar, valordolar;
            Console.WriteLine("Digite o valor da conversao: ");
            reais = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do dolar: ");
            valordolar = double.Parse(Console.ReadLine());

            dolar = reais * valordolar;
            Console.WriteLine("O valor em dolar é: " +dolar);
        }
    }
}
