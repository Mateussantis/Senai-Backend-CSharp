using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, comissao, salarionovo;

            Console.Write("Digite seu salario Fixo: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Digite quantos reais voce vendeu: ");
            comissao = double.Parse(Console.ReadLine());

            salarionovo = salario + (comissao * 5 / 100);
            Console.Write("Seu salario do mes, sera: " + salarionovo);
        }
    }
}
