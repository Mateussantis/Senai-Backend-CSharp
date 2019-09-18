using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {   
            int cont = 1;
            int numeros = 1;
            int impares = 0;
            while (cont <= 100) {
                cont++;
                impares = impares + cont;
                if (impares % 2 != 0) {
                    numeros = numeros + 1;
                }
            } 
            Console.WriteLine($"A quantidade de numeros impares de 0 a 100 é: {numeros}!");       
        }
    }
}
