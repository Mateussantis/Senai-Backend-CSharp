using System;
using testee.Controller;
namespace testee
{
    class Program
    {
        static void Main(string[] args)
        {
            TesteController a = new TesteController();
            a.receber();
            a.listar();
        }
    }
}
