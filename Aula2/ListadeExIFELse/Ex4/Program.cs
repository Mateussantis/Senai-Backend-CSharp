using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double precopagar;

            Console.Write("Preço a pagar: ");
            precopagar = double.Parse(Console.ReadLine());

            if (precopagar >= 100 && precopagar <= 1000) {
                precopagar = (precopagar * 15) / 100;
            }
            Console.WriteLine(precopagar);
        }
    }
}
