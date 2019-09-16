using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, valor3, media;
            String texto;

            Console.Write("Escreva seu primeiro numero: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.Write("Escreva seu segundo numero: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.Write("Escreva seu terceiro numero: ");
            valor3 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            media = (valor1 + valor2 + valor3) / 3;
            Console.WriteLine("Sua media final foi de: " +media);

            if(media >= 6) {
                texto = "Aprovado";
            }
            else if (media < 6 && media >= 4) {
                texto = "Exame!";
            }
            else {
                texto = "Reprovado!";
            }
            Console.WriteLine($" Voce {texto} - Sua media foi {media}");
        }
    }
}
