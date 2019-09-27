using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
            Console.Write("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("Digite a porcentagem: ");
            double porcentagem = double.Parse(Console.ReadLine());
            Console.WriteLine(calculo(valor, porcentagem));
            }
            catch (Exception ex) {
                Console.WriteLine("\n\nDigite Valores numericos, não caracteres!!!\n\n" ,ex);
            }
        }

        static double calculo(double valor, double porcentagem) {

            double resultado = valor * porcentagem / 100;
            valor -= resultado;

            return resultado;

        }
    }
}
