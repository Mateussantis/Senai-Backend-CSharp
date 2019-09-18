using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade = 0;
            double idadecerta = 0;
            int cont = 1;
            while (cont <= 10) {
                cont++;
                Console.Write("Idade: ");
                idade = double.Parse(Console.ReadLine());

                if (idade >= 50) {
                    idadecerta = 1 + idadecerta;
                }
            }
            Console.WriteLine($"Tem {idadecerta}, pessoas com mais de 50 anos!");
        }
    }
}
