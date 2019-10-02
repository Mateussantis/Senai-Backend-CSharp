using System;
using Ex4.Controller;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraController calculadora = new CalculadoraController();
            calculadora.Receber();
            System.Console.WriteLine(calculadora.Somar());
            System.Console.WriteLine(calculadora.Dividir());
            System.Console.WriteLine(calculadora.Multiplicar());
            System.Console.WriteLine(calculadora.Subtrair());
        }
    }
}
