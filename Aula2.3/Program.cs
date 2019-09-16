using System;

namespace Aula2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool entrada = false;
            int idade;
            String retorno = "Entrada não perimitida ):";

            Console.Write("Digite Sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 17) {
                entrada = true;
            }

            if (entrada == true) {
                retorno = "Entrada permitida!";
            }
            
            Console.WriteLine(retorno);          
        }
    }
}
