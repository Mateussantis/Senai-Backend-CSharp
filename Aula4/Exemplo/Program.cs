using System;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {

            double [] media = new double [10];
            int nada = media.Length;
            for (int i = 0; i <= 9; i++) {
                Console.Write("Digite sua primeira nota: ");
                media[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine(media[3]);

            for (int i = 0; i <= media.Length - 1; i++) {
                Console.WriteLine("Medias: "+media[i]);
            }
        }
    }
}
