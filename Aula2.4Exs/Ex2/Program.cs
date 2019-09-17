using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, gravidade, pesonoplaneta;
            String planeta, nomeplaneta;

            Console.Write("Digite o seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite um dos planetas de 1 a 6: ");
            planeta = Console.ReadLine();

            switch (planeta) {
                case "1":
                    nomeplaneta = "Mercurio";
                    gravidade = 0.37;
                    pesonoplaneta = (peso / 10) * gravidade;
                    Console.WriteLine($"Seu peso no planeta {nomeplaneta}, sera {pesonoplaneta}");
                    break;
                case "2":
                    nomeplaneta = "Venus";
                    gravidade = 0.88;
                    pesonoplaneta = (peso / 10) * gravidade;
                    Console.WriteLine($"Seu peso no planeta {nomeplaneta}, sera {pesonoplaneta}");
                    break;
                case "3":
                    nomeplaneta = "Marte";
                    gravidade = 0.38;
                    pesonoplaneta = (peso / 10) * gravidade;
                    Console.WriteLine($"Seu peso no planeta {nomeplaneta}, sera {pesonoplaneta}");
                    break;
                case "4":
                    nomeplaneta = "Jupiter";
                    gravidade = 2.64;
                    pesonoplaneta = (peso / 10) * gravidade;
                    Console.WriteLine($"Seu peso no planeta {nomeplaneta}, sera {pesonoplaneta}");
                    break;
                case "5":
                    nomeplaneta = "Saturno";
                    gravidade = 1.15;
                    pesonoplaneta = (peso / 10) * gravidade;
                    Console.WriteLine($"Seu peso no planeta {nomeplaneta}, sera {pesonoplaneta}");
                    break;
                case "6":
                    nomeplaneta = "Urano";
                    gravidade = 1.17;
                    pesonoplaneta = (peso / 10) * gravidade;
                    Console.WriteLine($"Seu peso no planeta {nomeplaneta}, sera {pesonoplaneta}");
                    break;      
                default: 
                    Console.WriteLine("Inforamações invalidas!!!");
                    break;      
            }
        }
    }
}