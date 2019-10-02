using System;
using Ex3.Controller;
namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutosController produto1 = new ProdutosController();
            produto1.cadastrar();
            Console.Clear();
            produto1.Reservar();
        }
    }
}
