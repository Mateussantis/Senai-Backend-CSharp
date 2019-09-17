using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            String resultado, pedido;

            Console.WriteLine("Digite o numero do pedido: ");
            pedido = Console.ReadLine();

            switch(pedido) {
                case "1": 
                    resultado = "Hamburguer";
                    break;
                case "2": 
                    resultado = "Cheese Salada";
                    break;
                case "3": 
                    resultado = "Cheese Burguer";
                    break;
                case "4":
                    resultado = "Cheese Bacon";
                    break;    
                default:
                    resultado = "Pedido Invalido";
                    break;
            }
            Console.WriteLine(resultado);
        }
    }
}
