using Aula11.Ariel.Exemplo.Model;
using System;
namespace Aula11.Ariel.Exemplo.Controller
{
    public class CarrosController
    {

        CarroModel carro = new CarroModel();
        MotorModel motor = new MotorModel();
        
        public void Ligar() {
            carro.Ligado = true;
            System.Console.WriteLine("Carro Ligado!");
        }

        public void Desligar() {
            carro.Ligado = false;
            System.Console.WriteLine("Desligando o carro !!!");
        }

        public void Acelerar() {
            if (carro.Ligado == true) {
                System.Console.WriteLine("Carro acelerado !!!");
            }
            else {
                System.Console.WriteLine("O carro nao esta ligado! Impossivel acelerar!");
            }
        }
        
        public void Frear() {
            if (carro.Ligado == true) {
                System.Console.WriteLine("Carro freado..");
            }
            else {
                System.Console.WriteLine("O carro não esta ligado!");
            }
        }

        public void CadastrarMotor() {
            System.Console.Write("Insira a quantidade de cavalos: ");
            motor.Cavalos = int.Parse(Console.ReadLine());

            System.Console.Write("Insira quantidade de cilindros: ");
            motor.Cilindros = int.Parse(Console.ReadLine());
            
            System.Console.Write("Insira o modelo do pistao do carro: ");
            motor.Pistao = Console.ReadLine();
        }
    }
}