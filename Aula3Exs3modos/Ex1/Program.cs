using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int atual = 0;
            int cont = 0;
            int antiga = 0;
            int soma = 0;
            
            while (cont <= 20) {
                
                if (cont <= 0) {
                Console.WriteLine(cont);
                Console.WriteLine(cont);
                }
                if (cont == 1) {
                Console.WriteLine(cont);
                Console.WriteLine(cont);
                }
                if (cont == 2) {
                    Console.WriteLine(cont);
                    antiga = cont;
                }
                
                cont++;
                if (cont >= 3 && cont <= 20) {
                    atual = cont;
                    
                    Console.WriteLine(atual);
                    soma = atual + antiga;
                    Console.WriteLine(soma);

                }
            }
        }
    }
}
