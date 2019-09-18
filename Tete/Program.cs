using System;

namespace Tete
{
    class Program
    {
        static void Main(string[] args)
        {
            long cont = 0;

            Console.WriteLine("While");

            while (cont > -1 ) {
            cont = cont + 10000;
            Console.WriteLine(cont);
            }

            Console.WriteLine();

            Console.WriteLine("For");

            for (int cont2 = 1; cont2 <= 10; cont2++) {
                Console.WriteLine(cont2);
            }
        }
    }
}
