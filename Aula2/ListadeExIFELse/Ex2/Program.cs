using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorpagar; 

            Console.Write("Valor a ser pago: ");
            valorpagar = double.Parse(Console.ReadLine());

            if (valorpagar < 100) {
                valorpagar = valorpagar - 25;
            }
            else {
                valorpagar = valorpagar;
            }
            Console.WriteLine(valorpagar);
        }
    }
}
