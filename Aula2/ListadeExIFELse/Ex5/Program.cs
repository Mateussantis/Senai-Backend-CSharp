using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3;

            Console.Write("Digite o valor 1: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor 2: ");
            valor2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor 3: ");
            valor3 = int.Parse(Console.ReadLine());

            if (valor1 > valor2 && valor1 > valor3 ) {
                Console.WriteLine(valor1);
            }
            else if (valor2 > valor1 && valor2 > valor3) {
                Console.WriteLine(valor2);
            }
            else {
                Console.WriteLine(valor3);
            }
        }
    }
}
