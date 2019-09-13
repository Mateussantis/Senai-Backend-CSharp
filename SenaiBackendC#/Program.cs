using System;

namespace e {
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();

            int num1,num2,num3;

            int soma;

            Console.Write("Digite o nome Do Aluno: ");
            String nomealuno = Console.ReadLine();

            Console.Write("Digite Sua Nota 1: ");
            num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Digite Sua Nota 2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite Sua Nota 3: ");
            num3 = int.Parse(Console.ReadLine());

            soma = (num1 + num2 + num3) / 3;

            Console.WriteLine(nomealuno + " Sua Media é: " +soma);          
        }
    }
}