using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, valor3, media;

            Console.Write("Escreva o numero: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.Write("Escreva o numero: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.Write("Escreva o numero: ");
            valor3 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            media = (valor1 + valor2 + valor3) / 3;
            Console.WriteLine("Sua media final foi de: " +media);

            if(media >= 6) {
                Console.WriteLine("Passou de ano!");
            }
            else {
                Console.WriteLine("Reprovado!");
            }
        }
    }
}
