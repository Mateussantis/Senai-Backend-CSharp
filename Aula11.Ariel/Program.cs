using System;
using Aula11.Ariel.Exemplo.Controller;
using Aula11.Ariel.Exemplo.Model;
namespace Aula11.Ariel
{
    class Program
    {
        static void Main(string[] args)
        {
            CarrosController carro1 = new CarrosController();
            CarrosEletricosController carroEletrico = new CarrosEletricosController();

            Console.Clear();

            carroEletrico.Ligar();
            carroEletrico.CarregarBateria(15);
            carroEletrico.StatusBateria();
        }
    }
}
