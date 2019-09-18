using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            double num;
            double soma = 0;

            while (cont <= 3) {
                cont = cont + 1;

                Console.Write("Digite a quantidade de pessoas da cidade: ");
                num = double.Parse(Console.ReadLine());

                soma = soma + num;           
            }
            Console.WriteLine($"A quantidade de pessoas de todas essas cidades é: {soma}!"); 
        }
    }
}
