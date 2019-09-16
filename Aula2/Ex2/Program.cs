using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1,nota2,nota3,media;
            String resultado;

            Console.Write("Digite Sua primeira nota: ");
            nota1 = float.Parse(Console.ReadLine);

            Console.Write("Digite Sua terceira nota: ");
            nota2 = float.Parse(Console.ReadLine);

            Console.Write("Digite Sua terceira nota: ");
            nota3 = float.Parse(Console.ReadLine);

            media = (nota1 + nota2 + nota3) / 3;
        }
    }
}
