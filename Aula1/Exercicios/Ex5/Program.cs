using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, vendas;
            String nome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu salario: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor em vendas: ");
            vendas = double.Parse(Console.ReadLine());

            Console.Write("Parabens: "+nome +" Seu salario é: " +salario  +" Voce vendeu: " +vendas);
        }
    }
}
