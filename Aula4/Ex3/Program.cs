using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            string [] produtos = new string[3]; 
            string [] c = new string[3]; 
            string [] t = new string[3]; 
            string [] pr = new string[3]; 
            

            for(int i = 0; i <= 2; i++) {

                Console.Write($"\nDigite o nome do produto {i+1}: ");
                produtos[i] = Console.ReadLine();

                Console.Write($"Digite o nome do cor {i+1}: ");
                c[i] = Console.ReadLine();

                Console.Write($"Digite o nome do tamanho {i+1}: ");
                t[i] = Console.ReadLine();

                Console.Write($"Digite o preço do {i+1}: ");
                pr[i] = Console.ReadLine();

            }
            for (int i = 0; i <= 2; i++) {
                Console.WriteLine($"\nO produto {produtos[i]}, a cor é {c[i]}, o tamanho é {t[i]} e o preço é {pr[i]}");
            }
        }
    }
}
