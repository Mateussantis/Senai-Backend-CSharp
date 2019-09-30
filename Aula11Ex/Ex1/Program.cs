using Ex1.Controller;
using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            PessoasController pessoa1 = new PessoasController();
            pessoa1.adicionar();
            pessoa1.ler();
            Console.WriteLine(pessoa1.Imc());            
            
        }
    }
}
