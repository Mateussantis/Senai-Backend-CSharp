using System;

namespace Aula3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = 0;
            int valor = 1;
            String armazen;

            do {
            valor++;
            Console.Write("Digite um numero: ");
            nums = int.Parse(Console.ReadLine());

            if (nums % 3 == 0) {
                    armazen = nums.ToString();
                }

           
            }
            while (valor <= 20);
            Console.WriteLine(armazen);
        }
    }
}
