using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double valortransporte = 4.30;
            double pessoas;
            double valorganho;
            Console.Write("Digite quantas pessoas entraram: ");
            pessoas = double.Parse(Console.ReadLine());

            valorganho = valortransporte * pessoas;
            Console.WriteLine("O valor arrecadado foi: " +valorganho);
        }
    }
}
