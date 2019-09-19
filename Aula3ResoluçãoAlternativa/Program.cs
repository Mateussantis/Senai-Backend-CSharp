using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {

            double acumuladora = 0;
            int cont = 0;
            double nota = 0;
            int qnotas;
            double media = 0;

            Console.Write("\nQuantas notas voce quer recerber: ");
            qnotas = int.Parse(Console.ReadLine());

            while (cont != qnotas) {
                
                try {
                Console.Write("\nDigite sua nota: ");
                nota = double.Parse(Console.ReadLine());

                acumuladora += nota;
                cont++;
                media = acumuladora / cont;
                }

                catch {
                    Console.WriteLine("ERROO, Digite um numero!!");
                }
            }
            Console.WriteLine($"\nVoce digitou {cont} notas, então sua media foi: {media}\n");
        }
    }
}
