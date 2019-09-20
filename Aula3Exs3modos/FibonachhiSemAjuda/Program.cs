using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int atual = 0;
            int antiga = 0;
            int fibo = 0;

            for (int cont = 0; cont <= 20; cont++) {

                if (cont == 0) {
                    Console.WriteLine(cont);
                    Console.WriteLine(cont);
                }
                if (cont == 1) {
                    Console.WriteLine(cont);
                    Console.WriteLine(cont);
                    antiga = cont;
                }
                if (cont == 2) {
                    Console.WriteLine(cont);
                    atual = cont;
                }
                if (cont >= 3 && cont <= 20) {
                    fibo = atual + antiga;
                    Console.WriteLine(fibo);
                    antiga = atual;
                    atual = fibo;
                }
            }
        }
    }
}
