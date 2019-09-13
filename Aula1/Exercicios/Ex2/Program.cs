using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            int porcentagem;
            float valor;
            float valornovo;

            Console.WriteLine("Digite o valor: ");
            valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem: ");
            porcentagem = int.Parse(Console.ReadLine());

            valornovo = valor * porcentagem / 100;

            Console.WriteLine("Valor com porcentagem é de: " +valornovo);

        }
    }
}
