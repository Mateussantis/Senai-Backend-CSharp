using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] lista = new int [10];
            double mult = 0;
            for (int i = 0; i <= 9; i++) {
                Console.Write("Digite um valor: ");
                lista[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= 9; i++) {
                Console.WriteLine(lista[i]);
            }
            mult = lista[9] * 5;
            Console.WriteLine($"A multiplicação de {lista[9]} por 5 é: {mult} ");
        }
    }
}
