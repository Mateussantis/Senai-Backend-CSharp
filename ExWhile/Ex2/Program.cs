using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            double altura = 0;
            double media = 0;
            double soma = 0;
            int cont = 1;
            while (cont <= 15) {
                cont = cont + 1;

                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();

                Console.Write("Digite a altura: ");
                altura = double.Parse(Console.ReadLine());

                soma = soma + altura;
            }
            media = soma / 15;
            Console.WriteLine("A media da altura da soma dessas pessoas é: " +media);
        }
    }
}
