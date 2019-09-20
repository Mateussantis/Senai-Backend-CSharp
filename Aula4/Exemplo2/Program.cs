using System;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {

            String [] series1 = new String[10];
            String [] series2 = new String[10];

            for (int i = 0; i <= 9; i++) {
                Console.WriteLine("Digite uma serie: ");
                series1[i] = Console.ReadLine();
            }
            for(int i = 0; i <= 9; i++) {
                series2[i] = series1[i];
            }
            for(int i = 0; i <= 9; i++) {
                Console.WriteLine(series2[i]);
            }

            

        }
    }
}
