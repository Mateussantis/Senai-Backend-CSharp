using System;
using Ex2.Controller;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            CelularController celular = new CelularController();
            celular.Ligar();
            bool valor = celular.Desligar();
            celular.Ligacao(valor);
            celular.Mensagem(valor);
        }
    }
}
